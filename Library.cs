using System;

namespace LibraryProject;

class Library{

    public List<Book> books = new List<Book>();

    public void AddBook ( Book book ){
      
        books.Add(book);

    }

    

}