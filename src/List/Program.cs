namespace Method_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dis;
            ListLab list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            dis = list.display();
            Console.WriteLine(dis);

            list.delete(1);
            dis = list.display();
            Console.WriteLine(dis);

            list.insert('c', 1);
            dis = list.display();
            Console.WriteLine(dis);

            list.deleteall('c');
            dis = list.display();
            Console.WriteLine(dis);

            list.reverse();
            int x = list.findfirst('a');
            Console.WriteLine("First occurrence of 'a': " + x);

            ListLab list2 = list.clone();
            list.extend(list2);
            dis= list.display();
            Console.WriteLine(dis);

            Console.WriteLine("List length: " + list.lenght());
        }
    }
}
