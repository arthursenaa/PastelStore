using System;
using System.Collections.Generic;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.Repositorio
{
    public class CardapioRepositorio
    {
        public List<ProdutoViewModel> ListaDeProdutos = new List<ProdutoViewModel>();

        public ProdutoViewModel Inserir(ProdutoViewModel todosProdutos){
            todosProdutos.Id = ListaDeProdutos.Count +1;
            todosProdutos.DataCriacao = DateTime.Now;

            ListaDeProdutos.Add(todosProdutos);
            return todosProdutos;
        }   

        public void BuscarPorId(){
            Console.Write("Digite o ID do produto desejado : ");
            int idDesejado = int.Parse(Console.ReadLine());

            foreach (var item in ListaDeProdutos)
            {
                if(item == null){
                    break;
                }
                if(idDesejado.Equals(item.Id)){
                    Console.WriteLine($"Produto - {item.Nome}\nDescrição - {item.Descricao}\nPreço - {item.Preco}");
                }
            }
        }
        internal List<CardapioRepositorio> Listar()
        {
            throw new NotImplementedException();
        }
    }
}