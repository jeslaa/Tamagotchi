using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class tamagotchi
    {
        private int hunger = 0;
        public string name = "";
        private int boredom = 1;

        private List<string> words = new List<string>();

        private Random generator = new Random();

        private bool isAlive;

        public void Feed() {
            hunger--;
        }

        public void Teach (string word)
        {
            words.Add(word);
        }

        public void Hi(){
             int i = generator.Next(words.Count);
             System.Console.WriteLine(words[i]);
        }

        public bool GetAlive(){
          return isAlive;
        }

        public void Tick(){
            while (boredom < 11){
                isAlive = true;

                if(words.Count > 1){
                    boredom++;
                }

                if (boredom == 11){
                    isAlive = false;
                }
            }
        }

        private void ReduceBoredom(){
            boredom--;
        }
          public void PrintStats(){
              
            }
    }
}
