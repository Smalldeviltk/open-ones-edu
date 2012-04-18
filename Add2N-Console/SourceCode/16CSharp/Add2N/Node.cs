using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Node
    {
        protected Node nodePrev; // node trước của node hiện tại

        public Node NodePrev //  get và set giúp cho việc truy xuất giá trị của biến protected nodePrev, và có thể kiểm soát dễ hơn
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

        protected Node nodeNext; // node kế tiếp của node hiện tại

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

        private int intVal; // giá trị của node hiện tại

        public int Value
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value > 0) // value phải là số nguyên có giá trị từ 0-->9
                    intVal = value;
                else
                    throw new Exception("Du lieu khong hop le!!!");
            }
        }

        public Node(Node _prev, Node _next, int _val)
        {
            nodePrev = _prev;
            nodeNext = _next;
            intVal = _val;
        }
    }
}
