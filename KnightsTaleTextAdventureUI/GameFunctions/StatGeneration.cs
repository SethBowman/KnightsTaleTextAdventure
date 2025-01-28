namespace KnightsTaleTextAdventureUI.GameFunctions;

public static class StatGeneration
{
    public static int GenerateRandomHealth()
    {
        return Random.Shared.Next(75, 101);
    }

    public static int GenerateRandomKnightAttack()
    {
        return Random.Shared.Next(20, 35);
    }

    public static int GenerateRandomEnemyAttack()
    {
        return Random.Shared.Next(5, 16);
    }
}