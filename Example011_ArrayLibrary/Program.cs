﻿//проделать и вникнуть в эту задачу 30 минута
void FillArray(int[] collection)//метод заполняет массив
{
  int length = collection.Length;
  int index = 0;
  while(index < length)
  {
    collection[index] = new Random().Next(1,10);
    index++;
  }
}

void PrintArray(int[] col)//метод void ничего не возвращает метод распечатывает массив
{
  int count = col.Length;
  int position = 0;
  while(position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int IndexOf(int [] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = 0;

  while(index < count)
  {
    if(collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int [] array = new int[10]; //создаём новый массив в котором будет 10 элементов (по умолч. заполнен нулями)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);