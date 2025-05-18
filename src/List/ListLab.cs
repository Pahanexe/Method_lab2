namespace Method_lab2
{
    public class ListLab
    {
        private class ListNode
        {
            public char data;
            public ListNode next;
        }
        private ListNode head;
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            int L = this.lenght();
            ListNode current = head;
            for (int i = 0; i < L; i++)
            {
                Console.Write(current.data + ", ");
                current = current.next;
            }
            Console.WriteLine();
        }

        //Counts number of elements in the list
        public int lenght()
        {
            if (head == null) return 0;

            ListNode current = head;
            int count = 1;
            while (current.next != head)
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
                newNode.next = head;
                ListNode current = head;
                while (current.next != head)
                {
                    current = current.next;
                }
                current.next = newNode;

            }
        }
        //Adds a new element to the point
        public void insert(char data, int index)
        {
            ListNode current = head;
            ListNode newNode = new ListNode();
            newNode.data = data;
            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
        }
        //Deletes the element at the point
        public void delete(int a)
        {
            int L = this.lenght();
            if (L == 0) return;
            if (L == 1)
            {
                if (a == 0)
                {
                    head = null;
                    return;
                }
            }

            ListNode curent = head;
            for (int i = 0; i < a - 1; i++)
            {
                curent = curent.next;
            }
            curent.next = curent.next.next;

        }
        //deletes all elemnts that are equal to the given element
        public void deleteall(char a)
        {
            int L = this.lenght();
            if (L == 0) return;
            if (L == 1)
            {
                if (head.data == a)
                {
                    head = null;
                    return;
                }
            }

            ListNode curentn = head;
            for (int i = 0; i < L; i++)
            {
                if (curentn.next.data == a)
                {
                    curentn.next = curentn.next.next;
                    continue;
                }
                else
                {
                    curentn = curentn.next;
                }
            }
        }

        public void clear()
        {
            int L = this.lenght();
            if (L == 0) return;

            ListNode current = head;
            ListNode temp;
            head = null;
            for (int i = 0; i < L; i++)
            {
                temp = current;
                current = current.next;
                temp = null;
            }
        }

        public int findfirst(char a)
        {
            int L = this.lenght();
            if (L == 0) return -1;
            ListNode current = head;
            for (int i = 0; i < L; i++)
            {
                if (current.data == a)
                {
                    return i;
                }
                current = current.next;
            }
            return -1;
        }

        public int findlast(char a)
        {
            int L = this.lenght();
            if (L == 0) return -1;
            ListNode current = head;
            int index = -1;
            for (int i = 0; i < L; i++)
            {
                if (current.data == a)
                {
                    index = i;
                }
                current = current.next;
            }
            return index;
        }

        public void reverse()
        {
            int L = this.lenght();
            if (L == 0 && L == 1) return;

            ListNode last = new ListNode();
            last.data = head.data;
            ListNode newhead = new ListNode();
            ListNode current = head.next;
            newhead.next = last;
            newhead.data = current.data;

            for (int i = 0; i < L - 2; i++)
            {
                current = current.next;
                ListNode temp = new ListNode();
                temp.next = newhead;
                temp.data = current.data;
                newhead = temp;
            }
            last.next = newhead;
            head = newhead;
        }
        public ListLab clone()
        {
            return this;
        }
        public void extend(ListLab list)
        {
            int L2 = list.lenght();
            if (list.head == null) return;
            ListNode curent = list.head;
            for (int i = 0; i < L2; i++)
            {
                Append(curent.data);
                curent = curent.next;
            }
        }
    }
}