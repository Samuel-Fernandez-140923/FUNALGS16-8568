using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
 
    class Servicio
    {
        public string descripcion { get; set; }
        public double precio { get; set; }

        public void vari2(string des,double pre) 
        {
            descripcion = des;
            precio = pre;
        
        
        }
        public void servi() 
        {
            Console.WriteLine("Ingrese la descripcion de la mascota");
            string des=Console.ReadLine();
            Console.WriteLine("Ingrese el precio:");
            double pre =double.Parse(Console.ReadLine());
        
        }
    }
}
