// CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS. LA FUNCIÓN DEBE RETORNAR EL MAYOR DE LOS DOS DÍGITOS.

class program
{
    static void Main(string[]args)
    {
        num();
    }

    static void num()
    {
        int x;
        int b, c;
        Console.WriteLine("ingresa un numero de 2 digitos:");
        x = Convert.ToInt32(Console.ReadLine());

        
        if(x > 9 && x < 100)
        {
            b = (x/10);
            c = (x%10);

            if(b > c)
            {
                Console.WriteLine($"el numero mayor es {b}");
            }
            else
            {
                Console.WriteLine($"el numero mayor es {c}");
            }
        }
        else
        {
            Console.WriteLine("Debe de ingresa un numero de 2 digitos");
        }
    
    }
}