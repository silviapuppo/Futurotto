using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise07
    {
        [TestMethod]
        public void TestLibrary()
        {
            Library library = new Library();

            Book book1 = new Book("Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11, 10), 9788804682028);
            Book book2 = new Book("Ogni storia è una storia d'amore", "Alessandro D'Avenia", "Mondadori", new DateTime(2017, 09, 30), 9788804681571);
            Book book3 = new Book("Origin", "Dan Brown", "Mondadori", new DateTime(2017, 10, 03), 9788804681960);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            string[] infoBook1 = { "Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11, 10).ToString(), "9788804682028" };
            string[] infoBook2 = { "Ogni storia è una storia d'amore", "Alessandro D'Avenia", "Mondadori", new DateTime(2017, 09, 30).ToString(), "9788804681571" };
            string[] infoBook3 = { "Origin", "Dan Brown", "Mondadori", new DateTime(2017, 10, 03).ToString(), "9788804681960" };

            CollectionAssert.AreEqual(infoBook1, library.DisplayBook(book1));
            CollectionAssert.AreEqual(infoBook2, library.DisplayBook(book2));
            CollectionAssert.AreEqual(infoBook3, library.DisplayBook(book3));

        }

        [TestMethod]
        public void TestLibraryDelete()
        {
            Library library = new Library();

            Book book1 = new Book("Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11, 10), 9788804682028);
            Book book2 = new Book("Ogni storia è una storia d'amore", "Alessandro D'Avenia", "Mondadori", new DateTime(2017, 09, 30), 9788804681571);
            Book book3 = new Book("Doctor Sleep", "Stephen King", " Sperling & Kupfer", new DateTime(2013, 09, 20), 9788804681123);
            Book book4 = new Book("La casa del buio", "Stephen King", " Sperling & Kupfer", new DateTime(2001, 05, 05), 9788804681456);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Book[] kingBook = library.SearchBookByAuthor("Stephen King");

            foreach (Book b in kingBook)
            {
                library.DeleleBook(b);
            }

            string[] infoBook1 = { "Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11, 10).ToString(), "9788804682028" };
            string[] infoBook2 = { "Ogni storia è una storia d'amore", "Alessandro D'Avenia", "Mondadori", new DateTime(2017, 09, 30).ToString(), "9788804681571" };

            Assert.AreEqual(2, library.BookList.Count);
            CollectionAssert.AreEqual(infoBook1, library.DisplayBook(book1));
            CollectionAssert.AreEqual(infoBook2, library.DisplayBook(book2));

        }

    }
}
