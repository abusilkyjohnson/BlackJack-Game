using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.Intrinsics.X86;
using PG2Input;
using System.Collections.Generic;

namespace Lab1
{

    //
    //------------Lab Notes-------------
    //      Add your Read methods to the Input.cs file in the PG2Input project.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {
        static void Main(string[] args)
        {

            //Part A-8: Menu Loop
            //You will need to create a loop in Main that handles the menu options for lab 1. This 
            //should be a simple while loop that loops while the menu selection is NOT exit. Inside
            //the while loop, you should 1) call GetMenuChoice to show the menu and get the
            //user’s menu selection. 2) use a switch statement that has logic for each menu option.

           
            static string GetSpeech()
            {
                string speech = " I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
            "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
            "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
            "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
            "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
            "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
            "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
            "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
            "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
            "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
            "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
            "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
            "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
            "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";
                return speech;
            }

            static List<string> Splitter()
            {
                string[] speechSplitArray = GetSpeech().Split(new char[] { '|', ' ', '.', '!', '?', ',', ';', ':', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> speechSplitList = new List<string>(speechSplitArray);
                for(int i = 0; i < speechSplitList.Count; i++)
                {
                    Console.WriteLine(speechSplitList[i]);
                }
                return speechSplitList;
              
            }

            int menuChoice = 1;
            string[] mainMenu = new string[] { "1. Show Speech", "2. Only Words", "3. Fish", "4. Exit" };

            while (menuChoice != 4)
            {
                Input.GetMenuChoice("", mainMenu, out menuChoice);
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine(GetSpeech());
                        break;
                    case 2:
                     Console.WriteLine(Splitter());
                        break;
                    case 3:
                        Console.WriteLine("Fish");
                        break;

                }
                
            }

        }
    }
}
