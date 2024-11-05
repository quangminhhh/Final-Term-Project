using System.Collections.Generic;

namespace Final_Term_Project.Models
{
    public class CircularLinkedListModel<T>
    {
        private NodeModel<T> head;

        // Kiểm tra danh sách có trống không
        public bool IsEmpty() => head == null;

        // Thêm node vào cuối danh sách
        public void AddLast(T data)
        {
            NodeModel<T> newNode = new NodeModel<T>(data);
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                NodeModel<T> temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
        }

        // Xóa node đầu tiên
        public void DeleteFirst()
        {
            if (!IsEmpty())
            {
                if (head.Next == head) // chỉ có 1 node
                {
                    head = null;
                }
                else
                {
                    NodeModel<T> temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = head.Next;
                    temp.Next = head;
                }
            }
        }

        // Xóa node cuối cùng
        public void DeleteLast()
        {
            if (!IsEmpty())
            {
                if (head.Next == head) // chỉ có 1 node
                {
                    head = null;
                }
                else
                {
                    NodeModel<T> temp = head;
                    while (temp.Next.Next != head)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = head;
                }
            }
        }

        // Chuyển danh sách thành List<T> để dễ visualize
        public List<T> ToList()
        {
            List<T> list = new List<T>();
            if (IsEmpty()) return list;

            NodeModel<T> temp = head;
            do
            {
                list.Add(temp.Data);
                temp = temp.Next;
            } while (temp != head);

            return list;
        }

    }
}
