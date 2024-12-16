using OpenQA.Selenium;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Drawing.Imaging;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
//1
//class Program
//{
//    static void Main(string[] args)
//    {
//        IWebDriver driver = new ChromeDriver();

//        try
//        {
//            driver.Navigate().GoToUrl("https://www.example.com");
//            Console.WriteLine("Title of the page is: " + driver.Title);
//            System.Threading.Thread.Sleep(3000);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//        finally
//        {
//            driver.Quit();
//        }
//    }
//}



//2
//class Program
//{
//    static void Main(string[] args)
//    {
//        IWebDriver driver = new ChromeDriver();

//        try
//        {
//            driver.Navigate().GoToUrl("https://www.python.org/");
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            wait.Until(d => d.Title.Contains("Welcome to Python.org"));
//            IWebElement downloadsButton = driver.FindElement(By.LinkText("Downloads"));
//            downloadsButton.Click();
//            wait.Until(d => d.Url.Contains("downloads"));
//            IWebElement searchBox = driver.FindElement(By.Id("id-search-field"));
//            searchBox.SendKeys("python 3.11");
//            IWebElement searchButton = driver.FindElement(By.Id("submit"));
//            searchButton.Click();
//            wait.Until(d => d.Title.Contains("Search Python.org"));
//            Console.WriteLine("Поиск выполнен успешно.");
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine("Произошла ошибка: " + e.Message);
//        }
//        finally
//        {
//            driver.Quit();
//        }
//    }
//}




//3
//class Program
//{
//    static void Main(string[] args)
//    {
//        IWebDriver driver = new ChromeDriver();

//        try
//        {
//            driver.Navigate().GoToUrl("https://www.python.org/");
//            driver.Manage().Window.Maximize();

//            IWebElement headerImage = driver.FindElement(By.XPath("//h1//img"));
//            string imageUrl = headerImage.GetAttribute("src");
//            Console.WriteLine("Ссылка на изображение заголовка (h1): " + imageUrl);

//            Console.WriteLine("\nСсылки из раздела 'About':");
//            IList<IWebElement> aboutLinks = driver.FindElements(By.XPath("//li[@id='about']//a"));
//            foreach (IWebElement link in aboutLinks)
//            {
//                Console.WriteLine(link.GetAttribute("href"));
//            }

//            Console.WriteLine("\nТексты заголовков h2:");
//            IList<IWebElement> headersH2 = driver.FindElements(By.CssSelector("h2"));
//            foreach (IWebElement header in headersH2)
//            {
//                Console.WriteLine(header.Text);
//            }

//            Console.WriteLine("\nСсылки из Navigation Menu:");
//            IList<IWebElement> navMenuLinks = driver.FindElements(By.CssSelector("#mainnav ul.navigation.menu li a"));
//            foreach (IWebElement link in navMenuLinks)
//            {
//                Console.WriteLine(link.GetAttribute("href"));
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Произошла ошибка: " + ex.Message);
//        }
//        finally
//        {
//            driver.Quit();
//        }
//    }
//}



//4
//class Program
//{
//    static void Main(string[] args)
//    {
//        ChromeOptions options = new ChromeOptions();
//        IWebDriver driver = new ChromeDriver(options);

//        string[] urls = { "https://vk.com/video", "https://vk.com/video/trends" };

//        using (StreamWriter writer = new StreamWriter("video_details.txt"))
//        {
//            foreach (var url in urls)
//            {
//                writer.WriteLine(new string('-', 20));
//                writer.WriteLine($"SOURCE: {url}");
//                writer.WriteLine(new string('-', 20));

//                driver.Navigate().GoToUrl(url);

//                IList<IWebElement> videos = driver.FindElements(By.ClassName("VideoCard"));
//                foreach (var video in videos)
//                {
//                    try
//                    {
//                        string title = video.FindElement(By.ClassName("VideoCard__title")).Text;
//                        string views = video.FindElement(By.ClassName("VideoCard__extendedInfoView")).Text;
//                        string dateCreated = video.FindElement(By.ClassName("VideoCard__extendedInfoUpdated")).Text;
//                        string channelName = video.FindElement(By.ClassName("VideoCard__ownerLink")).Text;

//                        writer.WriteLine($"Title: {title}");
//                        writer.WriteLine($"Views: {views}");
//                        writer.WriteLine($"Date Created: {dateCreated}");
//                        writer.WriteLine($"Channel Name: {channelName}");
//                        writer.WriteLine(new string('-', 20));
//                    }
//                    catch (NoSuchElementException ex)
//                    {
//                        Console.WriteLine($"Error processing video: {ex.Message}");
//                    }
//                }
//            }
//        }
//        Thread.Sleep(1000);
//        Process.Start(new ProcessStartInfo("notepad.exe", "video_details.txt") { UseShellExecute = true });

//        driver.Quit();
//    }
//}



//5
//class program
//{
//    static void main(string[] args)
//    {
//        chromeoptions options = new chromeoptions();
//        iwebdriver driver = new chromedriver(options);

//        try
//        {
//            driver.navigate().gotourl("https://ci.nsu.ru/news");
//            iwebelement datefirst = driver.findelement(by.cssselector("input[name=arrfilter_date_active_from_1]"));
//            iwebelement datesecond = driver.findelement(by.cssselector("input[name=arrfilter_date_active_from_2]"));
//            datefirst.sendkeys("01.10.2020");
//            datesecond.sendkeys("01.10.2024" + keys.return);
//            iwebelement loadbutton = driver.findelement(by.cssselector(".morenewslist"));
//            loadbutton.click();
//            ilist<iwebelement> newscards = driver.findelements(by.cssselector(".news-card"));
//            using (streamwriter writer = new streamwriter("result.txt"))
//            {
//                foreach (var card in newscards)
//                {
//                    string date = card.findelement(by.cssselector(".date")).getattribute("innerhtml");
//                    string title = card.findelement(by.cssselector(".name")).getattribute("innerhtml");
//                    string img = card.findelement(by.cssselector(".img-wrap img")).getattribute("src");
//                    string link = card.findelement(by.cssselector(".img-wrap")).getattribute("href");

//                    writer.writeline("{0} {1} {2} {3}", date, title, img, link);
//                }
//            }
//            thread.sleep(1000);
//            process.start(new processstartinfo("notepad.exe", "result.txt") { useshellexecute = true });
//        }
//        finally
//        {
//            driver.quit();
//        }
//    }
//}





//6
//class Program
//{
//    static void Main()
//    {
//        using (IWebDriver driver = new ChromeDriver())
//        {
//            try
//            {
//                // Задача 1: Работа с контекстным меню
//                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

//                IWebElement box = driver.FindElement(By.Id("hot-spot"));
//                Actions actions = new Actions(driver);
//                actions.ContextClick(box).Perform(); // Открытие контекстного меню

//                // Принятие окна подтверждения
//                IAlert alert = driver.SwitchTo().Alert();
//                alert.Accept(); // Закрытие предупреждения

//                // Задача 2: Загрузка файла
//                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

//                // Создание пустого текстового файла для загрузки
//                string filePath = Path.Combine(Environment.CurrentDirectory, "empty.txt");
//                File.WriteAllText(filePath, string.Empty); // Запись пустого файла

//                // Проверка, что файл существует
//                if (File.Exists(filePath))
//                {
//                    Console.WriteLine($"Файл создан по пути: {filePath}");
//                }
//                else
//                {
//                    Console.WriteLine("Ошибка: файл не найден!");
//                    return; // Прерывание выполнения, если файл не существует
//                }

//                // Загрузка файла
//                IWebElement uploadElement = driver.FindElement(By.Id("file-upload"));
//                uploadElement.SendKeys(filePath); // Загрузка файла

//                // Нажатие кнопки "Upload"
//                driver.FindElement(By.Id("file-submit")).Click(); // Нажатие кнопки "Upload"

//                // Проверка загруженного файла
//                var uploadedFileElement = driver.FindElement(By.Id("uploaded-files"));
//                Console.WriteLine($"Загруженный файл: {uploadedFileElement.Text}"); // Вывод имени загруженного файла

//                Console.WriteLine("Задание выполнено успешно!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Произошла ошибка: {ex.Message}");
//            }
//        }
//    }
//}


//7
//class Program
//{
//    static void Main(string[] args)
//    {
//        IWebDriver driver = new ChromeDriver();
//        driver.Manage().Window.Maximize();
//        List<string> titles = new List<string>();
//        driver.Navigate().GoToUrl("https://ru.wikipedia.org");
//        for (int i = 0; i < 5; i++)
//        {
//            driver.FindElement(By.LinkText("Случайная статья")).Click();
//            System.Threading.Thread.Sleep(2000); // Пауза для загрузки
//            string title = driver.Title;
//            titles.Add(title);
//        }
//        driver.SwitchTo().NewWindow(WindowType.Tab);
//        driver.Navigate().GoToUrl("https://en.wikipedia.org");
//        for (int i = 0; i < 5; i++)
//        {
//            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Special:Random");
//            System.Threading.Thread.Sleep(2000);
//            string title = driver.Title;
//            titles.Add(title);
//        }
//        driver.SwitchTo().NewWindow(WindowType.Tab);
//        driver.Navigate().GoToUrl("https://www.base64encode.org/");
//        Console.WriteLine("Заголовки:");
//        foreach (var title in titles)
//        {
//            Console.WriteLine(title);
//        }

//        Console.WriteLine("\nЗаголовки в Base64:");
//        foreach (var title in titles)
//        {
//            string base64Title = Convert.ToBase64String(Encoding.UTF8.GetBytes(title));
//            Console.WriteLine(base64Title);
//        }
//        driver.Quit();
//    }
//}

//8

class Program
{
    static void Main()
    {
        ChromeOptions options = new ChromeOptions();
        IWebDriver driver = new ChromeDriver(options);

        // Список URL для открытия
        string[] urls = {
            "https://translate.yandex.ru/translator",
            "https://www.culture.ru/literature/poems/author-aleksandr-pushkin"
        };

        // Открываем страницу со стихами Пушкина
        driver.Navigate().GoToUrl(urls[1]);

        // Ждем, пока загрузятся элементы со стихами
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        wait.Until(driver => driver.FindElements(By.CssSelector(".ICocV")).Count > 0);

        // Сохраняем ссылки на первые 8 стихотворений
        List<string> poemLinks = new List<string>();
        IList<IWebElement> poemElements = driver.FindElements(By.CssSelector(".ICocV"));
        for (int i = 0; i < 8 && i < poemElements.Count; i++)
        {
            poemLinks.Add(poemElements[i].GetAttribute("href"));
        }

        // Сохраняем тексты стихов
        List<string> poems = new List<string>();
        foreach (string link in poemLinks)
        {
            driver.Navigate().GoToUrl(link);

            // Ждем загрузки контента стихотворения
            wait.Until(driver => driver.FindElement(By.CssSelector("div[data-content='text']")).Displayed);

            // Извлекаем текст стихотворения
            string content = driver.FindElement(By.CssSelector("div[data-content='text']")).Text;
            poems.Add(content);
            Console.WriteLine($"Стих:\n{content}\n");

            // Возвращаемся на страницу со списком стихов
            driver.Navigate().Back();
        }

        //Открытие второй вкладки - Яндекс переводчика
        driver.SwitchTo().NewWindow(WindowType.Tab);
        driver.Navigate().GoToUrl("https://translate.yandex.ru");

        // Явное ожидание загрузки переводчика
        wait.Until(d => d.FindElement(By.XPath("//*[@id='app']/body")).Displayed);

        // Словарь для хранения переведенных стихов
        Dictionary<int, string> translatedPoems = new Dictionary<int, string>();

        // Перевод стихов на английский
        for (int i = 0; i < poems.Count; i++)
        {
            string originalPoem = poems[i];
            IWebElement inputBox = driver.FindElement(By.CssSelector("#fakeArea"));
            IWebElement outputBox = driver.FindElement(By.XPath("//*[@id=\"dstBox\"]/div[1]"));

            // Очистить поле ввода
            inputBox.Clear();

            // Вводим стихотворение в поле ввода
            inputBox.SendKeys(originalPoem);

            // Ожидаем, пока перевод не появится в поле перевода
            wait.Until(d => outputBox.Text.Length > 0);  // Ждем, пока не появится текст в поле

            // Получаем переведенный текст
            string translatedPoem = outputBox.Text;

            // Сохраняем переведенные стихотворения
            translatedPoems.Add(i + 1, translatedPoem);

            Console.WriteLine($"Стихотворение {i + 1} переведено.");
        }

        // Запись в текстовый файл
        using (StreamWriter sw = new StreamWriter("translated_poems.txt"))
        {
            for (int i = 0; i < poems.Count; i++)
            {
                sw.WriteLine($"Стихотворение {i + 1}:");
                sw.WriteLine("Оригинал на русском:");
                sw.WriteLine(poems[i]);
                sw.WriteLine("Перевод на английский:");
                sw.WriteLine(translatedPoems[i + 1]);
                sw.WriteLine();
            }
        }

        // Закрытие драйвера
        driver.Quit();

        Console.WriteLine("Задача выполнена. Переведенные стихи сохранены в 'translated_poems.txt'.");
    }
}