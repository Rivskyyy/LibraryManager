using System;

namespace LibraryProject;

class Library{

    public List<Book> books = new List<Book>();


    
    public void AddBook ( Book book ){
        
        books.Add(book);

    }

    

    public void RemoveBook ( string title ){

    }

    public void ShowAllBooks(){

        foreach (Book book in books){
        Console.WriteLine(book);
        }
        
    }

    

}