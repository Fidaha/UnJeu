namespace JeuVideo;

using System;

public class Character
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public int AttackStrength { get; set; }
    public int DefenseStrength { get; set; }


     public bool IsAlive()
        {
            if (HealthPoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    public void Attack(Character other)
    {
        other.HealthPoints -= AttackStrength - other.DefenseStrength;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Character player1 = new Character { Name = "Player 1", HealthPoints = 100, AttackStrength = 10, DefenseStrength = 5 };
        Character player2 = new Character { Name = "Player 2", HealthPoints = 50, AttackStrength = 10, DefenseStrength = 5 };

        while (player1.IsAlive() && player2.IsAlive())
        {
            player2.Attack(player1);
            player1.Attack(player2);
        }

        if (player1.IsAlive())
        {
            Console.WriteLine(player1.Name + " a gagné !");
        }
        else
        {
            Console.WriteLine(player2.Name + " a gagné !");
        }
    }
} 






