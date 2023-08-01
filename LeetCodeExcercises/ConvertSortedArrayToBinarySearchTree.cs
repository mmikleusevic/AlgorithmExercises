namespace LeetCodeExcercises
{
    public static class ConvertSortedArrayToBinarySearchTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArraryToBST(nums, 0, nums.Length);
        }

        private static TreeNode SortedArraryToBST(int[] nums, int l, int r)
        {
            if (l >= r) return null;
            var mid = l + (r - l) / 2;

            var node = new TreeNode(nums[mid]);
            node.left = SortedArraryToBST(nums, l, mid);
            node.right = SortedArraryToBST(nums, mid + 1, r);
            return node;
        }
    }
}
