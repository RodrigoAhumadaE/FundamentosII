// Escríbelas como funciones estáticas invocables desde Program.cs.​
// 1. Imprimir 1-255​

Console.WriteLine("<<<<<< 1 >>>>>>");
static void PrintNumbers()
{
  for(int i=1; i<=255; i++){
    Console.WriteLine(i);
  }
}

PrintNumbers();

// 2. Imprimir números impares entre 1-255​

Console.WriteLine("<<<<<< 2 >>>>>>");
static void PrintOdds(){
  for(int j=1; j<=255; j+=2){
    Console.WriteLine(j);
  }
}
PrintOdds();

// 3. Imprimir Suma​
// Print all of the numbers from 0 to 255, but this time, also print the sum as you go. 
// For example, your output should be something like this:
// New number: 0 Sum: 0
// New number: 1 Sum: 1
// New number: 2 Sum: 3

Console.WriteLine("<<<<<< 3 >>>>>>");
static void PrintSum(){   
  int sum = 0;
  for(int l=0; l<=255; l++){
    sum+=l;
    Console.WriteLine($"New number: {l} Sum: {sum}");
  }
}

PrintSum();

// 4. Iterar a través de una matriz​
// Write a function that would iterate through each item of the given integer array and print each value to the console.

Console.WriteLine("<<<<<< 4 >>>>>>");
int[] numero = new int[10];
for(int m=0; m<numero.Length; m++){
  numero[m] = (m+1) * 3;
}

static void LoopArray(int[] numbers)
{
  foreach(int num in numbers){
    Console.WriteLine(num);
  }
}

LoopArray(numero);

// 5. Encuentra el valor máximo
// Write a function that takes an integer array and prints and returns the maximum value in the array. 
// Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
// or even a mix of positive numbers, negative numbers and zero.

Console.WriteLine("<<<<<< 5 >>>>>>");
static int FindMax(int[] numbers){
  int max = numbers[0]; 

  for (int n=1; n<numbers.Length; n++){
    if (numbers[n] > max){
      max = numbers[n];
    }
  }
  Console.WriteLine($"el numero mayor en el array es {max}");
  return max; 
}
int[] valores = new int[]{-8,5,0,-10,-15,2};
int mayor = FindMax(valores);

// 6. Obtén el Promedio
// Write a function that takes an integer array and prints the AVERAGE of the values in the array.
// For example, with an array [2, 10, 3], your program should write 5 to the console.

Console.WriteLine("<<<<<< 6 >>>>>>");
static void GetAverage(int[] numbers){
  double sum = 0;
  foreach(int num in numbers){
    sum+=num;
  }
  Console.WriteLine($"El promedio es {sum/numbers.Length}");    
}

int[] numbers = new int[]{5,3,25,10};
GetAverage(numbers);

// 7. Lista con números impares
// Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
// When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].

Console.WriteLine("<<<<<< 7 >>>>>>");
static List<int> OddList(){
  List<int> imp = new List<int>();
  for(int o=1; o<=255; o++){
    if(o%2 != 0){
      imp.Add(o);
    }
  }
  return imp;
}

List<int> impares = new List<int>();
impares = OddList();
foreach(int imp in impares){
  Console.WriteLine(imp);
}

// 8. Mayor que Y​
// Write a function that takes an integer List, and an integer "y" and returns the number of values 
// That are greater than the "y" value. 
// For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
// (since there are two values in the List that are greater than 3).

Console.WriteLine("<<<<<< 8 >>>>>>");
static int GreaterThanY(List<int> numbers, int y){
  int cont = 0;
  foreach(int num in numbers){
    if(num > y){
      cont++;
    }
  }
  return cont;
}

List<int> num = new List<int>(){5,-8,6,7,-10};
int cantidad = GreaterThanY(num,6);
Console.WriteLine(cantidad);

// 9. Haz Cuadrar los Valores​
// Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
// For example, [1,5,10,-10] should become [1,25,100,100]

Console.WriteLine("<<<<<< 9 >>>>>>");
static void SquareArrayValues(List<int> numbers){
  List<int> numer = new List<int>();
  int aux = 0;
  for(int p=0; p<numbers.Count; p++){
    aux = numbers[p];
    numer.Add(aux*aux);
  }
  foreach(int num in numer){
    Console.WriteLine(num);
  }
}
SquareArrayValues(num);

// 10. Elimina los Números Negativos​
// Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
// When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

Console.WriteLine("<<<<<< 10 >>>>>>");
static void EliminateNegatives(List<int> numbers){
  List<int> num = new List<int>();
  foreach(int x in numbers){
    if(x < 0){
      num.Add(0);
    }else{
      num.Add(x);
    }
  }
  foreach(int x in num){
    Console.WriteLine(x);
  }
}

EliminateNegatives(num);