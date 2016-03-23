using System.Collections.Generic;

namespace Test_task_2
{
    public static class IntegerExtensions
    {
        public static List<int> GetListOfDividers(this int number)
        {
            List<int> listDividers = new List<int> { 1 };

            for (int i = 2;  i < number; i++)
            {
                if (number % i == 0)
                {
                    listDividers.Add(i);
                }
            }
            listDividers.Add(number);
            return listDividers;
        }
    }
}
