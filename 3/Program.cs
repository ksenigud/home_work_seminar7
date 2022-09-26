 Console.WriteLine("Введите количество строк: ");
 int n = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Введите количество столбцов: ");
 int m = Convert.ToInt32(Console.ReadLine());
 int[,] matrix = new int[n, m];

 void FillMatrix(int[,] matrix)
 {
 for(int row = 0; row < n; row++)
 {
     for(int col = 0; col < m; col++)
     {
     matrix[row, col] = new Random().Next(1,10);
     Console.Write($"{matrix[row, col]}" + " \t");
     }
 Console.WriteLine();
 }
 }

 void Row(int[,] matrix)
 {
     for (int c = 0; c < matrix.GetLength(1); c++)
     {
         double sum = 0;
         for (int r = 0; r < matrix.GetLength(0); r++)
         {
             sum += matrix[r, c];
         }
         Console.WriteLine(sum / matrix.GetLength(1));
     }
 }

FillMatrix(matrix);
Row(matrix);
