using System.Collections;

namespace _04._18._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(12);
            arrayList1.Add(23);
            arrayList1.Add(36);
            arrayList1.Add(48);
            arrayList1.Add(59);
            arrayList1.Add(13);
            arrayList1.Add(78);
            arrayList1.Add(45);
            arrayList1.Add(64);

            arrayList1.RemoveAt(0);



            arrayList1.GetInfo();
        }
    }
}
