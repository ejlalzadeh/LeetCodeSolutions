


using LeetCodeSolutions.Medium;

TreeNode root = new TreeNode(5, new TreeNode(4, null, null), new TreeNode(6, new TreeNode(3, null, null), new TreeNode(7, null, null)));

var root2 = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));

var root3 = new TreeNode(2, new TreeNode(1, new TreeNode(7, new TreeNode(6), new TreeNode(4)), new TreeNode(4, new TreeNode(7), null)), new TreeNode(4, new TreeNode(8), new TreeNode(3)));


Console.WriteLine(ValidateBinarySearchTreeSolution.IsValidBST(root3));
Console.WriteLine(ValidateBinarySearchTreeSolution.IsValidBSTOthersSolution(root3));