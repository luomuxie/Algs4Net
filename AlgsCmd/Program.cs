using Algs4Net;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AlgsCmd
{
    class Program
  {    
    static void Main(string[] args)
    {
        int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 22 };
        Assert.AreEqual(1, BinarySearch.IndexOf(a, 1));
        Assert.AreEqual(-1, BinarySearch.IndexOf(a, 20));
        Assert.AreEqual(-1, BinarySearch.IndexOf(a, 25));
        Assert.AreEqual(1, BinarySearch.IndexOf(a, 4));
        Assert.AreEqual(5, BinarySearch.IndexOf(a, 12));
        Assert.AreEqual(9, BinarySearch.IndexOf(a, 22));

    }
  }
}
