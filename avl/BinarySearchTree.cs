namespace avl

{using System;
    public class BinarySearchTree
    {
        public Node root;
  static readonly int count = 10;

  public void insert(int value, Node current){
    if(current == null){
      root = new Node(value);

    } else if (value < current.key){
      if (current.left == null){
        current.left = new Node(value);
      
      } else {
        insert(value, current.left);
      }
    } else if (value > current.key){
      if (current.right == null){
        current.right = new Node(value);
      } else{
        insert(value, current.right);
      }
    }
  }
  public Node search(int value, Node current){
    if(current == null){
      return null;
    }
    if(current.key == value){
      return current;
    }
    if(current.key > value){
      return search(value, current.left);
    }
    if(current.key < value){
      return search(value, current.right);
    }
    return null;
  }
  
  public void removeKey(int key){
    root = removeNode(root, key);
  }

  public Node removeNode(Node current, int key){
    if (current == null){
      return current;
    }

    if(key < current.key){
      current.left = removeNode(current.left, key);
    
    }else if(key > current.key){
      current.right = removeNode(current.right, key);
    
    }else{
      if(current.left == null){
        return current.right;
      
      }else if(current.right == null){
        return current.left;
      }

      current.key = minValue(current.right);
      current.right = removeNode(current.right, current.key);
    }
    return current;
  }
  
  public bool isLeaf(int key){
    Node current = search(key, root);
    if(current.left == null && current.right == null){
      return true;
    }
    return false;
  }

  public void preOrder(Node current){
    Console.WriteLine(" "+current.key);
    if (current.left != null){
      preOrder(current.left);
    }
    if (current.right != null){
      preOrder(current.right);
    }
  }

  public void inOrder(Node current){
    if(current.left != null){
      inOrder(current.left);
    }
    Console.WriteLine(" "+current.key);
    if(current.right != null){
      inOrder(current.right);
    }
  }
  public void postOrder(Node current){
    if(current.left != null){
      postOrder(current.left);
    }
    if(current.right != null){
      postOrder(current.right);
    }
    Console.WriteLine(" "+current.key);
  }

  public int minValue(Node current){
    int min = current.key;

    while (current.left != null){
      min = current.left.key;
      current = current.left;
    }
    return min;
  }
  public int maxValue(Node current){
    int max = current.key;

    while (current.right != null){
      max = current.right.key;
      current = current.right;
    }
    return max;
  }
  public int depth(Node current){
    if(current == null){
      return 0;
    } 
      int leftDepth = depth(current.left);
      int rightDepth = depth(current.right);

      if(leftDepth > rightDepth)
        return (leftDepth+1);
      else 
        return (rightDepth+1);
    

  }
public static void setDisplay(Node current, int space)  
{    
    if (current == null)  
        return;    
    space += count;  
   
    setDisplay(current.right, space);  

    Console.Write("\n");  
    for (int i = count; i < space; i++)  
        Console.Write(" ");  
    Console.Write(current.key + "\n");  
  
    setDisplay(current.left, space);  
}  
public void print(Node current){
  setDisplay(root, 0);
}
    }
}