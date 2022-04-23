using System;
using Lab_6.hardware;

namespace Lab_6.equipment
{
    public class Server : CompTex
    {
        public Server(CP cp, RAM ram) : base(cp, ram)
        {
        }

        public override CP Cp
        {
            get { return CP.Apple; }
        }
        public override String toString()
        {
            return Convert.ToString(Cp) + Convert.ToString(base.Ram) + Convert.ToString(base.Ram)+":server";
        }
    }
}