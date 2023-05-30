using LojaService.DTO;
using LojaService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaService.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Usuario Login(LoginDTO login);
    }
}
