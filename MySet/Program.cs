// See https://aka.ms/new-console-template for more information
using MySet;
//MyStringSet set1 = new MyStringSet(new string[] { "a", "b", "c", "d", "e", "c", "d", "e" });
//Console.WriteLine("qweq");
/*MyStringSet set1 = new MyStringSet(new string[] { "a", "b", "c", "d", "e", "c", "d", "e" });
MyStringSet set2 = new MyStringSet(new string[] { "k", "z", "x", "n", "g", "c", "f", "e" });

set1.Add("sdfds");

Console.WriteLine("Set1:");
foreach (var item in set1)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nSet2:");

foreach (var item in set2)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 UNION Set2");

foreach (var item in MyStringSet.Union(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 INTERSECTION Set2");

foreach (var item in MyStringSet.Intersection(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 COMPLEMENT Set2");

foreach (var item in MyStringSet.Complement(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 DISJUNCTION UNION Set2");

foreach (var item in MyStringSet.DisjunctionUnion(set1, set2))
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n\n");
*/

MySet<string> set1 = new MySet<string>(new string[] { "a", "b", "c", "d", "e", "c", "d", "e"  });
MySet<string> set2 = new MySet<string>(new string[] { "k", "z", "x", "n", "g", "c", "f", "e" });

Console.WriteLine("Set1:");
foreach (var item in set1)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nSet2:");

foreach (var item in set2)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 UNION Set2");

foreach (var item in MySet<string>.Union(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 INTERSECTION Set2");

foreach (var item in MySet<string>.Intersection(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 COMPLEMENT Set2");

foreach (var item in MySet<string>.Complement(set1, set2))
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nSet1 DISJUNCTION UNION Set2");

foreach (var item in MySet<string>.DisjunctionUnion(set1, set2))
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n\n");


