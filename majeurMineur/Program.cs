namespace majeurMineur;

class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Quel est ton age ?");
        age = int.Parse(Console.ReadLine());
        if (age >= 18)
            Console.WriteLine("Vous êtes majeur");
        
        else Console.WriteLine($"Vous êtes mineur et vous serez majeur dans {18-age} ans");
        
    }
}