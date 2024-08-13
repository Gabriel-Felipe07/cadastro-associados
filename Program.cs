namespace lista_dicionario_csharp;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //criando uma lista para armazenar os nomes
        List<string> cadastro_de_nomes = new List<string>();
        //criando uma variavel NAME para armazenar temporáriamente o valor digitado pelo associado
        string names = "";
        //definindo uma variavel para armazenar a escolha de menu do associado
        int escolha;
        //criando uma variavel para armazenar o nome da verificação de cadastro
        string verificacao_cadastro = "";
        //iniciando um programa com looping infinito
        while(true){
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+        Clube do C#         +");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+        1- Cadastrar        +");
            Console.WriteLine("+   2- Mostrar associados    +");
            Console.WriteLine("+    3- verificar cadastro   +");
            Console.WriteLine("+          0- Sair           +");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            //pedindo a escolha do usuario
            escolha = Convert.ToInt32(Console.ReadLine());
            //fazendo a verificação de escolha do usuario 
            if(escolha == 1){
                //intruções
                Console.WriteLine("Cadastro de associado\r\n");
                Console.WriteLine("Digite (stop) para parar de adicionar nomes.");
                //verificando se o usuario digitou STOP para parar o loop
                while(names != "stop"){
                    names = Console.ReadLine()!;
                    //adicionando o nome na lista
                    cadastro_de_nomes.Add(names);
                }
                Thread.Sleep(1000);
                //fazendo a verificação de escolha do usuario 
            }else if(escolha == 2){
                //instruções
                Console.WriteLine("Buscando lista de associados...");
                //removendo todas as ocorrencias de "stop" na lista
                cadastro_de_nomes.RemoveAll(x => x.ToLower() == "stop");
                Thread.Sleep(1000);
                //varrendo a lista e "printando" cada item
                foreach(var nome in cadastro_de_nomes){
                    Console.WriteLine(nome);
                }
                Thread.Sleep(1000);
                //fazendo a verificação de escolha do usuario 
            }else if(escolha == 3){
                Console.WriteLine("Digite o nome para buscar o cadastro");
                verificacao_cadastro = Console.ReadLine()!;
                Console.WriteLine("Aguarde um instante..");
                Thread.Sleep(2000);
                foreach(var busca in cadastro_de_nomes){
                    if (busca.ToLower() == verificacao_cadastro.ToLower()){
                        Console.WriteLine("Associado cadastrado!");
                    }
                }
                Thread.Sleep(2000);
            }else if(escolha == 0){
                //dando tchau e parando o programa
                Console.WriteLine("Obrigado por participar!");
                break;
            }
            
        }
    }
}
