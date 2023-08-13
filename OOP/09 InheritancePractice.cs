using System;
namespace OOP
{
	public class InheritancePractice
	{
		public static void MyInheritancePractice()
		{
			Tiger newTiger = new Tiger(4);
            Console.WriteLine("__________________________________");


            Cat newCat = new Cat(4);
			newCat.CatchMice();
			Console.WriteLine("__________________________________");

			Eagle newEagle = new Eagle(2);
			newEagle.SharpClaws();
            Console.WriteLine("__________________________________");

            Swallow newSwallow = new Swallow(2);
			newSwallow.FlySouth();
            Console.WriteLine("__________________________________");

            Console.ReadKey();  
		}
	}
	/// <summary>
	/// 动物类
	/// </summary>
	public class Animal
	{
		private int leg; // 动物都有腿 区别只是几条腿
		public int Leg
		{
			get { return leg; }
			set { leg = value; }
		}

		public void Walk()
		{
			Console.WriteLine("I can walk");
		}

		public void Eat()
		{
			Console.WriteLine("I can eat");
		}

		public void Sleep()
		{
			Console.WriteLine("I can sleep");
		}

		public void Shout()
		{
			Console.WriteLine("I can shout");
		}

		// constructor
		public Animal() { }
		public Animal(int leg)
		{
			this.leg = leg;
		}

		public void SayHello()
		{
			Console.WriteLine("I have {0} legs",this.leg);
		}

	}


	/// <summary>
	/// 猫科
	/// </summary>
	public class CatFamily:Animal
	{
		public void NightVision()
		{
			Console.WriteLine("I have night vision");
		}

		public CatFamily() { }
		public CatFamily(int leg) : base(leg) {
			// this.Leg = 4;
		}
	}
	/// <summary>
	/// 老虎类
	/// </summary>
	public class Tiger:CatFamily
	{
		public Tiger() { }
		public Tiger(int leg) : base(leg) { }
	}
	/// <summary>
	/// 猫类
	/// </summary>
	public class Cat : CatFamily
	{
		public Cat() { }
		public Cat(int leg):base(leg) { }
		public void CatchMice()
		{
			Console.WriteLine("I can catch mice");
		}
	}






	/// <summary>
	/// 鸟科
	/// </summary>
	public class BirdFamily : Animal
	{
		public BirdFamily() { }
		public BirdFamily(int leg) : base(leg) { }

		public void Fly() { Console.WriteLine("I can fly!"); }
	}
	/// <summary>
	/// 老鹰类
	/// </summary>
	public class Eagle : BirdFamily
	{
		public Eagle() { }
		public Eagle(int leg) : base(leg) { }

		public void SharpClaws()
		{
			Console.WriteLine("I have very sharp claws");
		}

	}
	/// <summary>
	/// 燕子类
	/// </summary>
	public class Swallow : BirdFamily
	{
		public Swallow() { }
		public Swallow(int leg) : base(leg) { }

		public void FlySouth()
		{
			Console.WriteLine("I will fly south");
		}
	}

}

