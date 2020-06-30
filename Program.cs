using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo mivehiculo = new Vehiculo("kia", "kIC53", 2017,1054);
            Console.WriteLine("La marca del vehiculo es: "+ mivehiculo.marca);
            Console.WriteLine("La placa del vehiculo es: "+ mivehiculo.placa);
            Console.WriteLine("El modelo del vehiculo es: "+ mivehiculo.modelo);
            Console.WriteLine("El precio del vehiculo es:" + mivehiculo.precio);
        }
    }

}
 
    
