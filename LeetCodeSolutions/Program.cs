using LeetCodeSolutions.Easy;
using LeetCodeSolutions.Medium;

ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

ListNode l3 = new ListNode(9, null);

ListNode l4 = new ListNode(9,
        new ListNode(9,
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9, null)))))));



ReverseLinkedListSolution.ReverseList(l2);