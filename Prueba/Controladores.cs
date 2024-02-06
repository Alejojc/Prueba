using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;


namespace Prueba
{
    class Controladores
    {
        public IWebDriver Nave;
        SelectElement selectElement = null;
        IWebElement element;

        private string texto;
        public void Aspect()
        {

        }
        public void Driver(string URL)
        {
            try
            {
                ChromeDriverService Service;
                Service = ChromeDriverService.CreateDefaultService();
                Service.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AddArguments("--lang=es");
                options.AddArguments("--disable-popup-blocking");
                options.AddArguments("--disable-notifications");
                options.AddArguments("--disable-md-downloads");
                options.AddArguments("--disable-infobars");
                options.AddArguments("--allow-running-insecure-content");
                options.AddArguments("--safebrowsing-disable-download-protection");
                options.AddArguments("--safebrowsing-disable-extension-blacklist");
                options.AddUserProfilePreference("safebrowsing.enabled", true);
                options.AddUserProfilePreference("download.directory_upgrade", true);
                options.AddUserProfilePreference("download.default_directory", @"C:\Robot Contratos\Downloads\");
                options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);
                options.AddUserProfilePreference("download.prompt_for_download", false);
                //options.AddAdditionalCapability("useAutomationExtension", false);
                Nave = new ChromeDriver(Service, options);
                Nave.Manage().Window.Maximize();
                Nave.Navigate().GoToUrl(URL);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        public void Cerrar()
        {
            //Esperar(2);
            Nave.Quit();
        }
        public void Refresh(string URL)
        {
            Nave.Navigate().GoToUrl(URL);
        }
        public void Esperar(int Tiempo)
        {
            Thread.Sleep(Tiempo * 1000);
        }
        public void ClickXP(string Obj)
        {
            try
            {
                //Nave.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                Nave.FindElement(By.XPath(Obj)).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló Click XPath: " + Obj + ": " + e);
            }

        }

        public void SelectOption(string Obj, string Texto)
        {
            try
            {
                element = Nave.FindElement(By.XPath(Obj));
                selectElement = new SelectElement(element);
                selectElement.SelectByText(Texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Err Select: " + e);
            }
        }
        public void TextoXP(string Obj)
        {
            try
            {
                texto = Nave.FindElement(By.XPath(Obj)).GetAttribute("value");

                Console.WriteLine("Capturado Texto XPath: " + Obj + " -> Texto: " + texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló Captura Texto XPath: " + Obj + ": " + e);
            }

        }

        public void TextoXPE(string Obj)
        {
            texto = "";
            try
            {
                texto = Nave.FindElement(By.XPath(Obj)).Text;

                Console.WriteLine("Capturado Texto XPath: " + Obj + " -> Texto: " + texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló Captura Texto XPath: " + Obj + ": " + e);
            }

        }



        public void ClickCS(string Obj)
        {
            Nave.FindElement(By.CssSelector(Obj)).Click();
        }
        public void ClickId(string Obj)
        {
            try
            {
                Nave.FindElement(By.Id(Obj)).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló Click Id: " + Obj + " : " + e);
            }

        }
        public void SetearXP(string Obj, string Valor)
        {
            try
            {
                //Nave.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Nave.FindElement(By.XPath(Obj)).SendKeys(Valor);
                Console.WriteLine("Seteo Exitoso: " + Obj + " Valor: " + Valor);
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló Setear XPath: " + Obj + ": " + e);
            }

        }

        public void CambiarFrame(string InnerId)
        {
            try
            {
                Nave.SwitchTo().Frame(Nave.FindElement(By.XPath("//iframe[@innerid='" + InnerId + "']")));
                Console.WriteLine("Frame -> " + InnerId + " ha sido cambiado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Frame -> " + InnerId + " no seleccionado: " + e);
            }

        }

        public void ScrollDown(int Pix)
        {
            IJavaScriptExecutor js = Nave as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0," + Pix + ")");
        }
        public void BuscarElemento(string etiqueta)
        {
            try
            {
                IReadOnlyCollection<IWebElement> Elms = Nave.FindElements(By.TagName(etiqueta));
                foreach (IWebElement n in Elms)
                {
                    Console.WriteLine(n.Text + " -> " + n.TagName);
                }
            }
            catch (Exception)
            {
            }

        }
        public void Frame(string srcframe)
        {
            try
            {
                Nave.SwitchTo().Frame(Nave.FindElement(By.XPath(srcframe)));
                Console.WriteLine("Seleccionado frame src=" + srcframe);
            }
            catch (Exception e)
            {
                Console.WriteLine("No selec frame " + srcframe + " :" + e);
            }

        }


        public void RestFrame()
        {
            try
            {
                Nave.SwitchTo().DefaultContent();
                Console.WriteLine("Reseteado Frame");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al Resetear Frame: " + e);
            }

        }


        public void Clear(string Obj)
        {
            try
            {
                //Nave.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Nave.FindElement(By.XPath(Obj)).Clear();
                Console.WriteLine("Limpiado con éxito: " + Obj);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al limpiar -> " + Obj + " : " + e);
            }
        }


        public bool IsVisible(string Obj)
        {
            try
            {
                if (Nave.FindElement(By.XPath(Obj)).Displayed)
                {
                    Console.WriteLine("Está visible: " + Obj);
                    //ClickXP(Obj);
                    return true;
                }
                else
                {
                    Console.WriteLine("No está visible: " + Obj);
                    //IsVisibleR(Obj);
                    return false;
                }
            }
            catch (Exception)
            {
                //IsVisibleR(Obj);
                //.WriteLine("Se ejecuta IsVisibleR con: " + Obj);
                Console.WriteLine("Error en IsVisible: " + Obj);

                return false;
            }
        }
        public void IsVisibleR(string Obj)
        {
            IsVisible(Obj);
            Console.WriteLine("Corrió IsVisibleR ");
        }


        public bool IsVisibleFrame(string InnerId)
        {
            try
            {
                if (Nave.FindElement(By.XPath("//iframe[@innerid='" + InnerId + "']")).Displayed)
                {
                    Console.WriteLine("Frame Está visible: " + InnerId);
                    return true;
                }
                else
                {
                    Console.WriteLine("Frame No está visible: " + InnerId);
                    IsVisibleF(InnerId);
                    return false;
                }
            }
            catch (Exception e)
            {
                IsVisibleF(InnerId);
                Console.WriteLine("Frame Error en: " + InnerId + " - por: " + e);

                return false;
            }
        }

        public void IsVisibleF(string Obj)
        {
            IsVisibleFrame(Obj);
            Console.WriteLine("Corrió IsVisibleF ");
        }

        public int ContarObj(string Obj)
        {

            IReadOnlyCollection<IWebElement> Var = Nave.FindElements(By.XPath(Obj));
            int CntObj = 0;
            foreach (IWebElement Elm in Var)
            {
                CntObj++;
            }
            return CntObj;
        }

        public void QuitarAtrr(string css, string Attr)
        {
            try
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Nave;
                //executor.ExecuteScript("document.querySelector('" + xpath + "').removeAttribute('readonly');");
                executor.ExecuteScript("document.querySelector('" + css + "').removeAttribute('" + Attr + "');");
                Console.WriteLine("Quitar OK");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Quitar atrr: " + e);
            }
        }

        public void RemoveObj(string css, string Attr)
        {
            try
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Nave;
                //executor.ExecuteScript("document.querySelector('" + xpath + "').removeAttribute('readonly');");
                executor.ExecuteScript("document.querySelector('" + css + "').removeAttribute('" + Attr + "');");
                Console.WriteLine("Quitar OK");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Quitar atrr: " + e);
            }
        }


        public void ChangeWindow(string Titulo)
        {
            Console.WriteLine("Buscar: " + Titulo);
            foreach (string item in Nave.WindowHandles)
            {
                Console.WriteLine("Tittle: " + Nave.SwitchTo().Window(item).Title);
                //Console.WriteLine("CurrentWindowHandle: " + Nave.CurrentWindowHandle);
                //Console.WriteLine("Count: "+Nave.WindowHandles.Count);
                if (Nave.SwitchTo().Window(item).Title.Equals(Titulo))//nombre de la ventana
                {
                    Console.WriteLine("Entontrada.");
                    //Nave.SwitchTo().Window(Nave.WindowHandles);
                    Nave.SwitchTo().Window(item);
                    Console.WriteLine("Cambiada");
                    break;
                }
            }
        }
        public void NewWindow()
        {
            //((IJavaScriptExecutor)Nave).ExecuteScript("window.open('{0}', '_blank');", "hola.com");
            try
            {
                ((IJavaScriptExecutor)Nave).ExecuteScript("window.open()");
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: " + e);
                try
                {
                    ((IJavaScriptExecutor)Nave).ExecuteScript("window.open()");
                }
                catch (Exception r) { Console.WriteLine("Err2: " + r); }
            }

            //IJavaScriptExecutor executor = (IJavaScriptExecutor)Nave;
            //executor.ExecuteScript("window.open('','_blank');");
        }


        public string Texto_ { set { texto = value; } get { return texto; } }
        public int Objetos { set { Objetos = value; } get { return Objetos; } }

    }
}
