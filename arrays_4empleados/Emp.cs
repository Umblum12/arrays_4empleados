using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_4empleados
{
    internal class Emp
    {
        //Propiedades
        private int[] Sueldos;
        //Constructor
        public Emp()
        {
            Sueldos = new int[4];
            for (int i = 0; i < Sueldos.Length; i++)
            {
                Console.WriteLine("Ingrese el Sueldo:");
                string linea = Console.ReadLine();
                Sueldos[i] = int.Parse(linea);
            }
        }
    }
}
