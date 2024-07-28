using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ClassObject
{
    public class Araba
    {
        //Ozellikler
        public string Marka;
        public string Model;
        public int Yil;

        //Davranislar
        public void Calistir()
        {
            Console.WriteLine("Araba calisti.");
        }

    }
}
