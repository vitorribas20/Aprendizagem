using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quem és tu?");
            String nome = Console.ReadLine();
            Console.WriteLine("ah tá bom, pode entrar senhor:");
            Console.WriteLine(nome);
            // String, ou seja, quero capturar um texto, defino a variável, depois coloco:
            // (Nome da variável) =(Atribui) Console.RealLine (Para que leia o que escrevi)

            Console.WriteLine("Eai, com tá indo?");
            String Comentário = Console.ReadLine();


            const float PI = 3.1456425f;
            // constante não muda o valor, o valor é posto uma única vez
            // é um Valor muito importante, valor crítico



            var MeuTexto = "assim se faz uma variável";

            // int -  236
            // float - 15.5 235.98
            // Bool - true ou false 
            // String - "Dados do tipo texto"
            //char - 'a' único caractere
            // Faz comentário, bem dahora né
            

            // A-Z
            // 0 - 9
            // @ $ .
            // _ Pode ter
            // não pode conter palavras reservadas
            // para trabalhar com números decimais, tem que por o f 245.6f Dados Float

            int SegundaGuerraMundial = 1942;
            String CorFavorita = "Preto";
            float Velocidade = 245.7f;
            bool asegundaguerra = true;





            Console.WriteLine("Opa, beleza?, o comando read line serve para ler, ou seja, você coloca o write e dps o realline, o read line fica esperando o usuário pressionar enter");
            Console.WriteLine("pra quebrar linha tem que por o writeline");
            Console.WriteLine("para começar um comando de texto, por alguma coisa na tela vai ficar assim, ConsoleWriteLine");
            Console.WriteLine("a estrutura de criação é essa do texto, bem de boa, paramos em 1 hora de vídeo, até o momento bem tranquilo");
            Console.WriteLine("DIa 11/08/21");
            Console.WriteLine("Dia 13/08/21");
            Console.WriteLine(MeuTexto);

            Console.WriteLine(Velocidade);


            Velocidade = 457.45f;
            //assim redefine o valor dessa variável

            
            dynamic Muda_palavra = "Assim";

            Console.WriteLine(Muda_palavra);

            Muda_palavra = 456;

            Console.WriteLine(Muda_palavra);

            // deste jeito, temos a mesma variável, mas ela armazena valores de vários tipo



       
            Console.WriteLine(Comentário);











            Console.ReadLine();
        }
    }
}
