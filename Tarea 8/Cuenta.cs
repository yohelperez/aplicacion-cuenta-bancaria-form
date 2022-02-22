using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_8
{
    class Cuenta
    {
        double saldo = 0;
        string name;
        string iD;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public double Depositar
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo += value;
            }
        }

        public double Retirar
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo -= value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

    }
}