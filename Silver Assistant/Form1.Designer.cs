namespace SilverAssistant
{
    partial class d_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d_form));
            this.d_titleText = new System.Windows.Forms.Label();
            this.d_tabControl = new System.Windows.Forms.TabControl();
            this.d_viewTab = new System.Windows.Forms.TabPage();
            this.d_priceHelp = new System.Windows.Forms.Button();
            this.d_priceCurrent = new System.Windows.Forms.Label();
            this.d_priceLabelCurrent = new System.Windows.Forms.Label();
            this.d_updatePricesButton = new System.Windows.Forms.Button();
            this.d_customizeTab = new System.Windows.Forms.TabPage();
            this.d_helpPreferences = new System.Windows.Forms.Button();
            this.d_runOnStartupBox = new System.Windows.Forms.CheckBox();
            this.d_buttonSaveNotifications = new System.Windows.Forms.Button();
            this.d_buttonTestLow = new System.Windows.Forms.Button();
            this.d_buttonTestHigh = new System.Windows.Forms.Button();
            this.d_buttonTestPeriodic = new System.Windows.Forms.Button();
            this.d_lowPriceCent = new System.Windows.Forms.TextBox();
            this.d_highPriceCent = new System.Windows.Forms.TextBox();
            this.d_lowPriceDecLabel = new System.Windows.Forms.Label();
            this.d_highPriceDecLabel = new System.Windows.Forms.Label();
            this.d_lowPriceLabel = new System.Windows.Forms.Label();
            this.d_lowPriceDollar = new System.Windows.Forms.TextBox();
            this.d_lowPriceBox = new System.Windows.Forms.CheckBox();
            this.d_highPriceLabel = new System.Windows.Forms.Label();
            this.d_highPriceDollar = new System.Windows.Forms.TextBox();
            this.d_highPriceBox = new System.Windows.Forms.CheckBox();
            this.d_timeLabelEvery = new System.Windows.Forms.Label();
            this.d_timeLabelMinutes = new System.Windows.Forms.Label();
            this.d_updateTimeInput = new System.Windows.Forms.TextBox();
            this.d_periodicNotificationBox = new System.Windows.Forms.CheckBox();
            this.d_infoTab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.d_linkToPaypal = new System.Windows.Forms.LinkLabel();
            this.d_infoLabel = new System.Windows.Forms.Label();
            this.d_errorMessage = new System.Windows.Forms.Label();
            this.d_periodicTimer = new System.Windows.Forms.Timer(this.components);
            this.d_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.d_notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.d_priceCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.d_notificationUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.d_JakeLabel = new System.Windows.Forms.Label();
            this.d_tabControl.SuspendLayout();
            this.d_viewTab.SuspendLayout();
            this.d_customizeTab.SuspendLayout();
            this.d_infoTab.SuspendLayout();
            this.d_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // d_titleText
            // 
            this.d_titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_titleText.Location = new System.Drawing.Point(57, 23);
            this.d_titleText.Name = "d_titleText";
            this.d_titleText.Size = new System.Drawing.Size(366, 50);
            this.d_titleText.TabIndex = 0;
            this.d_titleText.Text = "Silver Assistant";
            // 
            // d_tabControl
            // 
            this.d_tabControl.Controls.Add(this.d_viewTab);
            this.d_tabControl.Controls.Add(this.d_customizeTab);
            this.d_tabControl.Controls.Add(this.d_infoTab);
            this.d_tabControl.Location = new System.Drawing.Point(11, 76);
            this.d_tabControl.Name = "d_tabControl";
            this.d_tabControl.SelectedIndex = 0;
            this.d_tabControl.Size = new System.Drawing.Size(460, 387);
            this.d_tabControl.TabIndex = 1;
            // 
            // d_viewTab
            // 
            this.d_viewTab.Controls.Add(this.d_priceHelp);
            this.d_viewTab.Controls.Add(this.d_priceCurrent);
            this.d_viewTab.Controls.Add(this.d_priceLabelCurrent);
            this.d_viewTab.Controls.Add(this.d_updatePricesButton);
            this.d_viewTab.Location = new System.Drawing.Point(4, 22);
            this.d_viewTab.Name = "d_viewTab";
            this.d_viewTab.Padding = new System.Windows.Forms.Padding(3);
            this.d_viewTab.Size = new System.Drawing.Size(452, 361);
            this.d_viewTab.TabIndex = 0;
            this.d_viewTab.Text = "View Stats";
            this.d_viewTab.UseVisualStyleBackColor = true;
            // 
            // d_priceHelp
            // 
            this.d_priceHelp.Location = new System.Drawing.Point(6, 332);
            this.d_priceHelp.Name = "d_priceHelp";
            this.d_priceHelp.Size = new System.Drawing.Size(75, 23);
            this.d_priceHelp.TabIndex = 8;
            this.d_priceHelp.Text = "Help";
            this.d_priceHelp.UseVisualStyleBackColor = true;
            this.d_priceHelp.Click += new System.EventHandler(this.d_priceHelp_Click);
            // 
            // d_priceCurrent
            // 
            this.d_priceCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_priceCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_priceCurrent.Location = new System.Drawing.Point(0, 130);
            this.d_priceCurrent.Name = "d_priceCurrent";
            this.d_priceCurrent.Size = new System.Drawing.Size(450, 100);
            this.d_priceCurrent.TabIndex = 7;
            this.d_priceCurrent.Text = "$XX.XX";
            this.d_priceCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // d_priceLabelCurrent
            // 
            this.d_priceLabelCurrent.AutoSize = true;
            this.d_priceLabelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_priceLabelCurrent.Location = new System.Drawing.Point(111, 3);
            this.d_priceLabelCurrent.Name = "d_priceLabelCurrent";
            this.d_priceLabelCurrent.Size = new System.Drawing.Size(214, 37);
            this.d_priceLabelCurrent.TabIndex = 1;
            this.d_priceLabelCurrent.Text = "Current Price:";
            // 
            // d_updatePricesButton
            // 
            this.d_updatePricesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d_updatePricesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_updatePricesButton.Location = new System.Drawing.Point(321, 280);
            this.d_updatePricesButton.Name = "d_updatePricesButton";
            this.d_updatePricesButton.Size = new System.Drawing.Size(125, 75);
            this.d_updatePricesButton.TabIndex = 0;
            this.d_updatePricesButton.Text = "Get Update";
            this.d_updatePricesButton.UseVisualStyleBackColor = true;
            this.d_updatePricesButton.Click += new System.EventHandler(this.d_updatePricesButton_Click);
            // 
            // d_customizeTab
            // 
            this.d_customizeTab.Controls.Add(this.d_helpPreferences);
            this.d_customizeTab.Controls.Add(this.d_runOnStartupBox);
            this.d_customizeTab.Controls.Add(this.d_buttonSaveNotifications);
            this.d_customizeTab.Controls.Add(this.d_buttonTestLow);
            this.d_customizeTab.Controls.Add(this.d_buttonTestHigh);
            this.d_customizeTab.Controls.Add(this.d_buttonTestPeriodic);
            this.d_customizeTab.Controls.Add(this.d_lowPriceCent);
            this.d_customizeTab.Controls.Add(this.d_highPriceCent);
            this.d_customizeTab.Controls.Add(this.d_lowPriceDecLabel);
            this.d_customizeTab.Controls.Add(this.d_highPriceDecLabel);
            this.d_customizeTab.Controls.Add(this.d_lowPriceLabel);
            this.d_customizeTab.Controls.Add(this.d_lowPriceDollar);
            this.d_customizeTab.Controls.Add(this.d_lowPriceBox);
            this.d_customizeTab.Controls.Add(this.d_highPriceLabel);
            this.d_customizeTab.Controls.Add(this.d_highPriceDollar);
            this.d_customizeTab.Controls.Add(this.d_highPriceBox);
            this.d_customizeTab.Controls.Add(this.d_timeLabelEvery);
            this.d_customizeTab.Controls.Add(this.d_timeLabelMinutes);
            this.d_customizeTab.Controls.Add(this.d_updateTimeInput);
            this.d_customizeTab.Controls.Add(this.d_periodicNotificationBox);
            this.d_customizeTab.Location = new System.Drawing.Point(4, 22);
            this.d_customizeTab.Name = "d_customizeTab";
            this.d_customizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.d_customizeTab.Size = new System.Drawing.Size(452, 361);
            this.d_customizeTab.TabIndex = 1;
            this.d_customizeTab.Text = "Set Preferences";
            this.d_customizeTab.UseVisualStyleBackColor = true;
            // 
            // d_helpPreferences
            // 
            this.d_helpPreferences.Location = new System.Drawing.Point(371, 332);
            this.d_helpPreferences.Name = "d_helpPreferences";
            this.d_helpPreferences.Size = new System.Drawing.Size(75, 23);
            this.d_helpPreferences.TabIndex = 18;
            this.d_helpPreferences.Text = "Help";
            this.d_helpPreferences.UseVisualStyleBackColor = true;
            this.d_helpPreferences.Click += new System.EventHandler(this.d_helpPreferences_Click);
            // 
            // d_runOnStartupBox
            // 
            this.d_runOnStartupBox.Location = new System.Drawing.Point(345, 103);
            this.d_runOnStartupBox.Name = "d_runOnStartupBox";
            this.d_runOnStartupBox.Size = new System.Drawing.Size(101, 33);
            this.d_runOnStartupBox.TabIndex = 17;
            this.d_runOnStartupBox.Text = "Launch On PC Startup";
            this.d_runOnStartupBox.UseVisualStyleBackColor = true;
            // 
            // d_buttonSaveNotifications
            // 
            this.d_buttonSaveNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_buttonSaveNotifications.Location = new System.Drawing.Point(337, 6);
            this.d_buttonSaveNotifications.Name = "d_buttonSaveNotifications";
            this.d_buttonSaveNotifications.Size = new System.Drawing.Size(109, 93);
            this.d_buttonSaveNotifications.TabIndex = 15;
            this.d_buttonSaveNotifications.Text = "Save Changes";
            this.d_buttonSaveNotifications.UseVisualStyleBackColor = true;
            this.d_buttonSaveNotifications.Click += new System.EventHandler(this.d_buttonSaveNotifications_Click);
            // 
            // d_buttonTestLow
            // 
            this.d_buttonTestLow.Location = new System.Drawing.Point(11, 332);
            this.d_buttonTestLow.Name = "d_buttonTestLow";
            this.d_buttonTestLow.Size = new System.Drawing.Size(75, 23);
            this.d_buttonTestLow.TabIndex = 14;
            this.d_buttonTestLow.Text = "Test";
            this.d_buttonTestLow.UseVisualStyleBackColor = true;
            this.d_buttonTestLow.Click += new System.EventHandler(this.d_buttonTestLow_Click);
            // 
            // d_buttonTestHigh
            // 
            this.d_buttonTestHigh.Location = new System.Drawing.Point(11, 199);
            this.d_buttonTestHigh.Name = "d_buttonTestHigh";
            this.d_buttonTestHigh.Size = new System.Drawing.Size(75, 23);
            this.d_buttonTestHigh.TabIndex = 10;
            this.d_buttonTestHigh.Text = "Test";
            this.d_buttonTestHigh.UseVisualStyleBackColor = true;
            this.d_buttonTestHigh.Click += new System.EventHandler(this.d_buttonTestHigh_Click);
            // 
            // d_buttonTestPeriodic
            // 
            this.d_buttonTestPeriodic.Location = new System.Drawing.Point(11, 76);
            this.d_buttonTestPeriodic.Name = "d_buttonTestPeriodic";
            this.d_buttonTestPeriodic.Size = new System.Drawing.Size(75, 23);
            this.d_buttonTestPeriodic.TabIndex = 6;
            this.d_buttonTestPeriodic.Text = "Test";
            this.d_buttonTestPeriodic.UseVisualStyleBackColor = true;
            this.d_buttonTestPeriodic.Click += new System.EventHandler(this.d_buttonTestPeriodic_Click);
            // 
            // d_lowPriceCent
            // 
            this.d_lowPriceCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_lowPriceCent.Location = new System.Drawing.Point(262, 299);
            this.d_lowPriceCent.MaxLength = 4;
            this.d_lowPriceCent.Name = "d_lowPriceCent";
            this.d_lowPriceCent.Size = new System.Drawing.Size(66, 31);
            this.d_lowPriceCent.TabIndex = 13;
            this.d_lowPriceCent.Text = "0000";
            // 
            // d_highPriceCent
            // 
            this.d_highPriceCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_highPriceCent.Location = new System.Drawing.Point(262, 165);
            this.d_highPriceCent.MaxLength = 4;
            this.d_highPriceCent.Name = "d_highPriceCent";
            this.d_highPriceCent.Size = new System.Drawing.Size(66, 31);
            this.d_highPriceCent.TabIndex = 9;
            this.d_highPriceCent.Text = "0000";
            // 
            // d_lowPriceDecLabel
            // 
            this.d_lowPriceDecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_lowPriceDecLabel.Location = new System.Drawing.Point(242, 302);
            this.d_lowPriceDecLabel.Name = "d_lowPriceDecLabel";
            this.d_lowPriceDecLabel.Size = new System.Drawing.Size(23, 31);
            this.d_lowPriceDecLabel.TabIndex = 16;
            this.d_lowPriceDecLabel.Text = ".";
            // 
            // d_highPriceDecLabel
            // 
            this.d_highPriceDecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_highPriceDecLabel.Location = new System.Drawing.Point(242, 168);
            this.d_highPriceDecLabel.Name = "d_highPriceDecLabel";
            this.d_highPriceDecLabel.Size = new System.Drawing.Size(23, 31);
            this.d_highPriceDecLabel.TabIndex = 15;
            this.d_highPriceDecLabel.Text = ".";
            // 
            // d_lowPriceLabel
            // 
            this.d_lowPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_lowPriceLabel.Location = new System.Drawing.Point(6, 273);
            this.d_lowPriceLabel.Name = "d_lowPriceLabel";
            this.d_lowPriceLabel.Size = new System.Drawing.Size(182, 57);
            this.d_lowPriceLabel.TabIndex = 14;
            this.d_lowPriceLabel.Text = "Price is less than or equal to         $";
            // 
            // d_lowPriceDollar
            // 
            this.d_lowPriceDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_lowPriceDollar.Location = new System.Drawing.Point(203, 299);
            this.d_lowPriceDollar.MaxLength = 2;
            this.d_lowPriceDollar.Name = "d_lowPriceDollar";
            this.d_lowPriceDollar.Size = new System.Drawing.Size(33, 31);
            this.d_lowPriceDollar.TabIndex = 12;
            this.d_lowPriceDollar.Text = "10";
            // 
            // d_lowPriceBox
            // 
            this.d_lowPriceBox.AutoSize = true;
            this.d_lowPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_lowPriceBox.Location = new System.Drawing.Point(6, 237);
            this.d_lowPriceBox.Name = "d_lowPriceBox";
            this.d_lowPriceBox.Size = new System.Drawing.Size(273, 33);
            this.d_lowPriceBox.TabIndex = 11;
            this.d_lowPriceBox.Text = "Notify Me At Low Price";
            this.d_lowPriceBox.UseVisualStyleBackColor = true;
            // 
            // d_highPriceLabel
            // 
            this.d_highPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_highPriceLabel.Location = new System.Drawing.Point(6, 139);
            this.d_highPriceLabel.Name = "d_highPriceLabel";
            this.d_highPriceLabel.Size = new System.Drawing.Size(182, 57);
            this.d_highPriceLabel.TabIndex = 11;
            this.d_highPriceLabel.Text = "Price is greater than or equal to $";
            // 
            // d_highPriceDollar
            // 
            this.d_highPriceDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_highPriceDollar.Location = new System.Drawing.Point(203, 165);
            this.d_highPriceDollar.MaxLength = 2;
            this.d_highPriceDollar.Name = "d_highPriceDollar";
            this.d_highPriceDollar.Size = new System.Drawing.Size(33, 31);
            this.d_highPriceDollar.TabIndex = 8;
            this.d_highPriceDollar.Text = "30";
            // 
            // d_highPriceBox
            // 
            this.d_highPriceBox.AutoSize = true;
            this.d_highPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_highPriceBox.Location = new System.Drawing.Point(6, 103);
            this.d_highPriceBox.Name = "d_highPriceBox";
            this.d_highPriceBox.Size = new System.Drawing.Size(278, 33);
            this.d_highPriceBox.TabIndex = 7;
            this.d_highPriceBox.Text = "Notify Me At High Price";
            this.d_highPriceBox.UseVisualStyleBackColor = true;
            // 
            // d_timeLabelEvery
            // 
            this.d_timeLabelEvery.AutoSize = true;
            this.d_timeLabelEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_timeLabelEvery.Location = new System.Drawing.Point(6, 42);
            this.d_timeLabelEvery.Name = "d_timeLabelEvery";
            this.d_timeLabelEvery.Size = new System.Drawing.Size(67, 25);
            this.d_timeLabelEvery.TabIndex = 7;
            this.d_timeLabelEvery.Text = "Every";
            // 
            // d_timeLabelMinutes
            // 
            this.d_timeLabelMinutes.AutoSize = true;
            this.d_timeLabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_timeLabelMinutes.Location = new System.Drawing.Point(149, 42);
            this.d_timeLabelMinutes.Name = "d_timeLabelMinutes";
            this.d_timeLabelMinutes.Size = new System.Drawing.Size(87, 25);
            this.d_timeLabelMinutes.TabIndex = 6;
            this.d_timeLabelMinutes.Text = "minutes";
            // 
            // d_updateTimeInput
            // 
            this.d_updateTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_updateTimeInput.Location = new System.Drawing.Point(79, 39);
            this.d_updateTimeInput.MaxLength = 4;
            this.d_updateTimeInput.Name = "d_updateTimeInput";
            this.d_updateTimeInput.Size = new System.Drawing.Size(64, 31);
            this.d_updateTimeInput.TabIndex = 5;
            this.d_updateTimeInput.Text = "60";
            // 
            // d_periodicNotificationBox
            // 
            this.d_periodicNotificationBox.AutoSize = true;
            this.d_periodicNotificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_periodicNotificationBox.Location = new System.Drawing.Point(6, 6);
            this.d_periodicNotificationBox.Name = "d_periodicNotificationBox";
            this.d_periodicNotificationBox.Size = new System.Drawing.Size(265, 33);
            this.d_periodicNotificationBox.TabIndex = 4;
            this.d_periodicNotificationBox.Text = "Notify Me Periodically";
            this.d_periodicNotificationBox.UseVisualStyleBackColor = true;
            // 
            // d_infoTab
            // 
            this.d_infoTab.Controls.Add(this.linkLabel1);
            this.d_infoTab.Controls.Add(this.d_linkToPaypal);
            this.d_infoTab.Controls.Add(this.d_infoLabel);
            this.d_infoTab.Location = new System.Drawing.Point(4, 22);
            this.d_infoTab.Name = "d_infoTab";
            this.d_infoTab.Size = new System.Drawing.Size(452, 361);
            this.d_infoTab.TabIndex = 2;
            this.d_infoTab.Text = "Info/Instructions";
            this.d_infoTab.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 337);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Email me with comments or concerns";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // d_linkToPaypal
            // 
            this.d_linkToPaypal.AutoSize = true;
            this.d_linkToPaypal.Location = new System.Drawing.Point(326, 338);
            this.d_linkToPaypal.Name = "d_linkToPaypal";
            this.d_linkToPaypal.Size = new System.Drawing.Size(107, 13);
            this.d_linkToPaypal.TabIndex = 1;
            this.d_linkToPaypal.TabStop = true;
            this.d_linkToPaypal.Text = "Buy Me A Dr. Pepper";
            this.d_linkToPaypal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.d_linkToPaypal_LinkClicked);
            // 
            // d_infoLabel
            // 
            this.d_infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_infoLabel.Location = new System.Drawing.Point(3, 0);
            this.d_infoLabel.Name = "d_infoLabel";
            this.d_infoLabel.Size = new System.Drawing.Size(446, 315);
            this.d_infoLabel.TabIndex = 0;
            this.d_infoLabel.Text = resources.GetString("d_infoLabel.Text");
            // 
            // d_errorMessage
            // 
            this.d_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.d_errorMessage.Location = new System.Drawing.Point(12, 477);
            this.d_errorMessage.Name = "d_errorMessage";
            this.d_errorMessage.Size = new System.Drawing.Size(465, 50);
            this.d_errorMessage.TabIndex = 2;
            // 
            // d_contextMenuStrip
            // 
            this.d_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.d_contextMenuStrip.Name = "d_contextMenuStrip";
            this.d_contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Show";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // d_notifyIcon
            // 
            this.d_notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.d_notifyIcon.BalloonTipText = "Test";
            this.d_notifyIcon.BalloonTipTitle = "Big Test";
            this.d_notifyIcon.ContextMenuStrip = this.d_contextMenuStrip;
            this.d_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("d_notifyIcon.Icon")));
            this.d_notifyIcon.Text = "Settings";
            this.d_notifyIcon.Visible = true;
            this.d_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.d_notifyIcon_MouseDoubleClick);
            // 
            // d_notificationTimer
            // 
            this.d_notificationTimer.Enabled = true;
            this.d_notificationTimer.Interval = 1000;
            this.d_notificationTimer.Tick += new System.EventHandler(this.d_notificationTimer_Tick);
            // 
            // d_priceCheckTimer
            // 
            this.d_priceCheckTimer.Enabled = true;
            this.d_priceCheckTimer.Interval = 300000;
            this.d_priceCheckTimer.Tick += new System.EventHandler(this.d_priceCheckTimer_Tick);
            // 
            // d_notificationUpdateTimer
            // 
            this.d_notificationUpdateTimer.Enabled = true;
            this.d_notificationUpdateTimer.Interval = 5000;
            this.d_notificationUpdateTimer.Tick += new System.EventHandler(this.d_notificationUpdateTimer_Tick);
            // 
            // d_JakeLabel
            // 
            this.d_JakeLabel.AutoSize = true;
            this.d_JakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_JakeLabel.Location = new System.Drawing.Point(161, 9);
            this.d_JakeLabel.Name = "d_JakeLabel";
            this.d_JakeLabel.Size = new System.Drawing.Size(132, 20);
            this.d_JakeLabel.TabIndex = 3;
            this.d_JakeLabel.Text = "Jake_Guy_11\'s";
            // 
            // d_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.d_JakeLabel);
            this.Controls.Add(this.d_errorMessage);
            this.Controls.Add(this.d_tabControl);
            this.Controls.Add(this.d_titleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "d_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jake_Guy_11\'s Silver Assistant";
            this.d_tabControl.ResumeLayout(false);
            this.d_viewTab.ResumeLayout(false);
            this.d_viewTab.PerformLayout();
            this.d_customizeTab.ResumeLayout(false);
            this.d_customizeTab.PerformLayout();
            this.d_infoTab.ResumeLayout(false);
            this.d_infoTab.PerformLayout();
            this.d_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d_titleText;
        private System.Windows.Forms.TabControl d_tabControl;
        private System.Windows.Forms.TabPage d_viewTab;
        private System.Windows.Forms.TabPage d_customizeTab;
        private System.Windows.Forms.Button d_updatePricesButton;
        private System.Windows.Forms.Label d_errorMessage;
        private System.Windows.Forms.Timer d_periodicTimer;
        private System.Windows.Forms.Label d_timeLabelMinutes;
        private System.Windows.Forms.TextBox d_updateTimeInput;
        private System.Windows.Forms.CheckBox d_periodicNotificationBox;
        private System.Windows.Forms.Label d_timeLabelEvery;
        private System.Windows.Forms.Label d_priceLabelCurrent;
        private System.Windows.Forms.Label d_priceCurrent;
        private System.Windows.Forms.TextBox d_lowPriceDollar;
        private System.Windows.Forms.CheckBox d_lowPriceBox;
        private System.Windows.Forms.Label d_highPriceLabel;
        private System.Windows.Forms.TextBox d_highPriceDollar;
        private System.Windows.Forms.CheckBox d_highPriceBox;
        private System.Windows.Forms.Label d_lowPriceLabel;
        private System.Windows.Forms.TextBox d_lowPriceCent;
        private System.Windows.Forms.TextBox d_highPriceCent;
        private System.Windows.Forms.Label d_lowPriceDecLabel;
        private System.Windows.Forms.Label d_highPriceDecLabel;
        private System.Windows.Forms.Button d_buttonTestLow;
        private System.Windows.Forms.Button d_buttonTestHigh;
        private System.Windows.Forms.Button d_buttonTestPeriodic;
        private System.Windows.Forms.Button d_buttonSaveNotifications;
        private System.Windows.Forms.ContextMenuStrip d_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon d_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer d_notificationTimer;
        private System.Windows.Forms.Timer d_priceCheckTimer;
        private System.Windows.Forms.Timer d_notificationUpdateTimer;
        private System.Windows.Forms.TabPage d_infoTab;
        private System.Windows.Forms.CheckBox d_runOnStartupBox;
        private System.Windows.Forms.Label d_JakeLabel;
        private System.Windows.Forms.Label d_infoLabel;
        private System.Windows.Forms.LinkLabel d_linkToPaypal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button d_helpPreferences;
        private System.Windows.Forms.Button d_priceHelp;
    }
}

