// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 5 };

print("Numbers", numbers);
print("Even No", numbers.Where(x => isEven(x)));
print("Odd No", numbers.Where(x => isOdd(x)));




 static void print( string title , IEnumerable<int> list) {
    Console.Write($"{title}: [");
    foreach(int i in list) Console.Write($" {i} ");
    Console.Write(" ]");
    Console.WriteLine();
} 

static bool isEven (int num ) => num % 2 == 0;

static bool isOdd(int num) => !isEven(num);
