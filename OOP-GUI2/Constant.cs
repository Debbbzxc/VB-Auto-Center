using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GUI2
{
    public class Constant
    {
        public double stereoSystem {  get; set; }
        public double leatherInterior { get; set; }
        public double computerNav { get; set; }
        public double standard {  get; set; }
        public double pearlized { get; set; }
        public double customizedDet {  get; set; }
        public double taxRate { get; set; }
        public Constant()
        {
            stereoSystem = 425.76;
            leatherInterior = 987.41;
            computerNav = 1741.23;
            standard = 0;
            pearlized = 345.72;
            customizedDet = 599.99;
            taxRate = 0.08;
        }
        public Constant(double stereoSystem, double leatherInterior, double computerNav, double standard, double pearlized, double customizedDet, double taxRate)
        {
            this.stereoSystem = stereoSystem;
            this.leatherInterior = leatherInterior;
            this.computerNav = computerNav;
            this.standard = standard;
            this.pearlized = pearlized;
            this.customizedDet = customizedDet;
            this.taxRate = taxRate;
        }
    }
}
