using System;

namespace ExemploPonteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * “Ponteiro é uma variável que contém um endereço da memória. Esse endereço é normalmente a posição de uma outra variável na memória.”


Fornece meios para
Funções modificarem seus argumentos (passagem por referência)
Implementar alocação dinâmica de memória
Aumentar a eficiência de certas rotinas


Declaração
tipo* nome_da_variável;
tipo é qualquer tipo de dado em C# e indica o tipo base do ponteiro, ou seja, para que tipo de dado o ponteiro deve apontar. O conteúdo armazenado na variável ponteiro é sempre um endereço, independente do tipo base.
nome_da_variável é o nome da variável ponteiro para o tipo especificado.


Operador &
É um operador unário.
Devolve o endereço da memória do operando.
int *p;
int a=5, q;
...
p = &a; //ponteiro recebe o endereço da variável a

Neste exemplo, se a variável ‘a’ ocupasse a posição de memória 1250, o valor da variável ‘p’ seria 1250.

            */
            unsafe
            {
                int i;
                i = 10;
                int* ponteiro;
                ponteiro = &i;
                Console.WriteLine("O valor que o ponteiro está apontando é = "+ *ponteiro);
            }
        }
    }
}
