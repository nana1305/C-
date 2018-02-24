using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
              //Your code goes here
          /*  Console.WriteLine("Insira o primeiro número:");
         string texto = Console.ReadLine();
         Console.WriteLine("Você digitou o número " + texto);
         

        
             Console.WriteLine("Digite sua nota:");
              decimal nota1 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua nota:");
             decimal nota2 = decimal.Parse(Console.ReadLine());
         
            Console.WriteLine("Digite sua nota:");
              decimal nota3 = decimal.Parse(Console.ReadLine());
            
            
            decimal resultado = (nota1 + nota2 + nota3) / 3;
            
        
            if(resultado > 6){
                Console.WriteLine("Aluno Aprovado!");
            }
             
           else if (resultado < 6){
                Console.WriteLine("Aluno Reprovado!");
            }
                 Console.WriteLine("A média das notas é: " + resultado.ToString());
        */
        Console.WriteLine("Qual a cor do semaforo?");
        String semaforo = Console.ReadLine();
        

        if(semaforo == "green"){
            Console.WriteLine("Pode passar");
        }

        else if (semaforo == "yellow"){
            Console.WriteLine("Vá devagar");
        }
    

        else if (semaforo == "red"){
            Console.WriteLine("Pare!");
        }
        Console.ReadKey();
        }
    }
}
