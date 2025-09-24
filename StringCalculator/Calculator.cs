namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            string numberSeparator = ",";
            string newNumbers = numbers;

            if (newNumbers.StartsWith("//"))
            {
                int delimiterEndIndex = newNumbers.IndexOf('\n');

                numberSeparator = newNumbers.Substring(2, delimiterEndIndex - 2);
                newNumbers = newNumbers.Substring(delimiterEndIndex + 1);
            }

            string[] splitNumbers;

            if (numbers.StartsWith("//"))
            {
                splitNumbers = newNumbers.Split(new string[] { numberSeparator }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                splitNumbers = newNumbers.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            }

            List<int> negativeNumbers = new List<int>();

            int sum = 0;

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                int number = int.Parse(splitNumbers[i]);

                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }

                sum += number;
            }

            if (negativeNumbers.Count > 0)
            {
                string message = "Negatives not allowed: ";

                foreach (var item in negativeNumbers)
                {
                    message += item + " ";
                }

                throw new ArgumentException(message);
            }

            return sum;
        }
    }
}
