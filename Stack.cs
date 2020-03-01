using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stack
    {
        private int topRed, topBlack, length;
        private object[] data;

        public Stack(int length)
        {
            data = new object[length];
            this.length = length;
            topRed = -1;
            topBlack = length;
        }

        public void PushRed(object current)
        {
            int prevLength, diff;
            object[] temp;

            if (topRed + 1 == topBlack)
            {
                prevLength = length;
                length = length * 2;
                diff = prevLength - topBlack;
                temp = new object[length];

                for (int i = 0; i <= topRed; i++)
                {
                    temp[i] = data[i];
                }

                for (int i = 1; i <= diff; i++)
                {
                    temp[length - i] = data[prevLength - i];
                }
                data = temp;
                topBlack = length - diff;
            }
            topRed++;
            data[topRed] = current;
        }

        public void PushBlack(object current)
        {
            int prevLength, diff;
            object[] temp;

            if (topBlack - 1 == topRed)
            {
                prevLength = length;
                length = length * 2;
                diff = prevLength - topBlack;
                temp = new object[length];

                for (int i = 0; i <= topRed; i++)
                {
                    temp[i] = data[i];
                }

                for (int i = 1; i <= diff; i++)
                {
                    temp[length - i] = data[prevLength - i];
                }
                data = temp;
                topBlack = length - diff;
            }
            topBlack--;
            data[topBlack] = current;
        }


        public object PopRed()
        {
            if (IsEmptyRed()) { throw new EmptyStackException("The Stack is Empty"); }
            else
            {
                object lastPopObj = data[topRed];
                data[topRed] = null;
                topRed--;
                return lastPopObj;
            }

        }
        public object PopBlack()
        {
            if (IsEmptyBlack()) { throw new EmptyStackException("The Stack is Empty"); }
            else
            {
                object lastPopObj = data[topBlack];
                data[topBlack] = null;
                topBlack++;
                return lastPopObj;
            }
        }
        public bool IsEmptyRed()
        {
            return topRed == -1;
        }

        public bool IsEmptyBlack()
        {
            return topBlack == length;
        }

        public object TopBlack()
        {
            if (IsEmptyBlack()) { throw new EmptyStackException("The Stack is Empty"); }
            else return data[topBlack];
        }

        public object TopRed()
        {
            if (IsEmptyRed()) { throw new EmptyStackException("The Stack is Empty"); }
            else return data[topRed];
        }
        public int SizeOfRed()
        {
            return topRed + 1;
        }
        public int SizeOfBlack()
        {
            int diff = length - topBlack;
            return diff;
        }
    }
}
