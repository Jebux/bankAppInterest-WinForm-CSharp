using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    internal class CuentaAhorros:CuentaUsuario
    {
        public decimal TasaInteres {  get; set; }

        public CuentaAhorros(string nombre, decimal tasaInteres) : base(nombre + "(" + tasaInteres + "%)")
        {
            TasaInteres = tasaInteres;
        }

        public override string Depositar(decimal cantidad)
        { 
            
            decimal valorDepositado = cantidad * ( TasaInteres/ 100) + cantidad;
            Balance += valorDepositado;

            return "Has depositado " + valorDepositado;
        }
    }
}
