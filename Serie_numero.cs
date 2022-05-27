ing System;
using System.Collections.Generic;
using System.Text;

namespace ByronCalderon3A_Ejercicio9
{
    public class Serie_numero
    {
        private int Valor_numero { get; set; }
        private int Valor_total { get; set; }
        private int Valor_contador { get; set; }

        public Serie_numero()
        {
            this.Valor_numero = 0;
            this.Valor_total = 0;
            this.Valor_contador = 0;
        }

        public void Media_aritmetica()
        {
            do
            {
                Valor_contador++;
                Console.WriteLine("Ingrese un numero para agregar a la media aritmetica");
                String Valor_ingreso = Console.ReadLine();
                Valor_numero = Convert.ToInt32(Valor_ingreso);
                Valor_total = Valor_numero + Valor_total;
            } while (Valor_numero != 0);
             int Valor_media = Valor_total / (Valor_contador - 1);
            Console.WriteLine("El resultado de la media aritmetica es: " + Valor_media);
        }
    }
}
