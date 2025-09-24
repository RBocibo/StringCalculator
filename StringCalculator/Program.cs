using StringCalculator;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Adding empty string = {Calculator.Add("")}");
        Console.WriteLine($"Adding one number = {Calculator.Add("1")}");
        Console.WriteLine($"Adding two or more numbers = {Calculator.Add("1,2,3")}");
        Console.WriteLine($"Adding numbers and removing new line = {Calculator.Add("1\n2,3")}");
        Console.WriteLine($"Adding numbers and removing delimeters {Calculator.Add("//;\n1;2;3")}");

        //Remove comment to test negative numbers
        //Console.WriteLine($"Adding negative numbers = {Calculator.Add("-1, -2, -3")}");

        Console.ReadKey();
    }
}