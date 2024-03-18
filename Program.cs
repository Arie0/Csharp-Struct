using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    class Program
    {

        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;


            }


            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome} ");
                Console.WriteLine($"Preço: R$ {this.preco} ");
                Console.WriteLine($"Peso: {this.peso} kg");
                Console.WriteLine($"Marca: {this.marca}  ");
            }

            public float AdcCupom(float porc)
            {
                float desconto = this.preco * porc / 100;
                return this.preco - desconto;
            }



        }

        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola Nike", 12f, 1f, "Nike");
            Produto patins = new Produto("Patinete", 10f, 1f, "Adidas");

            bola.ExibirInfo();
            Console.WriteLine("**************");
            patins.ExibirInfo();

            float valorFinal = bola.AdcCupom(50f);
            patins.AdcCupom(50f);

            Console.WriteLine(valorFinal);

            Console.ReadLine();





        }


    }
}
