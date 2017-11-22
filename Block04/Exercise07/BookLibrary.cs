using System;
using System.Collections.Generic;

namespace Exercise07
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private DateTime releaseDate;
        private long isbn;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }

        public long Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

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

            informations[0] = title;
            informations[1] = author;
            informations[2] = publisher;
            informations[3] = releaseDate.ToString();
            informations[4] = isbn.ToString();

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
        private string name;
        private List<Book> bookList = new List<Book>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<Book> BookList
        {
            get
            {
                return bookList;
            }
            set
            {
                bookList = value;
            }
        }



        public Library(string name)
        {
            Name = name;
        }

        public Library() : this(null)
        {

        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public Book SearchBook(string author)
        {
            try
            {
                return bookList.Find(x => (x.Author == author));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public string[] DisplayBook(Book book)
        {
            return bookList.Find(x => x.Equals(book)).DisplayBook();
        }

        public void DeleleBook(Book book)
        {
            bookList.Remove(book);
        }

        
    }
}
