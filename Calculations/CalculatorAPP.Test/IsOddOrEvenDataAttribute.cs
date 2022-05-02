using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace CalculatorAPP.Test
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
     
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, true };
            yield return new object[] { 2, false };
        }
    }
}
