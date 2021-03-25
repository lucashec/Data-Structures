namespace avl
{
    public class Node{
public int key;
public Node parent;
public Node left;
public Node right;

public Node(int k){
    key = k;
    left = null;
    right = null;
    }
public override string ToString(){
    return $"{key}";
  }
}
}