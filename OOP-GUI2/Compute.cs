using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace OOP_GUI2
{
    public class Compute
    {
        public double carSalesPrice {  get; set; }
        public double accessoriesAndFinish {  get; set; }
        public double subtotal {  get; set; }
        public double salesTax { get; set; }
        public double total {  get; set; }
        public double tradeinAllowance {  get; set; }
        public double amountDue { get; set; }
        public Compute()
        {
            carSalesPrice = 0;
            accessoriesAndFinish = 0;
            subtotal = 0;
            salesTax = 0;
            total = 0;
            tradeinAllowance = 0;
            amountDue = 0;
        }
        public Compute(double carSalesPrice, double accessoriesAndFinish, double subtotal, double salesTax, double total, double tradeinAllowance, double amountDue)
        {
            this.carSalesPrice = carSalesPrice;
            this.accessoriesAndFinish = accessoriesAndFinish;
            this.subtotal = subtotal;
            this.salesTax = salesTax;
            this.total = total;
            this.tradeinAllowance = tradeinAllowance;
            this.amountDue = amountDue;
        }
        public double showSubtotal(Compute compute)
        {
            return compute.subtotal = compute.carSalesPrice + compute.accessoriesAndFinish;
        }
        public double showSalesTax(Compute compute, Constant constant)
        {
            return compute.salesTax = compute.subtotal * constant.taxRate;
        }
        public double showTotal(Compute compute)
        {
            return compute.total = compute.subtotal + compute.salesTax;
        }
        public double showAmountDue(Compute compute)
        {
            return compute.amountDue = compute.total - compute.tradeinAllowance;
        }
        public void showMessageBox(string message)
        {
            MessageBox.Show($"Please enter a valid numeric value in {message}.");
        }
    }
}
