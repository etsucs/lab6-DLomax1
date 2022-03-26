ShowCharacter();

void ShowCharacter()
{
System.Console.WriteLine("Please enter a word...");
string UserInput = Console.ReadLine();
System.Console.WriteLine("Please enter a number correspoding to a character in your word..");
string UserNumber = Console.ReadLine();
System.Console.WriteLine($"You have chosen character number {UserNumber} character from {UserInput}");
Convert.ToInt32(UserNumber);
char letter = UserInput[Convert.ToInt32(UserNumber) -1];
System.Console.WriteLine(letter);
}
