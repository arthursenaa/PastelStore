using System;
using System.Collections.Generic;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.ViewController
{
    public class LogadoViewController
    {
        static CardapioRepositorio  produtoRepositorio = new CardapioRepositorio();
        public static void CadastrarProduto(){
            string  produto, descricao;
            float preco;

            do
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("--Cadastrar Produto--\n  ");
                System.Console.Write("Nome Do Produto : ");
                produto = Console.ReadLine();
                if (string.IsNullOrEmpty(produto))
                {
                    Console.WriteLine("Produto inválido");
                }
            } while (string.IsNullOrEmpty(produto));
            // do
            // {
                
                System.Console.Write("Digite o Preço do Produto : ");
                preco = float.Parse(Console.ReadLine());
                // if(preco < 0){
                //     System.Console.WriteLine("Preço Inválido");
                //     continue;
                // }
            // } while (preco > 0);
            
            System.Console.WriteLine("Digite a Descrrição do Produto");
            descricao = Console.ReadLine();

            ProdutoViewModel ViewProdutos = new ProdutoViewModel();
            ViewProdutos.Produto = produto;
            ViewProdutos.Preco = preco;
            ViewProdutos.Descricao = descricao;

            produtoRepositorio.Inserir(ViewProdutos);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Produto Cadastrado com sucesso");
            Console.ResetColor();
        }
        public static void ListarProduto(){
            List<CardapioRepositorio> ListaDeProdutos = produtoRepositorio.Listar();

            foreach (var item in ListaDeProdutos)
            {
                System.Console.WriteLine("Id - {item.Id}\nProduto : {item.Produto}\nPreço : {item.Preco}\nDescrição : {item.Descricao}\nData de Criação : {item.DataCriacao}\n----------------------------------\n ");
            }
        }
        public static void BuscarPorId(){

        }
    }
}