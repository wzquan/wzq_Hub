 class HelloWorld
    {
         public static void Main()
         // 上面这行代码中，public 标识了这个方法可以被其他类访问，一般情况下在这里可以省略
         // void 声明这个方法没有返回值
         // Main 是这个方法的名称，注意M要大写，也是整个程序的入口点，一个应用程序有有且仅有一个 Main 方法
         // static 声明这是一个静态方法，静态方法可以不必使用 new 标识创建实例便可直接调用这个方法
         // 这里要问为什么 Main 方法一定要标识为 static 的呢？原因如下：
         // 首先我们要了解，标识为static的方法在调用的时候不必使用 new 标识创建对象，但不代表实际上没有创建这个对象，
         // 相反在调用标识为 static 的方法时，运行时环境会自动创建一个static方法所在类的实例。
         // 因为运行时环境在运行这个程序的时候，实际上并不知道 Main 方法所在的类的名字，所以无法创建Main方法所在类
         // 的实例后再运行Main方法，我们把 Main 标识为 static后，运行时环境就可以通过直接调用 Main 方法来自动
         // 创建 Main 方法所在类的实例。
         {
              //我们这是只是输出HelloWorld
              System.Console.WriteLine("Hello World！"); 
              //这句是使命令行窗口等待按键输入，防止我们直接运行exe文件时我们的HelloWorld一闪而过：）
              System.Console.ReadKey();
         }
    }