public class Node
{
    public int Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(int data)
    {
        this.Data = data;
    }

    // Problem 1: Insert a value into the binary search tree
public void Insert(int value)
{
    if (value < Data)
    {
        if (Left is null)
            Left = new Node(value);
        else
            Left.Insert(value);
    }
    else if (value > Data)
    {
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
}


    // Problem 2: Check if a value exists in the tree
    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left == null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            if (Right == null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    // Problem 4: Get the height of the tree
    public int GetHeight()
    {
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
