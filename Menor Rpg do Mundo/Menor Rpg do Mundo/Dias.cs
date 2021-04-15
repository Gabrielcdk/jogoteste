using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
   public class Dias
    {
        public Dias()
        {

        }
        public void NovoDia()
        {
            Console.WriteLine();
            Console.WriteLine("DIÁRIO DE VIAGEM\n-- DIA " + (Jogo.diasCont++) + " -- ");
            Console.WriteLine();
            ChamarAmbiente();
            ChamarEvento();
        }

        static public void ChamarAmbiente()
        {
            CatAmbientes a1 = new CatAmbientes( );
            a1.AmbienteAleatorio();
        }
        static void ChamarEvento()
        {
            CatEventos e1 = new CatEventos();
            e1.EventoAleatorio();
        }


    }
}
