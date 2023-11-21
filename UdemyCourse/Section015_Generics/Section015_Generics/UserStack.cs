using System.Text;

namespace Section015_Generics; 

public class UserStack<T> {

    private List<T> stack = new List<T>();

    public void Push(T element) {
        stack.Add(element);
    }

    public T Pop() {
        if (IsEmpty()) {
            throw new Exception("Empty stack exception");
        }
        
        T element = stack[Size() - 1];
        stack.Remove(element);

        return element;
    }

    public T Peek() {
        if (IsEmpty()) {
            throw new Exception("Empty stack exception");
        }

        return stack[Size() - 1];
    }

    public int Search(T element) {
        return stack.IndexOf(element);
    }

    public int Size() {
        return stack.Count;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public void Clear() {
        stack.Clear();
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        if (IsEmpty()) {
            return "[ ]";
        }
        
        sb.Append('[');

        for (int i = 0; i < Size() - 1; i++) {
            sb.Append($" {stack[i]},");
        }

        sb.Append($" {stack[Size() - 1]} ]");
        
        return sb.ToString();
    }
}