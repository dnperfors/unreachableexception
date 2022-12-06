using System.Diagnostics;
using Xunit;

namespace System.Tests;

public static class UnreachableExceptionTests
{
    [Fact]
    public static void DefaultConstructor()
    {
        UnreachableException unreachableException = new();

        Assert.Equal("The program executed an instruction that was thought to be unreachable.", unreachableException.Message);
    }

    [Fact]
    public static void MessageConstructor()
    {
        string message = "MessageConstructor";
        UnreachableException unreachableException = new(message);

        Assert.Equal(message, unreachableException.Message);
    }

    [Fact]
    public static void MessageInnerExceptionConstructor()
    {
        string message = "MessageConstructor";
        InvalidCastException innerException = new();
        UnreachableException unreachableException = new(message, innerException);

        Assert.Equal(message, unreachableException.Message);
        Assert.Same(innerException, unreachableException.InnerException);
    }
}
