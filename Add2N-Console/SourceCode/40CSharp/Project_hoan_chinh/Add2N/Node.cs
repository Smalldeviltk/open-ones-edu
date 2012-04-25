using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Node
    {
        protected Node nodePrev;

        public Node NodePrev
        {
            get
            {
                return nodePrev;
            }
            set
            {
                nodePrev = value;
            }
        }

        protected Node nodeNext;

        public Node NodeNext
        {
            get
            {
                return nodeNext;
            }
            set
            {
                nodeNext = value;
            }
        }

        private int intVal;

        public int Value
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value > 0)
                    intVal = value;
                else
                    throw new Exception("Du lieu khong hop le!!!");
            }
        }

        public Node(Node _prev, Node _next, int _val)
        {
            try
            {
                nodePrev = _prev;
                nodeNext = _next;
                intVal = _val;
            }
            catch
            {
                throw new Exception("Co loi xay ra khi tao node, vui long kiem tra du lieu nhap!!!");
            }
        }
    }
}
