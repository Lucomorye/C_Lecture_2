// Найти позицию нужного нам элемента
//               0   1   2   3   4   5   6   7  8
int [] array = { 1, 4, 93, 43, 56, 56, 67, 81, 81 };
int n = array.Length;
int find = 81;
int index = 0;

while(index < n)
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
    break; // этот оператор прерывает/останавливает поиск 
  }
  //index = index + 1; или
  index++;
}
