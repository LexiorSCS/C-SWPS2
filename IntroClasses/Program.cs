using IntroClasses;

bool isPlaying = true;
Player hero = new Player();
hero.Display();
while (isPlaying)
{
    hero.TakeTurn(ref isPlaying);
}
Console.WriteLine("NAURA");