namespace lista_dicionario_csharp;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cadastro_de_nomes = new List<string>();
        string names = "";
        int escolha;
        while(true){
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+        Clube do C#+        +");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+        1- Cadastrar        +");
            Console.WriteLine("+   2- Mostrar associados    +");
            Console.WriteLine("+          0- Sair           +");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            escolha = Convert.ToInt32(Console.ReadLine());
            
            if(escolha == 1){
                Console.WriteLine("Cadastro de associado\r\n");
                Console.WriteLine("Digite (stop) para parar");

                while(names != "stop"){
                    names = Console.ReadLine()!;
                    cadastro_de_nomes.Add(names);
                }
            }else if(escolha == 2){
                Console.WriteLine("Buscando lista de associados...");
                cadastro_de_nomes.RemoveAll(x => x.ToLower() == "stop");
                Thread.Sleep(1000);
                foreach(var nome in cadastro_de_nomes){
                    Console.WriteLine(nome);
                }
            }else if(escolha == 0){
                Console.WriteLine("Obrigado por participar!");
                break;
            }
        }
    }
}
