
namespace AdressBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label last_CallLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label client_Label;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label companyLabel;
            this.contactDBDataSet1 = new AdressBook.ContactDBDataSet();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new AdressBook.ContactDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager1 = new AdressBook.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.tableBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIDTextBox1 = new System.Windows.Forms.TextBox();
            this.last_CallDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.client_CheckBox1 = new System.Windows.Forms.CheckBox();
            this.telephoneTextBox1 = new System.Windows.Forms.TextBox();
            this.companyTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            contactIDLabel = new System.Windows.Forms.Label();
            last_CallLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            client_Label = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1BindingNavigator)).BeginInit();
            this.tableBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contactDBDataSet1
            // 
            this.contactDBDataSet1.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.contactDBDataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TableTableAdapter = this.tableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = AdressBook.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingSource1BindingNavigator
            // 
            this.tableBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.tableBindingSource1BindingNavigator.BindingSource = this.tableBindingSource1;
            this.tableBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.tableBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.tableBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.tableBindingSource1BindingNavigatorSaveItem});
            this.tableBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.tableBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.tableBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.tableBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.tableBindingSource1BindingNavigator.Name = "tableBindingSource1BindingNavigator";
            this.tableBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.tableBindingSource1BindingNavigator.Size = new System.Drawing.Size(971, 25);
            this.tableBindingSource1BindingNavigator.TabIndex = 0;
            this.tableBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 15);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton6.Text = "Delete";
            // 
            // tableBindingSource1BindingNavigatorSaveItem
            // 
            this.tableBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingSource1BindingNavigatorSaveItem.Image")));
            this.tableBindingSource1BindingNavigatorSaveItem.Name = "tableBindingSource1BindingNavigatorSaveItem";
            this.tableBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Location = new System.Drawing.Point(149, 85);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(61, 13);
            contactIDLabel.TabIndex = 1;
            contactIDLabel.Text = "Contact ID:";
            // 
            // contactIDTextBox1
            // 
            this.contactIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "ContactID", true));
            this.contactIDTextBox1.Location = new System.Drawing.Point(216, 82);
            this.contactIDTextBox1.Name = "contactIDTextBox1";
            this.contactIDTextBox1.Size = new System.Drawing.Size(200, 20);
            this.contactIDTextBox1.TabIndex = 2;
            // 
            // last_CallLabel
            // 
            last_CallLabel.AutoSize = true;
            last_CallLabel.Location = new System.Drawing.Point(149, 112);
            last_CallLabel.Name = "last_CallLabel";
            last_CallLabel.Size = new System.Drawing.Size(50, 13);
            last_CallLabel.TabIndex = 3;
            last_CallLabel.Text = "Last Call:";
            // 
            // last_CallDateTimePicker1
            // 
            this.last_CallDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource1, "Last Call", true));
            this.last_CallDateTimePicker1.Location = new System.Drawing.Point(216, 108);
            this.last_CallDateTimePicker1.Name = "last_CallDateTimePicker1";
            this.last_CallDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.last_CallDateTimePicker1.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(149, 137);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(216, 134);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox1.TabIndex = 6;
            // 
            // client_Label
            // 
            client_Label.AutoSize = true;
            client_Label.Location = new System.Drawing.Point(149, 165);
            client_Label.Name = "client_Label";
            client_Label.Size = new System.Drawing.Size(42, 13);
            client_Label.TabIndex = 7;
            client_Label.Text = "Client?:";
            // 
            // client_CheckBox1
            // 
            this.client_CheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource1, "Client?", true));
            this.client_CheckBox1.Location = new System.Drawing.Point(216, 160);
            this.client_CheckBox1.Name = "client_CheckBox1";
            this.client_CheckBox1.Size = new System.Drawing.Size(200, 24);
            this.client_CheckBox1.TabIndex = 8;
            this.client_CheckBox1.Text = "checkBox1";
            this.client_CheckBox1.UseVisualStyleBackColor = true;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(149, 193);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 9;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox1
            // 
            this.telephoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Telephone", true));
            this.telephoneTextBox1.Location = new System.Drawing.Point(216, 190);
            this.telephoneTextBox1.Name = "telephoneTextBox1";
            this.telephoneTextBox1.Size = new System.Drawing.Size(200, 20);
            this.telephoneTextBox1.TabIndex = 10;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(149, 219);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 11;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox1
            // 
            this.companyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Company", true));
            this.companyTextBox1.Location = new System.Drawing.Point(216, 216);
            this.companyTextBox1.Name = "companyTextBox1";
            this.companyTextBox1.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(670, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(971, 443);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox1);
            this.Controls.Add(last_CallLabel);
            this.Controls.Add(this.last_CallDateTimePicker1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(client_Label);
            this.Controls.Add(this.client_CheckBox1);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox1);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox1);
            this.Controls.Add(this.tableBindingSource1BindingNavigator);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1BindingNavigator)).EndInit();
            this.tableBindingSource1BindingNavigator.ResumeLayout(false);
            this.tableBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ContactDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.DateTimePicker last_CallDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox client_CheckBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private ContactDBDataSet contactDBDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private ContactDBDataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator tableBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tableBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIDTextBox1;
        private System.Windows.Forms.DateTimePicker last_CallDateTimePicker1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.CheckBox client_CheckBox1;
        private System.Windows.Forms.TextBox telephoneTextBox1;
        private System.Windows.Forms.TextBox companyTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

