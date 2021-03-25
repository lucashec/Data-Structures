namespace avl
{
    public class CompareTrees
    {
    public bool equalTrees(BinarySearchTree t1, BinarySearchTree t2){
    return verifyNodes(t1.root, t2.root);
}
public bool verifyNodes(Node a, Node b){
   
        if (a == null && b == null) 
        { 
            return true; 
        } 

        if (a != null && b != null) 
        { 
            return (a.key == b.key && verifyNodes(a.left, b.left) && verifyNodes(a.right, b.right)); 
        } 
  
        return false; 
}
    }
}