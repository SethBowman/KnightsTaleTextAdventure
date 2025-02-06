using KnightsTaleTextAdventureUI.GameFunctions;

namespace KnightsTaleTextAdventureUI.Character;

public class Knight : ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    
    public int Attack()
    {
        return AttackDamage;
    }

    public void TakeDamage(int damage)
    {
        if (Health - damage <= 0)
        {
            Health = 0;
        }
        else
        {
            Health -= damage;
        }
    }

    public static (string Name, int AttackDamage, int Health) BuildCharacter()
    {
        var name = UserInteraction.GetUserInput("Enter the name of your character:");
        var attack = StatGeneration.GenerateRandomKnightAttack();
        var health = StatGeneration.GenerateRandomHealth();
        return (name, attack, health);
    }
}