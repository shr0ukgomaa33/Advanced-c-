using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 

            // : What is a generic class? Why use generics?**
            // generic class is a class that uses a type parameter, allowing it to work with different data types.


            //We use generics because they: 
            //Provide type safety.
            //  Improve code reusability.
            //             Reduce the need for casting.
            //Make code more flexible and maintainable.



            #endregion

            #region Q2

            // Write a generic class Container<T> with Add and Get methods.


            //            class Container<T>
            //  {
            //   private T value;

            //  public void Add(T item)
            //  {
            //      value = item;
            //  }

            //   public T Get()
            //  {
            //       return value;
            //     }
            //  }

            #endregion

            #region Q3 

            // Multiple type parameters mean using more than one generic type parameter in a class.


            //class Pair<TKey, TValue> {
            //public TKey Key { get; set; }
            //public TValue Value { get; set; } }


            #endregion




        }
    }
}
