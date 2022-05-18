namespace generics
{
    public class ClsMain
    {
        private static void Main()
        {
           // bool IsEqual = ClsCalculator.AreEqual(10, 20);
           // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
            bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
            Console.ReadKey();
        }
    }
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(string value1, string value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(double value1, double value2)
        {
            return value1 == value2;
        }
    }
}