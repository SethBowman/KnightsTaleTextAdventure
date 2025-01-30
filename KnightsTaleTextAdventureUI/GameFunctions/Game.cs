using KnightsTaleTextAdventureUI.Character;

namespace KnightsTaleTextAdventureUI.GameFunctions;

public static class Game
{
    public static void RunGame()
    {
       UserInteraction.GameDialogue("Welcome to Knight's Tale!\nLet's start off by getting the name of your Knight.");
       var knight = new Knight();
       knight.Name = knight.BuildCharacter().Name;
       knight.Health = knight.BuildCharacter().Health;
       knight.AttackDamage = knight.BuildCharacter().AttackDamage;
       
       UserInteraction.GameDialogue($"Hello Sir {knight.Name}, I see you're new around here.\nWould you like to ask me something?");
       UserInteraction.PlayerInquiry(new string[] {"Who are you?", "What is this place?", "Goodbye"}, new string[] {"I am the commander of this fort. My name isn't relevant.", "This is the great city of Gondor, but danger lurks nearby.."});
       Thread.Sleep(2000);
       
       UserInteraction.GameDialogue("You sense a strange presence nearby..");
       Thread.Sleep(2000);

       var goblin01 = new Enemy();
       goblin01.Name = "Goblin";
       goblin01.Health = StatGeneration.GenerateRandomHealth();
       goblin01.AttackDamage = StatGeneration.GenerateRandomEnemyAttack();
       
       Combat.KnightVsOneEnemy(knight, goblin01);
       
       UserInteraction.GameDialogue("You have survived, brave Knight!");
    }
}