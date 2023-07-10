// Найти максимум из 9 чисел используя массив.
int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (result < arg2) result = arg2;
  if (result < arg3) result = arg3;
  return result;
}
//               0    1   2   3   4   5   6   7   8
int[] array = { 17, 291, 34, 24, 85, 66, 79, 48, 19 };

int max = Max(
          Max(array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
