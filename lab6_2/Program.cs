using System;

class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            throw new ArgumentException("Arrays must have the same length");

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }
        return result;
    }

    public static double[] Add(double[] array1, double[] array2)
    {
        if (array1.Length != array2.Length)
            throw new ArgumentException("Arrays must have the same length");

        double[] result = new double[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }
        return result;
    }

    public static int[,] Multiply(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        if (matrix2.GetLength(0) != columns || matrix2.GetLength(1) != rows)
            throw new ArgumentException("Matrix dimensions are not suitable for multiplication");

        int[,] result = new int[rows, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                int sum = 0;
                for (int k = 0; k < columns; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    // Додайте інші методи для інших операцій

    public static void Main()
    {
        int a = 5;
        int b = 3;
        int intResult = Add(a, b);
        Console.WriteLine($"Addition of integers: {intResult}");

        double x = 2.5;
        double y = 1.5;
        double doubleResult = Add(x, y);
        Console.WriteLine($"Addition of doubles: {doubleResult}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] arrayResult = Add(array1, array2);
        Console.WriteLine("Addition of arrays:");
        foreach (int num in arrayResult)
        {
            Console.Write(num + " ");
        }

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] matrixResult = Multiply(matrix1, matrix2);
        Console.WriteLine("\nMatrix multiplication result:");
        for (int i = 0; i < matrixResult.GetLength(0); i++)
        {
            for (int j = 0; j < matrixResult.GetLength(1); j++)
            {
                Console.Write(matrixResult[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
