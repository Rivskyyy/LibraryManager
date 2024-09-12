using System;

namespace LibraryProject;

class Book{

public string title;
public string author;
public int year;
public bool isCheckedOut;


public Book(string name, string author, int year, bool isCheckedOut) {
 this.title = name;
 this.author = author;
 this.year = year;
 this.isCheckedOut = isCheckedOut; 
}

override public string ToString() {
    return "Title: " + title + "\nAuthor: " + author + "\nYear: " + year + "\nIsCheckOut: " + isCheckedOut;
}
    
}