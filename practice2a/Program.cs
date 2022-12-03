namespace practice2a
{
    public class Programm
    {
        public static void Main()
        {
            Task1(5);
            Task2(5);
            Task34(5, 5);
            Task34(5, 4);
        }

        public static void Task1(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = i + 1;

            for (int i = n - 1; i >= 0; i--)
                Console.Write($"{array[i]} ");
            Console.Write("\n\n");

        }
        public static void Task2(int n)
        {
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    array[i, j] = 0;

            //перебераем все элементы главной диагонали и над ней
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    array[i, j] = 1;
            //присваиваем значения элементам на 1 ниже главной диагонали
            for (int i = 0; i < n - 1; i++)
                array[i + 1, i] = 1;

            printMatrix(array, n, n);
        }
        public static void Task34(int n, int m)
        {

            int[,] Arr = new int[n, m];
            int i = 0, j, k = 0, p = 1;

            while (i < n * m) //Цикл по номеру витка
            {
                k++;
                for (j = k - 1; j < m - k + 1; j++)
                {
                    Arr[k - 1, j] = p++;
                    i++;
                }   //Определение значений верхнего столбца

                for (j = k; j < n - k + 1; j++)
                {
                    Arr[j, m - k] = p++;
                    i++;
                }   //По правому вертикальному столбцу

                for (j = m - k - 1; j >= k - 1; j--)
                {
                    Arr[n - k, j] = p++;
                    i++;
                }   //по нижнему горизонтальному столбцу

                for (j = n - k - 1; j >= k; j--)
                {
                    Arr[j, k - 1] = p++;
                    i++;
                }   //по левому вертикальному столбцу

            }
            printMatrix(Arr, n, m);
        }
        public static void printMatrix(int[,] matrix, int columns, int lines)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < lines; j++)
                    Console.Write($"{matrix[i, j]} \t");
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}

