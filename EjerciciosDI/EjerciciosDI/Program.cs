namespace EjerciciosDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Escribe un número:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu número es " + num);

            Console.WriteLine("Y si le restas 5 es : " + (num - 5));

            Console.WriteLine("FIN modificado");

        }
    }
}
