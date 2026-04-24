using MyListLibrary;
namespace CW7
{
    public class Programm
    {
        static void Main()
        {
            CustomList list = new CustomList(-1.4f, 15.68f, -2.25f, 6.3f, 0.0f, 18.92f);

            Console.WriteLine("Initial list");
            foreach (float item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");

            Console.Write("\nEnter the the element you want to add: ");
            float addANumber = float.Parse(Console.ReadLine());
            list.AddLast(addANumber);
            Console.WriteLine($"List after adding {addANumber} item");
            foreach (float item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");

            Console.Write("\nEnter the index of the element you want to see: ");
            int indexToSee = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(list[indexToSee]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("\nEnter the index of the element you want to delete: ");
            int indexToDelete = int.Parse(Console.ReadLine());
            try
            {
                list.RemoveElement(indexToDelete);
                Console.WriteLine($"List after deleting {indexToDelete} item");
                foreach (float item in list)
                {
                    Console.Write(item + " -> ");
                }
                Console.WriteLine("null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nFirst element greater than 10.5 is " + list.FindFirstGreaterThan(10.5f));
            Console.WriteLine($"\nSummary of elements is " + list.FindSumOfElements());

            CustomList newList = list.GetListGreaterThan(10.5f);
            Console.WriteLine("\nNew list with elements greater than 10.5\n");
            foreach (float item in newList)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
            Console.ReadLine();
        }
    }
}