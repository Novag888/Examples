int[] array = { 1, 12, 31, 4, 15, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
      Console.WriteLine(index);  
      break;
    }
     //index = index + 1;
    index++;  
}



// ИЛИ Примерная декомпозиция (НЕ ОБЯЗАТЕЛЬНО ТАКАЯ ДОЛЖНА БЫТЬ У ВАС)

// 1. Считывание данных от пользователя 
//    1. Считать int число
//    int <- string
//    2. Считать double число
//    double <- string

// 2. Создать массив
//    1. int-чисел
//    int[] <- int 
//    2. double-чисел
//    double[] <- int 

// 3. Заполнить массив
//    1. Случайным образом
//    int[] <- (int, min, max)
//    double[]<- (int)

//    2. с клавиатуры
//    int[] <- (void)
//    double[]<- (void)

// 4. Найти произведения
//    int[] <- int[]
//    double[] <- double[]

// 5. Распечатать
//    string <- int[]
//    ТЕКСТОВЫЙ ФАЙЛ <- int[]
//      ```

//      res[i] = a[i] * a[N - 1 - i]