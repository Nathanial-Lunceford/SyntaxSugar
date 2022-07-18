// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        var answer = 4;
        var response = "";

        response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than " +
            $"or equal to nine";


        Console.WriteLine(response);
    }
}
