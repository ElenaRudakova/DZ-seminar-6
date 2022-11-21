// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int CoutnPositiv(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите три числа через пробел: ");
string input = Console.ReadLine()!;
int[] Array = GetArrayFromString(input);
int countNum = CoutnPositiv(Array);
Console.WriteLine($"Количество положительных чисел равно: {countNum}");