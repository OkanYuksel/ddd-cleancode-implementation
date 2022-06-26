namespace OrderX.Domain.Core;

public static class Guard
{
    // public static void Contains<T>(IEnumerable<T> collection, Func<T, bool> predicate, string message = "");
    // public static void Equal<T>(T left, T right, string message = "Values must be equal");
    // public static void Items<T>(IEnumerable<T> collection, Func<T, bool> predicate, string message = "");
    // public static void Not<TException>(bool condition, string message = "") where TException : Exception;
    // public static void Not(bool condition, string message = "");
    // public static void NotEqual<T>(T left, T right, string message = "Values must not be equal");
    // public static void NotNull(object value, string message = "");
    // public static void NotNullOrEmpty(string value, string message = "String cannot be null or empty");
    // public static void That(bool condition, string message = "");
    // public static void That(bool condition, string code = "", string message = "");
    // public static void That<TException>(bool condition, string message = "") where TException : Exception;

    public static void That<TException>(bool condition, string code = "", string message = "",
        string userFriendlyMessage = "")
    {
        throw new NotImplementedException();
    }

    // public static void ThatWithFunc<TException>(bool condition, string code = "", string message = "",
    //     Func<Task<string>> userFriendlyMessageFunc = null) where TException : Exception;
    //
    // public static class Argument
    // {
    //     public static void Is(bool condition, string message = "");
    //     public static void IsNot(bool condition, string message = "");
    //     public static void NotNull(object value, string paramName = "");
    //     public static void NotNullOrEmpty(string value, string paramName = "");
    // }
}