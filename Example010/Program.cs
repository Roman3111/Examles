int[] array = {2, 56, 34, 9, 6, 8, 21, 54, 8 ,9};
int n = array.Length;
int find = 9;

int index = 0;

while(index < n)
{
   if(array[index] == find )
   {
    System.Console.WriteLine(index);
    break;
   }
   index++;
}