namespace eu.sig.training.ch04
{
    public class Money
    {
        private decimal value = 0;

        public Money(decimal value)
        {
            this.value = value;
        }

        public bool GreaterThan(int limit)
        {
            return value > limit;
        }
    }
}
