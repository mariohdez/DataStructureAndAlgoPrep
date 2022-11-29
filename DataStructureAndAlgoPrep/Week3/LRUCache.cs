using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class LRUCache
    {
        private readonly int capacity;
        private readonly DLLNode head;
        private readonly DLLNode tail;
        private readonly IDictionary<int, DLLNode> cache;

        private int size;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;

            this.cache = new Dictionary<int, DLLNode>();

            this.head = new DLLNode();
            this.tail = new DLLNode();

            this.head.next = this.tail;
            this.tail.previous = this.head;
        }

        public int Get(int key)
        {
            if (!this.cache.ContainsKey(key))
            {
                return -1;
            }

            DLLNode node = this.cache[key];

            MoveToHead(node);

            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (this.cache.ContainsKey(key))
            {
                var node = this.cache[key];
                node.Value = value;

                MoveToHead(node);
            }
            else
            {
                var node = new DLLNode();
                node.Key = key;
                node.Value = value;
                this.cache.Add(key, node);

                AddNode(node);
                this.size++;

                if (this.size > this.capacity)
                {
                    var nodeToEvict = PopTail();
                    this.cache.Remove(nodeToEvict.Key);
                    this.size--;
                }
            }
        }

        public DLLNode PopTail()
        {
            var node = this.tail.previous;

            RemoveNode(node);

            return node;
        }


        public void MoveToHead(DLLNode node)
        {
            RemoveNode(node);
            AddNode(node);
        }

        public void AddNode(DLLNode node)
        {
            node.previous = head;
            node.next = head.next;

            head.next.previous = node;
            head.next = node;
        }

        public void RemoveNode(DLLNode node)
        {
            var nodesPrevious = node.previous;
            var nodesNext = node.next;

            nodesPrevious.next = nodesNext;
            nodesNext.previous = nodesPrevious;
        }


        public class DLLNode
        {
            public int Key { get; set; }
            public int Value { get; set; }

            public DLLNode previous { get; set; }
            public DLLNode next { get; set; }
        }
    }
}

