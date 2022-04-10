namespace TestAAPP.Data
{
    public class EvenElementsSum : IMathOperation
    {
        public IFibonoci SumtheSeries(IFibonoci ob,ulong currentItem)
        {
            if (currentItem % 2 == 0)
            {
                ob.totalAmount = currentItem + ob.totalAmount;
            }
            return ob;
        }
    }
}
