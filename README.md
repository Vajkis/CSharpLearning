## Types

```cs
char     // single character (e.g., 'A')
string   // sequence of characters (e.g., "Hello")
int      // integer number (e.g., 42)
float    // floating-point number, single precision (e.g., 3.14f)
double   // floating-point number, double precision (e.g., 3.14159)
decimal  // high-precision floating-point number, mainly for financial calculations (e.g., 10.99M)
bool     // boolean value (true or false)
```

## Variables

```cs
char symbol = 'x';
string text = "Hello world!";
int number = 5;
float number2 = 4.58f;
double number3 = 2.1685;
decimal number4 = 2.78M;
bool isOpen = false;
```

## Arithmetic Operators

```cs
+   // sum
-   // difference
*   // multiplication
/   // division
%   // remainder (modulus)
++  // increment (increase by 1)
--  // decrement (decrease by 1)
```

```cs
double num = 10;

num + 3  // 13
num - 4  // 6
num * 7  // 70
num / 4  // 2.25
num % 3  // 1
num++    // 11
num--    // 9
```

## Comparison Operators

```cs
<   // less than
>   // greater than
<=  // less than or equal to
>=  // greater than or equal to
==  // equal to
!=  // not equal to
```

```cs
1 < 6     // true
5 > 7     // false
5 <= 5    // true
7 >= 9    // false
99 == 66  // false
73 != 7   // true
```

## Assignment Operators

```cs
+=  // add and assign
-=  // subtract and assign
*=  // multiply and assign
/=  // divide and assign
%=  // modulus and assign
```

```cs
double num = 10;

num += 5;  // num = num + 5  → 15
num -= 2;  // num = num - 2  → 8
num *= 3;  // num = num * 3  → 30
num /= 5;  // num = num / 5  → 2
num %= 4;  // num = num % 4  → 2
```

## String

```cs
string text = "Some text";
```

```cs
int num = 2;

string text = "Number is " + num;
```

```cs
int num = 1;

string text = $"Number is {num}";
```

```cs
bool isOpen = false;

string text = "Doors is " + isOpen;  // Doors is False
```

```cs
string firstName = "Vardas";
string lastName = "Pavardė";

string fullName = firstName + " " + lastName;
string fullName2 = $"{firstName} {lastName}";
```

```cs
int price = 5;

string text = "Apple cost " + price + "€";
string text = $"Apple cost {price}€";
```

```cs
string text = "Some text";
string text2 = "more text"

text += text2;  // Some textmore text
```

```cs
string text = "Some text";
string text2 = "more text"

text += $" {text2}";  // Some text more text
```

```cs
string text = "Some text";
string text2 = "more text"

text += " ";    // "Some text "
text += text2;  // Some text more text
```

## String Methods

```cs
string text = "Some text";
string text2 = "Other text";

text.ToUpper();            // SOME TEXT
text.ToLower();            // some text
text.Equals("Some text");  // text == "Some text"  → true
text.Equals(text2);        // text == text2        → false
```

## ToString Method

```cs
// With 'ToString' method you can convert a number (integer, floating-point, etc.) to a string.
```

```cs
int num = 1;

num.ToString();      // "1"
num.ToString("F1");  // "1.0"
num.ToString("F2");  // "1.00"
```

```cs
double num = 3.789;

num.ToString();      // "3.789"
num.ToString("F1");  // "3.7"
num.ToString("F2");  // "3.78"
```

## Console Class

```cs
/*
Console class allows you to read input from the user,
display output to the terminal, and control various terminal properties
like colors and cursor position.
*/
```

```cs
// Prints text to the terminal without a new line at the end.
Console.Write("Some text");

// Prints text to the terminal and moves to the next line.
Console.WriteLine("Some text");

// Also you can provide different number types.
Console.Write(1);
Console.Write(3.14M);
Console.WriteLine(74.1);
Console.WriteLine(9.17f);

// Waits for user input until they press Enter
// and returns the input as a 'string'.
Console.ReadLine();

// Waits for a single key press from the user and does not require Enter.
// returns a 'ConsoleKeyInfo' object
Console.ReadKey();
```

## Parse & TryParse Methods

```cs
// Parse and TryParse are used to convert strings into specific data types.

string numberString = "123";

int intNumber = int.Parse(numberString);
float floatNumber = float.Parse(numberString);
double doubleNumber = double.Parse(numberString);
decimal decimalNumber = decimal.Parse(numberString);

int.TryParse(numberString, out int num);
float.TryParse(numberString, out float num);
double.TryParse(numberString, out double num);
decimal.TryParse(numberString, out decimal num);
```

```cs
string keyString = "x";

char key = char.Parse(keyString);
char.TryParse(keyString, out char num);
```

## Logical Operators

```cs
&&  // AND - Returns 'true' only if both conditions are 'true'.
||  // OR  - Returns 'true' only if at least one condition is 'true'.
!   // NOT - Reverses a boolean value
^   // XOR - Returns 'true' if exactly one of the conditions is 'true', otherwise returns false.
```

```cs
// NOR - Returns 'true' only if both conditions are 'false', otherwise returns false.
bool isOk = true;
bool isUser = false;

!(isOk || isUser)  // false
```

```cs
int x = 5;
int y = 7;

x >= 7 && y >= 7  // false
x >= 7 || y >= 7  // true

x >= 5 ^ y >= 5  // false
x >= 7 ^ y >= 7  // true
```

```cs
bool isOpen = false;

!isOpen  // true
```

## if Statement

```cs
/*
The if statement is a conditional statement that executes a block of code
only if a specified condition evaluates to 'true'.
*/
```

```cs
// single condition
int x = 1;
int y = 3;

if(x == y)
{
  Console.WriteLine("x and y are equal");
}
```

```cs

// single condition with an alternative case (all other cases)
bool iOpen = false;

if(isOpen)
{
   Console.WriteLine("Doors is open");
}
else
{
   Console.WriteLine("Doors is closed");
}
```

```cs

// multiple specific conditions
int x = 1;
int y = 3;

if(x > y)
{
  Console.WriteLine("x is greater when y");
}
else if(x < y)
{
  Console.WriteLine("x is less when y");
}
```

```cs
// multiple specific conditions with a fallback (all other cases)
string text = "Vilnius";

if(text.Equals("Vilnius"))
{
  Console.WriteLine("Provided city is Vilnius");
}
else if(text.Equals("Kaunas"))
{
  Console.WriteLine("Provided city is Kaunas");
}
else
{
  Console.WriteLine("Provided city not exist");
}
```

```cs
// multiple conditions combined in one case
int temperature = 10;

if( temperature < 10 )
{
  Console.WriteLine("It's cold");
}
else if ( temperature > 10 && temperature < 20)
{
  Console.WriteLine("It's warm");
}
else
{
    Console.WriteLine("It's hot");
}
```

```cs
// negating the condition (executing when isOk is 'false')
bool isOk = true;

if(!isOk)
{
  Console.WriteLine("An error occurred");
}
```
