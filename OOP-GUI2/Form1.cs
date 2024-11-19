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

            while (true)
            {
                if (double.TryParse(txtCarSalesPrice.Text, out double carSalesPrice))
                {
                    if (carSalesPrice > 0)
                    {
                        compute.carSalesPrice = carSalesPrice;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number greater than 0 in car sales price.");
                        txtCarSalesPrice.Text = string.Empty;
                        txtCarSalesPrice.Focus();
                        return;
                    }
                }
                else if (txtCarSalesPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the car sales price.");
                    txtCarSalesPrice.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number in car sales price.");
                    txtCarSalesPrice.Text = string.Empty;
                    txtCarSalesPrice.Focus();
                    return;
                }
            }

            while (true)
            {
                if (double.TryParse(txtTradeinAllowance.Text, out double tradeinAllowance))
                {
                    if (tradeinAllowance >= 0)
                    {
                        compute.tradeinAllowance = tradeinAllowance;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a number greater than 0 in trade-in allowance.");
                        txtTradeinAllowance.Text = string.Empty;
                        txtTradeinAllowance.Focus();
                        return;
                    }
                }
                else if (txtTradeinAllowance.Text == string.Empty)
                {
                    txtTradeinAllowance.Text = compute.tradeinAllowance.ToString();
                    break;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number in trade-in allowance.");
                    txtTradeinAllowance.Text = string.Empty;
                    txtTradeinAllowance.Focus();
                    return; 
                }
            }

            if (cbStereoSystem.Checked) { compute.setAccessoriesAndFinishPrice("stereo"); }
            if (cbLeatherInterior.Checked) { compute.setAccessoriesAndFinishPrice("leather"); }
            if (cbComputerNav.Checked) { compute.setAccessoriesAndFinishPrice("computer"); }
            if (rbStandard.Checked) { compute.setAccessoriesAndFinishPrice("standard"); }
            if (rbPearlized.Checked) { compute.setAccessoriesAndFinishPrice("pearlized"); }
            if (rbCustomizedDet.Checked) { compute.setAccessoriesAndFinishPrice("customized"); }

            txtAccessoriesAndFinish.Text = compute.showResult("accessories").ToString("N2");
            txtSubtotal.Text = compute.showResult("subtotal").ToString("N2");
            txtSalesTax.Text = compute.showResult("salesTax").ToString("N2");
            txtTotal.Text = compute.showResult("total").ToString("N2");
            txtAmountDue.Text = compute.showResult("amountDue").ToString("N2");
        }
    }
}
