using System.Xml.Serialization;
namespace hw_01_07_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Journal journal1 = null;
            Journal journal2 = null;
            Journal journal3 = null;

            try
            {
                journal1 = new Journal("NewTitle", "NewPubblisher", "33.33.2024", 225);
                journal2 = new Journal("SomeTitle", "SomePubblisher", "11.11.2011", 111);
                journal3 = new Journal("title3", "publisher3", "02.02.2222", 222);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            List<Journal> jl = new List<Journal>() { journal1, journal2,journal3 };
            foreach(Journal journal in jl)
            {
                Console.WriteLine(journal);
            }

            JournalFIleManager.Serialize(jl);
            Console.WriteLine("\nDeserialize: \n");
            List<Journal> newJL = JournalFIleManager.Deserialize();
            foreach(Journal el in newJL)
            {
                Console.WriteLine(el);
            }

        }
    }
}
