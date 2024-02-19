bool isWoman;

Console.WriteLine("Podaj imię:");
var name  = Console.ReadLine();

Console.WriteLine("Podaj płeć m - meżczyna k -kobieta:");
var sexAsString = Console.ReadLine();
if (sexAsString =="k") { isWoman = true;  } else isWoman = false;

Console.WriteLine("Podaj wiek:");
var ageAsString = Console.ReadLine();
int age = int.Parse(ageAsString)!;

if (isWoman && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{ 
    Console.WriteLine("Ewa lat 30");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Małoletni mężczyzna");
};