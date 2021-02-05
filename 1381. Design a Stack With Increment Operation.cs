public class CustomStack {
    int maxSize;
    Stack<int> stack;
    public CustomStack(int maxSize) {
        this.maxSize = maxSize;
        this.stack = new Stack<int>();
    }
    
    public void Push(int x) {
        if(this.stack.Count < this.maxSize){
            this.stack.Push(x);
        }
    }
    
    public int Pop() {
        return this.stack.Count == 0 ? -1 : this.stack.Pop();
    }
    
    public void Increment(int k, int val) {
        Stack<int> temp = new Stack<int>();
        int j = this.stack.Count > k ? this.stack.Count - k : 0; 
        
        while(this.stack.Count > 0){
            if(j != 0){
                temp.Push(this.stack.Pop());
                j--;
            }else{
                temp.Push(this.stack.Pop() + val);
            }
        }
        
        while(temp.Count > 0){
            this.stack.Push(temp.Pop());
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */