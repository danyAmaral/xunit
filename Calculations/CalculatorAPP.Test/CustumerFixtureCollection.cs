using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorAPP.Test
{
    [CollectionDefinition("Customer")]
    public class CustumerFixtureCollection: ICollectionFixture<CustomerFixture>
    {

    }
}
