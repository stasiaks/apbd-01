namespace Pjatk.Apbd;

public static class Exercise
{
    /// <summary> Wszyscy kochaja pisać własne, gorsze wersje System.Linq.Enumerable.Average </summary>
    public static double Average(int[] values) => (double)values.Sum() / values.Length;
}
