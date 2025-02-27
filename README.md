## Types:

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
+  // sum
-  // difference
*  // multiplication
/  // division
%  // remainder (modulus)
++ // increment (increase by 1)
-- // decrement (decrease by 1)

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
<  // less than
>  // greater than
<= // less than or equal to
>= // greater than or equal to
== // equal to
!= // not equal to

1 < 6     // true
5 > 7     // false
5 <= 5    // true
7 >= 9    // false
99 == 66  // false
73 != 7   // true
```

## Assignment Operators

```cs
+= // add and assign
-= // subtract and assign
*= // multiply and assign
/= // divide and assign
%= // modulus and assign

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

int num = 2;
string text2 = "Number is " + num;

int num2 = 1;
string text3 = $"Number is {num2}";

bool isOpen = false;
string text4 = "Doors is " + isOpen; // Doors is False

string firstName = "Dovydas";
string lastName = "Nesakysiu";
string fullName = firstName + " " + lastName;
string fullName2 = $"{firstName} {lastName}";

int price = 5;
string text5 = "Apple cost " + price + "€";
string text6 = $"Apple cost {price}€";

string text7 = "Some text";
string text8 = "more text"
text7 += text8; // Some textmore text

string text9 = "Some text";
string text10 = "more text"
text9 += $" {text10}"; // Some text more text

string text11 = "Some text";
string text12 = "more text"
text11 += " "; // "Some text "
text11 += text12; // Some text more text
```

## Console Class

```cs
/*
Console class allows you to read input from the user,
display output to the terminal, and control various terminal properties
like colors and cursor position.
*/

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
// returns a ConsoleKeyInfo object
Console.ReadKey();
```

## Parse

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

string keyString = "x";
char key = char.Parse(keyString);
char.TryParse(keyString, out char num);

```
