using System.Collections.Generic;
using System.Linq;

namespace DSA_Class_Work_lesson4
{

    public sealed class PriorityQueue<TEntry>
        where TEntry : IPrioritizable
    {
        private readonly LinkedList<TEntry> entries = new LinkedList<TEntry>();

        public LinkedList<TEntry> Entries
        {
            get
            {
                return entries;
            }
        }

        public LinkedList<TEntry> GetEntries()
        {
            return Entries;
        }

        public int Count()
        {
            return GetEntries().Count;
        }
              

        public void Enqueue(TEntry entry)
        {
            var value = new LinkedListNode<TEntry>(entry);
            if (Entries.First == null)
            {
                Entries.AddFirst(value);
            }
            else
            {
                var ptr = Entries.First;
                while (ptr.Next != null && ptr.Value.Priority < entry.Priority)
                {
                    ptr = ptr.Next;
                }

                if (ptr.Value.Priority <= entry.Priority)
                {
                    Entries.AddAfter(ptr, value);
                }
                else
                {
                    Entries.AddBefore(ptr, value);
                }
            }
        }
        public TEntry Dequeue()
        {
            if (Entries.Any())
            {
                var itemTobeRemoved = Entries.First.Value;
                Entries.RemoveFirst();
                return itemTobeRemoved;
            }

            return default(TEntry);
        }
    }
}
