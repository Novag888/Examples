// Делаем палец вверх - Закрышиваем пиксели.
// правило вокруг точки проверяет вверх, вниз, вправо, влево -проверяет 
//если закрашено идем дальше, если не закрашено -закрашиваем и двигаемся дальше.




Int[,] pic = new int[,]
{
// Здесь должен быть 0,1, ввиде пльца

}

void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{matr[i,j]} ");
            if(image[i,j] ==0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    FillImage(row-1, col);
    FillImage(row, col-1);
    FillImage(row+1, col);
    FillImage(row, col+1);
}
PrintImage(pic);
FillImage(13,13);//случайная точка
PrintImage(pic);