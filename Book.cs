using System;

namespace LibraryProject;

class Book{

public string name;
public string author;
public int year;
public bool isCheckedOut;


public Book(string name, string author, int year, bool isCheckedOut) {
 this.name = name;
 this.author = author;
 this.year = year;
 this.isCheckedOut = isCheckedOut; 
}
    
}