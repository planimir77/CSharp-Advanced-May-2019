using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<TItem>
        where TItem : IComparable<TItem>
    {
        private List<TItem> boxCollection;

        public int Count { get; private set; }

        public Box()
        {
            this.boxCollection = new List<TItem>();
        }

        public void Add(TItem item)
        {
            this.boxCollection.Add(item);
        }

        public void Compare(TItem item)
        {
            foreach (var text in this.boxCollection)
            {
                if (text.CompareTo(item) == 1)
                {
                    this.Count += 1;

                }
                else if (text.CompareTo(item) == 0)
                {
                    ;
                }
                else
                {
                    ;
                }
            }
        }

        public void Swap(int a, int b)
        {
            TItem temp = this.boxCollection[a];
            this.boxCollection[a] = this.boxCollection[b];
            this.boxCollection[b] = temp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var text in this.boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName}: {text}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
