namespace TestAAPP.Data
{
    public class MathOperation : IMathOperation
    {
        public IFibonoci SumtheSeries(IFibonoci ob, ulong currentItem)
        {

            ob.totalAmount = ob.totalAmount+ currentItem;
            return ob;
        }
    }
}
