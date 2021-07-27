using System;

/// <summary>Queue class.</summary>
class Queue<T>
{
    /// <summary>Node class contained in queue.</summary>
    public class Node
    {
        public T value;
        public Node next = null;

        /// <summary>Node constructor.</summary>
        public Node(T val)
        {
            value = val;
        }
    }

    /// <summary>Head node of queue.</summary>
    public Node head = null;
    /// <summary>Tail node of queue.</summary>
    public Node tail = null;
    /// <summary>Count of nodes.</summary>
    public int count = 0;

    /// <summary>Method that creates a new Node and adds it to the end of the queue.</summary>
    public void Enqueue(T val){
        Node n = new Node(val);
        
        if (head == null){
            head = n;
        }
        tail = n;
        count++;
    }

    /// <summary>Method that removes the first node in the queue and returns its' value.</summary>
    public T Dequeue(){
        Node n;

        if (head == null || count == 0){
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else{
            Node h = head;
            n = head.next;
            head = n;
            count--;
            return h.value;
        }
    }
    /// <summary>Returns the Queue's type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    /// <summary>Counts the length of the queue and returns it.</summary>
    public int Count()
    {
        return (count);
    }
}