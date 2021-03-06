﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams {
    class Program {
        static void Main(string[] args) {
            bool containsEveryLetter = true;
            bool goAgain = true;
            
            Console.WriteLine("               -- PANGRAMS --");
            Console.WriteLine("Enter a phrase and this program will tell you if");
            Console.WriteLine("you have used every letter of the alphabet.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            do {
                Console.WriteLine("Type a string of text: ");
                string input = Console.ReadLine();

                for(uint i = 0; i < 26; i++) {
                    if(!input.ToLower().Contains((char)((int)'a' + i))) {
                        containsEveryLetter = false;
                        break;
                    }
                }

                Console.WriteLine();
                if(containsEveryLetter) {
                    Console.WriteLine("This sentence DOES contain every letter.");
                } else {
                    Console.WriteLine("This sentence DOES NOT contain every letter;");
                }

                Console.WriteLine();
                Console.Write("Go again?");
                string goAgainSelection = Console.ReadLine();
                if(goAgainSelection.ToLower() == "y" || goAgainSelection.ToLower() == "yes"){
                    goAgain = true;
                }else{
                    goAgain = false;
                }

                Console.WriteLine();
            } while(goAgain);
        }
    }
}
