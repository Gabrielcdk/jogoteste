using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
   public class CatAmbientes
    {
        public CatAmbientes()
        {
            this.IniciaListaAmbientes();

        }
        public List<Ambiente> ListadeAmbientes { get; set; }


        public void IniciaListaAmbientes()
        {
            this.ListadeAmbientes = new List<Ambiente>();
            this.ListadeAmbientes.Add(new Ambiente("Ambiente 1", "Acodei estava em um lugar parecedo com uma cozinha"));
            this.ListadeAmbientes.Add(new Ambiente("Ambiente 2", "Acodei estava em um lugar parecedo com uma banheiro"));
            this.ListadeAmbientes.Add(new Ambiente("Ambiente 3", "Acodei estava em um lugar parecedo com uma sala"));
        }

        public void AmbienteAleatorio()
        {
            Random r = new Random();
            int aleatorio = r.Next(0, this.ListadeAmbientes.Count);
            this.ListadeAmbientes[aleatorio].TextoAmbiente();
        }
    }

}
