using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace assignment_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ-restriction operators
            #region question 1
            //1. Find all products that are out of stock.

            //LINQ query to find all products with zero stock (fluent syntax)
            ////var outOfStock = ListGenerator.ProductsList.Where(O => O.UnitsInStock == 0);
            ////OR
            ////LINQ quesry to find all products with zero stock (Query syntax)
            //var outOfStock = from O in ListGenerator.ProductsList
            //             where O.UnitsInStock == 0
            //             select O;
            //foreach (var item in outOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 2
            //2. Find all products that are in stock and cost more than 3.00 per unit.

            ////fluent syntax
            ////var expansiveInStockProduct = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            ////Or
            ////query syntax
            //var expansiveInStockProduct = from P in ListGenerator.ProductsList
            //                              where P.UnitsInStock > 0 && P.UnitPrice > 3
            //                              select P;
            //foreach (var item in expansiveInStockProduct)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 3
            //3. Returns digits whose name is shorter than their value.


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shortDigits = Arr.Where((D, I) => D.Length < I);
            //foreach (var item in shortDigits)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ-Odering Operators
            #region question 1
            //1.Sort a list of products by name

            //var sortProductByName = ListGenerator.ProductsList.OrderBy(P => P.ProductName);
            //foreach (var item in sortProductByName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 2
            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortWords = Arr.OrderBy(W => W, new CustomStringComparer());
            //foreach (var item in sortWords)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 3
            //3. Sort a list of products by units in stock from highest to lowest.

            ////fluent syntax
            ////var sortProductByStock = ListGenerator.ProductsList.OrderByDescending(P => P.UnitsInStock);
            ////OR
            ////Query syntax
            //var sortProductByStock = from P in ListGenerator.ProductsList
            //                         orderby P.UnitsInStock descending
            //                         select P;
            //foreach (var item in sortProductByStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 4
            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////fluent syntax
            ////var sortDigit = Arr.OrderBy(D => D.Length).ThenBy(D => D);

            ////OR

            ////query syntax
            //var sortDigit = from D in Arr
            //                orderby D.Length, D
            //                select D;
            //foreach (var item in sortDigit)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 5
            //5.Sort first by word length and then by a case -insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////fluent syntax
            ////var sortWords = words.OrderBy(W => W.Length).ThenBy(W => W, new CustomWordComparer());
            ////OR
            ////query syntax
            //var sortWords = from w in words
            //            orderby w.Length, w
            //            select w;
            //foreach (var item in sortWords)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 6
            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            ////fluent syntax
            ////var sortProductByCategory = ListGenerator.ProductsList.OrderBy(P => P.Category).OrderByDescending(P => P.UnitPrice);

            ////OR

            //var sortProductByCategory = from P in ListGenerator.ProductsList
            //                        orderby P.Category, P.UnitPrice
            //                        select P;
            //foreach (var item in sortProductByCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 7
            //7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortWords = Arr.OrderBy(W => W.Length).ThenByDescending(W => W, new CustomWordComparer());
            //foreach (var item in sortWords)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region question 8
            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var reverseDigit = Arr.Where(W => W.Length > 1 && W[1] == 'i').Reverse();
            //foreach (var item in reverseDigit)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }
}
