namespace avl

{
using System;
    public class AVLTree1
    {
      public NodeAVL root;
      static readonly int count = 10;

    public void leftRotate(NodeAVL current){
        NodeAVL temp = current.right; 
        current.right = temp.left;

    if(temp.left != null){
        temp.left.parent = current;
    }
    temp.parent = current.parent;
    if (current.parent == null) {
      root = temp;
    } else if (current == current.parent.left){
       current.parent.left = temp;
    } else {
        current.parent.right = temp;
    }
    temp.left = current;
    current.parent = temp;

    current.bf = (current.bf - 1) - Math.Max(0, temp.bf);
    temp.bf = (temp.bf - 1) + Math.Min(0, current.bf);
    }

    public void rightRotate(NodeAVL current){
        NodeAVL temp = current.right; 
        current.left = temp.right;

    if (temp.right != null){
        temp.right.parent = current;
    }
    temp.parent = current.parent;
    if (current.parent == null){
        root = temp;
    } else  if ( current == current.parent.right){
        current.parent.right = temp; 
    } else {
        current.parent.left = temp;
    }
    temp.right = current;
    current.parent = temp;

    current.bf = (current.bf + 1) - Math.Min(0, temp.bf);
    temp.bf = (temp.bf + 1) - Math.Max(0, current.bf);
    }

    public void insert(int value){
    //  if(current == null){
    //   root = new NodeAVL(value);

    // } else if (value < current.key){
    //   if (current.left == null){
    //     current.left = new NodeAVL(value);
      
    //   } else {
    //     insert(value, current.left);
    //   }
    // } else if (value > current.key){
    //   if (current.right == null){
    //     current.right = new NodeAVL(value);
    //   } else{
    //     insert(value, current.right);
    //   }
    // }   Console.WriteLine("balanceando");
    //    updateBF(current);
    // 
        NodeAVL current = new NodeAVL(value);
        NodeAVL aux = null; //y
        NodeAVL temp = root; //x

    while (temp != null){
        aux = root;
         if (current.key < temp.key){
            temp = temp.left;
    }    else {
            temp = temp.right;
    }
        
    }
    current.parent = aux;
     if (aux == null){
         root = current;
    } else if (current.key < aux.key) {
        aux.left = current; 
    } else {
        aux.right = current;
    }
        balance(current);
    }


    public void balance(NodeAVL current){
     if(current == null) return;
     if(current.bf > 0){
        if (current.right.bf < 0){
            rightRotate(current.right);
            leftRotate(current);
        } else {
            leftRotate(current);
        } 
    } else if (current.bf < 0){
        if (current.left.bf > 0){
            leftRotate(current.left);
            rightRotate(current);
        } else {
            rightRotate(current);
        }
    }
    }
    public NodeAVL search(int key, NodeAVL current){
     if (current == null || key == current.key) {
	    return current;
	}
	 if (key < current.key) {
	    return search(key,current.left);
	} 
        return search(key, current.right);
    }

    public NodeAVL delete(int key, NodeAVL current){
     if(current == null) return current; 
     else if (key < current.key){   
        current.left = delete(key, current.left);
    }
    else if (key > current.key){
        current.right = delete(key, current.right);
    }
    else {
        if(current.left == null && current.right == null){
            current = null;
    }
        else if (current.left == null) { 
            NodeAVL temp = current;
            current = current.right;
    }
        else if (current.right == null){
            NodeAVL temp = current;
            current = current.left;
    }
        else{
            NodeAVL temp = minValue(current.right);
            current.key = temp.key;
            current.right = delete(temp.key, current.right);
            }
        }
        updateBF(current);
        return current;
    }
    public void updateBF(NodeAVL current){
        if (current == null) return;
        if (current.bf < -1 || current.bf > 1){
            balance(current);
            return;
    }
        if (current.parent != null){
            if (current == current.parent.left){
                current.parent.bf -= 1;
        }
            if (current == current.parent.right){
                current.parent.bf += 1;
        }
            if (current.parent.bf != 0){
                updateBF(current.parent);
            }
        }

        }
public static void setDisplay(NodeAVL current, int space)  
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
public void print(NodeAVL current){
  setDisplay(root, 0);
}
 public NodeAVL minValue(NodeAVL current){
    int min = current.key;

    while (current.left != null){
      //min = current.left.key;
      current = current.left;
    }
    return current;
  }
  public NodeAVL maxValue(NodeAVL current){
    int max = current.key;

    while (current.right != null){
      //max = current.right.key;
      current = current.right;
    }
    return current;
  }
}

}