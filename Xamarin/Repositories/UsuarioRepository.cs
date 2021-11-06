using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Model;

namespace Xamarin.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }
        private int codigo = 1;

        public void Adicionar(Usuario usuario)
        {
            usuario.Codigo = codigo;
            usuarios.Add(usuario);
            codigo++;
        }
        public void Editar(Usuario usuario)
        {
            Usuario U = usuarios.Find(Us => Us.Codigo == usuario.Codigo);
            int posicao = usuarios.IndexOf(U);

            usuarios[posicao] = usuario;
        }
    }
}
