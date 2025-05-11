using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_lab2
{
    internal class List
    {
        private class ListNode
        {
            public char data;
            public ListNode next;
        }
        private ListNode head;

        //Counts number of elements in the list
        public int lenght() {
            if(head == null) return 0;
            
            ListNode current = head;
            int count = 1;
            while(current.next !=head)
            {
                current = current.next;
                count++;
            }
            return count;
        }
        //Adds a new element to the end of the list
        public void Append(char data)
        {
            ListNode newNode = new ListNode();
            newNode.data = data;
            if (head == null)
            {
                head = newNode;
                head.next = head;
            }
            else
            {
                ListNode current = head;
                while (current.next != head)
                {
                    current = current.next;
                }
                current.next = newNode;
                newNode.next = head;
            }
        }
        //Adds a new element to the point
        public void insert(char data, int index)
        {
            ListNode current = head;
            ListNode newNode = new ListNode();
            newNode.data = data;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
        }
        //Deletes the element at the point
        public void delete(int a)
        {

        }
        //deletes all elemnts that are equal to the given element
        public void deleteall(char a) {
            ListNode curentn = head;
            
            int L = this.lenght();
            if (L == 0) return;
            if(L == 1)
            {
                if(head.data == a)
                {
                    head = null;
                    return;
                }
            }
            do
            {
                if (curentn.data == a)
                {
                    ListNode temp = curentn;
                    curentn = curentn.next;
                    delete(temp.data);
                }
                else
                {
                    curentn = curentn.next;
                }
            }while(curentn.next != head);
        }

    }
}
