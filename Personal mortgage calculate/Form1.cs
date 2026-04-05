using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_mortgage_calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 綁定 RadioButton 切換事件
            rbDownPercent.CheckedChanged += DownPaymentType_CheckedChanged;
            rbDownAmount.CheckedChanged += DownPaymentType_CheckedChanged;
            btnCalculate.Click += btnCalculate_Click;
        }

        // 處理自備款切換機制 (更新單位提示) 
        private void DownPaymentType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDownPercent.Checked)
            {
                lblUnit2.Text = "%";
                txtDownPayment.Text = "20"; // 預設 20%
            }
            else
            {
                lblUnit2.Text = "元";
                txtDownPayment.Text = "2000000"; // 預設 200萬
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // --- 1. 輸入驗證與防呆 (Error Handling)  ---
            if (!double.TryParse(txtHousePrice.Text, out double housePrice) || housePrice <= 0)
            {
                MessageBox.Show("請輸入有效的「房屋總價」(需大於0)！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDownPayment.Text, out double downPayment) || downPayment < 0)
            {
                MessageBox.Show("請輸入有效的「自備款」！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtInterest.Text, out double annualInterestRate) || annualInterestRate < 0)
            {
                MessageBox.Show("請輸入有效的「貸款利率」！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTerm.Text, out int loanTermYears) || loanTermYears <= 0)
            {
                MessageBox.Show("請輸入有效的「貸款年限」(需為正整數)！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 寬限期為選填，若為空則預設為 0 
            if (string.IsNullOrWhiteSpace(txtGrace.Text)) txtGrace.Text = "0";
            if (!int.TryParse(txtGrace.Text, out int gracePeriodYears) || gracePeriodYears < 0)
            {
                MessageBox.Show("請輸入有效的「寬限期」(需大於等於0)！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gracePeriodYears >= loanTermYears)
            {
                MessageBox.Show("寬限期不得大於或等於貸款總年限！", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. 核心數值計算準備 ---
            double loanAmount = 0;

            // 計算自備款與貸款總額 [cite: 13, 20]
            if (rbDownPercent.Checked)
            {
                if (downPayment >= 100)
                {
                    MessageBox.Show("自備款比例不可大於或等於 100%！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loanAmount = housePrice * (1 - (downPayment / 100.0));
            }
            else
            {
                if (downPayment >= housePrice)
                {
                    MessageBox.Show("自備款金額不可大於或等於房屋總價！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loanAmount = housePrice - downPayment;
            }

            // 參數轉換 (年轉月)
            int totalMonths = loanTermYears * 12;
            int graceMonths = gracePeriodYears * 12;
            int amortizedMonths = totalMonths - graceMonths;
            double monthlyInterestRate = (annualInterestRate / 100.0) / 12.0;

            // 結果變數
            double monthlyPayment = 0;
            double firstPeriodInterest = 0;
            double firstPeriodPrincipal = 0;
            double totalRepayment = 0;
            double totalInterest = 0;

            // --- 3. 本息平均攤還法公式計算  ---
            if (monthlyInterestRate == 0) // 防呆：利率為 0 的極端情況
            {
                firstPeriodInterest = 0;
                if (graceMonths > 0)
                {
                    monthlyPayment = loanAmount / amortizedMonths;
                    firstPeriodPrincipal = 0;
                }
                else
                {
                    monthlyPayment = loanAmount / totalMonths;
                    firstPeriodPrincipal = monthlyPayment;
                }
                totalRepayment = loanAmount;
                totalInterest = 0;
            }
            else
            {
                // 計算每期應繳利息 (首期利息一定等於總本金乘上月利率) 
                firstPeriodInterest = loanAmount * monthlyInterestRate;

                // 每月攤還本息金額的計算公式：貸款本金 × [月利率 × (1+月利率)^還款期數] ÷ [(1+月利率)^還款期數 - 1]
                double ratePower = Math.Pow(1 + monthlyInterestRate, amortizedMonths);
                double amortizedMonthlyPayment = loanAmount * (monthlyInterestRate * ratePower) / (ratePower - 1);

                if (graceMonths > 0)
                {
                    // 有寬限期 
                    monthlyPayment = firstPeriodInterest; // 寬限期內每月只繳利息
                    firstPeriodPrincipal = 0; // 寬限期不繳本金 
                    // 總還款額 = (寬限期利息總和) + (攤還期每月應繳金額 * 攤還期數)
                    totalRepayment = (firstPeriodInterest * graceMonths) + (amortizedMonthlyPayment * amortizedMonths);
                }
                else
                {
                    // 無寬限期
                    monthlyPayment = amortizedMonthlyPayment;
                    firstPeriodPrincipal = monthlyPayment - firstPeriodInterest; // 本金 = 每月應繳 - 利息 
                    totalRepayment = monthlyPayment * totalMonths; // 總還款額 
                }

                // 總利息 = 總還款額 - 總貸款金額 
                totalInterest = totalRepayment - loanAmount;
            }

            // --- 4. 格式化結果輸出 ("N2" 包含千分位並精確到小數點後兩位)  ---
            lblResultLoan.Text = loanAmount.ToString("N2");
            lblResultMonthly.Text = (graceMonths > 0 ? monthlyPayment.ToString("N2") + " (寬限期內)" : monthlyPayment.ToString("N2"));
            lblResultFirstInt.Text = firstPeriodInterest.ToString("N2");
            lblResultFirstPrin.Text = firstPeriodPrincipal.ToString("N2");
            lblResultTotalInt.Text = totalInterest.ToString("N2");
            lblResultTotalRep.Text = totalRepayment.ToString("N2");
        }
    }
}
