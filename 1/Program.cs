 Console.WriteLine("Введите количество строк: ");
 int n = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Введите количество столбцов: ");
 int m = Convert.ToInt32(Console.ReadLine());
 double[,] matrix = new double[n, m];

 void FillMatrix(double[,] matrix)
 {
 for(int row = 0; row < n; row++)
 {
     for(int col = 0; col < m; col++)
   {
    matrix[row, col] = new Random().Next(-10, 10) + new Random().NextDouble();
    Console.Write($"{matrix[row, col]}" + " \t");
    }
Console.WriteLine();
}
}

FillMatrix(matrix);
