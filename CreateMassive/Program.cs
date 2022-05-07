string [] Mass = {"a", "b", "c", "d", "e", "f"};
string [] finMass = new string [new Random().Next(0, 4)];
int i = new Random().Next(0, Mass.Length - 3);
Console.WriteLine("Получившийся массив:");
for (int j = 0; j < finMass.Length; j++)
{
    finMass[j] = Mass [i];
    i++;
    Console.Write($"{finMass[j]} ");
}