namespace Pjatk.Apbd;

public static class Exercise
{
    /// <summary> Wszyscy kochają pisać własne, gorsze wersje System.Linq.Enumerable.Average </summary>
    public static double Average(int[] values) => (double)values.Sum() / values.Length;

    /// <summary> Wszyscy kochają pisać własne, gorsze wersje System.Linq.Enumerable.Max </summary>
    public static int Max(int[] values) => values.Aggregate((acc, next) => acc > next ? acc : next);
}
