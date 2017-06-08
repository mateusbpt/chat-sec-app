using chat.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace chat.teste
{
    public class MensagemTeste
    {
        Usuario usuario = new Usuario();
        
        [Fact]
        public void ValidarMensagemProibida()
        {
            Mensagem mensagem = new Mensagem("Olá Leandro", usuario);
            Assert.Equal(mensagem.mensagemProibida("Olá Leandro"), "Olá ******");
        }
    }
}
