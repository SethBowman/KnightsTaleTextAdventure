namespace KnightsTaleTextAdventureUI.Character;

public class Enemy : ICharacter
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
}