using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//launch trunup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


//identify the username text box and valid username

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify the password and valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify the login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully.

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("SUCCESS you logged in, Test PASSED");

}
else
{
    Console.WriteLine("login FAILED, Test FAILED");
}