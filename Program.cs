/*Задача. Написать программу, которая из имеющегося массива строк формирует массив из 
строк, длина которых меньше, либо равна 3 символам.*/

    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:   ", i + 1);
        array[i] = Console.ReadLine();
    }
    

void ArrayNew(string[] arrayNew)
{  
    Console.WriteLine("Строки, длина которых меньше, либо равна 3:   "); 
    for (int i = 0; i < n;  i++)
    {
        if(array[i].Length <= 3)
        {
            arrayNew[i] = array[i]; 
            Console.WriteLine(arrayNew[i]); 
        }      
    }
}
ArrayNew(array);
