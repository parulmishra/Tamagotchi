using System;
using System.Collections.Generic;

namespace Game.Models
{
    public class Tamagotchi
    {
        private int _food;
        private int _attention;
        private int _rest;
        private int _happiness = 5;
		private bool _isDead = false;
		private string _name;
		private static List<Tamagotchi> _tamagotchis = new List<Tamagotchi>();
		private int _id;
		
		public Tamagotchi(string name, int food, int attention, int rest)
		{
			_name = name;
			_food = food;
			_attention = attention;
			_rest = rest;
			_tamagotchis.Add(this);
			_id = _tamagotchis.Count;
		}
		
		public int GetId()
		{
			return _id;
		}
		
		public static List<Tamagotchi> GetAllTamagotchi()
		{
			return _tamagotchis;
		}
		public static Tamagotchi Find(int id)
		{
			return _tamagotchis[id-1];
		}
		public string GetName()
		{
			return _name;	
		}
		public int GetFood()
		{
			return _food;
		}
		public int GetAttention()
		{
			return _attention;
		}
		public int GetHappiness()
		{
			return _happiness;
		}
		public int GetRest()
		{
			return _rest;
		}
        public void Feed()
        {
			if(_isDead == true)
				return;
            _food += 5;
            _happiness += 5;
        }
        public void Play()
        {
			if(_isDead == true)
				return;
            _attention += 5;
            _happiness += 5;
        }
        public void Sleep()
        {
			if(_isDead == true)
				return;
            _rest += 5;
            _happiness += 5;
        }
		public void Timepass()
		{
			if(_happiness == 0)
			{
				_isDead = true;
				return;
			}
			
			_happiness -= 5;
			_food -= 5;
			_attention -= 5;
		}
    }
}
