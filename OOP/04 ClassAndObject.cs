using System;


namespace OOP
{

    /// <summary>
    /// 1.类就是描述事物特征的
    /// 2.public是访问修饰符，用于描述类的访问权限，可以不写
    /// 3.class是关键字，用于声明一个类，类似于enum struct
    /// 4.类的描述信息
    ///
    ///
    /// 
    /// 1.一个具体的个体就是一个对象
    /// 2.通过类实例化出来的就是对象
    /// 3.对象是类中的具体个体
    /// 4.变量在面向对象的类中就叫字段
    ///
    ///
    ///
    /// 
    /// 访问修饰符 = 权限修饰符
    /// public:  公开的，通过对象名.xx可以直接访问到
    /// private: 私有的
    ///
    ///
    ///
    /// 
    /// 属性
    /// 字段直接public的话 容易被恶意赋值，例如Person类的age字段赋值1800
    /// 这时就出现了一个新的概念“属性”
    /// 属性的作用是堆字段进行保护，我们将属性设置为public
    /// 属性保护的字段设置成private，作为我们通过属性间接操作的字段
    /// 1.public数据类型要和保护字段的数据类型一样
    /// 2.属性名和字段名一样，只不过首字母大写
    /// 3.get当通过属性名取值时，自动调用get代码
    /// 4.当通过属性名给字段赋值时，自动调用set代码
    /// 5.value也是系统关键词，代表赋给属性的值
    /// 6.get和set本质上是两个函数
    ///
    ///
    ///
    ///
    ///
    /// namespace 命名空间
    /// 对代码文件分类管理，往往是指类文件
    /// 定义命名空间：namespace <name> {类}
    /// 使用命名空间：using <name>
    /// 
    /// </summary>



    // definition
    public class Apple
    {
        public Color color;
        public int weight;
        public string shape;

        // 使用属性保护字段
        public int Pirce
        {   get { return price;} // get：取值
            set
            {
                if (value >= 10 || value <= 0)
                {
                    Console.WriteLine("The price is illegal");
                    price = 1;
                }
                else price = value;
            } // set: 赋值
        }
        private int price;

        public string placeOfOrigin;
    }


    public class ClassAndObject
	{
		public static void MyClassAndObject()
		{
            Apple myApple = new Apple(); // 实例化一个苹果对象

            // 字段的赋值
            myApple.color = Color.Red;
            myApple.weight = 200;
            myApple.shape = "球体";

            // 通过属性给private字段赋值
            myApple.Pirce = 200;

            

            // 字段的取值
            Console.WriteLine("myApple对象的颜色是{0},重量是{1},形状是{2}", myApple.color, myApple.weight, myApple.shape);
            Console.WriteLine("private price is {0}", myApple.Pirce);

            Console.ReadKey();
		}
	}
}

