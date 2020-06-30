using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Clase
{
    class Vehiculo
    {
        //propiedades
        public string marca;
        public string placa;
        public int modelo;
        public int precio;
        //metodo
        public Vehiculo(string marca, string placa, int modelo,int precio)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.precio = precio;
        }
    }
}
