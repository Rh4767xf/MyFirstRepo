using Module2CodingChallenge;

Polygon polygon = new Polygon(3); // a triangle
Square square = new Square(4.5f); // a square

Polygon octogon = new Polygon(8); // a octogon
Polygon octakaidecagon = new Polygon(18);// a octakaidecagon
Dodecagon dodecagon = new Dodecagon(8.5f); // a dodecagon

//Create a new player with one life and add points / gold / weapons to the player's setup
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);
player.AddGold(250);
player.EquipWeapon("Spiky Hasta");
//Display the player's score / gold / lives / equiped weapon
Console.WriteLine(  "Welcome to the game! \nYour score is:\t" + player.GetScore() + "\n" +
                    "You are carrying " + player.GetGold() + " gold!\n" +
                    "You are wielding a " + player.GetWeapon() + "\n" +
                    "You have " + player.GetLivesLeft() + " lives left!\n");

//Kill off the player's character
player.Kill();

//Let the player know their character was killed
Console.WriteLine(  "An orc attacks you. Sorry, you were killed. You have " +
                    player.GetLivesLeft() + " lives left!");