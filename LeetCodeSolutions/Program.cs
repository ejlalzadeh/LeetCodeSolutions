


using LeetCodeSolutions.Medium;

TreeNode root = new TreeNode(5, new TreeNode(4, null, null), new TreeNode(6, new TreeNode(3, null, null), new TreeNode(7, null, null)));

var root2 = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));

Console.WriteLine(ValidateBinarySearchTreeSolution.IsValidBST(root2));
