using LojaRepository.Context;
using LojaService.Entities;
using LojaService.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRepository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        LojaContext Db;
        public UsuarioRepository(LojaContext db) : base(db)
        {
            Db = db;
        }
    }
}
