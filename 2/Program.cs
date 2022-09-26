 Console.WriteLine("Введите количество строк: ");
 int n = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Введите количество столбцов: ");
 int m = Convert.ToInt32(Console.ReadLine());

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

 void Element(int[,] matrix)
 {
     Console.Write("Строкa: ");
     int r = Convert.ToInt32(Console.ReadLine());

     Console.Write("Столбец: ");
     int c = Convert.ToInt32(Console.ReadLine());

     if (r > matrix.GetLength(0) - 1 || c > matrix.GetLength(1) - 1)
         Console.WriteLine("нет элемента");
     else
         Console.WriteLine($"Элемент: {matrix[r, c]}");
}
int[,] matrix = new int[n, m];
FillMatrix(matrix);
Element(matrix);
