using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SilverAssistant
{
    public partial class d_form : Form
    {
        #region Globals
        public const string MyPath = @"%APPDATA%\SilverAssistant";
        public const string DATpath = @"%APPDATA%\SilverAssistant\Silver.dat";
        public string JSONpath = @"%APPDATA%\SilverAssistant\SilverPreferences.json";
        public string SilverPrice = "XX.XXXX";
        public string SilverPriceStr = "$XX.XXXX";
        public int TimeInterval = 60;
        public double HighPrice = 30.0000;
        public double LowPrice = 10.0000;
        public bool LowPriceEnabled = false;
        public bool HighPriceEnabled = false;
        public bool PeriodicEnabled = true;
        public bool runOnStartup = false;
        public bool downloadingDAT = false;
        //public bool firstTime = false;

        #endregion

        #region Periodic Functions and Timers

        public d_form()
        {
            InitializeComponent();
            InitializeTimer();
            if (!File.Exists(JSONpath))
            {
                Directory.CreateDirectory(MyPath);
                //firstTime = true;
                //firstTime = true;
                SilverPreferences myPreference = new SilverPreferences();

                myPreference.pr_highDollars = Int16.Parse(d_highPriceDollar.Text);
                myPreference.pr_highCents = Int16.Parse(d_highPriceCent.Text);
                myPreference.pr_lowDollars = Int16.Parse(d_lowPriceDollar.Text);
                myPreference.pr_lowCents = Int16.Parse(d_lowPriceCent.Text);
                myPreference.pr_intervalMins = Int16.Parse(d_updateTimeInput.Text);
                myPreference.pr_showUpdates = d_periodicNotificationBox.Checked;
                myPreference.pr_showHigh = d_highPriceBox.Checked;
                myPreference.pr_showLow = d_lowPriceBox.Checked;
                myPreference.pr_launchOnStartup = d_runOnStartupBox.Checked;

                string JSONresult = JsonConvert.SerializeObject(myPreference);

                Thread.Sleep(5000);
                using (var JSONwriter = new StreamWriter(JSONpath, true))
                {
                    JSONwriter.WriteLine(JSONresult);
                    JSONwriter.Close();
                }
            }
            UpdatePriceText();
            InitJSONSettings();
            OverwritePreferencesWithJSON();
            d_notificationTimer.Interval = TimeInterval * 60000;
            d_notificationTimer.Enabled = true;
        }

        private void InitializeTimer()
        {
            d_periodicTimer.Interval = 500;
            d_periodicTimer.Tick += new EventHandler(MyPeriodic);

            d_periodicTimer.Enabled = true;
        }

        private void MyPeriodic(object Sender, EventArgs e)
        {
            d_errorMessage.Text = ErrorMessages();

            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private string ErrorMessages()
        {
            String ErrorMessageQuerys = "";
            if (int.TryParse(d_updateTimeInput.Text, out _) == false) ErrorMessageQuerys += "Please enter a valid integer into the notification frequency field. ";
            else if (int.Parse(d_updateTimeInput.Text) == 0) ErrorMessageQuerys += "You cannot recieve an update every 0 minutes!";
            if (int.TryParse(d_highPriceDollar.Text, out _) == false) ErrorMessageQuerys += "Please enter a valid integer into the high price dollars field. ";
            if (int.TryParse(d_highPriceCent.Text, out _) == false) ErrorMessageQuerys += "Please enter a valid integer into the high price cents field. ";
            if (int.TryParse(d_lowPriceDollar.Text, out _) == false) ErrorMessageQuerys += "Please enter a valid integer into the low price dollars field. ";
            if (int.TryParse(d_lowPriceCent.Text, out _) == false) ErrorMessageQuerys += "Please enter a valid integer into the low price cents field. ";
            return ErrorMessageQuerys;
        }

        private void d_notificationTimer_Tick(object sender, EventArgs e)
        {
            UpdatePriceText();
            if (PeriodicEnabled)
            {
                ShowNotification(SilverPriceStr, "Silver is currently at " + SilverPriceStr);
            }
        }

        private void d_priceCheckTimer_Tick(object sender, EventArgs e)
        {
            UpdatePriceText();
            InitJSONSettings();
            if (LowPriceEnabled)
            {
                if(double.Parse(SilverPrice) <= LowPrice)
                {
                    ShowNotification("Low Price Alert", "Silver is currently at or below $" + (LowPrice + "000000").ToCharArray()[0] + (LowPrice + "000000").ToCharArray()[1] + (LowPrice + "000000").ToCharArray()[2] + (LowPrice + "000000").ToCharArray()[3] + (LowPrice + "000000").ToCharArray()[4] + (LowPrice + "000000").ToCharArray()[5] + (LowPrice + "000000").ToCharArray()[6]);
                }
            }

            if (HighPriceEnabled)
            {
                if (double.Parse(SilverPrice) >= HighPrice)
                {
                    ShowNotification("High Price Alert", "Silver is currently at or above $" + (HighPrice + "0000").ToCharArray()[0] + (HighPrice + "000000").ToCharArray()[1] + (HighPrice + "000000").ToCharArray()[2] + (HighPrice + "000000").ToCharArray()[3] + (HighPrice + "000000").ToCharArray()[4] + (HighPrice + "000000").ToCharArray()[5] + (HighPrice + "000000").ToCharArray()[6]);
                }
            }
        }

        #endregion

        #region Notification Functions And Preferences

        private void ShowNotification(String title, String cont)
        {
            d_notifyIcon.ShowBalloonTip(1000, title, cont, ToolTipIcon.Info);
        }

        private void d_buttonTestPeriodic_Click(object sender, EventArgs e)
        {
            UpdatePriceText();
            ShowNotification(SilverPriceStr, "Silver is currently at " + SilverPriceStr);
        }

        private void d_buttonTestHigh_Click(object sender, EventArgs e)
        {
            ShowNotification("Silver has reached $" + d_highPriceDollar.Text + "." + d_highPriceCent.Text, "Silver is currently at or above $" + d_highPriceDollar.Text + "." + d_highPriceCent.Text);
        }

        private void d_buttonTestLow_Click(object sender, EventArgs e)
        {
            ShowNotification("Silver has reached $" + d_lowPriceDollar.Text + "." + d_lowPriceCent.Text, "Silver is currently at or below $" + d_lowPriceDollar.Text + "." + d_lowPriceCent.Text);
        }

        private void d_buttonSaveNotifications_Click(object sender, EventArgs e)
        {
            if (ErrorMessages() == "")
            {
                SilverPreferences myPreference = new SilverPreferences();

                myPreference.pr_highDollars = Int16.Parse(d_highPriceDollar.Text);
                myPreference.pr_highCents = Int16.Parse(d_highPriceCent.Text);
                myPreference.pr_lowDollars = Int16.Parse(d_lowPriceDollar.Text);
                myPreference.pr_lowCents = Int16.Parse(d_lowPriceCent.Text);
                myPreference.pr_intervalMins = Int16.Parse(d_updateTimeInput.Text);
                myPreference.pr_showUpdates = d_periodicNotificationBox.Checked;
                myPreference.pr_showHigh = d_highPriceBox.Checked;
                myPreference.pr_showLow = d_lowPriceBox.Checked;
                myPreference.pr_launchOnStartup = d_runOnStartupBox.Checked;

                string JSONresult = JsonConvert.SerializeObject(myPreference);

                if (File.Exists(JSONpath))
                {
                    Thread.Sleep(1000);
                    /*
                    if (firstTime)
                    {
                        Thread.Sleep(1000);
                        firstTime = false;
                    }
                    */
                    MessageBox.Show("Thank you for downloading Jake_Guy_11's Silver Assistant! Please have a look at the Info/Instructions tab before attempting to use the many functions of the app.", 
                        "Welcome to Jake_Guy_11's Silver Assistant", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    File.Delete(JSONpath);
                    using (var JSONwriter = new StreamWriter(JSONpath, true))
                    {
                        JSONwriter.WriteLine(JSONresult);
                        JSONwriter.Close();
                    }
                }
                else if (!File.Exists(JSONpath))
                {
                    Thread.Sleep(1000);
                    using (var JSONwriter = new StreamWriter(JSONpath, true))
                    {
                        JSONwriter.WriteLine(JSONresult);
                        JSONwriter.Close();
                    }
                }
                if (d_runOnStartupBox.Checked)
                {
                    try
                    {
                        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        reg.SetValue("JG11s Silver Price Checker", Application.ExecutablePath.ToString());
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    try
                    {
                        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        reg.DeleteValue("JG11s Silver Price Checker");
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                ShowNotification("Could Not Complete Operation", "Please fix the printed errors and try again");
            }

            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void d_notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void InitJSONSettings()
        {
            try
            {
                string preferenceJSON = readPreferenceJSON();

                preferenceJSON = preferenceJSON.Replace("{\"", "");
                preferenceJSON = preferenceJSON.Replace("\":", "<");
                preferenceJSON = preferenceJSON.Replace(",", "<");
                preferenceJSON = preferenceJSON.Replace("<\"", "<");
                preferenceJSON = preferenceJSON.Replace("}", "");

                string[] preferenceJSONArray = preferenceJSON.Split('<');
                string TimeIntervalString = preferenceJSONArray[15];
                string HighPriceString = preferenceJSONArray[1] + "." + preferenceJSONArray[3];
                string LowPriceString = preferenceJSONArray[5] + "." + preferenceJSONArray[7];
                string LowPriceEnabledString = preferenceJSONArray[13];
                string HighPriceEnabledString = preferenceJSONArray[11];
                string PeriodicEnabledString = preferenceJSONArray[9];
                string runOnStartupString = preferenceJSONArray[17];

                TimeInterval = Int16.Parse(TimeIntervalString);
                HighPrice = double.Parse(HighPriceString, System.Globalization.CultureInfo.InvariantCulture);
                LowPrice = double.Parse(LowPriceString, System.Globalization.CultureInfo.InvariantCulture);
                HighPriceEnabled = bool.Parse(HighPriceEnabledString);
                LowPriceEnabled = bool.Parse(LowPriceEnabledString);
                PeriodicEnabled = bool.Parse(PeriodicEnabledString);
                runOnStartup = bool.Parse(runOnStartupString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Thrown: " + e);
            }
        }

        private void OverwritePreferencesWithJSON()
        {
            d_updateTimeInput.Text = (TimeInterval).ToString();
            d_periodicNotificationBox.Checked = PeriodicEnabled;
            d_highPriceDollar.Text = HighPrice.ToString().Split('.')[0];
            string tempstr = "";
            char[] tempstrArray;
            try
            {
                tempstr = HighPrice.ToString().Split('.')[1] + "0000";
                tempstrArray = tempstr.ToCharArray();
                d_highPriceCent.Text = tempstrArray[0].ToString() + tempstrArray[1].ToString() + tempstrArray[2].ToString() + tempstrArray[3].ToString();
            }
            catch (Exception e)
            {
                d_highPriceCent.Text = "0000";
                Console.WriteLine("Exception Thrown: " + e);
            }
            d_lowPriceDollar.Text = LowPrice.ToString().Split('.')[0];
            try
            {
                tempstr = LowPrice.ToString().Split('.')[1] + "0000";
                tempstrArray = tempstr.ToCharArray();
                d_lowPriceCent.Text = tempstrArray[0].ToString() + tempstrArray[1].ToString() + tempstrArray[2].ToString() + tempstrArray[3].ToString();
            }
            catch (Exception e)
            {
                d_lowPriceCent.Text = "0000";
                Console.WriteLine("Exception Thrown: " + e);
            }
            d_highPriceBox.Checked = HighPriceEnabled;
            d_lowPriceBox.Checked = LowPriceEnabled;
            d_runOnStartupBox.Checked = runOnStartup;
        }

        private void d_notificationUpdateTimer_Tick(object sender, EventArgs e)
        {
            if(d_notificationTimer.Interval != TimeInterval * 60000)
            {
                d_notificationTimer.Interval = TimeInterval * 60000;
            }
        }

        #endregion

        #region Price Update Functions

        private void UpdateFile()
        {
            using (WebClient wc = new WebClient())
            {
                downloadingDAT = true;
                wc.DownloadFileAsync(new System.Uri("http://data-asg.goldprice.org/dbXRates/CAD"), DATpath);
            }
        }

        private string readSilverDAT()
        {
            /*
            if (firstTime)
            {
                Thread.Sleep(1000);
                firstTime = false;
            }
            */
            UpdateFile();
            string cnt = "";
            string errstr = "SOMETHING THATS NOT NULL";
            while(errstr != "")
            {
                try
                {
                    cnt = System.IO.File.ReadAllText(DATpath);
                }
                catch (Exception e)
                {
                    errstr = e.ToString();
                }
            }
            return cnt;
        }

        private string readPreferenceJSON()
        {
            return System.IO.File.ReadAllText(JSONpath);
        }

        private string parseFile()
        {
            try
            {
                SilverPrice = readSilverDAT().Replace("xagPrice\":", ">");
                SilverPrice = SilverPrice.Replace(",\"chgXau", " >");
                string[] silverArray = SilverPrice.Split('>');

                //Throws IndexOutOfRange
                Console.WriteLine(SilverPrice);
                SilverPrice = silverArray[0]; //This line throws an exception in debug configuration
                return silverArray[0];
            }
            catch (System.IndexOutOfRangeException e)
            {
                //If this exception is throw, return an empty string for error checking.
                Console.WriteLine("Exception thrown: " + e);
                return string.Empty;
            }
        }

        private void d_updatePricesButton_Click(object sender, EventArgs e)
        {
            UpdatePriceText();
        }

        private void UpdatePriceText()
        {
            UpdateFile();
            Thread.Sleep(1000);
            SilverPriceStr = "$" + parseFile();
            d_priceCurrent.Text = SilverPriceStr;
        }


        #endregion

        #region Links

        //Open paypal for donations
        private void d_linkToPaypal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/JakeGuy11");
        }

        //Opens a mail application to send support messages
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The default mail application will now open. If you have not set it up, you can create your own email to me at Jake_Guy_11@protonmail.ch", "Thank you for contacting me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("mailto:Jake_Guy_11@protonmail.ch");
        }

        #endregion

        #region Help Boxes

        //These functions are used to display help information, in case the user needs it.
        private void d_helpPreferences_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application offers a notification feature. The first notification setting will notify you with the current silver price periodically. You can receive updates up to 9999 minutes apart. The next feature will notify you when silver is at or above a certain price. Again, this per ounce in Canadian dollars. The feature below this will notify you when silver is at or below a certain price, again per ounce in Canadian dollars. The latter two features will update every five minutes. You can disable any of the above features by unchecking the checkbox beside them and test them by pressing the test button below them. The last feature will set the application to run when your computer starts. This is untested, but will not cause damage to your system. Once you are happy with your settings, press the ‘Save Changes’ button. The application may freeze for up to two seconds, then restart." ,"Preference Help",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void d_priceHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is pretty straightforward. The large price in the middle is the market silver price per ounce in Canadian dollars. The price is taken from https://goldprice.org/ in case you want to check it out. Press the ‘Get Update’ button to get a live update of the price. Be aware that the application will freeze for around a second when pressed.", "Price Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}

    //This struct stores preference data for the user.
    struct SilverPreferences
    {
        public int pr_highDollars;
        public int pr_highCents;
        public int pr_lowDollars;
        public int pr_lowCents;
        public bool pr_showUpdates;
        public bool pr_showHigh;
        public bool pr_showLow;
        public int pr_intervalMins;
        public bool pr_launchOnStartup;
    }