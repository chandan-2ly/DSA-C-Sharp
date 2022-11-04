using Node;

namespace BinaryTreeFromInorderAndPostorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder = new int[] { 9, 15, 7, 20, 3 };

            TreeNode root = BinaryTree.BuildTree(inorder, postorder);

        }
    }
}