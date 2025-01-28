namespace KnightsTaleTextAdventureUI.Character;

public interface ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }

    public int Attack();
    public void TakeDamage(int damage);
}