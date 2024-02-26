using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    internal class Usuario
    {
        public ArrayList ID = new ArrayList();
        public ArrayList Contraseña = new ArrayList();
        public ArrayList Puntos = new ArrayList();
        public ArrayList Dinero = new ArrayList();

        public int n;
        public int n2;

        public void RegistrarUsuario()
        {
            
            Console.WriteLine("Ingresa N° Cedula:");
            n = int.Parse(Console.ReadLine());
            ID.Add(n);
            int indice1 = ID.IndexOf(n);
            Console.WriteLine("Ingresa tu contraseña de 4 digitos:");
            n2 = int.Parse(Console.ReadLine());
            


            if (n2 > 999 && n2 < 10000)
            {
                Contraseña.Add(n2);
                Console.WriteLine("Usuario Guardado");
                Console.WriteLine();
                Console.WriteLine("Desea consignar por primera vez dinero a su cuenta:\n1.si\n2. no");
                int elec = int.Parse(Console.ReadLine());

                if (elec == 1)
                {
                    Console.WriteLine("Ingresa monto:");
                    int valor = int.Parse(Console.ReadLine());
                    Dinero.Add(valor);
                    Puntos.Add(0);
                }
                else
                {
                    Dinero.Add(0);
                    Puntos.Add(0);
                }
            }
            else
            {
                Console.WriteLine("Usuario invalido!!!");
                Console.WriteLine("La contraseña supera el numero de digitos");
                ID.RemoveAt(indice1);

            }
            

        }
        public void validacionID (int indice2,int indice1)
        {
            Console.WriteLine("Ingresa N° Cedula:");
            int n = int.Parse(Console.ReadLine());
            indice1 = ID.IndexOf(n);
            Console.WriteLine("Ingresa tu contraseña de 4 digitos:");
            int n2 = int.Parse(Console.ReadLine());
            indice2 = Contraseña.IndexOf(n2);
            Console.WriteLine(n + " " + indice1);
            Console.WriteLine(n2 + " " + indice2);




            if ( indice1 == indice2)
            {
                Console.WriteLine("Contraseña valida");
                
                Console.WriteLine("Saldo: " + Dinero[indice2]);

                
                
            }

            
        }
        



    }
}
