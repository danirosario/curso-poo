using System;
using System.Collections.Generic;

namespace Generics.Services
{
    internal class CalculationService
    {
        public T Max<T> (List<T> list) where T : IComparable // T must implement IComparable interface // to be able to compare the elements and find the maximum value
        {
            if (list == null)
            {
                throw new ArgumentNullException ("list");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo (max) > 0) // CompareTo method returns a value less than zero if the current instance is less than the object being compared,
                                                 // zero if they are equal, and a value greater than zero if the current instance is greater than the object being compared.
                                                 // So if list[i] is greater than max, it will return a value greater than zero, and we will update max to be list[i].
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
