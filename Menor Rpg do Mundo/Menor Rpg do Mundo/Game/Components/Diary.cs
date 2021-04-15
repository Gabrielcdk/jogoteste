using System;

namespace Menor_Rpg_do_Mundo.Game.Entities
{
    class Diary
    {
        public Diary()
        {
            playerName = "";
            passedDays = 0;
        }

        private string playerName { get; set; }
        private int passedDays { get; set; }
        private string choice { get; set; }

        public string Draw()
        {
            Console.Clear();

            if (passedDays == 0)
            {
                passedDays++;
                Console.WriteLine();
                Console.WriteLine("Acordei em um lugar escuro e estranho parece uma prisão...");
                Console.WriteLine("Tem somente uma cama e uma mesa com uma vela e este velho diário com outros escritos...");
                Console.WriteLine("Deixarei aqui registrado todos meus feitos para que o mundo nunca se esqueça....");
                Console.WriteLine();
                Console.Write("~ Digite seu nome viajante: ");
                playerName = Console.ReadLine(); //Talvez o sistema de ranking entraria aqui para ver ser o nome não é repetido
                Console.WriteLine();
                Console.WriteLine($"Sir ${playerName} o maior herói que já pisou neste mundo !!!");
                Console.WriteLine();
                Console.WriteLine("como farei para sair daqui ??");
                Console.Write("1 - Tentar procurar uma saída\n2 - Procurar se tem algum pertence com você\n3 - Gritar por socorro\n");
                Console.Write("Digite o número da opção desejada: ");
            }
            else
            {
                Console.WriteLine("DIÁRIO DE VIAGEM\n-- DIA (${passedDays} )  -- ");
            }
            
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Tentei achar uma saída, mas a porta da cela prece estar trancada\nVou tentar forçar novamente\n...\nParece que se abriu...\nmas o barulho chamou a atenção de algo lá fora...");
                    Console.ReadLine();
                    //Definindo um evento randomico
                    //ChamarEvento();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Vou tentar vasculhar a cela para ver se acho alguma coisa\nEstou vendo alguma coisa debaixo da cama\nEncontrei uma caixa de fósforo\nA vela em minha mesa já estava acesa\nNão me será muito útil...\nEspere, quem sabe se eu ascender a vela na porta alguém do corredor possa me ver\n...\nParece que a luz chamou a atenção de alguma coisa...");
                    Console.ReadLine();
                    //Definindo um evento randomico
                    //ChamarEvento();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Resolvi gritar o mais alto que pude para ver se algúem aparecesse\nSOOOOOCCCOOOOOOORRRRROOOOOOO, gritei novamente\nParece que funcionou estou ouvindo algum barulho vindo em minha direção..");
                    Console.ReadLine();
                    //Definindo um evento randomico
                    //ChamarEvento();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("~ Você ainda parece confuso a opção não foi encontrada");
                    Console.WriteLine();
                    Console.WriteLine("~ Tente novamente: ");
                    Console.ReadLine();
                    break;
            }

            return choice;
        }
    }
}
