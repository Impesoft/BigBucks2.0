using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace BigBucks2._0
{
    internal abstract class Beverage : IBeverage
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description { get; set; }

        private static int instanceIDCounter = 1;

        public string DefaultImage { get; set; }

        public int InstanceID { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        protected Beverage()
        {
            InstanceID = instanceIDCounter;
            instanceIDCounter++;
        }

        public override string ToString()
        {
            string result = $"{Price}, {Description}, {InstanceID}, {Image}, {Name}";
            return result;
        }

        public virtual List<Control> CreateControls()
        {
            return null;
        }
    }
}