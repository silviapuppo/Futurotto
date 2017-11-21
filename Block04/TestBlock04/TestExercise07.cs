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

            Book book1 = new Book("Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11 ,10), 9788804682028);
            Book book2 = new Book("Ogni storia è una storia d'amore", "Alessandro D'Avenia", "Mondadori", new DateTime(2017, 09, 31), 9788804681571);
            Book book3 = new Book("Quando tutto inizia", "Fabio Volo", "Mondadori", new DateTime(2017, 11, 10), 9788804682028);



        }
    }
}
