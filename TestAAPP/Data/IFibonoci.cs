using System.Collections.Generic;

namespace TestAAPP.Data
{
    public interface IFibonoci
    {
        //public  List<ulong> fibArray { get; set; }
        public ulong lengthOftheSeries { get; set; }
        public ulong totalAmount { get; set; }
        public IAsyncEnumerable<ulong> GenarateNumber(IFibonoci Fib);
        public ulong GettheSumoftheSeries();

    }
}
