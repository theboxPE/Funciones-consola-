// CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS Y QUE ESTA FUNCIÓN GENERE Y MUESTRE EN PANTALLA LA TABLA DE MULTIPLICAR DEL PRIMER DÍGITO, SIENDO EL LÍMITE DE LA TABLA EL SEGUNDO DÍGITO. 
class program
{
    static void Main(string[]args)
    {
        num();
    }

    static void num()
    {
        int a;
        int b,c;
        Console.WriteLine("ingresa un numero de 2 digitos: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();

        if(a > 9 && a < 100)
        {
            b = (a/10);
            c = (a%10);
    
            for(int i = 0; i < 1; i++)
            {
               Console.WriteLine($"La tabla de multiplicar del {b} hasta el {c} es: ");
            }

            for(int i = b; i <= c; i++)
            {
                Console.WriteLine(b +"x"+ i+"="+ (b*i));
            }
        }
        else
        {
            Console.WriteLine("Debe de ingresa un numero de 2 digitos");
        }
    }

    
}
