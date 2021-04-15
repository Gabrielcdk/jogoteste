using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    public class Monstro
    {
        public Monstro()
        {
            Nome = "";
            Descricao = "";
            Tipodedado = "";
        }

        public Monstro(string _nome, string _descricao, string _tipodedado)
        {
            Nome = _nome;
            Descricao = _descricao;
            Tipodedado = _tipodedado;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipodedado { get; set; }
        
        public void TextoMonstro()
        {
            Console.WriteLine("De repente apareceu um " + this.Nome + " " + this.Descricao + "\nEle veio para cima de mim sem tempo de me esconder");
            Console.WriteLine("~Role um " + this.Tipodedado + " para tentar sobreviver");
            Console.ReadLine();
            Random dadoD6 = new Random();
            int d6 = dadoD6.Next(1, 7);
            Console.WriteLine("Você tirou um " + d6);
            Console.ReadLine();
            if (d6 <= 3)
            {
                Console.WriteLine("O " + this.Nome + " é muito mais forte que eu\nAcho que não vou conseguir sobreviver... ");
                ChamarGameOver();
                //chamar Game Over
            }
            else
            {
                Console.WriteLine("Depois de uma luta intensa consegui escapar do maldito " + this.Nome + "\nEstou muito cansado para continuar... \nResolvi me encostar aqui mesmo...");
                Chamardia();
                
            }
            
            
        }

        static void Chamardia()
        {
            Dias d1 = new Dias();
            d1.NovoDia();
        }
        static void ChamarGameOver()
        {
            GameOver g1 = new GameOver();
            g1.TextoGameOver();
        }

    }
}
