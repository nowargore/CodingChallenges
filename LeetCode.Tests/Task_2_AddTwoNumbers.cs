using System.Collections.Generic;
using Xunit;
using ListNode = LeetCode.Task_2_AddTwoNumbers.ListNode;

#nullable disable

namespace LeetCode.Tests;

public class Task_2_AddTwoNumbers
{
    [Fact]
    public void Test1()
    {
        var result = LeetCode.Task_2_AddTwoNumbers.AddTwoNumbers(
            ToLinkedList(new[] { 2, 4, 3 }),
            ToLinkedList(new[] { 5, 6, 4 }));

        Assert.Equal(new[] { 7, 0, 8 }, ToArray(result));
    }

    [Fact]
    public void Test2()
    {
        var result = LeetCode.Task_2_AddTwoNumbers.AddTwoNumbers(
            ToLinkedList(new[] { 0 }),
            ToLinkedList(new[] { 0 }));

        Assert.Equal(new[] { 0 }, ToArray(result));
    }

    [Fact]
    public void Test3()
    {
        var result = LeetCode.Task_2_AddTwoNumbers.AddTwoNumbers(
            ToLinkedList(new[] { 9, 9, 9, 9, 9, 9, 9 }),
            ToLinkedList(new[] { 9, 9, 9, 9 }));

        Assert.Equal(new[] { 8, 9, 9, 9, 0, 0, 0, 1 }, ToArray(result));
    }

    public ListNode ToLinkedList(int[] arr)
    {
        ListNode startNode = null, curNode = null;

        for (int i = 0; i < arr.Length; i++)
        {
            if (curNode == null)
            {
                curNode = startNode = new ListNode();
            }
            else
            {
                curNode.next = new ListNode();
                curNode = curNode.next;
            }

            curNode.val = arr[i];
        }

        return startNode;
    }

    public int[] ToArray(ListNode startNode)
    {
        var result = new List<int>();

        do
        {
            result.Add(startNode.val);
            startNode = startNode.next;
        } while (startNode != null);

        return result.ToArray();
    }
}
