namespace TestingParkingApp
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPark = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRegBox = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.Label();
            this.grpSubmenu = new System.Windows.Forms.GroupBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnBike = new System.Windows.Forms.Button();
            this.btnMc = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.lstPHouse = new System.Windows.Forms.ListBox();
            this.grpMenu.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(342, 339);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(132, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Parkinghouse";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnShow);
            this.grpMenu.Controls.Add(this.btnExit);
            this.grpMenu.Controls.Add(this.btnSearch);
            this.grpMenu.Controls.Add(this.btnMove);
            this.grpMenu.Controls.Add(this.btnRemove);
            this.grpMenu.Controls.Add(this.btnPark);
            this.grpMenu.Location = new System.Drawing.Point(29, 35);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(130, 403);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            this.grpMenu.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 197);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(114, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Phouse";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Vehicle";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(10, 111);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(114, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move Vehicle";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(10, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Vehicle";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPark
            // 
            this.btnPark.Location = new System.Drawing.Point(10, 31);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(114, 23);
            this.btnPark.TabIndex = 0;
            this.btnPark.Text = "Park Vehicle";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.button1);
            this.grpInput.Controls.Add(this.txtRegBox);
            this.grpInput.Controls.Add(this.txtReg);
            this.grpInput.Location = new System.Drawing.Point(330, 35);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(200, 220);
            this.grpInput.TabIndex = 7;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            this.grpInput.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegBox
            // 
            this.txtRegBox.Location = new System.Drawing.Point(12, 55);
            this.txtRegBox.Name = "txtRegBox";
            this.txtRegBox.Size = new System.Drawing.Size(142, 23);
            this.txtRegBox.TabIndex = 1;
            this.txtRegBox.TextChanged += new System.EventHandler(this.txtRegBox_TextChanged);
            // 
            // txtReg
            // 
            this.txtReg.AutoSize = true;
            this.txtReg.Location = new System.Drawing.Point(12, 32);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(142, 15);
            this.txtReg.TabIndex = 0;
            this.txtReg.Text = "Enter registration number";
            // 
            // grpSubmenu
            // 
            this.grpSubmenu.Controls.Add(this.btnBus);
            this.grpSubmenu.Controls.Add(this.btnBike);
            this.grpSubmenu.Controls.Add(this.btnMc);
            this.grpSubmenu.Controls.Add(this.btnCar);
            this.grpSubmenu.Location = new System.Drawing.Point(180, 35);
            this.grpSubmenu.Name = "grpSubmenu";
            this.grpSubmenu.Size = new System.Drawing.Size(131, 220);
            this.grpSubmenu.TabIndex = 8;
            this.grpSubmenu.TabStop = false;
            this.grpSubmenu.Text = "Sub Menu";
            this.grpSubmenu.Visible = false;
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(28, 153);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(75, 23);
            this.btnBus.TabIndex = 3;
            this.btnBus.Text = "BUS";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnBike
            // 
            this.btnBike.Location = new System.Drawing.Point(28, 111);
            this.btnBike.Name = "btnBike";
            this.btnBike.Size = new System.Drawing.Size(75, 23);
            this.btnBike.TabIndex = 2;
            this.btnBike.Text = "BIKE";
            this.btnBike.UseVisualStyleBackColor = true;
            this.btnBike.Click += new System.EventHandler(this.btnBike_Click);
            // 
            // btnMc
            // 
            this.btnMc.Location = new System.Drawing.Point(28, 74);
            this.btnMc.Name = "btnMc";
            this.btnMc.Size = new System.Drawing.Size(75, 21);
            this.btnMc.TabIndex = 1;
            this.btnMc.Text = "MC";
            this.btnMc.UseVisualStyleBackColor = true;
            this.btnMc.Click += new System.EventHandler(this.btnMc_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(28, 32);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(75, 22);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "CAR";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // lstPHouse
            // 
            this.lstPHouse.FormattingEnabled = true;
            this.lstPHouse.ItemHeight = 15;
            this.lstPHouse.Location = new System.Drawing.Point(556, 35);
            this.lstPHouse.Name = "lstPHouse";
            this.lstPHouse.Size = new System.Drawing.Size(186, 319);
            this.lstPHouse.TabIndex = 9;
            this.lstPHouse.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPHouse);
            this.Controls.Add(this.grpSubmenu);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMenu.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtRegBox;
        private System.Windows.Forms.Label txtReg;
        private System.Windows.Forms.GroupBox grpSubmenu;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnBike;
        private System.Windows.Forms.Button btnMc;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstPHouse;
    }
}
