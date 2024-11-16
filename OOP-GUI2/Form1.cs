using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbStereoSystem.Checked = false;
            cbLeatherInterior.Checked = false;
            cbComputerNav.Checked = false;
            rbStandard.Checked = false;
            rbPearlized.Checked = false;
            rbCustomizedDet.Checked = false;
            txtCarSalesPrice.Text = string.Empty;
            txtAccessoriesAndFinish.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtSalesTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTradeinAllowance.Text = string.Empty;
            txtAmountDue.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Constant constant = new Constant();
            Compute compute = new Compute();

            if (txtCarSalesPrice.Text == string.Empty) { txtCarSalesPrice.Text = compute.carSalesPrice.ToString("F2"); }
            else
            {
                if (double.TryParse(txtCarSalesPrice.Text, out double carSalesPrice))
                {
                    compute.carSalesPrice = carSalesPrice;
                }
                else
                {
                    compute.showMessageBox("car sales price");
                    txtCarSalesPrice.Text = string.Empty;
                    txtCarSalesPrice.Focus();
                }
            }

            if (txtTradeinAllowance.Text == string.Empty) { txtTradeinAllowance.Text = compute.tradeinAllowance.ToString("F2"); }
            else
            {
                if (double.TryParse(txtTradeinAllowance.Text, out double tradeinAllowance))
                {
                    compute.tradeinAllowance = tradeinAllowance;
                }
                else
                {
                    compute.showMessageBox("trade-in allowance");
                    txtTradeinAllowance.Text = string.Empty;
                    txtTradeinAllowance.Focus();
                }
            }

            if (cbStereoSystem.Checked) { compute.accessoriesAndFinish += constant.stereoSystem; }
            if (cbLeatherInterior.Checked) { compute.accessoriesAndFinish += constant.leatherInterior; }
            if (cbComputerNav.Checked) { compute.accessoriesAndFinish += constant.computerNav; }
            if (rbStandard.Checked) { compute.accessoriesAndFinish += constant.standard; }
            if (rbPearlized.Checked) { compute.accessoriesAndFinish += constant.pearlized; }
            if (rbCustomizedDet.Checked) { compute.accessoriesAndFinish += constant.customizedDet; }

            txtAccessoriesAndFinish.Text = compute.accessoriesAndFinish.ToString("F2");
            txtSubtotal.Text = compute.showSubtotal(compute).ToString("F2");
            txtSalesTax.Text = compute.showSalesTax(compute, constant).ToString("F2");
            txtTotal.Text = compute.showTotal(compute).ToString("F2");
            txtAmountDue.Text = compute.showAmountDue(compute).ToString("F2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Debbbzxc");
        }
    }
}
