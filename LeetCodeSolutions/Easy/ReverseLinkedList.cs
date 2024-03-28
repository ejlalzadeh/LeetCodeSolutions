using LeetCodeSolutions.Medium;

namespace LeetCodeSolutions.Easy;

public class ReverseLinkedListSolution
{
    public static ListNode ReverseList(ListNode head)
    {
        if (head is null)
            return null;

        List<int> values = new();

        while (head is not null)
        {
            values.Add(head.val);
            head = head.next;
        }


        ListNode reversed = new();
        ListNode currentNode = reversed;

        for (int i = values.Count - 1; i >= 0; i--)
        {
            currentNode.val = values[i];
            currentNode.next = i == 0 ? null : new ListNode();
            currentNode = currentNode.next;
        }

        return reversed;
    }
}