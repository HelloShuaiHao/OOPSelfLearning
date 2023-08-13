using System;
namespace OOP
{

	/// <summary>
	/// 1.结构体是一种值类型，通常用于封装一些小型变量数据
	/// 2.可以把结构体当作一个迷你版的对象来使用
	/// 
	/// 
	/// </summary>
	public class StructTest
	{

		// 结构体定义,public不可少
		public struct Person
		{
			public string name;
			public int age;
			public Gender gender;
			public string address;
		}

		

		public static void MyStructTest()
		{

			// 1.创建结构体类型的变量
			Person ShuaiHao = new Person();

			// 2.给结构体赋值
			ShuaiHao.name = "SHUAIHAO";
			ShuaiHao.age = 22;
			ShuaiHao.gender = Gender.Male;
			ShuaiHao.address = "Singapore";

			// 3.输出
			Console.WriteLine(ShuaiHao.name + ShuaiHao.gender);


			Console.ReadKey();
		}
	}
}

