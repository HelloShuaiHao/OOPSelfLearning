using System;


namespace OOP
{
	/// <summary>
	/// 方法就是函数
	///
	/// A.普通方法
	/// 在类中的作用就是对对象的行为进行描述
	/// 访问修饰符 返回值 方法名（参数列表） {具体功能}
	/// private修饰的普通方法无法通过对象名.方法名()的形式调用
	///
	///
	/// 
	/// B.构造方法
	/// 首先他是一个方法，然后它具有构造作用，简单来说就是初始化对象。
	/// 语法：public 类名() {构造函数代码；}
	/// 构造方法要用public修饰
	/// 没有返回值 练void也不能写
	/// 方法名必须跟类名保持一致
	/// 可以有重载
	/// 当我们的类中不写构造方法时，系统在编译后会自动加一个空构造
	///
	///
	/// C.析构方法
	/// 与构造方法相反，析构方法用于清理一个对象
	/// 语法：～类名（）{ 代码体;}
	/// 不能有任何参数，无返回值，无修饰符
	/// 由系统自动调用，可以不写，GC垃圾回收的时候再学
	/// 
	/// </summary>

	public class Person
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private Gender gender;
		public Gender Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		private string address;
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private int age;
		public int Age
		{
			get { return age; }
			set
			{
				if (value > 110) age = 0;
				else age = value;
			}
		}

		/// <summary>
		/// 构造方法，初始化对象
		/// this 关键字 代表当前类的一个对象
		/// </summary>
		public Person(string name, int age, Gender gender, string address)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.address = address;
		} 

		public void Eat()
		{
			Console.WriteLine($"{name} is eating");
		}

		public void Sleep()
		{
			Console.WriteLine($"{name} is sleeping");
		}

		private void UsingToilet()
		{
			Console.WriteLine($"{name} is using toilet");
		}

		public void SayHello()
		{
			Console.WriteLine($"Name: {this.name}, Gender: {this.gender}, Age:{this.age}, Address:{this.address}");
		}

	}




	public class Methods
	{
		public static void myMethods()
		{
			// 实例化+构造函数
			Person person1 = new Person("SHUAIHAO",22,Gender.Male,"Singapore");

			/*
			// 赋值
			person1.Name = "SHUAIHAO";
			person1.Age = 22;
			person1.Address = "Singapore";
			person1.Gender = Gender.Male;
			*/

			// 构造方法
			

			// 普通  方法
			person1.Eat();
			
			Console.ReadKey();
		}
	}
}

