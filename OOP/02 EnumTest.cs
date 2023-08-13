using System;
namespace OOP
{
	/// <summary>
	/// enum 是一个数据类型，
	/// 建议定义在namespace下边，这样所有的class都可以访问枚举
	///
	/// 应用案例
	/// 切水果游戏，里面有不同的水果，可以定义一个水果的枚举类型
	/// RPG游戏中，会有不同的职业，也可以定义一个职业的枚举
	/// 
	/// </summary>

	// definition
	public enum Direction
	{
		north,
		east,
		south,
		west
	}

	public enum WeekDay
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday,
	}

	public enum Gender
	{
		Male,
		Female
	}

	public enum Color
	{
		Green,
		Red,
		Blue
	}

	public class EnumTest
	{
		

		public static void MyEnumTest()
		{
			// use it
			WeekDay myDay = WeekDay.Friday;
			Console.WriteLine(myDay);

			Console.ReadKey();
		}
	}
}

