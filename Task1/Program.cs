// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindrome (int arg) {
    int reversNum = 0;
    int temp = arg;
    while (temp != 0) {
        reversNum = reversNum * 10 + temp % 10;
        temp /= 10;
    }
    if (arg == reversNum) Console.WriteLine("The number is a polydrome");
    else Console.WriteLine("The number is not a polydrome");
}

Console.WriteLine("Enter a five-digit number");
int num = Convert.ToInt32(Console.ReadLine());

CheckPalindrome(num);