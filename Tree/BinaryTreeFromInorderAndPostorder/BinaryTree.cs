using Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeFromInorderAndPostorder
{
    public static class BinaryTree
    {
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder == null || postorder == null) return null;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
            {
                map.Add(inorder[i], i);
            }
            //Array.Reverse(postorder);
            TreeNode root = BuildTreeNode(postorder, postorder.Length - 1, inorder, 0, inorder.Length - 1, map);
            return root;
        }

        private static TreeNode BuildTreeNode(int[] postorder, int postStart,
            int[] inOrder, int inStart, int inEnd, Dictionary<int, int> map)
        {
            if (postStart < 0 || inStart > inEnd) return null;

            TreeNode root = new TreeNode(postorder[postStart]);

            int inRootIndex = map[root.val];
            int countToInEnd = inEnd - inRootIndex;

            root.right = BuildTreeNode(postorder, postStart - 1,
                                        inOrder, inRootIndex + 1, inEnd, map);
            root.left = BuildTreeNode(postorder, postStart - countToInEnd - 1,
                                        inOrder, inStart, inRootIndex - 1, map);

            return root;
        }
    }
}
