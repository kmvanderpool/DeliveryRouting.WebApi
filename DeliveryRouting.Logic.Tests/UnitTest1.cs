using System;
using System.Threading.Tasks;
using Xunit;

namespace DeliveryRouting.Logic.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            //Arrange
            var router = new Router();

            //Act
            await router.DoRouting();

            //Asert
            Console.Write("did stuff");
        }
    }
}
