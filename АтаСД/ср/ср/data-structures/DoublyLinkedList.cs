using System;

namespace cp.data_structures
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public int value { get; set; }
            public Node prev { get; set; }
            public Node next { get; set; }

            public Node(int val)
            {
                value = val;
            }
        }

        public class DoublyList
        {
            public Node head { get; private set; }
            public Node tail { get; private set; }

            public Node add(int value)
            {
                Node node = new Node(value);
                node.next = head;

                if (head != null)
                    head.prev = node;
                else
                    tail = node;

                head = node;

                return node;
            }

            public Node find(int value)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.value == value)
                        return current;
                    current = current.next;
                }
                return null;
            }

            public void insert(int value, int newValue)
            {
                Node foundNode = find(value);
                if (foundNode == null) return;

                Node newNode = new Node(newValue);
                newNode.next = foundNode.next;
                newNode.prev = foundNode;

                if (foundNode.next != null)
                    foundNode.next.prev = newNode;
                else
                    tail = newNode;

                foundNode.next = newNode;
            }

            public bool remove(int value)
            {
                Node current = find(value);

                if (current == null) return false;

                if (current.prev != null)
                    current.prev.next = current.next;
                else
                    head = current.next;

                if (current.next != null)
                    current.next.prev = current.prev;
                else
                    tail = current.prev;

                return true;
            }

        }
    }
}