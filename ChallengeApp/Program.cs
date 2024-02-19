
int number = 45667456;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
int[] counter = new int[10];

foreach (char letter in letters)
{
    int index = (int)Char.GetNumericValue(letter);
    counter[index]++;
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + "  ==> " + counter[i]);
}