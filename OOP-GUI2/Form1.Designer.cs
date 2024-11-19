namespace OOP_GUI2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbStereoSystem = new System.Windows.Forms.CheckBox();
            this.cbLeatherInterior = new System.Windows.Forms.CheckBox();
            this.cbComputerNav = new System.Windows.Forms.CheckBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbPearlized = new System.Windows.Forms.RadioButton();
            this.rbCustomizedDet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCarSalesPrice = new System.Windows.Forms.TextBox();
            this.txtAccessoriesAndFinish = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTradeinAllowance = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStereoSystem
            // 
            this.cbStereoSystem.AutoSize = true;
            this.cbStereoSystem.Location = new System.Drawing.Point(20, 28);
            this.cbStereoSystem.Name = "cbStereoSystem";
            this.cbStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.cbStereoSystem.TabIndex = 0;
            this.cbStereoSystem.Text = "Stereo System";
            this.cbStereoSystem.UseVisualStyleBackColor = true;
            // 
            // cbLeatherInterior
            // 
            this.cbLeatherInterior.AutoSize = true;
            this.cbLeatherInterior.Location = new System.Drawing.Point(20, 51);
            this.cbLeatherInterior.Name = "cbLeatherInterior";
            this.cbLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.cbLeatherInterior.TabIndex = 1;
            this.cbLeatherInterior.Text = "Leather Interior";
            this.cbLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // cbComputerNav
            // 
            this.cbComputerNav.AutoSize = true;
            this.cbComputerNav.Location = new System.Drawing.Point(20, 74);
            this.cbComputerNav.Name = "cbComputerNav";
            this.cbComputerNav.Size = new System.Drawing.Size(125, 17);
            this.cbComputerNav.TabIndex = 2;
            this.cbComputerNav.Text = "Computer Navigation";
            this.cbComputerNav.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(20, 28);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 3;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbPearlized
            // 
            this.rbPearlized.AutoSize = true;
            this.rbPearlized.Location = new System.Drawing.Point(20, 51);
            this.rbPearlized.Name = "rbPearlized";
            this.rbPearlized.Size = new System.Drawing.Size(68, 17);
            this.rbPearlized.TabIndex = 4;
            this.rbPearlized.TabStop = true;
            this.rbPearlized.Text = "Pearlized";
            this.rbPearlized.UseVisualStyleBackColor = true;
            // 
            // rbCustomizedDet
            // 
            this.rbCustomizedDet.AutoSize = true;
            this.rbCustomizedDet.Location = new System.Drawing.Point(20, 74);
            this.rbCustomizedDet.Name = "rbCustomizedDet";
            this.rbCustomizedDet.Size = new System.Drawing.Size(123, 17);
            this.rbCustomizedDet.TabIndex = 5;
            this.rbCustomizedDet.TabStop = true;
            this.rbCustomizedDet.Text = "Customized Detailing";
            this.rbCustomizedDet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStereoSystem);
            this.groupBox1.Controls.Add(this.cbLeatherInterior);
            this.groupBox1.Controls.Add(this.cbComputerNav);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPearlized);
            this.groupBox2.Controls.Add(this.rbStandard);
            this.groupBox2.Controls.Add(this.rbCustomizedDet);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 111);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // txtCarSalesPrice
            // 
            this.txtCarSalesPrice.Location = new System.Drawing.Point(340, 37);
            this.txtCarSalesPrice.Name = "txtCarSalesPrice";
            this.txtCarSalesPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCarSalesPrice.TabIndex = 9;
            // 
            // txtAccessoriesAndFinish
            // 
            this.txtAccessoriesAndFinish.Location = new System.Drawing.Point(340, 60);
            this.txtAccessoriesAndFinish.Name = "txtAccessoriesAndFinish";
            this.txtAccessoriesAndFinish.ReadOnly = true;
            this.txtAccessoriesAndFinish.Size = new System.Drawing.Size(100, 20);
            this.txtAccessoriesAndFinish.TabIndex = 10;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(340, 109);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(100, 20);
            this.txtSalesTax.TabIndex = 12;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(340, 86);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 11;
            // 
            // txtTradeinAllowance
            // 
            this.txtTradeinAllowance.Location = new System.Drawing.Point(340, 158);
            this.txtTradeinAllowance.Name = "txtTradeinAllowance";
            this.txtTradeinAllowance.Size = new System.Drawing.Size(100, 20);
            this.txtTradeinAllowance.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(340, 135);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(340, 184);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmountDue.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Car Sales Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Accessories && Finish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trade-in Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sales Tax (8%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Amount Due";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(203, 247);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 38);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(284, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.txtTradeinAllowance);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtAccessoriesAndFinish);
            this.Controls.Add(this.txtCarSalesPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "VB Auto Center";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbStereoSystem;
        private System.Windows.Forms.CheckBox cbLeatherInterior;
        private System.Windows.Forms.CheckBox cbComputerNav;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbPearlized;
        private System.Windows.Forms.RadioButton rbCustomizedDet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCarSalesPrice;
        private System.Windows.Forms.TextBox txtAccessoriesAndFinish;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTradeinAllowance;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

