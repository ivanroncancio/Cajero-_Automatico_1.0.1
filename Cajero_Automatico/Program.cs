using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int t = 0, t2 = 0;
            Cajero cajero = new Cajero();
            
            do
            {
               
               
                Console.WriteLine("Ingresa opcion");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    cajero.RegistrarUsuario();
                }
                if (n == 2)
                {
                    
                    cajero.validacionID(t,t2);
                }
                if (n == 3)
                {
                    cajero.Retirar();
                }
                if(n == 4)
                {
                    
                    cajero.Consignacion(t,t2);
                }
                
                
                
                

                Console.WriteLine("in......");
                n1 = int.Parse(Console.ReadLine());

            } while (n1 > 0);

            
        }   
    }
}
