using System;
using System.Linq;
using System.Collections.Generic;
using testDot.Library.Models;

namespace testDot.Library.Services
{
    public class categoryService
    {
        testDotContext context = new testDotContext();

        de_molContext context = new de_molContext();

        public IEnumerable<AppPlayer> All()
        {
            return context.AppPlayers
                .OrderBy(player => player.Name);
        }


         public void UnVoteOn(){
              magicContext context = new magicContext();
            var myList = context.Cards
                .OrderBy(c => c.Name)
                .ToList();
            
            foreach(var item in myList){
                Console.WriteLine(item.Name);
            }
         }

       
    }

}
