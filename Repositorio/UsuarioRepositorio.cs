using System;
using System.Collections.Generic;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.Repositorio
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

            return usuario;            
        }

        public List<UsuarioViewModel> Listar(){
            return listaDeUsuarios;
        }//Fim Listar
        public UsuarioViewModel BuscarUsuario(string email, string senha){
            foreach (var item in listaDeUsuarios)
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }
            return null;
        }//fim buscarUsuario

    }
}