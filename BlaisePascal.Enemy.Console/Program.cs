using BlaisePascal.Lesson.Domain;

public class Program
{
    static void Main(string[] args)
    {
        Enemy enemy = new Enemy();
        enemy.Health = 5;
        Console.WriteLine($"Enemy health: {enemy.Health}");
    }
}
