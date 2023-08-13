using System;
namespace OOP
{
	/// <summary>
	/// OOP：封装 继承 多态(*)
	/// 一堆类中共有成员 --> 父类
	///
	/// merit: 联系类与类 复用 为多态提供前提
	///
	/// Example: 抽象成Hero类，4个英雄继承Hero类
	///
	/// Syntax: 使用“:”
	///			clss 子类:父类{}
	///			
	/// </summary>



	public class Inheritance
	{
		public static void MyInheritance()
		{
			AyeRock2 a2 = new AyeRock2("A2","From the border",80,80,80,"A2");
			a2.SayHello();

			Tyler2 t2 = new Tyler2("T2", "From the border", 80, 80, 80, "T2");
			t2.SayHello();

			Console.ReadKey();
		}
	}


	/// <summary>
	/// 所有英雄的父类
	/// </summary>
	public class Hero
	{
		private string heroName;
		private string heroInfo;
		private int attackPower;
		private int defense;
		private int speed;
		private string nickName;
		public string msg;

		// 为六个字段编写属性
		public string HeroName
		{
			get { return heroName; }
			set { heroName = value; }
		}
		public string HeroInfo
		{
			get { return heroInfo; }
			set { heroInfo = value; }
		}
		public int AttackPower
		{
			get { return attackPower; }
			set { attackPower = value; }
		}
		public int Defense
		{
			get { return defense; }
			set { defense = value; }
		}
		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		public string NickName
		{
			get { return nickName; }
			set { nickName = value; }
		}

		// Inherited Constructor 父类的构造方法
		public Hero()
		{

		}
		public Hero(string name, string heroInfo, int attackPower, int defense, int speed, string nickName)
		{
			this.nickName = name;
			this.heroInfo = heroInfo;
			this.attackPower = attackPower;
			this.defense = defense;
			this.speed = speed;
			this.nickName = name;
		}

		public void SayHello()
		{
			Console.WriteLine("Name: {0}, HeroInfo: {1}, AttackPower: {2}, Defense: {3}, Speed: {4}, NickName:{5}", this.heroName, this.heroInfo, this.attackPower, this.defense, this.speed,this.nickName);
		}
	}

	public class AyeRock2 : Hero
	{
		// 子类的构造方法,通过关键字base传递值，但是没有继承到父类的构造方法
		public AyeRock2() { }
		public AyeRock2(string heroName, string heroInfo, int attackPower, int defense, int speed, string nickName)
			:base(heroName, heroInfo, attackPower,defense,speed,nickName)
		{
			/*this.HeroName = "AyeRock2";
			this.HeroInfo = "I am a warrior from the border";
			this.AttackPower = 80;
			this.Defense = 40;
			this.Speed = 60;
			this.NickName = nickName;*/
		}

		public void GravelStrike()
		{
			// 父类中public的字段/属性，可以在子类中用base.访问
			string msg = base.msg;
			Console.WriteLine("Gravel Strike!");
		}
		public void FlameAnchor()
		{
			Console.WriteLine("Flame Anchor!");
		}
		public void BattleRoar()
		{
			Console.WriteLine("Battle Roar!");
		}
	}

	public class Tyler2 : Hero
	{
		public Tyler2() { }
        public Tyler2(string heroName, string heroInfo, int attackPower, int defense, int speed, string nickName):base(heroName,heroInfo,attackPower,defense,speed,nickName)
        {
            /*this.HeroName = "Tyler2";
            this.HeroInfo = "I am a wizard from the sea";
            this.AttackPower = 50;
            this.Defense = 60;
            this.Speed = 80;
            this.NickName = nickName;*/
        }

        public void WaveImpact()
		{
			Console.WriteLine("Wave Impact!");
		}
		public void ElementalAssault()
		{
			Console.WriteLine("Elemental Assualt");
		}
		public void RevengeKilling()
		{
			Console.WriteLine("Revenge Killing");
		}
	}

}

