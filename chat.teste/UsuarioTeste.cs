using chat.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace chat.teste
{
    public class UsuarioTeste
    {
        public List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                Id = 1,
                Nome = "mateusbpt"
            },
            new Usuario()
            {
                Id = 2,
                Nome = "teste"
            }
        };

        [Fact]
        public void ValidarUsuarioNaoExistente()
        {
            var usuario = new Usuario()
            {
                Id = 3,
                Nome = "leandro"
            };
            Assert.False(usuario.ValidarNicknameRepetido(usuarios));
        }

        [Fact]
        public void ValidarUsuarioExistente()
        {
            var usuario = new Usuario()
            {
                Id = 3,
                Nome = "teste"
            };
            Assert.True(usuario.ValidarNicknameRepetido(usuarios));
        }
    }
}
