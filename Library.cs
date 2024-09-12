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

    public void CheckOutBook( string title ){

        Book targetBook = books.FirstOrDefault(book => book.title == title );  // book == it 

        if ( targetBook != null ){
            targetBook.isCheckedOut = true;
            Console.WriteLine("Book is successfully checkout");
        } else{
            Console.WriteLine("Book is not found");
        }
    }

    public void ReturnBook( string title ){
        
        Book targetBook = books.FirstOrDefault(book => book.title == title);

        if ( targetBook != null ) {
             targetBook.isCheckedOut = false;
            Console.WriteLine("Book is successfully returned");
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
