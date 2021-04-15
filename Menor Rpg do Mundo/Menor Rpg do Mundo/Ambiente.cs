using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    public class Ambiente
    {
        public Ambiente()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Ambiente(string _nome, string _descricao)
        {
            this.Nome = _nome;
            this.Descricao = _descricao;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public void TextoAmbiente()
        {
            Console.WriteLine(this.Descricao);
        }
    }
}
