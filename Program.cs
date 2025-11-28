// See https://aka.ms/new-console-template for more information

using ClassCatacombs;

// Point myPoint = new Point();
// Point myPoint2 = new Point();
//
// myPoint.X = 2;
// myPoint.Y = 3;
//
// myPoint2.X = -4;
// myPoint2.Y = 0;
//
// Console.WriteLine($"{myPoint.X}, {myPoint.Y}");
// Console.WriteLine($"{myPoint2.X}, {myPoint2.Y}");
//
// Color myColor = new Color(169, 87, 90);
// Color myColor2 = Color.CreateOrange();
//
// Console.WriteLine($"myColor: {myColor.Red}, {myColor.Green}, {myColor.Blue}");
// Console.WriteLine($"myColor2: {myColor2.Red}, {myColor2.Green}, {myColor2.Blue}");

// Type cardType = typeof(Card);
// foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
//     foreach  (CardRank rank in Enum.GetValues(typeof(CardRank)))
//     {
//         object obj = Activator.CreateInstance(cardType, color, rank);
//         var card = (Card)obj;
//         card.DisplayData();
//     }

// string oldPassInput;
// Console.WriteLine("Type your passcode for the door: ");
// oldPassInput = Console.ReadLine();
// Door myDoor = new Door(DoorState.Closed, oldPassInput);
// while (true)
// {
//     Console.WriteLine("Enter your desired input: 1) Close door, 2) Open door, 3) Lock door, 4) Unlock door, 5) Change door passcode: ");
//     string userInput = Console.ReadLine();
//     switch (userInput)
//     {
//         case "1":
//             myDoor.Close();
//             break;
//         case "2":
//             myDoor.Open();
//             break;
//         case "3":
//             myDoor.Lock();
//             break;
//         case "4":
//             Console.WriteLine("Enter your passcode: ");
//             oldPassInput = Console.ReadLine();
//             myDoor.Unlock(oldPassInput);
//             break;
//         case "5":
//             Console.WriteLine("Enter your old passcode: ");
//             oldPassInput = Console.ReadLine();
//             Console.WriteLine("Enter your new passcode: ");
//             string newPassInput =  Console.ReadLine();
//             myDoor.NewPass(oldPassInput, newPassInput);
//             break;
//             
//     }
// }


PasswordValidator myPasswordValidator = new PasswordValidator("ello123");
myPasswordValidator.PasswordValidation();


