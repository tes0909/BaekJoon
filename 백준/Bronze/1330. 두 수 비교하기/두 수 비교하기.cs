string[] input = Console.ReadLine().Split();
int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);
string result = a > b ? ">" : (a < b ? "<" : "==");
Console.WriteLine(result);