int number = 77777;
string numberInString = number.ToString();
char[] lettesr = numberInString.ToArray();
int[] digits = new int[10];

for (int i=0; i < lettesr.Length; i++)
{
 //   Console.WriteLine(lettesr[i]);
    int digit = lettesr[i] - '0';
 //   Console.WriteLine(digit);
    digits[digit] +=1;
}

for (int x=0; x<digits.Length; x++)
{
    Console.WriteLine(x+" => "+digits[x]);
}