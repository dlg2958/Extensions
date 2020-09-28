using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class DelegateTutorial
    {
        delegate int Numbers(int[] numbers);
        public DelegateTutorial()
        {
            int[] numbers = { 42, 7, 14, 63, 21, 70, 49, 28, 35, 56 };
            Numbers code = SumTheNumbers;
            int total = code(numbers);

            code = MaximumNumber;
            int max = code(numbers);

            code = delegate (int[] nums) { return nums[0]; };
            int first = code(numbers);

            Console.WriteLine($"The total is {total}");
            Console.WriteLine($"The largest number is {max}");
            Console.WriteLine($"The first number is {first}");
        }

        private int MaximumNumber(int[] numbers)
        {
            var max = int.MinValue;
            foreach (var num in numbers)
                if (num > max)
                    max = num;
            return max;
        }
        private int SumTheNumbers(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
                total += num;
            return total;
        }
    }
}
