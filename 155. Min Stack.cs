public class MinStack {
    Stack<int> MainStack;
    Stack<int> Min;

    public MinStack() {
        MainStack = new Stack<int>();
        Min = new Stack<int>();
        Min.Push(int.MaxValue);
    }
    
    public void Push(int val) {
        MainStack.Push(val);
        Min.Push(Math.Min(val, Min.Peek()));
    }
    
    public void Pop() {
        MainStack.Pop();
        Min.Pop();
    }
    
    public int Top() {
        return MainStack.Peek();
    }
    
    public int GetMin() {
        return Min.Peek();
    }   
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */