﻿using System;

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
    /// <summary>Returns the Queue's type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}