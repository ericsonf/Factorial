namespace Factorial
{
    public class Factorial
    {
        public ulong Calculate(uint number) => number <= 1 ? 1 : number * Calculate(number - 1);
    }
}
