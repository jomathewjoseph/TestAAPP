using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestAAPP.Data
{
    public class FibonociService : IFibonoci
    {
        public ulong totalAmount { get; set; }
        public ulong lengthOftheSeries { get; set; }
        private  IFibonoci _fibonoci;
        public FibonociService()
        {
            //fibArray = new List<ulong>();
        }
        public async IAsyncEnumerable<ulong> GenarateNumber(IFibonoci Fib)
        {
            _fibonoci = Fib;
            ulong firstNumber = 0;
            ulong secondNumber = 1;
            ulong thirdNumber = 0;
            for (ulong i = 1; i <= _fibonoci.lengthOftheSeries; i++)
            {
                thirdNumber =firstNumber +secondNumber;
                firstNumber =secondNumber;
                secondNumber =thirdNumber;
                SumtheSeries( thirdNumber, new EvenElementsSum());
                //SumtheSeries(_Fib, thirdNumber, new OddElementSum());
                //SumtheSeries(_Fib, thirdNumber, new MathOperation());
                await Task.Delay(200);
                yield return thirdNumber;
            }
        }
        private void SumtheSeries( ulong currentItem, IMathOperation ob)
        {
            ob.SumtheSeries(_fibonoci, currentItem);
        }
        public ulong GettheSumoftheSeries()
        {
           return _fibonoci.totalAmount;
        }
    }
}
