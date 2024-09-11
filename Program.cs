/*
Домашнє завдання: Проект на базові теми C#
Опис завдання: Створіть консольний додаток на C#, який моделює систему управління бібліотекою.
Цей проект допоможе вам закріпити знання з основних тем, таких як колекції, класи, методи, властивості,
та базові принципи об'єктно-орієнтованого програмування.

Вимоги до проекту:
1. Моделювання класів:
Створіть клас Book, який має такі властивості:

Title (назва книги)
Author (автор)
Year (рік видання)
IsCheckedOut (чи книга в бібліотеці, чи видана)
Створіть клас Library, який містить колекцію книг та методи для управління бібліотекою:

Додати книгу до бібліотеки (AddBook(Book book))
Видалити книгу з бібліотеки (RemoveBook(string title))
Знайти книгу за назвою (FindBook(string title))
Видати книгу читачу (CheckOutBook(string title))
Повернути книгу в бібліотеку (ReturnBook(string title))
Показати всі доступні книги (ShowAvailableBooks())
2. Робота з колекціями:
Використовуйте List<Book> для зберігання списку книг у бібліотеці.
Використовуйте методи LINQ для фільтрації книг (наприклад, знаходження книги за назвою).
3. Взаємодія з користувачем:
Додайте простий інтерфейс взаємодії з користувачем через консоль.
Користувач повинен мати можливість додавати книги, видаляти їх, шукати книги за назвою, брати книги на читання та повертати їх.
Використовуйте меню з кількома опціями для користувача (напр., "1. Додати книгу", "2. Видалити книгу", і т.д.).
4. Обробка помилок:
Забезпечте обробку помилок, наприклад:
Перевірка, чи є книга в бібліотеці перед тим, як її видати.
Перевірка, чи введено правильні дані від користувача.
5. Збереження стану бібліотеки:
Додатково (необов'язково): Додайте функціонал збереження та завантаження стану бібліотеки з файлу (наприклад, у форматі JSON).
*/


using System;

namespace LibraryProject;

class Program {

    static void Main(string[] args){

      Library library= new Library();
      
        ShowMenu(library);
       
 }

 private static void ShowMenu(Library library){

        Console.WriteLine("Choose option:");
        Console.WriteLine("1.Add book");
        Console.WriteLine("2.Delete book");
        Console.WriteLine("3.Find book");
        Console.WriteLine("4.Checkout book");
        Console.WriteLine("5.Return book");
        Console.WriteLine("6.Show available books");

        int userChoise = Convert.ToInt32(Console.ReadLine());
         switch(userChoise){
            case 1:
             Console.WriteLine("Adding book:");
             Console.WriteLine("Name: " );
            string nameInput =  Console.ReadLine().Trim();
             Console.WriteLine("Author: " );
            string authorInput = Console.ReadLine().Trim();
             Console.WriteLine("Year: " );
            int year = Console.ReadLine().Trim().ToString().IndexOf("");
            
            Book newBook = new Book(nameInput, authorInput, year, false);
            Console.WriteLine("Your book successfully added!");
            library.AddBook(newBook);
            ShowMenu(library);
            break;

            case 2:
            Console.WriteLine("Enter the title:");
            string userInputTargetBookToDelete = Console.ReadLine().Trim();
            library.RemoveBook(userInputTargetBookToDelete);
            Back(library);
            break;

            case 3:
            Console.WriteLine("Enter the title:");
            string userInputTargetBook = Console.ReadLine().Trim();
            library.FindBook(userInputTargetBook);
            Back(library);
            break;

            case 6:
            library.ShowAllBooks();
            Back(library);
            break;
        }
 }

 public static void Back (Library library){
   Console.WriteLine("0.Back");
          int userInputAfterShowBooks = Convert.ToInt32(Console.ReadLine().Trim());
          if(userInputAfterShowBooks == 0)
            ShowMenu(library);
 }
}

