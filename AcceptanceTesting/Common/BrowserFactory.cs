using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace AcceptanceTesting.Common
{
    /// <summary>
    /// ������� ���������
    /// </summary>
    public static class BrowserFactory
    {
        #region Fields

        /// <summary>
        /// ���� � ��������� ���������
        /// </summary>
        private const string PathToDriver = "..\\..\\Drivers";

        #endregion

        #region Public methods

        /// <summary>
        /// ��������� �����
        /// </summary>
        /// <param name="browser"></param>
        /// <returns></returns>
        public static RemoteWebDriver GetLocalDriver(string browser)
        {
            InternetExplorerOptions internetExplorerOptions;
            switch (browser)
            {              
                case "Firefox":
                    var profile = new FirefoxProfile();
                    //profile.SetPreference("network.automatic-ntlm-auth.trusted-uris", ConfigurationManager.AppSettings["SiteIP"]);
                    return new FirefoxDriver(profile);

                //case "Chrome":
                //    return new ChromeDriver(PathToDriver);

                case "IE":
                    internetExplorerOptions = new InternetExplorerOptions
                    {
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        EnableNativeEvents = true
                    };
                    return new InternetExplorerDriver(
                        PathToDriver,
                        internetExplorerOptions);

                default:
                    var profile1 = new FirefoxProfile();
                    //profile.SetPreference("network.automatic-ntlm-auth.trusted-uris", ConfigurationManager.AppSettings["SiteIP"]);
                    return new FirefoxDriver(profile1);
            }

        }

        #endregion
    }
}