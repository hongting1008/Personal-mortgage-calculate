namespace Personal_mortgage_calculate
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.rbDownPercent = new System.Windows.Forms.RadioButton();
            this.rbDownAmount = new System.Windows.Forms.RadioButton();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblGrace = new System.Windows.Forms.Label();
            this.txtGrace = new System.Windows.Forms.TextBox();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOutLoanTitle = new System.Windows.Forms.Label();
            this.lblResultLoan = new System.Windows.Forms.Label();
            this.lblOutMonthlyTitle = new System.Windows.Forms.Label();
            this.lblResultMonthly = new System.Windows.Forms.Label();
            this.lblOutInterestTitle = new System.Windows.Forms.Label();
            this.lblResultFirstInt = new System.Windows.Forms.Label();
            this.lblOutPrinTitle = new System.Windows.Forms.Label();
            this.lblResultFirstPrin = new System.Windows.Forms.Label();
            this.lblOutTotalIntTitle = new System.Windows.Forms.Label();
            this.lblResultTotalInt = new System.Windows.Forms.Label();
            this.lblOutTotalRepTitle = new System.Windows.Forms.Label();
            this.lblResultTotalRep = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.lblUnit5);
            this.grpInput.Controls.Add(this.txtGrace);
            this.grpInput.Controls.Add(this.lblGrace);
            this.grpInput.Controls.Add(this.lblUnit4);
            this.grpInput.Controls.Add(this.txtTerm);
            this.grpInput.Controls.Add(this.lblTerm);
            this.grpInput.Controls.Add(this.lblUnit3);
            this.grpInput.Controls.Add(this.txtInterest);
            this.grpInput.Controls.Add(this.lblInterest);
            this.grpInput.Controls.Add(this.lblUnit2);
            this.grpInput.Controls.Add(this.txtDownPayment);
            this.grpInput.Controls.Add(this.rbDownAmount);
            this.grpInput.Controls.Add(this.rbDownPercent);
            this.grpInput.Controls.Add(this.lblUnit1);
            this.grpInput.Controls.Add(this.txtHousePrice);
            this.grpInput.Controls.Add(this.lblHousePrice);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(331, 291);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入資訊";
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Location = new System.Drawing.Point(6, 26);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(82, 22);
            this.lblHousePrice.TabIndex = 1;
            this.lblHousePrice.Text = "房屋總價:";
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Location = new System.Drawing.Point(94, 23);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(100, 30);
            this.txtHousePrice.TabIndex = 2;
            this.txtHousePrice.Text = "10000000";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(200, 26);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(92, 22);
            this.lblUnit1.TabIndex = 3;
            this.lblUnit1.Text = "元 (新台幣)";
            // 
            // rbDownPercent
            // 
            this.rbDownPercent.AutoSize = true;
            this.rbDownPercent.Checked = true;
            this.rbDownPercent.Location = new System.Drawing.Point(10, 59);
            this.rbDownPercent.Name = "rbDownPercent";
            this.rbDownPercent.Size = new System.Drawing.Size(116, 26);
            this.rbDownPercent.TabIndex = 4;
            this.rbDownPercent.TabStop = true;
            this.rbDownPercent.Text = "自備款比例";
            this.rbDownPercent.UseVisualStyleBackColor = true;
            // 
            // rbDownAmount
            // 
            this.rbDownAmount.AutoSize = true;
            this.rbDownAmount.Location = new System.Drawing.Point(10, 91);
            this.rbDownAmount.Name = "rbDownAmount";
            this.rbDownAmount.Size = new System.Drawing.Size(116, 26);
            this.rbDownAmount.TabIndex = 5;
            this.rbDownAmount.Text = "自備款金額";
            this.rbDownAmount.UseVisualStyleBackColor = true;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(132, 58);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(62, 30);
            this.txtDownPayment.TabIndex = 6;
            this.txtDownPayment.Text = "20";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(200, 63);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(25, 22);
            this.lblUnit2.TabIndex = 7;
            this.lblUnit2.Text = "%";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(6, 120);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(82, 22);
            this.lblInterest.TabIndex = 8;
            this.lblInterest.Text = "貸款利率:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(94, 117);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 30);
            this.txtInterest.TabIndex = 9;
            this.txtInterest.Text = "2.15";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(200, 120);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(90, 22);
            this.lblUnit3.TabIndex = 10;
            this.lblUnit3.Text = "% (年利率)";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(6, 150);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(82, 22);
            this.lblTerm.TabIndex = 11;
            this.lblTerm.Text = "貸款年限:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(94, 147);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 30);
            this.txtTerm.TabIndex = 12;
            this.txtTerm.Text = "30";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(200, 150);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(27, 22);
            this.lblUnit4.TabIndex = 13;
            this.lblUnit4.Text = "年";
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Location = new System.Drawing.Point(6, 180);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(113, 22);
            this.lblGrace.TabIndex = 14;
            this.lblGrace.Text = "寬限期 (選填):";
            // 
            // txtGrace
            // 
            this.txtGrace.Location = new System.Drawing.Point(125, 180);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(69, 30);
            this.txtGrace.TabIndex = 15;
            this.txtGrace.Text = "0";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Location = new System.Drawing.Point(200, 180);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(27, 22);
            this.lblUnit5.TabIndex = 16;
            this.lblUnit5.Text = "年";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(10, 205);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 56);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblResultTotalRep);
            this.grpOutput.Controls.Add(this.lblOutTotalRepTitle);
            this.grpOutput.Controls.Add(this.lblResultTotalInt);
            this.grpOutput.Controls.Add(this.lblOutTotalIntTitle);
            this.grpOutput.Controls.Add(this.lblResultFirstPrin);
            this.grpOutput.Controls.Add(this.lblOutPrinTitle);
            this.grpOutput.Controls.Add(this.lblResultFirstInt);
            this.grpOutput.Controls.Add(this.lblOutInterestTitle);
            this.grpOutput.Controls.Add(this.lblResultMonthly);
            this.grpOutput.Controls.Add(this.lblOutMonthlyTitle);
            this.grpOutput.Controls.Add(this.lblResultLoan);
            this.grpOutput.Controls.Add(this.lblOutLoanTitle);
            this.grpOutput.Location = new System.Drawing.Point(12, 309);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(331, 194);
            this.grpOutput.TabIndex = 18;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblOutLoanTitle
            // 
            this.lblOutLoanTitle.AutoSize = true;
            this.lblOutLoanTitle.Location = new System.Drawing.Point(6, 26);
            this.lblOutLoanTitle.Name = "lblOutLoanTitle";
            this.lblOutLoanTitle.Size = new System.Drawing.Size(99, 22);
            this.lblOutLoanTitle.TabIndex = 0;
            this.lblOutLoanTitle.Text = "貸款總金額:";
            // 
            // lblResultLoan
            // 
            this.lblResultLoan.AutoSize = true;
            this.lblResultLoan.ForeColor = System.Drawing.Color.Blue;
            this.lblResultLoan.Location = new System.Drawing.Point(111, 26);
            this.lblResultLoan.Name = "lblResultLoan";
            this.lblResultLoan.Size = new System.Drawing.Size(44, 22);
            this.lblResultLoan.TabIndex = 1;
            this.lblResultLoan.Text = "0.00";
            // 
            // lblOutMonthlyTitle
            // 
            this.lblOutMonthlyTitle.AutoSize = true;
            this.lblOutMonthlyTitle.Location = new System.Drawing.Point(6, 48);
            this.lblOutMonthlyTitle.Name = "lblOutMonthlyTitle";
            this.lblOutMonthlyTitle.Size = new System.Drawing.Size(173, 22);
            this.lblOutMonthlyTitle.TabIndex = 2;
            this.lblOutMonthlyTitle.Text = "每月應繳金額(本+息):";
            // 
            // lblResultMonthly
            // 
            this.lblResultMonthly.AutoSize = true;
            this.lblResultMonthly.ForeColor = System.Drawing.Color.Red;
            this.lblResultMonthly.Location = new System.Drawing.Point(185, 48);
            this.lblResultMonthly.Name = "lblResultMonthly";
            this.lblResultMonthly.Size = new System.Drawing.Size(44, 22);
            this.lblResultMonthly.TabIndex = 3;
            this.lblResultMonthly.Text = "0.00";
            // 
            // lblOutInterestTitle
            // 
            this.lblOutInterestTitle.AutoSize = true;
            this.lblOutInterestTitle.Location = new System.Drawing.Point(6, 70);
            this.lblOutInterestTitle.Name = "lblOutInterestTitle";
            this.lblOutInterestTitle.Size = new System.Drawing.Size(82, 22);
            this.lblOutInterestTitle.TabIndex = 4;
            this.lblOutInterestTitle.Text = "首期利息:";
            // 
            // lblResultFirstInt
            // 
            this.lblResultFirstInt.AutoSize = true;
            this.lblResultFirstInt.ForeColor = System.Drawing.Color.Blue;
            this.lblResultFirstInt.Location = new System.Drawing.Point(94, 70);
            this.lblResultFirstInt.Name = "lblResultFirstInt";
            this.lblResultFirstInt.Size = new System.Drawing.Size(44, 22);
            this.lblResultFirstInt.TabIndex = 5;
            this.lblResultFirstInt.Text = "0.00";
            // 
            // lblOutPrinTitle
            // 
            this.lblOutPrinTitle.AutoSize = true;
            this.lblOutPrinTitle.Location = new System.Drawing.Point(6, 92);
            this.lblOutPrinTitle.Name = "lblOutPrinTitle";
            this.lblOutPrinTitle.Size = new System.Drawing.Size(82, 22);
            this.lblOutPrinTitle.TabIndex = 6;
            this.lblOutPrinTitle.Text = "首期本金:";
            // 
            // lblResultFirstPrin
            // 
            this.lblResultFirstPrin.AutoSize = true;
            this.lblResultFirstPrin.ForeColor = System.Drawing.Color.Blue;
            this.lblResultFirstPrin.Location = new System.Drawing.Point(94, 92);
            this.lblResultFirstPrin.Name = "lblResultFirstPrin";
            this.lblResultFirstPrin.Size = new System.Drawing.Size(44, 22);
            this.lblResultFirstPrin.TabIndex = 7;
            this.lblResultFirstPrin.Text = "0.00";
            // 
            // lblOutTotalIntTitle
            // 
            this.lblOutTotalIntTitle.AutoSize = true;
            this.lblOutTotalIntTitle.Location = new System.Drawing.Point(6, 114);
            this.lblOutTotalIntTitle.Name = "lblOutTotalIntTitle";
            this.lblOutTotalIntTitle.Size = new System.Drawing.Size(99, 22);
            this.lblOutTotalIntTitle.TabIndex = 8;
            this.lblOutTotalIntTitle.Text = "總利息支出:";
            // 
            // lblResultTotalInt
            // 
            this.lblResultTotalInt.AutoSize = true;
            this.lblResultTotalInt.ForeColor = System.Drawing.Color.Blue;
            this.lblResultTotalInt.Location = new System.Drawing.Point(111, 114);
            this.lblResultTotalInt.Name = "lblResultTotalInt";
            this.lblResultTotalInt.Size = new System.Drawing.Size(44, 22);
            this.lblResultTotalInt.TabIndex = 9;
            this.lblResultTotalInt.Text = "0.00";
            // 
            // lblOutTotalRepTitle
            // 
            this.lblOutTotalRepTitle.AutoSize = true;
            this.lblOutTotalRepTitle.Location = new System.Drawing.Point(6, 136);
            this.lblOutTotalRepTitle.Name = "lblOutTotalRepTitle";
            this.lblOutTotalRepTitle.Size = new System.Drawing.Size(99, 22);
            this.lblOutTotalRepTitle.TabIndex = 10;
            this.lblOutTotalRepTitle.Text = "總還款金額:";
            // 
            // lblResultTotalRep
            // 
            this.lblResultTotalRep.AutoSize = true;
            this.lblResultTotalRep.ForeColor = System.Drawing.Color.Blue;
            this.lblResultTotalRep.Location = new System.Drawing.Point(111, 136);
            this.lblResultTotalRep.Name = "lblResultTotalRep";
            this.lblResultTotalRep.Size = new System.Drawing.Size(44, 22);
            this.lblResultTotalRep.TabIndex = 11;
            this.lblResultTotalRep.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "個人房貸試算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.RadioButton rbDownAmount;
        private System.Windows.Forms.RadioButton rbDownPercent;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.TextBox txtGrace;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblOutLoanTitle;
        private System.Windows.Forms.Label lblResultMonthly;
        private System.Windows.Forms.Label lblOutMonthlyTitle;
        private System.Windows.Forms.Label lblResultLoan;
        private System.Windows.Forms.Label lblOutTotalIntTitle;
        private System.Windows.Forms.Label lblResultFirstPrin;
        private System.Windows.Forms.Label lblOutPrinTitle;
        private System.Windows.Forms.Label lblResultFirstInt;
        private System.Windows.Forms.Label lblOutInterestTitle;
        private System.Windows.Forms.Label lblResultTotalRep;
        private System.Windows.Forms.Label lblOutTotalRepTitle;
        private System.Windows.Forms.Label lblResultTotalInt;
    }
}

