namespace Tasker
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNotify = new System.Windows.Forms.TabPage();
            this.tabPageIn = new System.Windows.Forms.TabPage();
            this.tabPageOut = new System.Windows.Forms.TabPage();
            this.tabPageArchive = new System.Windows.Forms.TabPage();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.listViewNotify = new System.Windows.Forms.ListView();
            this.columnHeaderMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAll = new System.Windows.Forms.ListView();
            this.columnHeaderTime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCust = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOut = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewArchive = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageNotify.SuspendLayout();
            this.tabPageIn.SuspendLayout();
            this.tabPageOut.SuspendLayout();
            this.tabPageArchive.SuspendLayout();
            this.tabPageAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(180, 22);
            this.MenuExit.Text = "Выход";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsers,
            this.MenuQuery});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.сервисToolStripMenuItem.Text = "Администрирование";
            // 
            // MenuUsers
            // 
            this.MenuUsers.Name = "MenuUsers";
            this.MenuUsers.Size = new System.Drawing.Size(175, 22);
            this.MenuUsers.Text = "Пользователи";
            this.MenuUsers.Click += new System.EventHandler(this.MenuUsers_Click);
            // 
            // MenuQuery
            // 
            this.MenuQuery.Name = "MenuQuery";
            this.MenuQuery.Size = new System.Drawing.Size(175, 22);
            this.MenuQuery.Text = "Консоль запросов";
            this.MenuQuery.Click += new System.EventHandler(this.MenuQuery_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuAbout.Text = "О программе";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageNotify);
            this.tabControl.Controls.Add(this.tabPageAll);
            this.tabControl.Controls.Add(this.tabPageIn);
            this.tabControl.Controls.Add(this.tabPageOut);
            this.tabControl.Controls.Add(this.tabPageArchive);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 522);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPageNotify
            // 
            this.tabPageNotify.Controls.Add(this.listViewNotify);
            this.tabPageNotify.Location = new System.Drawing.Point(4, 29);
            this.tabPageNotify.Name = "tabPageNotify";
            this.tabPageNotify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotify.Size = new System.Drawing.Size(752, 489);
            this.tabPageNotify.TabIndex = 0;
            this.tabPageNotify.Text = "Уведомления";
            this.tabPageNotify.UseVisualStyleBackColor = true;
            // 
            // tabPageIn
            // 
            this.tabPageIn.Controls.Add(this.listViewIn);
            this.tabPageIn.Location = new System.Drawing.Point(4, 29);
            this.tabPageIn.Name = "tabPageIn";
            this.tabPageIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIn.Size = new System.Drawing.Size(752, 489);
            this.tabPageIn.TabIndex = 1;
            this.tabPageIn.Text = "Входящие";
            this.tabPageIn.UseVisualStyleBackColor = true;
            // 
            // tabPageOut
            // 
            this.tabPageOut.Controls.Add(this.listViewOut);
            this.tabPageOut.Location = new System.Drawing.Point(4, 29);
            this.tabPageOut.Name = "tabPageOut";
            this.tabPageOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOut.Size = new System.Drawing.Size(752, 489);
            this.tabPageOut.TabIndex = 2;
            this.tabPageOut.Text = "Исходящие";
            this.tabPageOut.UseVisualStyleBackColor = true;
            // 
            // tabPageArchive
            // 
            this.tabPageArchive.Controls.Add(this.listViewArchive);
            this.tabPageArchive.Location = new System.Drawing.Point(4, 29);
            this.tabPageArchive.Name = "tabPageArchive";
            this.tabPageArchive.Size = new System.Drawing.Size(752, 489);
            this.tabPageArchive.TabIndex = 3;
            this.tabPageArchive.Text = "Архив";
            this.tabPageArchive.UseVisualStyleBackColor = true;
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.listViewAll);
            this.tabPageAll.Location = new System.Drawing.Point(4, 29);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAll.Size = new System.Drawing.Size(752, 489);
            this.tabPageAll.TabIndex = 4;
            this.tabPageAll.Text = "Все заявки";
            this.tabPageAll.UseVisualStyleBackColor = true;
            // 
            // listViewNotify
            // 
            this.listViewNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNotify.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTime,
            this.columnHeaderMsg});
            this.listViewNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewNotify.FullRowSelect = true;
            this.listViewNotify.HideSelection = false;
            this.listViewNotify.Location = new System.Drawing.Point(6, 6);
            this.listViewNotify.Name = "listViewNotify";
            this.listViewNotify.Size = new System.Drawing.Size(740, 477);
            this.listViewNotify.TabIndex = 0;
            this.listViewNotify.UseCompatibleStateImageBehavior = false;
            this.listViewNotify.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMsg
            // 
            this.columnHeaderMsg.Text = "Сообщение";
            this.columnHeaderMsg.Width = 600;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Время";
            this.columnHeaderTime.Width = 100;
            // 
            // listViewAll
            // 
            this.listViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderTime1,
            this.columnHeaderCust,
            this.columnHeaderExe,
            this.columnHeaderText});
            this.listViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAll.FullRowSelect = true;
            this.listViewAll.HideSelection = false;
            this.listViewAll.Location = new System.Drawing.Point(6, 6);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(740, 477);
            this.listViewAll.TabIndex = 1;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTime1
            // 
            this.columnHeaderTime1.Text = "Время";
            this.columnHeaderTime1.Width = 80;
            // 
            // columnHeaderCust
            // 
            this.columnHeaderCust.Text = "Заказчик";
            this.columnHeaderCust.Width = 120;
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "Номер";
            // 
            // columnHeaderExe
            // 
            this.columnHeaderExe.Text = "Исполнитель";
            this.columnHeaderExe.Width = 120;
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "Заявка";
            this.columnHeaderText.Width = 320;
            // 
            // listViewIn
            // 
            this.listViewIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listViewIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewIn.FullRowSelect = true;
            this.listViewIn.HideSelection = false;
            this.listViewIn.Location = new System.Drawing.Point(6, 6);
            this.listViewIn.Name = "listViewIn";
            this.listViewIn.Size = new System.Drawing.Size(740, 477);
            this.listViewIn.TabIndex = 2;
            this.listViewIn.UseCompatibleStateImageBehavior = false;
            this.listViewIn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Время";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Заказчик";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Заявка";
            this.columnHeader5.Width = 440;
            // 
            // listViewOut
            // 
            this.listViewOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOut.FullRowSelect = true;
            this.listViewOut.HideSelection = false;
            this.listViewOut.Location = new System.Drawing.Point(6, 6);
            this.listViewOut.Name = "listViewOut";
            this.listViewOut.Size = new System.Drawing.Size(740, 477);
            this.listViewOut.TabIndex = 3;
            this.listViewOut.UseCompatibleStateImageBehavior = false;
            this.listViewOut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Время";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Исполнитель";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Заявка";
            this.columnHeader8.Width = 440;
            // 
            // listViewArchive
            // 
            this.listViewArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewArchive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewArchive.FullRowSelect = true;
            this.listViewArchive.HideSelection = false;
            this.listViewArchive.Location = new System.Drawing.Point(6, 6);
            this.listViewArchive.Name = "listViewArchive";
            this.listViewArchive.Size = new System.Drawing.Size(740, 477);
            this.listViewArchive.TabIndex = 2;
            this.listViewArchive.UseCompatibleStateImageBehavior = false;
            this.listViewArchive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Номер";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Время";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Заказчик";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Исполнитель";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Заявка";
            this.columnHeader13.Width = 320;
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRefresh});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // MenuRefresh
            // 
            this.MenuRefresh.Name = "MenuRefresh";
            this.MenuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuRefresh.Size = new System.Drawing.Size(180, 22);
            this.MenuRefresh.Text = "Обновить";
            this.MenuRefresh.Click += new System.EventHandler(this.MenuRefresh_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageNotify.ResumeLayout(false);
            this.tabPageIn.ResumeLayout(false);
            this.tabPageOut.ResumeLayout(false);
            this.tabPageArchive.ResumeLayout(false);
            this.tabPageAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuQuery;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNotify;
        private System.Windows.Forms.TabPage tabPageIn;
        private System.Windows.Forms.TabPage tabPageOut;
        private System.Windows.Forms.TabPage tabPageArchive;
        private System.Windows.Forms.TabPage tabPageAll;
        private System.Windows.Forms.ListView listViewNotify;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderMsg;
        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderTime1;
        private System.Windows.Forms.ColumnHeader columnHeaderCust;
        private System.Windows.Forms.ColumnHeader columnHeaderExe;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ListView listViewIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewOut;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewArchive;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRefresh;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}