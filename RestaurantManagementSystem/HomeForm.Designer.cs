namespace RestaurantManagementSystem
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            menuStrip1 = new MenuStrip();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            addItemsToolStripMenuItem = new ToolStripMenuItem();
            edToolStripMenuItem = new ToolStripMenuItem();
            deleteItemsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            viewUserToolStripMenuItem = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            newBillToolStripMenuItem = new ToolStripMenuItem();
            viewBillToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gold;
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemsToolStripMenuItem, userToolStripMenuItem, billToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(806, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addItemsToolStripMenuItem, edToolStripMenuItem, deleteItemsToolStripMenuItem, exitToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(56, 20);
            itemsToolStripMenuItem.Text = "&Items";
            // 
            // addItemsToolStripMenuItem
            // 
            addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            addItemsToolStripMenuItem.Size = new Size(180, 22);
            addItemsToolStripMenuItem.Text = "&Add Items";
            // 
            // edToolStripMenuItem
            // 
            edToolStripMenuItem.Name = "edToolStripMenuItem";
            edToolStripMenuItem.Size = new Size(180, 22);
            edToolStripMenuItem.Text = "&Edit Items";
            // 
            // deleteItemsToolStripMenuItem
            // 
            deleteItemsToolStripMenuItem.Name = "deleteItemsToolStripMenuItem";
            deleteItemsToolStripMenuItem.Size = new Size(180, 22);
            deleteItemsToolStripMenuItem.Text = "&Delete Items";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewUserToolStripMenuItem, deleteUserToolStripMenuItem, changePasswordToolStripMenuItem, viewUserToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(48, 20);
            userToolStripMenuItem.Text = "&User";
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(190, 22);
            addNewUserToolStripMenuItem.Text = "Add &New User";
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(190, 22);
            deleteUserToolStripMenuItem.Text = "&Delete User";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(190, 22);
            changePasswordToolStripMenuItem.Text = "&Change Password";
            // 
            // viewUserToolStripMenuItem
            // 
            viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            viewUserToolStripMenuItem.Size = new Size(190, 22);
            viewUserToolStripMenuItem.Text = "&View User";
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBillToolStripMenuItem, viewBillToolStripMenuItem });
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(36, 20);
            billToolStripMenuItem.Text = "&Bill";
            // 
            // newBillToolStripMenuItem
            // 
            newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            newBillToolStripMenuItem.Size = new Size(127, 22);
            newBillToolStripMenuItem.Text = "&New Bill";
            // 
            // viewBillToolStripMenuItem
            // 
            viewBillToolStripMenuItem.Name = "viewBillToolStripMenuItem";
            viewBillToolStripMenuItem.Size = new Size(127, 22);
            viewBillToolStripMenuItem.Text = "&View Bill";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 480);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "HomeForm";
            Text = "Apna Restraunt";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem addItemsToolStripMenuItem;
        private ToolStripMenuItem edToolStripMenuItem;
        private ToolStripMenuItem deleteItemsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem viewUserToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem newBillToolStripMenuItem;
        private ToolStripMenuItem viewBillToolStripMenuItem;
    }
}
