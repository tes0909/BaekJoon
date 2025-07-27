int number = int.Parse(Console.ReadLine());
int quotient = number / 4;
string answer = "long";
string result = "";
for (int i = 0; i < quotient; i++)
{
    result += answer + " ";
}
result += "int";
Console.WriteLine(result);