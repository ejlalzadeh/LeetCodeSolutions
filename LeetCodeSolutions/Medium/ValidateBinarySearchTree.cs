﻿namespace LeetCodeSolutions.Medium;

public class ValidateBinarySearchTreeSolution
{
    public static bool IsValidBST(TreeNode root)
    {
        return Validate(root, new List<int>(), new List<int>());

        bool Validate(TreeNode node, List<int> greaterThanList, List<int> lessThanList)
        {
            TreeNode? left = node.left;
            TreeNode? right = node.right;

            if (greaterThanList.Any(x => node.val <= x) || lessThanList.Any(x => node.val >= x))
                return false;

            bool result = true;

            if (left is not null)
            {
                lessThanList.Add(node.val);

                result = Validate(left, greaterThanList, lessThanList);
                lessThanList.Remove(node.val);
            }

            if (right is not null && result)
            {
                greaterThanList.Add(node.val);

                result = Validate(right, greaterThanList, lessThanList);
                greaterThanList.Remove(node.val);
            }

            return result;
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}