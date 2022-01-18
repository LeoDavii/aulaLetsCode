using System;
using System.Collections.Generic;

namespace aula.lista
{
    /**
        Criar um menu com as opções
            1 - Adicionar um novo vagão
            2 - Exibir o último vagão
            3 - Exibir todos os vagões
            4 - Buscar por id dentro do trem
            5 - Buscar por nome dentro do trem
            6 - Buscar por peso dentro do trem
            7 - Atualizar as informações de um vagão
            8 - Excluir um vagão
            0 - Sair
    **/

    public class Menu
    {

        public void MenuBasic() {
            ListaLigada gerenciarVagoes = new ListaLigada();
            main(gerenciarVagoes);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("4. Buscar por id");
            Console.WriteLine("5. Buscar por carga");
            Console.WriteLine("6. Buscar por peso");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '4':
                    Console.WriteLine("Insira o id");
                    var id = int.Parse(Console.ReadLine());
                    Console.WriteLine(gerenciarVagoes.BuscarPorId(id));
                    break;
                case '5':
                    Console.WriteLine("Insira a carga");
                    var carga = Console.ReadLine();
                    foreach(Vagao item in gerenciarVagoes.BuscarPorCarga(carga))
                    {
                     Console.WriteLine("ID {0}", item.Id);
                     Console.WriteLine("Carga {0}", item.Carga);
                     Console.WriteLine("Peso {0}", item.Peso);
                    }
                    break;
                case '6':
                    Console.WriteLine("Insira o peso");
                    var peso = int.Parse(Console.ReadLine());
                    foreach(Vagao item in gerenciarVagoes.BuscarPorPeso(peso))
                    {
                     Console.WriteLine("ID {0}", item.Id);
                     Console.WriteLine("Carga {0}", item.Carga);
                     Console.WriteLine("Peso {0}", item.Peso);
                    }
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            MenuBasic();
        }

        public static void main(ListaLigada gerenciarVagoes) {
            Vagao vagao1 = new Vagao() { Id = 1, Carga = "Arroz", Peso = 10 };
            Vagao vagao2 = new Vagao() { Id = 2, Carga = "Feijão", Peso = 15 };
            Vagao vagao3 = new Vagao() { Id = 3, Carga = "Farinha", Peso = 20 };
            Vagao vagao4 = new Vagao() { Id = 4, Carga = "Trigo", Peso = 25 };
            Vagao vagao5 = new Vagao() { Id = 5, Carga = "Soja", Peso = 30 };
            gerenciarVagoes.InserirVagao(vagao1);
            gerenciarVagoes.InserirVagao(vagao2);
            gerenciarVagoes.InserirVagao(vagao3);
            gerenciarVagoes.InserirVagao(vagao4);
            gerenciarVagoes.InserirVagao(vagao5);
            foreach(Vagao item in gerenciarVagoes.getVagoes()) {
                Console.WriteLine("ID {0}", item.Id);
                Console.WriteLine("Carga {0}", item.Carga);
                Console.WriteLine("Peso {0}", item.Peso);
            }
        }
    }
}