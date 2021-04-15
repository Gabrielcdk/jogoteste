using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
   public class CatMonstros
    {
        public CatMonstros()
        {
            this.IniciaListaMonstros();
        }

        public List<Monstro> ListadeMonstros { get; set; }


        public void IniciaListaMonstros()
        {
            this.ListadeMonstros = new List<Monstro>();
            this.ListadeMonstros.Add(new Monstro("Morcego Gigante", "é um morcedo muito maior que os demais","D6"));
            this.ListadeMonstros.Add(new Monstro("Rato Gigante", "tão nojento quanto um normal, só que maior", "D6"));
            this.ListadeMonstros.Add(new Monstro("Esqueleto", "um monte osso em pé", "D6"));
        }

        public void MonstroAleatorio()
        {
            Random r = new Random();
            int aleatorio = r.Next(0, this.ListadeMonstros.Count);
            this.ListadeMonstros[aleatorio].TextoMonstro();
        }




    }
}
