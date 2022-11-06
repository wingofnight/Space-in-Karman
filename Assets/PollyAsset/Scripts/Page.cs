using System.Collections;
using System.Collections.Generic;


public class Page
{
    public string Title { get; set; }
    public string Text { get; set; }
    public List<string> Pages { get; set; }

    private static List<Page> _pageList = null;

    public static Page RandomPage;

    public static int CurrentPage1 = 0;
    public static int CurrentPage2 = 1;

    public static Page GetRandomPage()
    {
        List<Page> pageList = PageList;

        int num = UnityEngine.Random.Range(0, _pageList.Count);
        Page pge = pageList[num];
        pge.Pages = new List<string>();

        string[] words = pge.Text.Split(' ');

        foreach (var VARIABLE in PageList)
        {
            pge.Pages.Add(VARIABLE.Text);
        }
        RandomPage = pge;
        /* //put 7 words on each page
        string page = "";
        int wordCnt = 0;

        foreach (string word in words)
        {
            wordCnt++;
            if (wordCnt > 6)
            {
                pge.Pages.Add(page);
                page = "";
                wordCnt = 0;
            }
            page += string.Format("{0}", word);
        }
        pge.Pages.Add(page);

        RandomPage = pge;
        */

        return pge;

    }

    public static List<Page> PageList
    {
        get
        {
            if (_pageList == null)
            {
                _pageList = new List<Page>();
                
                _pageList.Add(new Page()
                {
                    //1
                    Title = "Kocмосправочник",
                    Text = "1.Введение\r" + "\n2.Как запустить эту Чудо-машину\r" + "\n3.Все для комфортного полета\r" + "\n4.Управление направлением полета\r"
                    
                });
                _pageList.Add(new Page()
                {
                    //2
                    Title = "Kocмосправочник",
                    Text = "5.Что делать если вас хотят поиметь?\r" + "\n6.Что делать если вы хотите кого-то поиметь?\r" +"\n7.Когда все очень плохо…"+"\n8.Ну и как мне приземлиться?\r"
                });
                _pageList.Add(new Page()
                {
                    //3
                    Title = "Kocмосправочник",
                    Text = "Удачи разобраться с тем что написано в этой макулатуре.\r" + "\nВведение\r"+ "\n“Итак, Вы решили стать пилотом этого космического летательного аппарата. Внимательно прочитайте этот справочник"
                });
                _pageList.Add(new Page()
                {
                    //4
                    Title = "Kocмосправочник",
                    Text = "перед тем, как покорять просторы космоса.\r" + "\nКак запустить эту Чудо-машину\r" + "Вот он, самый волнительный момент! Подготовка, подача, запуск! Взлетаем! Какое приятное ощущение"
                });
                _pageList.Add(new Page()
                {
                    //5
                    Title = "Kocмосправочник",
                    Text = " где-то внизу живота… Так приятно…\r" + "\n- Подача топлива.(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\n- Подготовка двигателей. (кнопка №_ ОПИСАНИЕ"
                });
                _pageList.Add(new Page()
                {
                    //6
                    Title = "Kocмосправочник",
                    Text = " лялялялявавапрпр)\r" + "\n - Запуск ускорителей. (кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r"+"\n ВСЕ ДЛЯ КОМФОРТНОГО ПОЛЕТА\r"
                });
                _pageList.Add(new Page()
                {
                    //7
                    Title = "Kocмосправочник",
                    Text = "Чудо инженерной мысли, которым Вы управляете оснащено всем необходимым для комфортного полета.Для удобства эти функции также используются и в критических ситуациях,"
                });
                _pageList.Add(new Page()
                {
                    //8
                    Title = "Kocмосправочник",
                    Text = "например при нападении на Ваш корабль.\r" + "\n- Включение кассетной магнитолы (кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\n- Включение вентилятора."
                });
                _pageList.Add(new Page()
                {
                    //9
                    Title = "Kocмосправочник",
                    Text = "(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\n- Включение гирлянд (кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\nУПРАВЛЕНИE"
                });
                _pageList.Add(new Page()
                {
                    //10
                    Title = "Kocмосправочник",
                    Text = " НАПРАВЛЕНИЕМ ПОЛЕТА\r" + "\n- Включение маневровых двигателей.(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\nБольшая зеленая кнопка (кнопка №_)"
                });
                _pageList.Add(new Page()
                {
                    //11
                    Title = "Kocмосправочник",
                    Text = "ЧТО ДЕЛАТЬ ЕСЛИ ВАС ХОТЯТ ПОИМЕТЬ?\r" + "\n-Стабилизатор жизнеобеспечения(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\n-Генератор силового поля"
                });
                _pageList.Add(new Page()
                {
                    //12
                    Title = "Kocмосправочник",
                    Text = "(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\n-Кнопка для звука пердежа(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\nЧТО ДЕЛАТЬ"
                });
                _pageList.Add(new Page()
                {
                    //13
                    Title = "Kocмосправочник",
                    Text = "ЕСЛИ ВЫ ХОТИТЕ КОГО_ТО ПОИМЕТЬ?\r" + "\n-Кнопка насыпания корма для попугая(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\nЖить грустно, а умирать тошно."
                });
                _pageList.Add(new Page()
                {
                    //14
                    Title = "Kocмосправочник",
                    Text = "КОГДА ВСЁ ОЧЕНЬ ПЛОХО…\r" + "\n-молитвы\r" +"\nПодготовка посадочного модуля(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\nНУ И КАК МНЕ"
                });
                _pageList.Add(new Page()
                {
                    //15
                    Title = "Kocмосправочник",
                    Text = "ПРИЗЕМЛИТЬСЯ?\r" + "\nЕсли честно, составляя этот справочник я и не думал, что кто-то доживет до этого момента. По правде сказать, я вообще не думал что этот хлам взлетит…Это все затянувшаяся шутка"
                });
                _pageList.Add(new Page()
                {
                    //16
                    Title = "Kocмосправочник",
                    Text = "… Я не смешной… Никто меня никогда не любил…\r" + "\n-Экстренный тормоз(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" +"\nВливание тормозной жидкости"
                });
                _pageList.Add(new Page()
                {
                    //17
                    Title = "Kocмосправочник",
                    Text = "(кнопка №_ ОПИСАНИЕ лялялялявавапрпр)\r" + "\nБыло что-то ещё...хмм..забыл"
                });
            
            }
            return _pageList;
        }
        
        
        
    }

}
