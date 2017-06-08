using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nickname { get; set; }


        public bool ValidarNicknameRepetido(List<Usuario> usuarios)
        {
            return usuarios.Any(u => u.Nickname.ToLower().Equals(Nickname.ToLower()));
        }
    }
}
