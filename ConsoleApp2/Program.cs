internal class Program
{

    static void Main(string[] args)
    {

        int a = 2;
        int b = 3;
        int c = 4;
        Console.WriteLine(calculator(a, b));
        Console.WriteLine(calculato(b, c));


    }
    public static int calculator(int num1, int num2)
    {
        return num1 + num2;



    }
    public static int calculato(int num2, int num3)
    {

        return num2 * num3;
    }
}







