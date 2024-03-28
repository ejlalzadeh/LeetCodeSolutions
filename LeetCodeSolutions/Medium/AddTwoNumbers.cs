namespace LeetCodeSolutions.Medium;

public class AddTwoNumbersSolution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode currentNode = result;
        var d = 0;

        while (l1 is not null || l2 is not null || d != 0)
        {
            var sum = d;
            d = 0;

            if (l1 is not null)
                sum += l1.val;
            if (l2 is not null)
                sum += l2.val;

            if (sum >= 10)
            {
                currentNode.val = sum - 10;
                d++;
            }
            else
            {
                currentNode.val = sum;
            }

            l1 = l1 is not null ? l1.next : l1;
            l2 = l2 is not null ? l2.next : l2;

            currentNode.next = l1 is null && l2 is null && d == 0 ? null : new ListNode();
            currentNode = currentNode.next;
        }

        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}