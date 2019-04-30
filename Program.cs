using System;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewController;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
           do
           {
               //Menu Deslogado
               MenuUtil.MenuDeslogado();
               opcaoDeslogado = int.Parse(Console.ReadLine());

               switch (opcaoDeslogado)
               {
                   case 1:
                   //Cadastrar usuário
                   UsuarioViewController.CadastrarUsuario();
                   break;
                   case 2:
                   //Efetuar Login
                   UsuarioViewModel usuarioRetornado =  UsuarioViewController.EfetuarLogin();
                   if (usuarioRetornado != null)
                   {
                        Console.WriteLine($"Bem vindo {usuarioRetornado.Nome}");
                        //Coloar O menu Logado
                        bool sair = false;
                        do{
                            System.Console.WriteLine(" ");
                            MenuUtil.MenuLogado();
                            System.Console.WriteLine(" ");
                            int opcaoLogado = int.Parse(Console.ReadLine());
                            
                            switch (opcaoLogado)
                            {
                                case 1:  //Cadastrar Produtos
                                    LogadoViewController.CadastrarProduto();
                                break;
                                case 2:  //Listar todos os Produtos 
                                    LogadoViewController.ListarProduto();
                                break;
                                case 3:  //Buscar produto por ID 
                                    LogadoViewController.BuscarPorId();
                                break;
                                case 0:  //Sair
                                    sair = true;
                                break;
                                default:
                                    System.Console.WriteLine("Valor Inválido");
                                break;
                            }

                        } while (true);   
                   }
                   break;
                   case 3:
                   //Listar usuários Cadastrados
                   UsuarioViewController.ListarUsuario();
                   break;
                   case 0:
                   //Sair
                   break;
                   default:
                   Console.WriteLine("Opção Inválida");
                   break;
               }
           } while (opcaoDeslogado != 0);
        }
    }
}
