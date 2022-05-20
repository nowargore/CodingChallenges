using Xunit;

namespace Other.Tests;

public class Task_1_restore_splitted_array
{
    [Fact]
    public void Test1()
    {
        var result = Other.Task_1_restore_splitted_array.RestoreSplittedArray(new[] { 15, 56, 1, 7, 9 });

        Assert.Equal(result, new[] { 1, 7, 9, 15, 56 });
    }

    [Fact]
    public void Test2()
    {
        var result = Other.Task_1_restore_splitted_array.RestoreSplittedArray(new[] { 2, 3, 4 });

        Assert.Equal(result, new[] { 2, 3, 4 });

    }

    [Fact]
    public void Test3()
    {
        var result = Other.Task_1_restore_splitted_array.RestoreSplittedArray(new[] { 5, 3 });

        Assert.Equal(result, new[] { 3, 5 });
    }
}
