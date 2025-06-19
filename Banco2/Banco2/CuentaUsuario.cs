using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    internal class CuentaUsuario
    {
        private decimal tasaInteres;

        public string Nombre { get; private set; }

        public Guid NumeroCuenta { get; private set; }

        public decimal Balance { get; protected set; }

        public CuentaUsuario(string nombre) 
        {
            Nombre = nombre;
            NumeroCuenta = Guid.NewGuid();
            Balance = 0;
        }

        public CuentaUsuario(string nombre, decimal tasaInteres) : this(nombre)
        {
            this.tasaInteres = tasaInteres;
        }

        public virtual string Depositar(decimal cantidad) 
        {
            if (cantidad <= 0)
            {
                return "No se puede depositar" + cantidad;
            }

            if (cantidad > 20000) 
            {
                return "De dónde viene esa plata?? 🤨";
            }
            Balance += cantidad;
            return "Dinero depositado exitosamente";
        }

        public string Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                return "No se puede retirar" + cantidad;
            }

            if (cantidad > Balance)
            {
                return "Ud no le alcanza pa eso 🤨";
            }
            Balance -= cantidad;
            return "Dinero retirado exitosamente";
        }

    }
}
