using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.
            ////string title = "clean code";
            ////string upperTitle = title.ToUpper();
            ////Console.WriteLine(upperTitle);
            ////Console.WriteLine(title);
            #endregion

            #region Q2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            ////string first = "clean code";
            ////string second = "clean code";
            ////Console.WriteLine(ReferenceEquals(first, second));
            #endregion

            #region Q3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            ////StringBuilder sb = new StringBuilder();
            ////sb.Append("book list");
            ////sb.Append(" - updated");
            ////Console.WriteLine(sb);
            #endregion

            #region Q4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            ////sb.Replace("book list", "library");
            ////Console.WriteLine(sb);
            #endregion

            #region Q5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.
            string title = "Clean Code";
            int pages = 464;
            ////Console.WriteLine("book:"+title+ ", pages=" +pages);
            #endregion

            #region Q6
            //Build the same sentence as above, but using string interpolation ($"...").
            ////Console.WriteLine($"book:{title} , pages= {pages}");
            #endregion

            #region Q7
            //Build the same sentence again, but using string.Format().
            Console.WriteLine(string.Format("title: {0} , pages= {1}", title, pages));
            #endregion

        }
    }
}
