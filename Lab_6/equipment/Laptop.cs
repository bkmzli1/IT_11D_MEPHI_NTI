using System;
using Lab_6.hardware;

namespace Lab_6.equipment
{
    public class Laptop : CompTex
    {
        private bool _builtInGraphicsCard;

        public Laptop(CP cp, RAM ram, bool builtInGraphicsCard) : base(cp, ram)
        {
            this._builtInGraphicsCard = builtInGraphicsCard;
        }

        public override string RamString()
        {
            return Convert.ToString(CP.AMD);
        }

        public override string toString()
        {
            return  Convert.ToString(RamString()) + Convert.ToString(Ram) +
                   Convert.ToString(_builtInGraphicsCard)+":Laptop";
        }
    }
}