using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vet
{
    internal class Mascota
    {
        public string nombre { get; set; }
        public int edad { get; set; } 

        public string especie { get; set; }
        public Mascota(string no,int e,string es) 
        {
            nombre = no;
            edad = e;
            especie = es;
        }

        public void datos()
        {
            Console.WriteLine("Ingrese Nombre de la mascota =)");
            string no=Console.ReadLine();
            Console.WriteLine("Inrese la edad de la mascota");
            int e=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la especia de la mascota");
            string es=Console.ReadLine();
        }
        public void masc() 
        {
            Console.WriteLine(nombre, edad, especie);
        }
        public override string ToString()
        {
            return $"Número de nombre: {nombre}, edad: {edad}, Especie: {especie}},";
        }
    }
}
