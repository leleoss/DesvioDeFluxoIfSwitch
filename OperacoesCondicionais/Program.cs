using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário in-line(em linha)
            /*
                Comentário in-block(em bloco)
             */
             //Declaração de variável operação. Ela será do tipo interira
             int operacao;

             //Declaração das variáveis n1 e n2. Elas serão do tipo double
             double n1, n2;

             /*
             Para limpar a tela de comando a cada execução, utilizaremos o comando Console.Clear();
             obs.:Clear->Limpar
              */
              
              Console.Clear(); 
              Console.WriteLine("Esolha uma das operações abaixo:");  

              /*
              Para a exibição das opções de operação, vamos usar o comando Console.WriteLine e, nele usaremos um comando de quebra de linha \n(contra-barra m(new line)).
              Assim, as opções ficarão abaixo da outra
               */
               Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
               operacao = int.Parse(Console.ReadLine());
               
               Console.WriteLine("Digite um número:");
               n1 = double.Parse(Console.ReadLine());
               
               Console.WriteLine("Digite outro número");
               n2 = double.Parse(Console.ReadLine());

               if(operacao==1)
               {
                   Console.WriteLine("O resultado da soma é: "+(n1+n2));
               }
               else if(operacao==2)
               {
                   Console.WriteLine("O resultado da subtração é: "+(n1-n2));
               }
               else if(operacao==3)
               {
                   Console.WriteLine("O resultado da multiplicação é: "+(n1*n2));
               }
               else if(operacao==4)
               {
                   Console.WriteLine("O resultado da divisão é: "+(n1/n2));
               }
               else
               {
                   Console.WriteLine("Operação inválida!");
               }

        }
    }
}
