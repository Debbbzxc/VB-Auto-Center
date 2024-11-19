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
    public class Compute : Constant
    {
        public double carSalesPrice { get; set; }
        public double accessoriesAndFinish { get; set; }
        public double subtotal { get; set; }
        public double salesTax { get; set; }
        public double total { get; set; }
        public double tradeinAllowance { get; set; }
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
        public double getAccessoriesAndFinishPrice(string addon)
        {
            if (addon == "stereo")
                return stereoSystem;
            else if (addon == "leather")
                return leatherInterior;
            else if (addon == "computer")
                return computerNav;
            else if (addon == "standard")
                return standard;
            else if (addon == "pearlized")
                return pearlized;
            else if (addon == "customized")
                return customizedDet;
            else
                return 0.00;
        }
        public double setAccessoriesAndFinishPrice(string addon)
        {
            return accessoriesAndFinish += getAccessoriesAndFinishPrice(addon);
        }
        public double showResult(string result)
        {
            if (result == "accessories")
                return accessoriesAndFinish;
            else if (result == "subtotal")
                return subtotal = carSalesPrice + accessoriesAndFinish;
            else if (result == "salesTax")
                return salesTax = subtotal * taxRate;
            else if (result == "total")
                return total = subtotal + salesTax;
            else if (result == "amountDue")
                return amountDue = total - tradeinAllowance;
            else
                return 0.00;
        }
    }
}
