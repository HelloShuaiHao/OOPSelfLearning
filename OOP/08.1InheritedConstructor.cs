using System;
namespace OOP
{
	/// <summary>
	/// 1.父类的构造方法
	///
	/// 2.子类的构造方法
	/// keyword: base 代表父类
	/// keyword：this 代表当前类
	///
	/// 3.继承关系
	/// 字段 属性 普通方法 都能继承public
	/// 构造方法就算public也无法继承，但是可以通过base访问
	///
	/// 结论：父类中使用public的成员，在实例化生成的对象里也可以访问到
	///
	/// 堆栈关系
	/// 在堆中不但子类包含着父类的实例对象
	/// 
	/// </summary>
	public class InheritedConstructor
	{
		public void MyInheritedConstructor()
		{

		}
	}
}

