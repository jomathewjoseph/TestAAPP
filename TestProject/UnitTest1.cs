using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestAAPP.Data;
using TestApp;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase((ulong)3)]
        [TestCase((ulong)5)]
        public async Task TestPattern(ulong limit)
        {
            ulong[] fibActualArray;
            FibonociService objFibonociService = new FibonociService();
            objFibonociService.lengthOftheSeries = limit;
            ulong total = 0;
            if(limit==3)
            {
                fibActualArray = new ulong[3] { 1, 2, 3 };
                total = 2;
            }
           else if(limit == 5)
            {
                fibActualArray = new ulong[5] { 1, 2, 3, 5, 8 };
                total = 10;
            }
            else 
            {
                fibActualArray = new ulong[1] { 1 };
                total = 0;

            }
            ulong[] fibResultArray = new ulong[limit];
            ulong loopCount = 0;
            await foreach(var item in objFibonociService.GenarateNumber(objFibonociService))
            {
                fibResultArray[loopCount] = item;
                Assert.AreEqual(fibActualArray[loopCount], fibResultArray[loopCount]);
             
                loopCount++;
            }
            Assert.AreEqual(total, objFibonociService.GettheSumoftheSeries());
        }
    }
}