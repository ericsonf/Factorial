namespace Factorial;

public static class Factorial
{
    public static ulong Calculate(uint number) => number <= 1 ? 1 : number * Calculate(number - 1);
}