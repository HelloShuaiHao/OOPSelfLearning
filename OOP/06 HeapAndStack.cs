using System;
namespace OOP
{

	/// <summary>
	/// 对象的实例化
	/// 无参
	///
	/// 有参
	///
	/// 都需要写
	///
	/// new关键字 在堆空间开辟
	///
	/// 游戏中的一切都是对象，为了创建对象，需要针对不同的对象写出相应的类
	/// 在类中规划好基本信息，功能作用
	///
	/// 之后实例化对象，进行对象与对象之间的相应交互
	/// 
	/// </summary>
	public class HeapAndStack
	{
		public static void MyHeapAndStack()
		{
			Person p1 = new Person("SHUAIHAO",22,Gender.Male,"Singapore");
			Person p2 = p1;

			p1.SayHello();
			p2.SayHello();

			p2.Name = "NewSH";

			// 发现p1内容也发生了改变，因为用new的时候会在堆空间开辟一段，存储信息，有一个地址值
			// 将p1的引用地址赋值给了p2
            p1.SayHello();
            p2.SayHello();

            Console.ReadKey();
		}
	}
}

