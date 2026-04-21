using System;
using System.Collections.Generic;
using System.Text;

namespace MyListLibrary
{
    public class CustomList
    {
        public Node Head { get; set; }
        public float this[int index] 
        { 
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Index is out of range! :o");
                Node el = Head;
                int currentIndex = 0;
                while (el != null)
                {
                    if (currentIndex == index)
                        return el.Number;
                    el = el.Next;
                    currentIndex++;
                }
                throw new IndexOutOfRangeException("Index is not found :(");
            }
        }

        public void AddLast(float num)
        {
            Node element = new Node(num);
            if (Head == null)
                Head = element;
            else
            {
                Node el = Head;
                while (el.Next != null)
                {
                    el = el.Next;
                }
                el.Next = element;
            }
        }
        public void RemoveElement(int index)
        {
            if (index < 0 || Head == null)
                throw new IndexOutOfRangeException("Index is out of range! :o");
            if (index == 0)
                Head = Head.Next;
            else
            {
                Node el = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    el = el.Next;
                    if (el == null)
                        throw new IndexOutOfRangeException("Index is out of range! :o");
                }
                if (el.Next == null)
                    throw new IndexOutOfRangeException("Index is out of range! :o");
                el.Next = el.Next.Next;
            }
        }
        public IEnumerator<float> GetEnumerator()
        {
            Node el = Head;
            while (el != null)
            {
                yield return el.Number;
                el = el.Next;
            }
        }
        public float FindFirstGreaterThan(float comparative)
        {
            Node element = Head;
            while (element != null)
            {
                if (element.Number > comparative)
                {
                    return element.Number;
                }
                element = element.Next;
            }
            return float.NaN;
        }
        public float FindSumOfElements()
        {
            Node element = Head;
            float firstNegativeEl = 0;
            float sumOfNegatives = 0;
            while (element != null)
            {
                if (element.Number < 0.0f)
                {
                    firstNegativeEl = element.Number;
                    break;
                }
                element = element.Next;
            }
            if (firstNegativeEl == 0)
                return float.NaN;
            element = Head;
            while (element != null)
            {
                if (element.Number < firstNegativeEl)
                {
                    sumOfNegatives += element.Number;
                }
                element = element.Next;
            }
            
            return sumOfNegatives;
        }
        public CustomList GetListGreaterThan(float comparative)
        {
            CustomList newList = new CustomList();
            Node k = Head;
            while (k != null)
            {
                if (k.Number > comparative)
                {
                    newList.AddLast(k.Number);
                }
                k = k.Next;
            }
            return newList;
        }
    }
}
