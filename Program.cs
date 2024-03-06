using System;
namespace StackArray
{
    class Stack
    {
        private int[] array;
        private int top;
        private int size;
        public Stack(int size)
        {
            this.size = size;
            array = new int[size];
            top = -1;
        }
        public void Push(int value)
        {
            if (top == size - 1)
            {
                Console.WriteLine("The stack is full");
                return;
            }
            array[++top] = value;
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            return array[top--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
