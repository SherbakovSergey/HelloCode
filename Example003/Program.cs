using System.Runtime.Intrinsics.X86;
int numberA = 3;
int numberB = 5;
int result  = numberA + numberB;
Console.WriteLine(result);

numberA = new Random().Next(1,10);
numberB = new Random().Next(1,10);
result  = numberA + numberB;
Console.WriteLine(result);