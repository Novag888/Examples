//Вид 1
void Method1()
{
    Console.WriteLine("Автор Александр");
}
//Method1();




  



  



//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");


//Вид21
void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст");









//Вид3 Показывает год
int Method3()
{
    return DateTime.Now.Year;
}

 int year = Method3();
 //Console.WriteLine(year);











 //Вид4 10 раз вывели буку Z
 string Method4(int count, string text)
 {
       
    string result = String.Empty;
    for( int i = 0; i < count; i++)    
    {
        result = result + text;
    }
    return result;
 }

 string res = Method4(10, "z");
 //Console.WriteLine(res);







// Таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }



// Работа с текстом
// Дан текст, в тексте нужно все пробелы заменить точками
// Маленькие буква "k" Заменить большими "К",
// А большие "С" Маленькими "с"

string text = "- Я думаю, сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали всемто нашего корогорда,"
            + "Вы бы взяли приступом согласие пруССкого короля"
            + " Вы так красноречивы. Вы дадите мне чаю?";
// String s = "qwerty"
//             012
// s[3] // r

// //Начало
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text [i]}";
// }

//     return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// //конец

// Алгоритм сортировки - выбор максимального (минимального)
// Выбрвть 1й элемент и нужно далее определить минимальный
//После того как определен нужно поменять выделенный с еденицей которая является минимальной
//далее выбираем следющее число (прошлое уже отмечено)
// Снова брать минимальный и поменять его местами с рабочим
// Снова находим минимальний и т.д
// задача отсортировать массив. 1354643 = 1234567
int[] arr = {1,2,9,3,8,4,7,5,6,6};

void PrintArray(int[] array)
{
    int count = array.Length;

for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
// До этого момента код только выводит список цифр
// теперь идет код упорядовачивания цифр.

void SelectionSort(int[]array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition =i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);