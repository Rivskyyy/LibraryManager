using System;

namespace LibraryProject;

class Library{

    public List<Book> books = new List<Book>();

    public void AddBook ( Book book ){

        books.Add(book);
    }

    public void FindBook ( string title ){

        Book targetBook = books.FirstOrDefault(book => book.title == title);
        
        if ( targetBook != null ){
            Console.WriteLine($"Book deleted: {targetBook}");
        } else {
            Console.WriteLine("Book is not found");
        }

    }

    public void RemoveBook ( string title ){

            Book targetBook = books.FirstOrDefault (book => book.title == title);

            if ( targetBook != null ){
                books.Remove(targetBook);
                 Console.WriteLine("Book successfully deleted");
                 
            } else{
                Console.WriteLine("Book is not found");
            }
    }

    public void ShowAllBooks(){

        foreach (Book book in books){
        Console.WriteLine(book);
        }
        
    }

}
