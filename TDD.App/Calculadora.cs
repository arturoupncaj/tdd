using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.App
{
    public class Calculadora
    {
        private Modo modo;
        public Calculadora(Modo modo)
        {
            this.modo = modo;
        }
        public int Sumar(int v1, int v2)
        {
            if (modo.Mode == "decimal")
                return v1 + v2;
            if (modo.GetMode() == "binario")
                return 1;
            return 0;
        }
        
        public int Mutiplicar(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
