using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class

class MyBook : Book
{
    private int price;
    public MyBook(string title, string author, int myPrice) : base(title, author)
    {
        price = myPrice;
    }
    
    public override void display()
    {
        Console.WriteLine("Title: "+ title);
        Console.WriteLine("Author: "+ author);
        Console.WriteLine("Price: "+ price);
    }
}
//inheritance