using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.dominio
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DateTimeEnvio { get; private set; }
        public Usuario Usuario { get; private set; }

        public Mensagem(string texto, Usuario usuario)
        {
            this.Texto = texto;
            this.DateTimeEnvio = DateTime.Now;
            this.Usuario = usuario;
        }
    }
}
