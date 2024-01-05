// CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN NUMERO Y RETORNE UN MENSAJE DICIENDO SI ES PAR O IMPAR, SEGÚN SEA EL CASO.
class program
{
    static void Main(string[]args)
    {
        num();
    }

    static void num()
    {
        int a;
        int b;
        int c;
        Console.WriteLine("ingresa un numero de 2 digitos: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();

        if(a > 9 && a < 100)
        {
            b = (a/10);
            c = (a%10); 

            if(b%2==0)
            {
                Console.WriteLine("El digito "+ b +" es par");
                Console.WriteLine("El digito "+ c +" es impar");
            } 

            if(c%2==0)
            {
                Console.WriteLine("El digito "+ c +" es par");
                Console.WriteLine("El digito "+ b +" es impar");
            }
            else
            {
                Console.WriteLine("Debe de ingresa un numero de 2 digitos");
            }
        
        }
    }
}
