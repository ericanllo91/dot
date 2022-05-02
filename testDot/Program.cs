using testDot.Library.Models;

    class Program{
        static void Main(string[] args){
            magicContext context = new magicContext();
            var myList = context.Cards
                .OrderBy(c => c.Name)
                .ToList();
            
            foreach(var item in myList){
                Console.WriteLine(item.Name);
            }
        }
    }