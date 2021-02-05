class FrontMiddleBackQueue {
    LinkedList<Integer> list;

    public FrontMiddleBackQueue() {
        this.list = new LinkedList<>();
    }
    
    public void pushFront(int val) {
        this.list.addFirst(val);
    }
    
    public void pushMiddle(int val) {
        this.list.add(this.list.size()/2, val);
    }
    
    public void pushBack(int val) {
         this.list.addLast(val);
    }
    
    public int popFront() {
       if(this.list.size() == 0 ){
            return -1;
        }
        return this.list.poll();
    }
    
    public int popMiddle() {
        if(this.list.size() == 0 ){
            return -1;
        }
        int i;
        if(list.size() % 2 != 0){
            i = this.list.get(this.list.size()/2);
            this.list.remove(this.list.size()/2);
        }else{
            i = this.list.get(this.list.size()/2 - 1);
            this.list.remove(this.list.size()/2 - 1);
        }
        return i;
    }
    
    public int popBack() {
          return this.list.size() == 0 ? -1 : this.list.pollLast();
    }
}

/**
 * Your FrontMiddleBackQueue object will be instantiated and called as such:
 * FrontMiddleBackQueue obj = new FrontMiddleBackQueue();
 * obj.pushFront(val);
 * obj.pushMiddle(val);
 * obj.pushBack(val);
 * int param_4 = obj.popFront();
 * int param_5 = obj.popMiddle();
 * int param_6 = obj.popBack();
 */