string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villainsFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainsFile));

//string[] heroes = {"Tomoe", "Ciel", "Midzuki", "Sebastian"};
//string[] villains = {"FootF", "Jeesus", "Konstantin", "Ded Tolik", "Sad Hamster"};

string[] weapon = {"Angel Sword", "Cat Busja", "Banana", "Angry Mom", "Udar Bati"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves my cake");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to eat my cake :(");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}