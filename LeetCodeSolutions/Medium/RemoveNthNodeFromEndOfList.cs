namespace LeetCodeSolutions.Medium;

public class RemoveNthNodeFromEndOfListSolution
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next is null && n == 1)
            return null!;

        ListNode? node = head;
        ListNode? prevNode = null;

        while (node is not null)
        {
            ListNode? pointerNode = node;

            for (int i = 1; i <= n - 1; i++)
            {
                pointerNode = pointerNode!.next;
            }

            if (pointerNode!.next is not null)
            {
                prevNode = node;
                node = node.next;
            }
            else
            {
                if (prevNode is null)
                    return node.next!;
                else
                    prevNode.next = node.next;

                break;
            }
        }

        return head;
    }
}