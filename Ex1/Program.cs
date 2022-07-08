Console.WriteLine("How many numbers do you want to enter?"); 
int a = int.Parse(Console.ReadLine());
// Возможно, я неправильно понял условие задачи, и программа не должна спрашивать число М у пользователя.
// Преобразовать введенную пользователем строку в числа (разделенные пробелами) можно, например, так:
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] Array = new int[a];
int counter = 0;
int even = 0;

while (counter < a)
{
 Console.WriteLine("Enter the number");
 Array[counter] = int.Parse(Console.ReadLine());
    if (Array[counter]%2 == 0)
        {
        even++;    
        counter++;
        }
    else 
        counter++;
}

Console.WriteLine($"You entered {even} even numbers");