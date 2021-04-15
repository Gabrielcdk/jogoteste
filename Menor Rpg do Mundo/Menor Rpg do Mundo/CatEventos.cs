using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    public class CatEventos
    {
        public  CatEventos()
        {
            this.IniciaListaEventos();
        }

        public List<Evento> ListaEventos { get; set; }



        public void IniciaListaEventos()
        {
            this.ListaEventos = new List<Evento>();  // Tipos de Consequencias 1 - Novo dia, 2 - encontro com monstro, 3 - Novo evento, 4 - Morte...
            this.ListaEventos.Add(new Evento("A sombra misteriosa", "Acho que estou vendo uma sombra chegar perto...\nNão consigo ver do que se trata\nMe levanto e vou em direção à sombra", "Ataco desperadamente a sombra", "Tento conversar com a sombra", "Tento iluminar a sombra para ver do que se trata", "Corri em direção à sombra para dar meu melhor ataque\nmas ela desviou e acabei sendo atacado por ela...", "Quem é você ?Pergunteo\nNão obtive resposta\nTentei me aproximar mais de perto...", "Uso uma vela para iluminar a sombra e vejo que não era nada\nAcho que estou ficando maluco...\nMelhor descansar um pouco",2,3,1));
            this.ListaEventos.Add(new Evento("Um gnomo", "Olhei fixamente para a direção da porta\nVi uma figura pequena bastante pitoresca\nParecia que tinha saído dos livros infantis\nEra um gnomo...", "Vou tentar conversar com o gnomo", "Melhor atar primeiro o gnomo antes que ele me ataque", "Ignorar o gnomo", "Tentei me aproximar do gnomo, mas ele correu\nFui em direção à porta...\nQuando cheguei lá não vi mais nada\nAcho que estou ficando maluco melhor descansar um pouco", "Corri em direção ao gnomo com intuito de lhe atacar\nMuito mais ágil ele corre em direão à porta e foge\nMas escuto um novo barulho se aproximando rapidamente de mim...", "Resolvi ignorar aquela figura\nMas cada vez mais ele se aproximava de mim\nJá não aguentava mais tive que olhá-lo fixamente\nMas ele não estava mais lá...\nEle apareceu atrás mim e ....",1,2,4));
            
            
        }

        //public void ListarEventos()
        //{
        //    for (int i = 0; i < this.ListaEventos.Count; i++)
        //    {
        //        Console.Write("[ " + i + " ] ");
        //        this.ListaEventos[i].TextoEvento();
        //    }
                       
        //}
       public void EventoAleatorio()
        {
            Random r = new Random();
            int aleatorio = r.Next(0, this.ListaEventos.Count);
            this.ListaEventos[aleatorio].TextoEvento();
        }

       
             

    }
}
