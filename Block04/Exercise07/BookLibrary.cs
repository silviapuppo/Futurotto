using System;
using System.Collections.Generic;

namespace Exercise07
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long Isbn { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, long isbn)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
        }

        public Book() : this(null, null, null, DateTime.Now, 0)
        {

        }

        public string[] DisplayBook()
        {
            string[] informations = new string[5];

            informations[0] = Title;
            informations[1] = Author;
            informations[2] = Publisher;
            informations[3] = ReleaseDate.ToString();
            informations[4] = Isbn.ToString();

            return informations;

        }

        public bool Equals(Book book)
        {
            bool titleBool = (Title == book.Title);
            bool authorBool = (Author == book.Author);
            bool publisherBool = (Publisher == book.Publisher);
            bool dateBool = (ReleaseDate == book.ReleaseDate);
            bool isbnBool = (Isbn == book.Isbn);

            if (titleBool && authorBool && publisherBool && dateBool && isbnBool)
            {
                return true;
            }

            return false;
        }


    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> BookList { get; set; } = new List<Book>();


        public Library(string name)
        {
            Name = name;
        }

        public Library() : this(null)
        {

        }

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }

        public Book[] SearchBookByAuthor(string author)
        {
            int index = 0;

            foreach (Book b in BookList)
            {
                if (b.Author == author)
                {
                    index++;
                }
            }

            Book[] found = new Book[index];
            index = 0;

            foreach (Book b in BookList)
            {
                if (b.Author == author)
                {
                    found[index] = b;
                    index++;
                }
            }

            return found;
        }

        public string[] DisplayBook(Book book)
        {
            foreach (Book b in BookList)
            {
                if (b.Equals(book))
                {
                    return b.DisplayBook();
                }
            }
            return null;
        }

        public void DeleleBook(Book book)
        {
            BookList.Remove(book);
        }
    }
}
