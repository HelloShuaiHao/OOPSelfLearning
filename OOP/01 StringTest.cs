using System;
using System.Text;
using System.Diagnostics;

namespace OOP
{
	/// <summary>
	/// 1. 字符串是引用类型，字符串的数据存储在堆空间，在栈空间中存储了该数据的引用地址
	/// 2. 字符串是不可变的，当给一个字符串变量重新赋值，旧的并没有销毁，而是重新开辟一块新空间
	///    引用不存在了，但是原数据仍然停留在堆空间
	/// 3. 字符串可以看成一个只读的字符数组，不可更改
	/// </summary>
	public class StringTest
	{

		public static void MyStringTest()
		{
			string s1 = "ShuaiHao";

			// 转化大小写
			Console.WriteLine("ToUpper: " + s1.ToUpper() + " ToLower: "+s1.ToLower());


			// Equals() * 比较两个字符串是否相同
			string s2 = "SHUAIHAO";
			Console.WriteLine("Are they the same? " + s1.Equals(s2));


			// Split() * 分割字符串 返回字符串类型的数组
			string s3 = "中国｜浙江｜嘉兴,秀洲区，高照街道";
			char[] splitArr = new char[3] { '｜', '，' , ',' };
			var splitedData = s3.Split(splitArr);
			foreach (string t in splitedData) Console.Write(t + " ");


			// Substring() * 返回子字符串
			s1 = s1.Substring(5, 3);
			s2 = s2.Substring(2);
			Console.WriteLine("\n" + s1 + "\n" + s2);

			// 字符串并不会改变 


			// IndexOf() * 查找某个字符串在字符串第一次出现的位置，没找到返回1
			Console.WriteLine("IndexOf: " + s3.IndexOf("嘉兴"));


			// LastIndexOf * 某个字符串最后出现的位置


			// StartsWith()  返回字符串是否以某个开头
			Console.WriteLine("StartsWith: " + s3.StartsWith("中国"));

			// EndsWith() 判断是否以某个字符串结尾
			Console.WriteLine("EndsWith: " + s3.EndsWith("高照街道"));


			// Replace() * 将字符串中某个字符串替换 并返回 新的字符串
			string s4 = "HelloShuaiHao";
			Console.WriteLine(s4.Replace("Hello","Hi"));


			// Contains() 是否包含
			Console.WriteLine("Contains: " + s4.Contains("ShuaiHao"));


			// Trim() 去掉字符串中前后字符，返回，类似于Split()
			// TrimEnd() 去掉结尾处空格
			// TrimStart() 去掉开头空格
			string s5 = "  www.google.com   ";
			Console.WriteLine(s5.Trim());



			// isNullOrEmpty() * 判断一个字符串是否为null 或空 null不占内存空间 “”占内存空间
			// 使用：string.方法名（字符串变量）
			string s6 = "";
			Console.WriteLine("isNullOrEmpty(): " + string.IsNullOrEmpty(s6));

				
			Console.ReadKey();
		}




		/// <summary>
		/// string操作会给堆空间，造成大量不必要的损失
		/// StringBuilder是一个类，其类型的变量是引用类型，一直操作同一块内存
		/// 执行效率远高于string类型
		///
		/// 需要using System.Text
		/// </summary>
		public static void StringBuilderTest()
		{
			StringBuilder sb1 = new StringBuilder();

			// 追加数据
			sb1.Append("S");
			sb1.Append(123456);
			sb1.Append(true);

			// 将StringBuilder类型转化为string类型
			string s1 = sb1.ToString();
			Console.WriteLine(s1);

			// 清空
			sb1.Clear();


			// 统计运行时间,效率,差距有千倍
			Stopwatch sw = new Stopwatch();
			sw.Start(); // start
			for(int i = 0; i < 90000; i++)
			{
				s1 += i;
			}
			sw.Stop(); // stop
			Console.WriteLine("string running time: " + sw.Elapsed); // sw.Elapsed 取得时间长度

			Stopwatch sw2 = new Stopwatch();
			sw2.Start();
			for (int i = 0; i<90000;i++) {
				sb1.Append(i);
			}
			sw2.Stop();
			Console.WriteLine("StringBuilder running time: " + sw2.Elapsed);

			Console.ReadKey();
		}
	}
}

