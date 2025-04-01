using System;
using eCommerce.Models;

namespace eCommerce.Repositories
{
    public interface IUsuarioRepository
    {
        // Vamos descrever os métodos de um CRUD para Usuários.

        List<Usuario> Get();
        Usuario Get(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int Id);
    }
}