using System;
using System.Collections.Generic;

namespace Game.Models
{
    public class Tamagotchi
    {
        private int _food = 20;
        private int _attention = 20;
        private int _rest = 20;
        private int _happiness = 20;

        public void feed()
        {
            _food += 5;
            _happiness += 5;
        }
        public void play()
        {
            _attention += 5;
            _happiness += 5;
        }
        public void sleep()
        {
            _rest += 5;
            _attention -= 5;
        }
    }
}
