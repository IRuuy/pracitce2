namespace practice2b
{
    class Programm
    {
        public static void Main()
        {
            Console.WriteLine(DoOperation(Operation.DIVISION, 2, 1));
            Console.WriteLine(DoOperation(Operation.POW, 2, 3));
            Console.WriteLine(DoOperation(Operation.SQRT, 4, 1));
        }
        public static int DoOperation(Operation op, int a, int b) => op switch
        {
            Operation.DIVISION => (b != 0) ? a / b : throw new DivideByZeroException(),
            Operation.POW => (int)Math.Pow((double)a, (double)b),
            Operation.SQRT => (int)Math.Sqrt((double)a),
            _ => throw new NotImplementedException(),
        };

    }
}