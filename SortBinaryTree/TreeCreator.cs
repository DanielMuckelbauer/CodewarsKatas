namespace SortBinaryTree;

public static class TreeCreator
{
    public static Node CreateTree()
    {
        var level41 = new Node(null, null, 7);
        var level33 = new Node(null, null, 6);
        var level32 = new Node(null, null, 5);
        var level31 = new Node(level41, null, 4);
        var level22 = new Node(level33, null, 3);
        var level21 = new Node(level31, level32, 2);
        return new(level21, level22, 1);
    }
}