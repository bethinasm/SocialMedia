
using SocialMediaOppgave;

Console.WriteLine("SocialMedia Oppgave");


void Main()
{
    var mainUser = new User("Bethina", 15081996, "slowly losing all my hair while studying IT");

    var user1 = new User("Kairo", 11032023, "I love q-tips and screaming!");
    var user2 = new User("Oscar", 24032024, "i'm not fat, i'm big boned and fluffy thank you very much");
    var user3 = new User("Luna", 19032014, "I have one and a half ear and I can still hear you talking too much.");

    
}

void Menu()
{
    bool isRunning = true;

    while (isRunning)
    {
        Console.WriteLine("Welcome to FriendFace! \nWhat would you like to do?\n");
        Console.WriteLine("[ 1 ] Add friend \n[ 2 ] Remove friend \n[ 3 ] View friendlist \n[ 4 ] View friends profile \n[ 5 ] Exit program");
        var userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                isRunning = false;
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("The program will now shut down.\nThank you for using FriendFace! Come back soon!");
                Thread.Sleep(1000);
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }
}