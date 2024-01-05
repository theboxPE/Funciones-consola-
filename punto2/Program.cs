// CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS Y RETORNE SU ÚLTIMO DÍGITO. 
class program
{
    static void Main(string[]args)
    {
        num();
    }

    static void num()
    {
        int a;
        int c;
        Console.WriteLine("ingresa un numero de 2 digitos: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();

        if(a > 9 && a < 100)
        {
            c = (a%10);
            Console.WriteLine("El ultimo digito del numero "+ a +" es "+ c);
        } 
        else
        {
            Console.WriteLine("Debe de ingresa un numero de 2 digitos");
        }
    }
}
