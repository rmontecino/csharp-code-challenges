namespace CodeChallenges.TreesAndGraphs
{
    public class BinaryTreesDFS
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MinDepth(root.left);
            int right = MinDepth(root.right);

            if (left == 0 || right == 0)
            {
                return left + right + 1;
            }

            return 1 + Math.Min(left, right);
        }

        public static int MaxAncestorDiff(TreeNode root)
        {
            return MaxAncestorDiff(root, root.val, root.val);
        }

        private static int MaxAncestorDiff(TreeNode node, int min, int max)
        {
            if (node == null)
            {
                return max - min;
            }

            max = Math.Max(max, node.val);
            min = Math.Min(min, node.val);

            int left = MaxAncestorDiff(node.left, min, max);
            int right = MaxAncestorDiff(node.right, min, max);

            return Math.Max(left, right);
        }
    }
}