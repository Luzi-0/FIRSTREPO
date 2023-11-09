int a = 25;

a += 4;

Console.WriteLine(a);

int b = 69;

b ++;
Console.WriteLine(b);

// input 1, pro sudé číslo hodnotu zvětším 3x
//pro liché číslo hodnotu zvětším 2x
// na konci číslo vypište

int input1 = 4;

if ((input1 % 2) == 0)
{
    input1 *= 3;
}
else
{
    input1 *= 2;
}
Console.WriteLine(input1);

string s = "Ahoj,";
s += "Láďo!";

Console.WriteLine(s);

string x = "";
if (string.IsNullOrWhiteSpace(x))
{
    Console.WriteLine("prázdné");
}
else
{
    Console.WriteLine("něco tam je");
}

string int2 = "heh";

if (string.IsNullOrWhiteSpace(int2))
{
    Console.WriteLine(" Ahoj světe");
}
else
{
    Console.WriteLine(int2 + " ahoj");
}

string input3 = "Username ble ble";
Console.WriteLine(input3.Length);
if (input3.Length > 5 && input3.Length < 10)
{
    Console.WriteLine("Username nejde vytvořit");
}
else
{
    Console.WriteLine("Username v pořádku");
}

Console.WriteLine("Zadej slovo");
string userInput = Console.ReadLine();

Console.WriteLine("Uživatel zadal " + userInput);
Console.WriteLine($"Uživatel zadal {userInput}");

int userInput3 = 253;
int result = 0;
if (userInput3 > 0)
{
    //udelat zaporne
    result = userInput3 * -1;
}
else
{
    result = userInput3;
}