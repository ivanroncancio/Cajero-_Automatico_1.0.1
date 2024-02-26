using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    internal class Cajero:Usuario
    {
        public void Retirar()
        {
            int valor = 0;
            int contador = 0;
            int suma = 0;
            Console.WriteLine("Ingresa N° Cedula:");
            int n = int.Parse(Console.ReadLine());
            int indice1 = ID.IndexOf(n);
            Console.WriteLine("Ingresa tu contraseña de 4 digitos:");
            int n2 = int.Parse(Console.ReadLine());
            int indice2 = Contraseña.IndexOf(n2);
            Console.WriteLine(n + " " + indice1);
            Console.WriteLine(n2 + " " + indice2);

            if (indice1 == indice2)
            {


                Console.WriteLine("Ingresa valor a retirar:");
                valor = int.Parse(Console.ReadLine());
                foreach (int i in Dinero)
                {
                    if (indice2 == contador)
                    {
                        suma = i;
                        Console.WriteLine(suma);
                    }
                    contador++;
                }
                suma = suma - valor;
                Dinero[indice1] = suma;



            }
        }
        public void Consignacion(int indice1, int indice2)
        {
            int valor;
            int contador = 0;   
            int suma = 0;
            int cuentaDes = 0;
            int indiceDes = 0;
            validacionID(indice2,indice1);

            if (indice1 == indice2)
            {
                Console.WriteLine("Ingresa en laor a consignar");
                valor = Convert.ToInt32(Console.ReadLine());

                foreach(int i in Dinero)
                {
                    if (indice1 == contador)
                    {
                        suma = i;
                    }
                    contador++;
                }
                suma = suma -valor;
                Dinero[indice1] = suma;

                contador = 0;
                suma = 0;
                Console.WriteLine("Ingresa el numero de cuenta del destinatario");
                cuentaDes = int.Parse(Console.ReadLine());
                indiceDes = ID.IndexOf(cuentaDes);

                foreach(int i in Dinero)
                {
                    if (indiceDes == contador)
                    {
                        suma = i;
                    }
                    contador++;
                }
                suma = suma + valor;
                Dinero[indiceDes] = suma;

            }

                
            
        }
    }
}
