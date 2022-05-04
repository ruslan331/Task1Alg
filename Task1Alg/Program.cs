using System;

namespace Task1Alg
{

    class Program
    {
        public static int[] ArrayInit(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-200, 200);
            }
            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Array:");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; ++i)
                Console.Write(String.Format("{0,5}", arr[i]));
            Console.WriteLine();
        }

        public static int MinValue(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        public static int MaxValue(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public static int[] Swap(int i, int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            Array.Copy(arr, res, n);
            int tmp = res[i];
            res[i] = res[i + 1];
            res[i + 1] = tmp;
            return res;
        }

        public static int[] SortByAscending(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            Array.Copy(arr, res, n);
            for (int j = 0; j < res.Length - 1; j++)
                for (int i = 0; i < res.Length - 1; i++)
                    if (res[i] > res[i + 1])
                        res = Swap(i, res);

            return res;
        }

        public static int[] SortByDescending(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            Array.Copy(arr, res, n);
            for (int j = 0; j < res.Length - 1; j++)
                for (int i = 0; i < res.Length - 1; i++)
                    if (res[i] < res[i + 1])
                        res = Swap(i, res);

            return res;
        }

        public static int[] TaskAa(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            arr = SortByAscending(arr);
            int center = n / 2;
            res[center] = arr[n - 1];

            int c = center;
            if (n % 2 == 0)
                c--;

            for (int i = 1; i <= c; i++)
            {
                res[center - i] = arr[n - i * 2];
                res[center + i] = arr[n - i * 2 - 1];
            }

            if (n % 2 == 0)
                res[0] = arr[0];

            return res;
        }

        public static int[] TaskAb(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            arr = SortByDescending(arr);
            int center = n / 2;
            res[center] = arr[n - 1];

            int c = center;
            if (n % 2 == 0)
                c--;

            for (int i = 1; i <= c; i++)
            {
                res[center - i] = arr[n - i * 2];
                res[center + i] = arr[n - i * 2 - 1];
            }

            if (n % 2 == 0)
                res[0] = arr[0];

            return res;
        }
        public static int[] TaskB(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];
            arr = SortByDescending(arr);

            for (int i = 0; i < n / 2; i++)
            {
                res[2 * i] = arr[i];
                res[2 * i + 1] = arr[n - i - 1];
            }

            if (n % 2 != 0)
                res[n - 1] = arr[n / 2];

            return res;
        }
        public static int[] TaskV(int[] arr)
        {
            int n = arr.Length;
            int[] res = new int[n];

            int[] a = new int[n - n / 2];
            int[] b = new int[n / 2];

            for (int i = 0; i < n - n / 2; i++)
                a[i] = arr[2 * i];

            for (int i = 0; i < n / 2; i++)
                b[i] = arr[2 * i + 1];

            a = SortByDescending(a);
            b = SortByAscending(b);

            for (int i = 0; i < n - n / 2; i++)
                res[2 * i] = a[i];

            for (int i = 0; i < n / 2; i++)
                res[2 * i + 1] = b[i];

            return res;
        }

        public static int[][] MatrixInit(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Random random = new Random();
                    matrix[i][j] = random.Next(-100, 100);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[][] matrix, int n)
        {
            Console.WriteLine();
            Console.WriteLine("Matrix:");
            Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,4}", matrix[i][j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int MinValueMatrix(int[][] matrix)
        {
            int min = matrix[0][0];


            foreach (int[] array in matrix)
                foreach (int num in array)
                {
                    if (num < min)
                        min = num;
                }
            return min;
        }
        public static int MaxValueMatrix(int[][] matrix)
        {
            int max = matrix[0][0];


            foreach (int[] array in matrix)
                foreach (int num in array)
                {
                    if (num > max)
                        max = num;
                }
            return max;
        }
        public static int[][] Task2A(int[][] matrix)
        {

            int n = matrix.Length;
            int[][] res = new int[n][];
            Array.Copy(matrix, res, n);

            for (int row = 0; row < n; row++)
                for (int i = 0; i < n; i++)
                    for (int col = 0; col < n - 1; col++)
                        if (res[row][col] > res[row][col + 1])
                            res[row] = Swap(col, res[row]);

            return res;
        }

        public static int[][] Task2B(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] res = new int[n][];
            for (int i = 0; i < n; i++)
                res[i] = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i][j] = matrix[i][j];
                }
            }
            for (int col = 0; col < n; col++)
                for (int j = 0; j < n; j++)
                    for (int i = 0; i < n - 1; i++)
                        if (res[i][col] > res[i + 1][col])
                            res = SwapForMatrix(i, col, res);

            return res;

        }

        static int[][] SwapForMatrix(int i, int j, int[][] matrix)
        {

            int tmp = matrix[i][j];
            matrix[i][j] = matrix[i + 1][j];
            matrix[i + 1][j] = tmp;
            return matrix;
        }


        public static int[] MatrixToArray(int[][] matrix)
        {
            int n = matrix.Length;
            int[] res = new int[n * n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    res[i * n + j] = matrix[i][j];
            return res;
        }

        public static int[][] Task2C(int[][] matrix)
        {
            int N = matrix.Length;
            int[] arr = MatrixToArray(matrix);
            arr = SortByAscending(arr);
            int j = 0;
            int[][] res = new int[N][];
            for (int i = 0; i < N; i++)
                res[i] = new int[N];
            for (int n = 0; n < N;)
            {
                for (int i = n; i < N; i++)
                    res[n][i] = arr[j++];
                for (int i = n + 1; i < N; i++)
                    res[i][N - 1] = arr[j++];
                for (int i = N - 2; i >= n; i--)
                    res[N - 1][i] = arr[j++];
                for (int i = N - 2; i > n; i--)
                    res[i][n] = arr[j++];
                n++;
                N--;
            }
            return res;

        }
        public static int[][] Task2D(int[][] matrix)
        {
            int N = matrix.Length;
            int[] array = MatrixToArray(matrix);
            array = SortByDescending(array);
            int j = 0;
            int[][] res = new int[N][];

            for (int i = 0; i < N; i++)
                res[i] = new int[N];

            for (int n = 0; n < N;)
            {

                for (int i = N - 1; i >= n; i--)
                    res[n][i] = array[j++];

                for (int i = n + 1; i < N; i++)
                    res[i][n] = array[j++];

                for (int i = n + 1; i < N; i++)
                    res[N - 1][i] = array[j++];

                for (int i = N - 2; i > n; i--)
                    res[i][N - 1] = array[j++];

                n++;
                N--;
            }

            return res;
        }

        public static int[][] Task2E(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] res = new int[n][];
            Array.Copy(matrix, res, n);

            for (int row = 0; row < n; row++)
                for (int j = 0; j < n; j++)
                    for (int col = 0; col < n - 1; col++)
                    {
                        if (row % 2 == 0)
                        {
                            if (res[row][col] > res[row][col + 1])
                                res[row] = Swap(col, res[row]);
                        }
                        else
                        {
                            if (res[row][col] < res[row][col + 1])
                                res[row] = Swap(col, res[row]);
                        }
                    }

            return res;
        }
        public static int[][] Task2F(int[][] matrix)
        {
            int n = matrix.Length;
            int[] arr = MatrixToArray(matrix);
            arr = SortByAscending(arr);
            PrintArray(arr);
            int k = 0;
            bool f = false;
            int r = 0;
            int[][] res = new int[n][];

            for (int i = 0; i < n; i++)
                res[i] = new int[n];

            for (int j = 0; j < n; j += 2)
            {
                for (int l = 0; l < n; l += 2)
                {
                    if ((j + 2) % 4 != 0)
                    {
                        if (l != n - 1)
                        {
                            res[l][j] = arr[k++];
                            res[l][j + 1] = arr[k++];
                            res[l + 1][j + 1] = arr[k++];
                            res[l + 1][j] = arr[k++];
                        }
                        else
                        {
                            res[l][j] = arr[k++];
                            res[l][j + 1] = arr[k++];

                        }
                    }
                    else
                    {

                        if (!f)
                        {
                            l = n - 1;
                            f = true;
                        }
                        if (l != 0)
                        {
                            res[l][j] = arr[k++];
                            res[l][j + 1] = arr[k++];
                            res[l - 1][j + 1] = arr[k++];
                            res[l - 1][j] = arr[k++];
                        }
                        else
                        {
                            res[0][j] = arr[k++];
                            res[0][j + 1] = arr[k++];
                        }
                        if (l != 0)
                            l -= 4;
                        else l = n;
                    }
                }
                f = false;
                r++;
                if (r == n / 2)
                    break;
            }
            for (int h = n - 1; h >= 0; h--)
            {
                res[h][n - 1] = arr[k++];
            }

            return res;
        }

        public static int[][][] ThreeDimArrayInit(int[][][] arr, int n)
        {
            for (int z = 0; z < n; z++)
            {
                arr[z] = new int[n][];

                for (int y = 0; y < n; y++)
                {
                    arr[z][y] = new int[n];

                    for (int x = 0; x < n; x++)
                    {
                        Random random = new Random();
                        arr[z][y][x] = random.Next(-100, 100);
                    }
                }
            }
            return arr;

        }
        public static void Print3DimArray(int[][][] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Array: ");
            Console.WriteLine();
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write("< ");
                for (int y = 0; y < arr[x].Length; y++)
                {
                    Console.Write("< ");
                    for (int z = 0; z < arr[x][y].Length; z++)
                    {
                        Console.Write(String.Format("{0,4}", arr[x][y][z]));
                    }
                    Console.Write(" > ");
                }
                Console.WriteLine(" >");
            }
        }
        public static int MinValue3DimArr(int[][][] arr)
        {
            int min = arr[0][0][0];
            foreach (int[][] z in arr)
                foreach (int[] y in z)
                    foreach (int x in y)
                    {
                        if (x < min)
                            min = x;
                    }
            return min;
        }
        public static int MaxValue3DimArr(int[][][] arr)
        {
            int max = arr[0][0][0];
            foreach (int[][] z in arr)
                foreach (int[] y in z)
                    foreach (int x in y)
                    {
                        if (x > max)
                            max = x;
                    }
            return max;
        }

        public static int[][][] OX(int[][][] arr)
        {
            int n = arr.Length;
            int[][][] res = new int[n][][];
            for (int z = 0; z < n; z++)
            {
                res[z] = new int[n][];

                for (int y = 0; y < n; y++)
                {
                    res[z][y] = new int[n];

                    for (int x = 0; x < n; x++)
                    {
                        Random random = new Random();
                        res[z][y][x] = arr[z][y][x];
                    }
                }
            }
            for (int i = 0; i < n; i++)
                for (int z = 0; z < n; z++)
                    for (int y = 0; y < n; y++)
                        for (int x = 0; x < n - 1; x++)
                            if (res[z][y][x] > res[z][y][x + 1])
                                res[z][y] = Swap(x, res[z][y]);
            return res;
        }

        public static int[][][] OY(int[][][] arr)
        {
            int n = arr.Length;
            int[][][] res = new int[n][][];
            for (int z = 0; z < n; z++)
            {
                res[z] = new int[n][];

                for (int y = 0; y < n; y++)
                {
                    res[z][y] = new int[n];

                    for (int x = 0; x < n; x++)
                    {
                        Random random = new Random();
                        res[z][y][x] = arr[z][y][x];
                    }
                }
            }

            for (int i = 0; i < n; i++)
                for (int z = 0; z < n; z++)
                    for (int y = 0; y < n - 1; y++)
                        for (int x = 0; x < n; x++)
                            if (res[z][y][x] > res[z][y + 1][x])
                                res[z] = SwapForMatrixForOY(x, y, res[z]);
            return res;
        }
        static int[][] SwapForMatrixForOY(int x, int y, int[][] matrix)
        {
            int n = matrix.Length;
            int[][] res = new int[n][];
            Array.Copy(matrix, res, n);
            int tmp = res[y][x];
            res[y][x] = res[y + 1][x];
            res[y + 1][x] = tmp;

            return res;
        }
        public static int[][][] OZ(int[][][] arr)
        {
            int n = arr.Length;
            int[][][] res = new int[n][][];
            for (int z = 0; z < n; z++)
            {
                res[z] = new int[n][];

                for (int y = 0; y < n; y++)
                {
                    res[z][y] = new int[n];

                    for (int x = 0; x < n; x++)
                    {
                        Random random = new Random();
                        res[z][y][x] = arr[z][y][x];
                    }
                }
            }

            for (int i = 0; i < n; i++)
                for (int z = 0; z < n - 1; z++)
                    for (int y = 0; y < n; y++)
                        for (int x = 0; x < n; x++)
                            if (res[z][y][x] > res[z + 1][y][x])
                                res = SwapFor3Dim(x, y, z, res);

            return res;
        }
        public static int[][][] SwapFor3Dim(int x, int y, int z, int[][][] arr)
        {
            int n = arr.Length;
            int[][][] res = new int[n][][];
            Array.Copy(arr, res, n);
            int tmp = res[z][y][x];
            res[z][y][x] = res[z + 1][y][x];
            res[z + 1][y][x] = tmp;

            return res;
        }

        public static int[] WithoutDuplicates(int[] arr)
        {
            int[] number = new int[100];

            for (int i = 0; i < arr.Length; i++)
                number[arr[i]]++;

            int n = 0;
            for (int i = 0; i < 11; i++)
                if (number[i] > 0)
                    n++;

            int[] res = new int[n];
            int r = 0;
            for (int i = 0; i < 11; i++)
                if (number[i] > 0)
                    res[r++] = i;

            return res;
        }
        public static int[] Disjunction(int[] a, int[] b)
        {
            int n1 = a.Length;
            int n2 = b.Length;
            int[] res = new int[n1 + n2];

            for (int i = 0; i < n1; i++)
                res[i] = a[i];

            for (int i = 0; i < n2; i++)
                res[n1 + i] = b[i];

            res = WithoutDuplicates(res);
            return res;
        }

        public static int[] Conjunction(int[] a, int[] b)
        {
            int[] wda = WithoutDuplicates(a);
            int[] wdb = WithoutDuplicates(b);

            int n = 0;
            int[] res = new int[11];

            for (int i = 0; i < wda.Length; i++)
                for (int j = 0; j < wdb.Length; j++)
                    if (wda[i] == wdb[j])
                    {
                        res[n++] = wda[i];
                        break;
                    }

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
                result[i] = res[i];

            return result;
        }

        public static int[] Complement(int[] a, int[] universum)
        {
            return Difference(universum, a);
        }

        public static int[] Difference(int[] a, int[] b)
        {
            a = WithoutDuplicates(a);
            b = WithoutDuplicates(b);
            int n = a.Length;

            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                    {
                        a[i] = -1;
                        n--;
                        break;
                    }

            int[] res = new int[n];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] >= 0)
                    res[k++] = a[i];
            return res;

        }

        public static int[] SymmetricalDifference(int[] a, int[] b)
        {
            int[] disjunction = Disjunction(a, b);
            int[] conjunction = Conjunction(a, b);
            return Difference(disjunction, conjunction);
        }



        static void Main(string[] args)
        {

            int n = 200;
            Console.WriteLine("N= " + n);
            int[] arr = new int[n];
            Random random = new Random();
            ArrayInit(arr);
            PrintArray(arr);
            Console.WriteLine("\nMin value: " + MinValue(arr));
            Console.WriteLine("\nMax value: " + MaxValue(arr));
            Console.WriteLine();
            Console.WriteLine("Sorted by ascending: ");
            PrintArray(SortByAscending(arr));
            Console.WriteLine();
            Console.WriteLine("Sorted by descending: ");
            PrintArray(SortByDescending(arr));
            Console.WriteLine();
            Console.WriteLine("Max value in the center and descending values on the sides: ");
            PrintArray(TaskAa(arr));
            Console.WriteLine();
            Console.WriteLine("Min value in the center and ascending values on the sides: ");
            PrintArray(TaskAb(arr));
            Console.WriteLine();
            Console.WriteLine("Max, min, max, min ... : ");
            PrintArray(TaskB(arr));
            Console.WriteLine();
            Console.WriteLine("even - descending, odd - ascending: ");
            PrintArray(TaskV(arr));
            Console.WriteLine();
            Console.WriteLine("TASK2");

            n = 15;
            int[][] matrix = new int[n][];

            MatrixInit(matrix, n);
            PrintMatrix(matrix, n);
            Console.WriteLine("\nMin value: " + MinValueMatrix(matrix));
            Console.WriteLine("\nMax value: " + MaxValueMatrix(matrix));
            Console.WriteLine();
            Console.WriteLine("Task2 A: ");
            PrintMatrix(Task2A(matrix), n);
            Console.WriteLine();
            Console.WriteLine("Task2 B: ");
            PrintMatrix(Task2B(matrix), n);
            Console.WriteLine();
            Console.WriteLine("Task2 C: ");
            PrintMatrix(Task2C(matrix), n);
            Console.WriteLine();
            Console.WriteLine("Task2 D: ");
            PrintMatrix(Task2D(matrix), n);
            Console.WriteLine();
            Console.WriteLine("Task2 E: ");
            PrintMatrix(Task2E(matrix), n);
            Console.WriteLine();
            Console.WriteLine("Task2 F: ");
            PrintMatrix(Task2F(matrix), n);

            Console.WriteLine("TASK3");
            n = 6;
            int[][][] arr3 = new int[n][][];
            ThreeDimArrayInit(arr3, n);
            Print3DimArray(arr3);
            Console.WriteLine("\nMin value: " + MinValue3DimArr(arr3));
            Console.WriteLine("\nMax value: " + MaxValue3DimArr(arr3));
            Console.WriteLine("OX Sort: ");
            Print3DimArray(OX(arr3));
            Console.WriteLine("OY Sort: ");
            Print3DimArray(OY(arr3));
            Console.WriteLine("OZ Sort: ");
            Print3DimArray(OZ(arr3));

            Console.WriteLine();
            Console.WriteLine("Task 4: ");

            int n1 = 8;
            int n2 = 5;
            int[] A = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Random randomA = new Random();
                A[i] = randomA.Next(0, 10);
            }

            int[] B = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Random randomB = new Random();
                B[i] = randomB.Next(0, 10);
            }
            Console.WriteLine("\nArrays:");
            Console.WriteLine("Array A:");
            PrintArray(A);
            Console.WriteLine("Array B:");
            PrintArray(B);
            Console.WriteLine("\nArrays without duplicates:");
            Console.WriteLine("Array A:");
            PrintArray(WithoutDuplicates(A));
            Console.WriteLine("Array B:");
            PrintArray(WithoutDuplicates(B));
            Console.WriteLine("\nDisjunction: ");
            PrintArray(Disjunction(A, B));
            Console.WriteLine("\nConjuction: ");
            PrintArray(Conjunction(A, B));
            int[] universum = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nComplement A: ");
            PrintArray(Complement(A, universum));

            Console.WriteLine("\nDifference A\\B: ");
            PrintArray(Difference(A, B));
            Console.WriteLine("\nSymmetrical Difference: ");
            PrintArray(SymmetricalDifference(A, B));


        }
    }
}
