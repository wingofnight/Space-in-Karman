using System;
using System.Collections;
using System.Collections.Generic;


public static class AppEvents
{
    public static event EventHandler CloseBook;
    public static event EventHandler OpenBook;

    public static void CloseBookFunktion()
    {
        if (CloseBook != null)
        {
            CloseBook(new object(), new EventArgs());
        }
    }
    
    public static void OpenBookFunktion()
    {
        if (OpenBook != null)
        {
            OpenBook(new object(), new EventArgs());
        }
    }
}
