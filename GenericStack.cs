using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSqolvingPractice
{
    internal class GenericStack <T>
    {
        private int Top;
        private T[] stack;
        private int Size;
        public  int Count  { get { return Top + 1; } } //property get number of items in the stack
        public GenericStack( int size)
        {
            this.Size = size;
            stack = new T[ size ];
            Top = -1;
        }
        public void  Push( T item )
        {
            if (Top == Size -1)
            {
                throw new Exception("Stack is full");

            }
            stack[ ++Top ] = item;

        }
        public T Pop()
        {
            if (Top == -1)
            {
                throw new Exception("the stack is empty");
            }
            var item= stack[Top--];
            return item;
        

        }
        public T Peek()
        {
            if (Top == -1)
            {
                throw new Exception("The stack is empty");
            }
           return stack[ Top ];
        }
        public void Print()
        {
            foreach ( var item in stack )
            {
                Console.WriteLine( item +""); 
            }
        }
    }
}
