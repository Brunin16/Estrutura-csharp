using FiapW.Estrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapW.Estrutura.Controller
{
    public class UsuarioController
    {
        public bool validarUsuario(string usuario, string senha)
        {
            UsuarioRepository repository = new UsuarioRepository();

            return repository.validarUsuario(usuario, senha);
        }
    }
}
