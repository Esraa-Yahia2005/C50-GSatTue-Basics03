using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Text;

namespace Assignment2_Roote
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.

            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine("Title: " + title);
            Console.WriteLine("UpperTitle: " + upperTitle);

            #endregion



            #region Question2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            //to check if they point to the same object in memory.

            string S1 = "Clean Code";
            string S2 = "Clean Code";

            bool areSame = ReferenceEquals(S1, S2);

            Console.WriteLine(areSame);

            #endregion


            #region Question3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            //object.Print the final result.

            StringBuilder sb = new StringBuilder("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);


            #endregion

            #region Question4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
            //Print the result.

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);

            #endregion


            #region Question5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
            // Pages: 464" using the + operator. 

            string Title = "Clean Code";
            int Pages = 464;
            Console.WriteLine("Book: " + Title + ", Pages: " + Pages);

            #endregion

            #region Question6
            //Build the same sentence as above, but using string interpolation ($"...").

            Console.WriteLine($"Book: {Title}, Pages: {Pages}");


            #endregion 


        }
    }
}
