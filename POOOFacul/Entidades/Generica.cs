using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOFacul.Entidades
{
    public class Generica
    {
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }


        public int VerQuantidade()
        {

            if (Quantidade < 0)
            {

                Console.WriteLine("Estoque zerado!");
                return 0;
            }

            return Quantidade;



        }

        public decimal AdicionarItem(decimal valor)
        {

            return valor + Quantidade;

        }

        public decimal RemoverItem(decimal valor)
        {

            return valor - Quantidade;

        }

        




    }
}
