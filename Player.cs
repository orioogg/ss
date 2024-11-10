using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_S10270448
{
	class Player
	{
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private double hp;

		public double Hp
		{
			get { return hp; }
			set { hp = value; }
		}
		private int attackDamage;

		public int AttackDamage
		{
			get { return attackDamage; }
			set { attackDamage = value; }
		}
		private int xp;

		public int Xp
		{
			get { return xp; }
			set { xp = value; }
		}
		public Player(int id, string name, double hp, int attackDamage, int xp)
		{
			Id = id;
			Name = name;
			Hp = hp;
			AttackDamage = attackDamage;
			Xp = xp;
		}
		public double CalculateLevel()
		{
			double player_level = 1 + ((0.2) * Math.Sqrt(Xp));
			return Math.Floor(player_level);
		}
		public bool attack(Player defender)
		{
            if defender.Id

        }
	}
}



