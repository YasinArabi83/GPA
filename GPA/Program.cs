//یاسین عربی
//ده نمره دانشجو


double math = 0;
int Inputvalue1 = 0;
while
    (Inputvalue1 < 1)
{
    Console.Write("1.Please enter the math grade (Between 0 and 20): ");
    math = double.Parse(Console.ReadLine());
    if (math >= 0 && math <= 20)
    {
        Inputvalue1 = Inputvalue1 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double mathnum = math * 3;


double geometry = 0;
int Inputvalue2 = 0;
while
    (Inputvalue2 < 1)
{
    Console.Write("2.Please enter the geometry grade (Between 0 and 20): ");
    geometry = double.Parse(Console.ReadLine());
    if (geometry >= 0 && geometry <= 20)
    {
        Inputvalue2 = Inputvalue2 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double geometrynum = geometry * 2;


double Programming = 0;
int Inputvalue3 = 0;
while
    (Inputvalue3 < 1)
{
    Console.Write("3.Please enter the Programming grade (Between 0 and 20): ");
    Programming = double.Parse(Console.ReadLine());
    if (Programming >= 0 && Programming <= 20)
    {
        Inputvalue3 = Inputvalue3 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double Programmingnum = Programming * 4;


double Farsi = 0;
int Inputvalue4 = 0;
while
    (Inputvalue4 < 1)
{
    Console.Write("4.Please enter the Farsi grade (Between 0 and 20): ");
    Farsi = double.Parse(Console.ReadLine());
    if (Farsi >= 0 && Farsi <= 20)
    {
        Inputvalue4 = Inputvalue4 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double Farsinum = Farsi * 2;


double English = 0;
int Inputvalue5 = 0;
while
    (Inputvalue5 < 1)
{
    Console.Write("5.Please enter the English grade (Between 0 and 20): ");
    English = double.Parse(Console.ReadLine());
    if (English >= 0 && English <= 20)
    {
        Inputvalue5 = Inputvalue5 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double englishnum = English * 3;


double physics = 0;
int Inputvalue6 = 0;
while
    (Inputvalue6 < 1)
{
    Console.Write("6.Please enter the physics grade (Between 0 and 20): ");
    physics = double.Parse(Console.ReadLine());
    if (physics >= 0 && physics <= 20)
    {
        Inputvalue6 = Inputvalue6 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double physicsnum = physics * 3;


double chemistry = 0;
int Inputvalue7 = 0;
while
    (Inputvalue7 < 1)
{
    Console.Write("7.Please enter the chemistry grade (Between 0 and 20): ");
    chemistry = double.Parse(Console.ReadLine());
    if (chemistry >= 0 && chemistry <= 20)
    {
        Inputvalue7 = Inputvalue7 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double chemistrynum = chemistry * 2;


double Biology = 0;
int Inputvalue8 = 0;
while
    (Inputvalue8 < 1)
{
    Console.Write("8.Please enter the Biology grade (Between 0 and 20): ");
    Biology = double.Parse(Console.ReadLine());
    if (Biology >= 0 && Biology <= 20)
    {
        Inputvalue8 = Inputvalue8 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double Biologynum = Biology * 2;


double logic = 0;
int Inputvalue9 = 0;
while
    (Inputvalue9 < 1)
{
    Console.Write("9.Please enter the logic grade (Between 0 and 20): ");
    logic = double.Parse(Console.ReadLine());
    if (logic >= 0 && logic <= 20)
    {
        Inputvalue9 = Inputvalue9 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double logicnum = logic * 2;


double accountant = 0;
int Inputvalue10 = 0;
while
    (Inputvalue10 < 1)
{
    Console.Write("10.Please enter the accountant grade (Between 0 and 20): ");
    accountant = double.Parse(Console.ReadLine());
    if (accountant >= 0 && accountant <= 20)
    {
        Inputvalue10 = Inputvalue10 + 1;
    }
    else
    {
        Console.WriteLine("The number is not in the correct range.");
    }
}
double accountantnum = accountant * 3;


double GPA = (mathnum + geometrynum + Programmingnum + Farsinum + englishnum + physicsnum + chemistrynum + Biologynum + logicnum + accountantnum) / 26;
Console.Write("your GPA: ");
Console.WriteLine(GPA);

if (GPA >= 10)
{
    Console.WriteLine("you are pass");
}
else
{
    Console.WriteLine("you are fail");
}
if (GPA >= 16 && GPA <= 20)
{
    Console.WriteLine("GPA type : A ");
}
else if (GPA >= 14 && GPA < 16)
{
    Console.WriteLine("GPA type : B ");
}
else if (GPA >= 12 && GPA < 14)
{
    Console.WriteLine("GPA type : C ");
}
else if (GPA >= 10 && GPA < 12)
{
    Console.WriteLine("GPA type : D ");
}
else if (GPA >= 0 && GPA < 10)
{
    Console.WriteLine("GPA type : F ");
}