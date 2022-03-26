IsPrime();

void IsPrime()
{
System.Console.WriteLine("Please enter a number...");
int UserInput = Int32.Parse(Console.ReadLine());

 int n = UserInput, a = 0;
         for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine($"{UserInput} is a Prime Number", n);
         } else {
            Console.WriteLine($"{UserInput} is not a Prime Number");
         }
        




}