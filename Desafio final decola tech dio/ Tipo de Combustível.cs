using System; 

class URI {

    static void Main(string[] args) { 
int[] contador = new int[3];
int codigo = 0;
            do
            {
            codigo = int.Parse(Console.ReadLine());
                 
                
                switch (codigo)
                {
                    case 1:
                    contador[0]++;
                    break;
                     
                    case 2:
                    contador[1]++;
                    break;
                      
                    case 3:
                    contador[2]++;
                    break;
                    
                    case 4:
                   
                        break;
                    default:                       
                        continue;
                }
            }
       
         while (codigo!= 4);
         
    
         
         System.Console.WriteLine("MUITO OBRIGADO");
         
         System.Console.WriteLine("Alcool: " + contador[0]);
         
         System.Console.WriteLine("Gasolina: " + contador[1]);
         
         System.Console.WriteLine("Diesel: " + contador[2]);

    }

}