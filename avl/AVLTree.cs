namespace avl
{ using System;
 public class AVLTree {
	private NodeAVL root;

	public AVLTree() {
		root = null;
	}
public void insert(int key) {
	NodeAVL current = new NodeAVL(key);
	NodeAVL temp = null;
	NodeAVL aux = root;

	while (aux != null) {
		temp = aux;
		if (current.key < aux.key) {
			aux = aux.left;
		} else {
			aux = aux.right;
		}
	}

	current.parent = temp;
	if (temp == null) {
		root = current;
	} else if (current.key < temp.key) {
		temp.left = current;
	} else {
		temp.right = current;
	}

		updateBalance(current);
	}
public void leftRotation(NodeAVL current) {
	NodeAVL temp = current.right;
	current.right = temp.left;
		if (temp.left != null) {
			temp.left.parent = current;
	}
		temp.parent = current.parent;
		if (current.parent == null) {
			root = temp;
		} else if (current == current.parent.left) {
			current.parent.left = temp;
		} else {
			current.parent.right = temp;
		}
		temp.left = current;
		current.parent = temp;
		current.bf = (current.bf - 1) - Math.Max(0, temp.bf);
		temp.bf = (temp.bf - 1) + Math.Min(0, current.bf);
	}

public void rightRotation(NodeAVL current) {     
	NodeAVL temp = current.left;
	current.left = temp.right;
		if (temp.right != null) {
			temp.right.parent = current;
		}
		temp.parent = current.parent;
		if (current.parent == null) {
			root = temp;
		} else if (current == current.parent.right) {
			current.parent.right = temp;
		} else {
			current.parent.left = temp;
		}
		temp.right = current;
		current.parent = temp;
		current.bf = (current.bf + 1) - Math.Min(0, temp.bf);
		temp.bf = (temp.bf + 1) + Math.Max(0, current.bf);
	}

public NodeAVL searchHandle(int key, NodeAVL current) {
		if (current == null || key == current.key) {
			return current;
		}
		if (key < current.key) {
			return searchHandle(key, current.left);
		} 
		return searchHandle(key, current.right);
	}
public NodeAVL deleteHandle(int key, NodeAVL current) {
		if (current == null) return current;
		else if (key < current.key) current.left = deleteHandle(key,current.left);
		else if (key > current.key) current.right = deleteHandle(key,current.right);
		else {
		if (current.left == null && current.right == null) {
			current = null;
		}
		else if (current.left == null) {
			NodeAVL temp = current;
			current = current.right;
		}
			else if (current.right == null) {
				NodeAVL temp = current;
				current = current.left;
		}
			else {
				NodeAVL temp = minValue(current.right);
				current.key = temp.key;
				current.right = deleteHandle(temp.key,current.right);
			}
		} 
		updateBalance(current);
		return current;
	}
public void updateBalance(NodeAVL current) {
	if (current.bf < -1 || current.bf > 1) {
		rebalance(current);
		return;
	}

	if (current.parent != null) {
		if (current == current.parent.left) {
			current.parent.bf -= 1;
		} 

		if (current == current.parent.right) {
			current.parent.bf += 1;
		}
		if (current.parent.bf != 0) {
			updateBalance(current.parent);
		}
		}
	}
public void rebalance(NodeAVL current) {
	if (current.bf > 0) {
		if (current.right.bf < 0) {
			rightRotation(current.right);
				leftRotation(current);
		} else {
			leftRotation(current);
		}
		} else if (current.bf < 0) {
			if (current.left.bf > 0) {
				leftRotation(current.left);
				rightRotation(current);
			} else {
				rightRotation(current);
			}
		}
	}
	public NodeAVL search(int key) {
		return searchHandle(key,root);
	}
    public NodeAVL delete(int key) {
		return deleteHandle(key, root);
	}
public NodeAVL minValue(NodeAVL current) {
		while (current.left != null) {
			current = current.left;
	}
		return current;
}
public NodeAVL maxValue(NodeAVL current) {
	while (current.right != null) {
		current = current.right;
	}
		return current;
	}



  }
}
