using System.Reflection;

namespace Rrrrr
{
    internal class Program
    {
       

        static void Main(string[] args) 
        {




            Fruit[] Basket = new Fruit[3];

            Basket[0] = new Apple { Price = 1, Sort = "White apple", VitaminA = 5, VitaminB = 2 };
            Basket[1] = new Pinapple { Price = 4, Sort = "Africa Pinapple", VitaminE = 4, VitaminD = 3 };
            Basket[2] = new Orange { Price = 1, Sort = "Lankaran Orange", VitaminC = 6 };

           
            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine("Type: " + type.Name);
                FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine(field.Name + ": " + field.GetValue(fruit));
                }
                
            }

























            //Assembly assembly = Assembly.GetExecutingAssembly();

            // Type[] types = assembly.GetTypes();    
            // foreach ( Type type in types )
            // {
            //     Console.WriteLine( type.Name +"----------");
            //     foreach (var item in type.GetMembers())
            //     {
            //         Console.WriteLine(item.Name);
            //     }



            //// }
            //Animal animal = new Animal();

            // var type =animal.GetType();

            // var field = type.GetField("name",BindingFlags.NonPublic | BindingFlags.Instance);

            // field.SetValue(animal,(int)257);

            // Console.WriteLine(field.GetValue(animal));




            //Type types = type.GetType();


            //foreach (var t in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            //{
            //    Console.WriteLine(t);
            //}

        }
    }
}