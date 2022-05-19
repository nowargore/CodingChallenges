using Xunit;

namespace LeetCode.Tests;

public class Task_1_TwoSum
{
    [Fact]
    public void Test1()
    {
        var result = LeetCode.Task_1_TwoSum.TwoSum(new[] { 2, 7, 11, 15 }, 9);

        Assert.Contains(0, result);
        Assert.Contains(1, result);
    }

    [Fact]
    public void Test2()
    {
        var result = LeetCode.Task_1_TwoSum.TwoSum(new[] { 3, 2, 4 }, 6);

        Assert.Contains(1, result);
        Assert.Contains(2, result);
    }

    [Fact]
    public void Test3()
    {
        var result = LeetCode.Task_1_TwoSum.TwoSum(new[] { 3, 3 }, 6);

        Assert.Contains(0, result);
        Assert.Contains(1, result);
    }
}
