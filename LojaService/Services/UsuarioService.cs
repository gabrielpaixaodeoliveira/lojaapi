using LojaService.DTO;
using LojaService.Entities;
using LojaService.Interfaces.Repository;
using LojaService.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaService.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IBaseRepository<Usuario> _usuarioRepository;

        public UsuarioService(IBaseRepository<Usuario> usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Login(LoginDTO login)
        {
            return _usuarioRepository
                .GetBy(x => x.Senha == login.Senha && x.Login == login.Login)
                .FirstOrDefault();
        }
    }
}
