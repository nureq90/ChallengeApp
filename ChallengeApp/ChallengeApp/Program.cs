string name = "Ewa";
bool female = false;
var age = 17;

if (female == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (female == true && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (female == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

