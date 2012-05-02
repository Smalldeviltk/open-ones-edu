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
		/// <summary>
		/// Hàm tạo danh sách liên kết với các node kiểu int, từ chuỗi nhập
		/// </summary>
		/// <param name="strInput">Chuỗi nhập vào</param>
        public ListSN(string strInput = null)
        {
            intCount = 0;
            bool zeroInHead = true;

            if (strInput != null)
            {
                // Chỉ số
                int signIndex = 0;

                while (strInput[signIndex] == '0')
                {
                    signIndex++;
                }

                int i = strInput.Length - 1;
                
                try
                {
                    while (i >= signIndex)
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

        /// <summary>
        /// Hàm thêm một node vào danh sách
        /// </summary>
        /// <param name="intNode">Node cần thêm</param>
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

        /// <summary>
        /// Hàm trả về Node kế tiếp của Node hiện tại
        /// </summary>
        /// <returns>Node kế tiếp</returns>
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

        /// <summary>
        /// Hàm trả về Node đầu tiên của danh sách
        /// </summary>
        /// <returns>Node đầu tiên</returns>
        public Node ToFirst()
        {
            if (nodeCurrent.NodePrev == null)
                return nodeCurrent;

            while (nodeCurrent.NodePrev != null)
                nodeCurrent = nodeCurrent.NodePrev;

            return nodeCurrent;
        }

        /// <summary>
        /// Hàm trả về chuỗi giá trị của danh sách
        /// </summary>
        /// <returns>Chuỗi trả về</returns>
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
