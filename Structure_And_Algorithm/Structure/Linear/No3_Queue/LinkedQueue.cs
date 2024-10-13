﻿using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 링크드 리스트 기반 큐
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedQueue<T> : AbstractQueue<T>
    {
        #region Member Fields
        DoublyLinkedList<T> linkedList;
        #endregion

        #region Constructors
        public LinkedQueue()
        {
            linkedList = new();
        }

        public LinkedQueue(T? data)
        {
            linkedList = new();
            Enqueue(data);
        }
        #endregion

        #region Overrides
        public override void Enqueue(T? newData)
        {
            linkedList.Append(newData);
        }

        public override CustomLinkedListNode<T>? Dequeue()
        {
            if (!IsEmpty())
            {
                return linkedList.Delete(0);
            }
            else
            {
                return null;
            }
        }

        public override bool IsEmpty()
        {
            return linkedList.Length == 0;
        }
        #endregion
    }
}
