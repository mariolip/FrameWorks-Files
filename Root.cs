namespace MyRootLib;
    public class Root
    {
        /// <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double MyProduct(double number1, double number2) {
            double product;
            product = (number1 * number2);

            Console.WriteLine("The product of " + number1 + " and " + number2 + " is " + product);
            return product;
        }
    }
