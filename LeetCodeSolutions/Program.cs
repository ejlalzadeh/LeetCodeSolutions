using LeetCodeSolutions.Medium;

ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ListNode head2 = new ListNode(1, new ListNode(2));

Console.WriteLine(RemoveNthNodeFromEndOfListSolution.RemoveNthFromEnd(head2, 2));



