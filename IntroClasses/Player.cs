namespace IntroClasses;

public class Player
{
    private int x;
    private int y;
    private string avatar = "@";

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(avatar);
    }

    public void Move(int diffX, int diffY)
    {
        x += diffX;
        y += diffY;
    }

    public bool TakeTurn(ref bool isPlaying)
    {
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
           case ConsoleKey.Q:
                isPlaying = false;
                return isPlaying;
        
        }
        Display();
        return isPlaying;
    }
}
