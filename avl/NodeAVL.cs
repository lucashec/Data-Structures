namespace avl
{
    public class NodeAVL
    {
        public int bf;
        public int key;
        public NodeAVL parent;
        public NodeAVL left;
        public NodeAVL right;

        public NodeAVL(int key){
            parent = null;
            left = null;
            right = null;
            bf = 0;
            this.key = key;
        }
    }
}