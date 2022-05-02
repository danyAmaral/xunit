using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPP.Test
{
    public static class TestDataShare
    {
        public static IEnumerable<Object[]> IsOddOrEvenData
        {
            get
            {
                yield return new Object[] { 1, true };
                yield return new Object[] { 2, false };
            }
        }
    }
}
