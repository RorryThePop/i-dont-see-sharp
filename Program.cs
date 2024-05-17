// See https://aka.ms/new-console-template for more information;


//Data types:
// 1. bool
// bool alive = true;
// bool isProgrammer = true;
// bool isFool = false;
// Console.WriteLine(alive);
//2. byte - stores an integer from 0 to 255 and occupies 1 byte
// byte bit1 = 102;
// Console.WriteLine(bit1);
// 3. Double 
// double height = 1.6
//4. Decimal - stores a decimal fraction number
// decimal weight = 977;
//Interpolation

// string name = "Yury";
// int age = 26;
// double height = 1.7;
// Console.WriteLine("Name: {0} age {2} height: {1}", name, height, age);

// Console.Write("Insert your name: ");
// string? name = Console.ReadLine();
//
// Console.Write("Insert your age: ");
// // Convert.ToInt32() (convert in int type)
// int age = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Insert your height: ");
// double height = Convert.ToDouble(Console.ReadLine());
//
// Console.Write("Insert your wage: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());
//
// Console.WriteLine($"Name: {name}, Age: {age}, height: {height}, salary: {salary}");
// int x = 10;
// int z = 5;
// Console.WriteLine(x * z);
//
// var salary2 = 334.2m;
// decimal result = salary2 * 3;
// Console.WriteLine(result);
// decimal Z = result / 4;
// Console.WriteLine(Z);
// double trouble = 10 / 4;
// Console.WriteLine(trouble);
//
// decimal newResult = ++Z;
// Console.WriteLine(newResult);

/*logical operations*/
// 1. logical multiplication
// int x1 = 2; //010
// int y1 = 5; //101
// Console.WriteLine(x1&y1); //0
// 2. Logical addition
// Console.WriteLine(x1|y1); // 7 that is equal 111
// 3. Logical exclusive OR
// int x = 45; // The value to be encrypted in binary form 101101
// int key = 102; //The key in binary form 1100110
//
// int encrypt = x ^ key;
// int decrypt = encrypt ^ key;
// Console.WriteLine($"Encrypted integer: {encrypt}, and decryption is {decrypt}"); //75 or 1001011 in binary
// const string hello = "greetings";
// Console.WriteLine(hello);

// const int x = 222;
// var y = ~x;
// y += 1;
// Console.WriteLine(y);
// 4. Shift operations
/*int a = 16; // 10000 in binary
int b = 2; // 10
int c = a << b;
int d = a >> b;
Console.WriteLine(d);
Console.WriteLine(c);*/

//Assignment operations

/*var a = 10;
a += 5;
a -= 4;
a *= 2;
a /= 5;
a <<= 4;
a >>= 2;
Console.WriteLine(a);*/
// Assignment operations are right-associative, they are performed from right to left
/*int a = 10;
int b = 7;
int c = a += b -= 5; //12
Console.WriteLine(c);*/

//Comparison operations

/*int a = 10;
int b = 4;
bool c = a == b;
bool d = a != b;
bool x = a > b | b > a; // bitwise OR. It works with binary comparison or boolean values.
bool result = a > b || b > a; //logical OR. Works only with boolean values
bool z = a > b & b < a; // Applied to integers by performing bitwise AND
bool zx = a > b && b < a; // Logical AND. Applied to boolean values.
bool x5 = (5 > 6) ^ (4 < 6); // Exclusive OR operation. Returns true
                             // if either the first or second operand (BUT NOT BOTH) is true,
                             // otherwise returns false
bool x6 = (a > b) ^ (b < a);
Console.WriteLine(x6);*/

// The if ... else and ternary operation
/*int num1 = 8;
int num2 = 10;
if (num1 > num2)
{
    Console.WriteLine("it is more than a");
}
else
{
    Console.WriteLine("It is less than a)");
}
int z = num1 < num2 ? (num1 + num2) : (num1 * num2);
Console.WriteLine(z);*/

//Cycles
// 1. FOR
// for (int i = 1; i < 10; i++) Console.WriteLine(i);
//2. DO..WHILE
/*int i = 10;
do
{
    Console.WriteLine(i);
    i--;
}
while(i > 0);*/
//3. WHILE
/*int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}*/
// 4. FOREACH
/*foreach(var letter in "CARALHO MANO"){
    Console.WriteLine(letter);
}*/
/*for (var i = 0; i < 10; i++)
{
    if (i == 5) break;
    Console.WriteLine(i);
}

for (var i = 0; i < 10; i++)
{
    for (var j = 0; j < 10; j++)
    {
        Console.WriteLine($"Combined data is {i * j} \t");
    }
}*/
/*Console.WriteLine("Insert deposit sum: ");
var sum = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Insert payment period in months: ");
var period = Convert.ToInt32(Console.ReadLine());
var j = 0;
while (j <= period)
{
    j++;
    sum += sum * 0.07M;
}
for (var i = 0; i <= period; i++)
{
    sum += sum * 0.07M;
}

Console.WriteLine(sum);*/

/*Console.WriteLine("Insert first num");
var firstInt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert second num");
var secondInt = Convert.ToInt32(Console.ReadLine());*/

/*for (var i = 0; i < 10; i++)
{
    if (firstInt > i && secondInt > i)
    {
        Console.WriteLine("Inserted data is more than 10");
    }
    else
    {
        Console.WriteLine("Tudo bem!");
    }
}*/

/*if (firstInt > 10 || firstInt < 0 || secondInt > 10 || secondInt < 0)
{
    Console.WriteLine("Inserted data is incorrect, do again");
}
else
{
    Console.WriteLine(firstInt * secondInt);
}*/
// Console.WriteLine(firstInt);
// Console.WriteLine(secondInt);

//ARRAYS
/*int[] nums = new int[4] {1, 2, 3, 4};
int[] nums1 = { 1, 2, 3, 4};
string[] people = { "Yury" , "Arakelov", "Bianca", "Massa Silva"};
Console.WriteLine(people[^1]); // Massa silva
Console.WriteLine(people[^3]); // Arakelov*/

/*int[] nums2 = new []{1, 2, 3, 4, 100, 3232};
for (var i = 0; i < nums2.Length; i++)
{
    Console.WriteLine(nums2[i]);
}
foreach (var c in nums2)
{
    Console.WriteLine(c);
}
string [] stringArr = {"Hello", "world", "It", "is", "me"};
var index = 0;
while (index < stringArr.Length)
{
    Console.WriteLine(stringArr[index]);
    index++;
}*/

//Multidimensional arrays
/*int[] nums1 = { 1, 2, 3, 4, 5 };
int[,] nums2 = { { 1, 2, 3 }, { 3, 4, 5} };
Console.WriteLine(nums1[0]);
Console.WriteLine(nums2.Length);
int[,,] nums3 = new int [3, 4, 5];
int[,,] nums4 = new int [3, 3, 3];
Console.WriteLine(nums4.Length);*/
/*
int[,] numbers = { { 1, 2, 3 }, { 3, 4, 5 } };
foreach (var i in numbers)
{
    Console.WriteLine($"{i} ");
}
*/

/*string[,] arrString = { { "Hi", "My", "name" }, { "is", "mister", "Yury" } };
int[,] arrNums = { { 1, 2, 3 }, { 4, 5, 6 } };
int rows = arrNums.GetUpperBound(0) + 1;
int columns = arrNums.Length / rows;

for (var i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
     Console.Write($"{arrNums[i, j]} \t");   
    }
    Console.WriteLine();
}*/


//ARRAY OF ARRAYS
/*int [][] nums = new int [4][];
nums[0] = new int[2] { 1, 2 };
nums[1] = new int[4] { 3, 4, 5, 6 };
nums[2] = new int[5] { 2, 3, 4, 4, 1 };
nums[3] = new int[6] { 2, 12, 2, 3, 4, 2 };
Console.WriteLine(nums.Length);

for (var i = 0; i < nums.Length; i++)
{
    for (var j = 0; j < nums[i].Length; j++)
    {
        Console.Write($"{nums[i][j]} \t");
    }
    Console.WriteLine();
}*/

//BASIC CONCEPTS OF ARRAYS

// rank - the number of dimensions (измерение) of an array
// dimension lenght - the length of the individual measurement of the array
// array length - amount of all elements in the array
// int [,] nums = new int[3, 4];
// rank - 2, it has 2 dimensions
// first dimension length is 3, second dimension length is 4
// array length is equal to 12 (3 * 4 = 12)

/*int[,,] mas = { 
    { { 1, 2 },{ 3, 4 } }, 
    { { 4, 5 }, { 6, 7 } }, 
    { { 7, 8 }, { 9, 10 } }, 
    { { 10, 11 }, { 12, 13 } }
};
int dim1 = mas.GetUpperBound(0);
int dim2 = mas.GetUpperBound(1);
int dim3 = mas.GetUpperBound(2);
for (var i = 0; i < dim1; i++)
{
    for (int j = 0; j < dim2; j++)
    {
        for (int k = 0; k < dim3; k++)
        {
            Console.Write($"mas[{i}, {j}, {k}] = {mas[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}*/
