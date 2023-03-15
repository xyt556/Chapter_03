using System;

namespace Chapter_03
{


    #region eg3.1: 类和对象-对象调用方法
    //public class TPoint    //声明类TPoint
    //{
    //    int x, y;　　　　　//类的私有字段

    //    //public int X
    //    //{ get { return x; } }

    //    public void setpoint(int x1, int y1)
    //    { x = x1; y = y1; }
    //    public void dispoint()
    //    { Console.WriteLine("({0},{1})", x, y); }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TPoint p1 = new TPoint();	// 定义对象p1
    //        p1.setpoint(2, 6);
    //        //Console.WriteLine(p1.X);
    //        //Console.WriteLine(p1.x);

    //        Console.Write("第一个点=>");
    //        p1.dispoint();
    //        TPoint p2 = new TPoint();	// 定义对象p2
    //        p2.setpoint(8, 3);
    //        Console.Write("第二个点=>");
    //        p2.dispoint();
    //    }
    //}

    #endregion

    #region eg3.2: 类和对象-构造函数
    //public class TPoint1
    //{
    //    int x, y;　		              //类的私有变量
    //    public TPoint1() { }           	//默认的构造函数
    //    public TPoint1(int x1, int y1) 	//带参数的构造函数
    //    {
    //        x = x1;
    //        y = y1;
    //    }
    //    public void dispoint()
    //    {
    //        Console.WriteLine("({0},{1})", x, y);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TPoint1 p1 = new TPoint1();	   //调用默认的构造函数
    //        Console.Write("第一个点=>");
    //        p1.dispoint();
    //        TPoint1 p2 = new TPoint1(8, 3);//调用带参数的构造函数
    //        Console.Write("第二个点=>");
    //        p2.dispoint();
    //    }
    //}
    #endregion

    #region eg3.3: 类和对象-析构函数
    //class Program
    //{
    //    public class TPoint2 //声明类TPoint2
    //    {
    //        int x, y;
    //        public TPoint2(int x1, int y1) 	//带参数的构造函数
    //        {
    //            x = x1;
    //            y = y1;
    //        }
    //        ~TPoint2()
    //        {
    //            Console.WriteLine("点=>({0},{1})", x, y);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        TPoint2 p1 = new TPoint2(2, 6);
    //        TPoint2 p2 = new TPoint2(8, 3);
    //    }
    //}
    #endregion

    #region eg3.4: 类和对象-属性
    //public class TPoint3 	//声明类TPoint3
    //{
    //    int x, y;
    //    //public int XX
    //    //{
    //    //    get;
    //    //    set;
    //    //}

    //    public int PX
    //    {
    //        get     //get访问器
    //        {
    //            return x;
    //        }
    //        set     //set访问器
    //        {
    //            x = value;
    //        }
    //    }
    //    public int PY
    //    {
    //        get     //get访问器
    //        {
    //            return y;
    //        }
    //        set     //set访问器
    //        {
    //            y = value;
    //        }
    //    }
    //    ~TPoint3()
    //    {
    //        Console.WriteLine("析构函数：点=>({0},{1})", x, y);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TPoint3 p = new TPoint3();
    //        p.PX = 3; p.PY = 8;    //属性写操作
    //        Console.WriteLine("点=>({0},{1})", p.PX, p.PY);//属性读操作
    //    }
    //}
    #endregion

    #region eg3.5: 类和对象-方法参数-值类型
    //class ValParams
    //{
    //    static void Change100(int x)
    //    {
    //        Console.WriteLine("Inside Method, x={0}", x);
    //        x = 100;
    //        Console.WriteLine("Inside Method, x={0}", x);
    //    }
    //    static void Main(string[] args)
    //    {
    //        int y = 10;
    //        Console.WriteLine("Outside Method, y={0}", y);
    //        Change100(y);
    //        Console.WriteLine("Outside Method, y={0}", y);
    //    }
    //}
    #endregion

    #region eg3.6: 类和对象-方法参数-引用类型
    //public class RefParams
    //{
    //    int num = 1;
    //    public void Addnum(int num1, ref int num2)
    //    {
    //        num2 = num + num1;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int x = 0, y = 5;
    //        RefParams s = new RefParams();
    //        s.Addnum(y, ref x);
    //        Console.WriteLine("x={0},y={1}", x, y);
    //    }
    //}

    #endregion

    #region eg3.7: 类和对象-方法参数-输出参数
    //public class OutParams
    //{
    //    int num = 1;
    //    public void Addnum(int num1, out int num2)
    //    {
    //        num2 = num + num1;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int y = 5, x;
    //        OutParams s = new OutParams();
    //        s.Addnum(y, out x);
    //        Console.WriteLine("x={0},y={1}", x, y);　　//输出：5
    //    }
    //}

    #endregion

    #region eg3.8-1：类和对象-方法参数-params参数
    //public class ArrayParams
    //{
    //    public int Addnum(params int[] b)//具有int返回值的方法
    //    {
    //        int sum = 0;
    //        foreach (int item in b)//省略foreach循环语句后面的{}时，
    //            sum += item; //有效语句块仅此一行
    //        return sum;//此句不属foreach的语句块
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int sum = 0;
    //        int[] a = new int[3] { 1, 2, 3 };
    //        ArrayParams s = new ArrayParams();
    //        sum = s.Addnum(a);
    //        Console.WriteLine("sum1={0}", sum);
    //        Console.WriteLine("sum2={0}", s.Addnum(2, 3, 4,4,5,6,7,8,9));
    //    }
    //}

    #endregion

    #region eg3.8-2: 类和对象-方法参数-综合运用
    //public class ArrayParams
    //{
    //    int n = 10;
    //    //方法1：值参数与params参数
    //    public void Addnum(int sum, params int[] b)
    //    {
    //        sum = n;
    //        foreach (int item in b)
    //            sum += item;
    //    }
    //    //方法2：ref与params
    //    public void Addnum(ref int sum, params int[] b)
    //    {
    //        sum = n;
    //        foreach (int item in b)
    //            sum += item;
    //    }
    //    //方法3：无params修饰符的数组参数
    //    public void OutAddnum(out int sum, int[] b)
    //    {
    //        sum = n;
    //        foreach (var item in b)
    //        {
    //            sum += item;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] a = new int[3] { 1, 2, 3 };
    //        ArrayParams s = new ArrayParams();

    //        int x = 0;
    //        s.Addnum(x, a);//调用方法1
    //        Console.WriteLine("方法1：值参数调用x={0}", x);

    //        x = 0;
    //        s.Addnum(ref x, a);//调用方法2，实参a为数组
    //        Console.WriteLine("方法2：params参数为数组调用后 x={0}", x);

    //        x = 0;
    //        int b = 3;
    //        s.Addnum(ref x, b);//调用方法2, 实参b为变量
    //        Console.WriteLine("方法2：params参数为变量调用后 x={0}", x);

    //        x = 0;
    //        s.Addnum(ref x, b, b, b);//调用方法2, 实参b为变量
    //        Console.WriteLine("方法2：params参数为变量调用后 x={0}", x);

    //        x = 0;
    //        s.OutAddnum(out x, a);//
    //        Console.WriteLine("方法3：无params修饰符的数组参数，x={0}", x);

    //        x = 0;
    //        //s.OutAddnum(out x, b);//变量b不被编译器认为是合法的实参
    //    }
    //}

    #endregion

    #region eg3.9: 静态字段和静态方法
    public class Mineral//矿物类
    {
        private int sn;//密度
        private static int counter;

        public int Sn { get => sn; set => sn = value; }
        public static int Counter { get => counter; set => counter = value; }

        public Mineral()
        {
            Sn = Counter;
            Counter++;
        }
        public static int AddUp(int x, int y)
        {
            return x + y;
        }
        public int GetSN()
        {
            return Sn;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Mineral quartz = new Mineral();
            int c = Mineral.AddUp(3, Mineral.Counter);
            Console.WriteLine("c={0}, Mineral.counter={1}", c, Mineral.Counter);//调用静态方法和静态字段
            Console.WriteLine("object sn={0}", quartz.GetSN());//调用对象的方法

            Mineral aa = new Mineral();
            Console.WriteLine("Mineral.counter={0}", Mineral.Counter);//调用静态方法和静态字段
            Console.WriteLine("object sn={0}", aa.GetSN());
            Console.ReadKey();
        }
    }

    #endregion

    #region eg3.10: this~
    //public class Test1
    //{
    //    public string str = "aaa";
    //    public void f(Test1 test)
    //    {
    //        str = "bbb";
    //        Console.WriteLine(test.str);
    //    }
    //    public void f1()
    //    {
    //        f(this);
    //    }

    //    public static void Main()
    //    {
    //        Test1 test = new Test1();
    //        test.f1();
    //    }
    //}

    #endregion

    #region eg3.11: 索引器~
    //class Program
    //{
    //    class Photo
    //    {
    //        string _title;
    //        public Photo(string title)
    //        {
    //            this._title = title;
    //        }
    //        public string Title
    //        {
    //            get
    //            {
    //                return _title;
    //            }
    //        }
    //    }
    //    class Album
    //    {
    //        // 该数组用于存放照片
    //        Photo[] photos;
    //        public Album(int capacity)
    //        {
    //            photos = new Photo[capacity];
    //        }
    //        public Photo this[int index]
    //        {
    //            get
    //            {
    //                // 验证索引范围
    //                if (index < 0 || index >= photos.Length)
    //                {
    //                    Console.WriteLine("索引无效");
    //                    // 使用 null 指示失败
    //                    return null;
    //                }
    //                // 对于有效索引，返回请求的照片
    //                return photos[index];
    //            }
    //            set
    //            {
    //                if (index < 0 || index >= photos.Length)
    //                {
    //                    Console.WriteLine("索引无效");
    //                    return;
    //                }
    //                photos[index] = value;
    //            }
    //        }
    //        public Photo this[string title]
    //        {
    //            get
    //            {
    //                // 遍历数组中的所有照片
    //                foreach (Photo p in photos)
    //                {
    //                    // 将照片中的标题与索引器参数进行比较
    //                    if (p.Title == title)
    //                        return p;
    //                }
    //                Console.WriteLine("未找到");
    //                // 使用 null 指示失败
    //                return null;
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        // 创建一个容量为 3 的相册
    //        Album family = new Album(3);
    //        // 创建 3 张照片
    //        Photo first = new Photo("Jeny ");
    //        Photo second = new Photo("Smith");
    //        Photo third = new Photo("Lono");
    //        // 向相册加载照片
    //        family[0] = first;
    //        family[1] = second;
    //        family[2] = third;
    //        // 按索引检索
    //        Photo objPhoto1 = family[2];
    //        Console.WriteLine(objPhoto1.Title);
    //        // 按名称检索
    //        Photo objPhoto2 = family["Jeny"];
    //        Console.WriteLine(objPhoto2.Title);
    //    }
    //} 
    #endregion

    #region eg3.12-1：常用类和结构-Array类
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i, k;
    //        int[] myarr = new int[10];    //定义一个一维数组
    //                                      //Console.Write("LB={0},UB={1},Length={2}",myarr.GetLowerBound(0), myarr.GetUpperBound(0),myarr.GetLength(0));
    //        Random randobj = new Random();  //定义一个随机对象
    //        for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
    //        {
    //            k = randobj.Next() % 20;           //返回一个0～19的正整数
    //            myarr.SetValue(k, i);           //给数组元素赋值
    //        }
    //        Console.Write("随机数序:");
    //        for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
    //            Console.Write("{0} ", myarr.GetValue(i));
    //        Console.WriteLine();
    //        Array.Sort(myarr);            //数组排序
    //        Console.Write("排序数序:");
    //        for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
    //            Console.Write("{0} ", myarr.GetValue(i));
    //        Console.WriteLine();
    //    }
    //}
    #endregion
}
