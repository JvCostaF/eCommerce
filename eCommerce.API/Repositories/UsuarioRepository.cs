using System;
using eCommerce.Models;

namespace eCommerce.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public static List<Usuario> _db = [];
        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }

        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario Get(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }

        public void Update(Usuario usuario)
        {
            _db.Remove(Get(usuario.Id));
            _db.Add(usuario);
        }
    }
}