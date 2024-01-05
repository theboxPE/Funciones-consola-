// CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UNA CADENA (EL NOMBRE DEL USUARIO) LA FUNCIÓN DEBE RETORNAR UN SALUDO QUE INCLUYA EL NOMBRE DEL USUARIO QUE RECIBIÓ.
class program
{
    static void Main(string[]args)
    {
        cadena();
        
    }

    static void cadena()
    {
        string a;
        Console.WriteLine("Digite el nombre de usuario: ");
        a = Console.ReadLine()!;
        Console.WriteLine($"saludos {a}");
        Console.ReadKey();
    }

}