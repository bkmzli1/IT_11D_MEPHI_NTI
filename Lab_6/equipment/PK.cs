using System;
using Lab_6.hardware;

namespace Lab_6.equipment
{
    public class Pk : CompTex
    {
        private RAM _ram2;

        public Pk(CP cp, RAM ram, RAM ram2) : base(cp, ram)
        {
            _ram2 = ram2;
        }

        public override string toString()
        {
            return Convert.ToString(base.Cp) + Convert.ToString(base.Ram) + Convert.ToString(_ram2)+":PK";
        }
    }
}