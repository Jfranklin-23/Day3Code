int number1 = 25;
int number2 = 75;
int number3 = 10;

int highest = number1;
int lowest = number1;

if(number2 > highest) highest = number2;
if(number2 < lowest) lowest = number2;

if(number3 > highest) highest = number3;
if(number3 <lowest) lowest = number3;

Console.WriteLine("The highest number is: " + highest);
Console.WriteLine("The lowest number is: " + lowest);