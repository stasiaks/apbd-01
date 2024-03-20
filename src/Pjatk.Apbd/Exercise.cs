namespace Pjatk.Apbd;

public static class Exercise
{
    /// <summary> Wszyscy kochają pisać własne, gorsze wersje System.Linq.Enumerable.Average </summary>
    public static double Average(int[] values) =>
        values.Aggregate(0d, (acc, next) => acc + next) / values.Count();

    /// <summary> Wszyscy kochają pisać własne, gorsze wersje System.Linq.Enumerable.Max </summary>
    public static int Max(int[] values) => values.Aggregate((acc, next) => acc > next ? acc : next);
}
