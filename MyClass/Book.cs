using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Book
    {
        private String author;    // автор 
        private String title;    // название 
        private String publisher;  // издательство 
        private int pages;    // кол-во страниц 
        private int year;      // год издания 

        private static decimal price = 9; // стоимость аренды  за любую книгу

        public string Author
        {
            get { return author; }
            set
            {
                if (value.Length > 10)
                    author = "Ошибка! Имя автора должно быть меньше чем 11 символов!";
                 else
                    author = value;
            }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                    pages = 0;
                else
                    pages = value;
            }
        }

        public String Title { get; set; } // автоматическое свойство
        public String Publisher { get; set; }
        public int Year { get; set; }

        //Статический конструктор, инициализирует статическое поле класса
        static Book()        
        {
            price = 10;
        }

        //Конструктор по-умолчанию
        public Book()       
        {
        }

        // Конструктор инициализирует все поля объекта
        public Book(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        //public Book(String author, String title)
        //{
        //    this.author = author;
        //    this.title = title;
        //}

   

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            Pages = pages;
            Year = year;
        }

        // Метод позволяет изменить стоимость аренды
        public static void SetPrice(decimal price)
        {
            Book.price = price;
        }

        //Метод выводящий на экран информацию о книге
        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4} p. в сутки",
                Author, Title, Year, Pages, Book.price);
        }

        // Метод определяющий стоимость аренды за указанное количество суток 
        public decimal PriceBook(int s)
        {
            decimal cust = s * price;
            return cust;
        }




    }
}
