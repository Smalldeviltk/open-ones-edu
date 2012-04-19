using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class ListSN
    {
        private int intCount;
        public int Count
        {
            get
            {
                return intCount;
            }
        }

        private Node nodeCurrent;
        public Node NodeCurrent
        {
            get
            {
                return nodeCurrent;
            }
            set
            {
                nodeCurrent = value;
            }
        }
		
        public ListSN(string strInput = null)
        {
            intCount = 0;

            if (strInput != null)
            {
                int i = strInput.Length - 1;
                try
                {
                    while (i >= 0)
                    {
                        AddNext(Int32.Parse(new string(strInput[i], 1)));
                        i--;
                    }
                }
                catch
                {
                    throw new Exception("Co loi xay ra khi, vui long kiem tra du lieu nhap!!!");
                }
                    
            }
            else
                nodeCurrent = null;
        }        

        public void AddNext(int intNode)
        {
            if (nodeCurrent != null)
            {
                nodeCurrent.NodeNext = new Node(nodeCurrent, null, intNode);
                nodeCurrent = nodeCurrent.NodeNext;
            }
            else
            {
                nodeCurrent = new Node(null, null, intNode);
            }
            intCount++;
        }

        public Node ToNext()
        {
           if (nodeCurrent != null)
            {
                if (nodeCurrent.NodeNext == null)
                    return (NodeCurrent = null);
                else
                {
                    nodeCurrent = nodeCurrent.NodeNext;

                    return nodeCurrent;
                }
            }
            else
                return (NodeCurrent = null);
        }

        public Node ToFirst()
        {
            if (nodeCurrent.NodePrev == null)
                return nodeCurrent;

            while (nodeCurrent.NodePrev != null)
                nodeCurrent = nodeCurrent.NodePrev;

            return nodeCurrent;
        }

        public string GetValueList()
        {
            string strResult = "";
            strResult = ToFirst().Value.ToString();
            while (nodeCurrent != null)
            {
                if(ToNext()!=null)
                    strResult += NodeCurrent.Value.ToString();
            }
            char[] chrTemp = strResult.ToCharArray();
            Array.Reverse(chrTemp);
            return (new string(chrTemp));
        }
    }
}
