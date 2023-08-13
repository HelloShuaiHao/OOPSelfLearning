using System;
namespace OOP { 

	/// <summary>
	/// 
	/// 经过分析，我们发现角色具有以下信息
	/// 字段：角色名字，角色简介，角色昵称，攻击力，防御力，速度
	/// 用属性进行封装
	/// 方法：每个角色都有三个不同的攻击技能
	///
	///
	/// 但是多个英雄代码冗余
	///
	/// 
	/// </summary>
	public class Practise
	{
		public static void MyPractise()
		{
			AyeRock ayeRock1 = new AyeRock("TestName");
			ayeRock1.SayHello();


			Console.ReadKey();
		}
	}

	public class AyeRock
	{
		private string heroName;
		public string HeroName
		{
			get { return heroName; }
			set { heroName = value; }
		}

		private string introduction;
		public string Introduction
		{
			get { return introduction; }
			set { introduction = value; }
		}

		private string nickName;
		public string NickName
		{
			get { return nickName; }
			set { nickName = value; }
		}

		private int attack;
		public int Attack
		{
			get { return attack; }
			set { attack = value; }
		}

		private int defense;
		public int Defence
		{
			get { return defense; }
			set { defense = value; }
		}

		private int speed;
		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		private int hp;
		public int Hp
		{
			get { return hp; }
			set { Hp = value; }
		}

		public void GravelStrike()
		{
			Console.WriteLine("Gravel Strike!");
		}

		public void FlameAnchor()
		{
			Console.WriteLine("Flame Anchor");
		}

		public void BattleRoar()
		{
			Console.WriteLine("Battle Roar");
		}

		public AyeRock(string nickName)
		{
			this.nickName = nickName;

			this.heroName = "AyeRock";
			this.introduction = "AyeRock is a warrior from the border";
			this.attack = 80;
			this.defense = 50;
			this.speed = 50;
			this.hp = 70;
		}

		public void SayHello()
		{
			Console.WriteLine("Name: {0}, Introduction: {1}, Attack: {2}, Defense: {3}, Speed: {4}, HP: {5}", this.heroName, this.introduction, this.attack, this.defense, this.speed, this.hp);
			this.GravelStrike();
			this.FlameAnchor();
			this.BattleRoar();
		}
	}

	
}

