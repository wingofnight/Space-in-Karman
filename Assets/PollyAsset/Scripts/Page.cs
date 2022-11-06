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
                    Text = "Многие думают, что Lorem Ipsum - взятый с потолка псевдо-латинский набор слов, но это не совсем так."
                    
                });
                _pageList.Add(new Page()
                {
                    //2
                    Title = "Kocмосправочник",
                    Text = "Его корни уходят в один фрагмент классической латыни 45 года н.э., то есть более двух тысячелетий назад"
                });
                _pageList.Add(new Page()
                {
                    //3
                    Title = "Kocмосправочник",
                    Text = "Есть много вариантов Lorem Ipsum, но большинство из них имеет не всегда приемлемые модификации, например, юмористические вставки или слова, которые даже отдалённо не напоминают латынь"
                });
                _pageList.Add(new Page()
                {
                    //4
                    Title = "Kocмосправочник",
                    Text = "Он использует словарь из более чем 200 латинских слов, а также набор моделей предложений. В результате сгенерированный Lorem Ipsum выглядит правдоподобно, не имеет повторяющихся абзацей или слов."
                });
                _pageList.Add(new Page()
                {
                    //5
                    Title = "Kocмосправочник",
                    Text = "Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum."
                });
                _pageList.Add(new Page()
                {
                    //6
                    Title = "Kocмосправочник",
                    Text = "Здесь ваш текст.. Здесь ваш текст.. Многие программы электронной вёрстки и редакторы HTML используют"
                });
                _pageList.Add(new Page()
                {
                    //7
                    Title = "Kocмосправочник",
                    Text = "анялся его поисками в классической латинской литературе. В результате он нашёл неоспоримый первоисточник"
                });
                _pageList.Add(new Page()
                {
                    //8
                    Title = "Kocмосправочник",
                    Text = "Таким образом новая модель организационной деятельности влечет за собой процесс внедрения и модернизации"
                });
                _pageList.Add(new Page()
                {
                    //9
                    Title = "Kocмосправочник",
                    Text = "Идейные соображения высшего порядка, а также реализация намеченных плановых заданий требуют"
                });
            }
            return _pageList;
        }
        
        
        
    }

}
