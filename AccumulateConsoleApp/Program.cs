﻿//Instructions
//Implement the accumulate operation, which, given a collection and an operation to perform on each element of the collection, returns a new collection containing the result of applying that operation to each element of the input collection.

//Given the collection of numbers:

//1, 2, 3, 4, 5
//And the operation:

//square a number (x => x * x)
//Your code should be able to produce the collection of squares:

//1, 4, 9, 16, 25
//Check out the test suite to see the expected function signature.

//Restrictions
//Keep your hands off that collect/map/fmap/whatchamacallit functionality provided by your standard library! Solve this one yourself using other basic tools instead.

//To be more specific, you are not allowed to use any of the built-in LINQ methods.

//Laziness test
//Since accumulate returns an IEnumerable, it's execution is deferred until ToList() it is called on it, which is tested with the Accumulate_is_lazy method

//Hints
//This exercise requires you to write an extension method. For more information, see this page.



int[] inputArray = new[] { 1, 4, 9 };

int[] outputArray = ((int[])new [] { 1, 2, 3 }.Accumulate(x => x * x));

foreach (int i in outputArray)
{
    Console.WriteLine($"i = {i}");
}

Console.WriteLine("helloo world");
Console.ReadLine();

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> returnList = new List<U>();

        foreach (T item in collection)
        {
            returnList.Add(func(item));
        }
        return returnList.ToList();
    }

}