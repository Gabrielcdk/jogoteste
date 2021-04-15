using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Rpg_do_Mundo
{
    public class Evento
    {
        public Evento()
        {
            this.NomedoEvento = "";
            this.Descricao = "";
            this.Opcao1 = "";
            this.Opcao2 = "";
            this.Opcao3 = "";
            this.Consequencia1 = "";
            this.Consequencia2 = "";
            this.Consequencia3 = "";
            this.TipoCons1 = 0;
            this.TipoCons2 = 0;
            this.TipoCons3 = 0;
        }
        public Evento(string _NomedoEvento, string _descrição, string _opcao1, string _opcao2, string _opcao3, string _consequencia1, string _consequencia2, string _consequencia3, int _tipocons1, int _tipocons2, int _tipocons3 )
        {
            this.NomedoEvento = _descrição;
            this.Descricao = _descrição;
            this.Opcao1 = _opcao1;
            this.Opcao2 = _opcao2;
            this.Opcao3 = _opcao3;
            this.Consequencia1 = _consequencia1;
            this.Consequencia2 = _consequencia2;
            this.Consequencia3 = _consequencia3;
            this.TipoCons1 = _tipocons1;
            this.TipoCons2 = _tipocons2;
            this.TipoCons3 = _tipocons3;


        }

        public string NomedoEvento { get; set; }
        public string Descricao { get; set; }
        public string Opcao1 { get; set; }
        public string Opcao2 { get; set; }
        public string Opcao3 { get; set; }
        public string Consequencia1 { get; set; }
        public string Consequencia2 { get; set; }
        public string Consequencia3 { get; set; }
        public int TipoCons1 { get; set; }
        public int TipoCons2 { get; set; }
        public int TipoCons3 { get; set; }
        // Tipos de Consequencias 1 - Novo dia, 2 - encontro com monstro, 3 - Novo evento, 4 - Morte...
        public void TextoEvento()
        {
        Escolhas:
            Console.WriteLine(this.Descricao);
            Console.WriteLine();
            Console.WriteLine("O que farei agora ???");
            Console.WriteLine("1 - " + this.Opcao1);
            Console.WriteLine("2 - " + this.Opcao2);
            Console.WriteLine("3 - " + this.Opcao3);
            Console.Write("~ Digite o número da opção desejada: ");
       
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(this.Consequencia1);
                    switch (this.TipoCons1)
                    {
                        case 1:
                            Console.WriteLine("Um novo dia");
                            Chamardia();
                            //Chamar dia
                            break;
                        case 2:
                            Console.WriteLine("Um monstro apareceu");
                            ChamarMonstro();
                            //Chamar monstro                            
                            break;
                        case 3:
                            Console.WriteLine("Um novo evento");
                            //Chamar evento
                           goto Escolhas;
                        case 4:
                            Console.WriteLine("Você morreu");
                            ChamarGameOver();
                            //Chamar Game over
                            break;
                        default:
                            Console.WriteLine("Acho que deu errado");
                            break;

                    }
                    Console.ReadLine();

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(this.Consequencia2);
                    switch (this.TipoCons1)
                    {
                        case 1:
                            Console.WriteLine("Um novo dia");
                            Chamardia();
                            break;
                        case 2:
                            Console.WriteLine("Um monstro apareceu");
                            ChamarMonstro();
                            //Chamar monstro
                            break;
                        case 3:
                            Console.WriteLine("Um novo evento");
                            //Chamar evento
                            goto Escolhas;
                           
                            
                        case 4:
                            Console.WriteLine("Você morreu");
                            ChamarGameOver();
                            //Chamar Game over
                            break;
                        default:
                            Console.WriteLine("Acho que deu errado");
                            break;

                    }
                    Console.ReadLine();

                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(this.Consequencia3);
                    switch (this.TipoCons1)
                    {
                        case 1:
                            Console.WriteLine("Um novo dia");
                            Chamardia();
                            //Chamar dia
                            break;
                        case 2:
                            Console.WriteLine("Um monstro apareceu");
                            ChamarMonstro();
                            //Chamar monstro
                            break;
                        case 3:
                            Console.WriteLine("Um novo evento");
                            goto Escolhas;
                            //Chamar novo evento
                            
                        case 4:
                            Console.WriteLine("Você morreu");
                            ChamarGameOver();
                            //Chamar Game over
                            break;
                        default:
                            Console.WriteLine("Acho que deu errado");
                            
                            break;

                    }
                    Console.ReadLine();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("~ Você ainda parece confuso a opção não foi encontrada");
                    Console.WriteLine();
                    Console.WriteLine("~ Tente novamente: ");
                    Console.ReadLine();

                    goto Escolhas;

            }

            }
        static void Chamardia()
        {
            Dias d1 = new Dias();
            d1.NovoDia();
        }

        static void ChamarMonstro()
        {
            CatMonstros c1 = new CatMonstros();
            c1.MonstroAleatorio();
        }
        static void ChamarGameOver()
        {
            GameOver g1 = new GameOver();
            g1.TextoGameOver();
        }

    }
}
