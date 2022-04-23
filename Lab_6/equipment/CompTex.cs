using System;
using Lab_6.hardware;

namespace Lab_6.equipment
{
    public class CompTex
    {
        private CP _cp;
        private RAM _ram;
        public CompTex(CP cp,RAM ram)
        {
            _cp = cp;
            _ram = ram;
        }

        public virtual CP Cp
        {
            get => _cp;
            set => _cp = value;
        }

        public RAM Ram
        {
            get => _ram;
            set => _ram = value;
        }

        public virtual string RamString()
        {
            return Convert.ToString(_cp);
        }

        public virtual String toString()
        {
            return Convert.ToString(_cp) + Convert.ToString(_ram)+":CompTex";
        }
    }
}