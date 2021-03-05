using System;
class HelloWorld
{
  static void Main()
  {
      // instantiating our objects
      Book myBook = new Book();
      Book yourBook = new Book();
      
      // assigning our abjects values
      myBook.Title = "The alchemist";
      yourBook.Title = "Cant hurt me";
      
      // calling the AdvertisingMessage() method from Main()
      myBook.AdvertisingMessage();
      yourBook.AdvertisingMessage();
  }
}

class Book
{
    // fields. private most of the time
    private string title;
    private int numPages;
    private int price;
    
    // property for title. public all the time. Always the field name with a capital ist initial
    public string Title
    {
        get
        {
             return this.title;
        }
        set
        {
            this.title = value;
        }
    }
    
    // method located in the Book class
    // you can call it with an object + dot + method identifier
    public void AdvertisingMessage()
    {
        Console.WriteLine("Buy it now: {0}", this.Title);
    }
}
