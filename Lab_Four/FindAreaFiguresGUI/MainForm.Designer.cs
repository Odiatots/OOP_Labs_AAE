namespace FindAreaFiguresGUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MinimazeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.RandomButton = new System.Windows.Forms.Button();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.DataFiguresGridView = new System.Windows.Forms.DataGridView();
            this.TypeFigureLabel = new System.Windows.Forms.Label();
            this.AddFigure = new System.Windows.Forms.Button();
            this.RemoveFigure = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFiguresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MovePanel.Controls.Add(this.MinimazeLabel);
            this.MovePanel.Controls.Add(this.CloseLabel);
            this.MovePanel.Controls.Add(this.RandomButton);
            this.MovePanel.Controls.Add(this.AreaLabel);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(301, 33);
            this.MovePanel.TabIndex = 1;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            // 
            // MinimazeLabel
            // 
            this.MinimazeLabel.AutoSize = true;
            this.MinimazeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimazeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimazeLabel.Location = new System.Drawing.Point(247, 3);
            this.MinimazeLabel.Name = "MinimazeLabel";
            this.MinimazeLabel.Size = new System.Drawing.Size(21, 27);
            this.MinimazeLabel.TabIndex = 2;
            this.MinimazeLabel.Text = "_";
            this.MinimazeLabel.Click += new System.EventHandler(this.MinimazeLabel_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseLabel.Location = new System.Drawing.Point(274, 3);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(24, 27);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RandomButton.Location = new System.Drawing.Point(150, 5);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(65, 24);
            this.RandomButton.TabIndex = 14;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomBurron_Click);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AreaLabel.Location = new System.Drawing.Point(7, 6);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(137, 21);
            this.AreaLabel.TabIndex = 0;
            this.AreaLabel.Text = "Area calculator list";
            this.AreaLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaLabel_MouseDown);
            this.AreaLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaLabel_MouseMove);
            // 
            // DataFiguresGridView
            // 
            this.DataFiguresGridView.AllowUserToAddRows = false;
            this.DataFiguresGridView.AllowUserToDeleteRows = false;
            this.DataFiguresGridView.AllowUserToResizeRows = false;
            this.DataFiguresGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataFiguresGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DataFiguresGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataFiguresGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataFiguresGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataFiguresGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataFiguresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFiguresGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataFiguresGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataFiguresGridView.EnableHeadersVisualStyles = false;
            this.DataFiguresGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DataFiguresGridView.Location = new System.Drawing.Point(11, 75);
            this.DataFiguresGridView.Name = "DataFiguresGridView";
            this.DataFiguresGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataFiguresGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataFiguresGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.DataFiguresGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataFiguresGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DataFiguresGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataFiguresGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFiguresGridView.Size = new System.Drawing.Size(280, 246);
            this.DataFiguresGridView.TabIndex = 1;
            // 
            // TypeFigureLabel
            // 
            this.TypeFigureLabel.AutoSize = true;
            this.TypeFigureLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeFigureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeFigureLabel.Location = new System.Drawing.Point(8, 45);
            this.TypeFigureLabel.Name = "TypeFigureLabel";
            this.TypeFigureLabel.Size = new System.Drawing.Size(90, 17);
            this.TypeFigureLabel.TabIndex = 9;
            this.TypeFigureLabel.Text = "List of figures:";
            // 
            // AddFigure
            // 
            this.AddFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AddFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFigure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddFigure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFigure.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFigure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddFigure.Location = new System.Drawing.Point(11, 327);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(99, 23);
            this.AddFigure.TabIndex = 10;
            this.AddFigure.Text = "Add Figure";
            this.AddFigure.UseVisualStyleBackColor = false;
            this.AddFigure.Click += new System.EventHandler(this.AddFigure_Click);
            // 
            // RemoveFigure
            // 
            this.RemoveFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RemoveFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveFigure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RemoveFigure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RemoveFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveFigure.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFigure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RemoveFigure.Location = new System.Drawing.Point(12, 356);
            this.RemoveFigure.Name = "RemoveFigure";
            this.RemoveFigure.Size = new System.Drawing.Size(98, 23);
            this.RemoveFigure.TabIndex = 11;
            this.RemoveFigure.Text = "Remove Figure";
            this.RemoveFigure.UseVisualStyleBackColor = false;
            this.RemoveFigure.Click += new System.EventHandler(this.RemoveFigure_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshButton.Location = new System.Drawing.Point(104, 42);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(62, 24);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.Location = new System.Drawing.Point(12, 385);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveButton.Location = new System.Drawing.Point(116, 327);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 36);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadButton.Location = new System.Drawing.Point(116, 372);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(175, 36);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(301, 421);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RemoveFigure);
            this.Controls.Add(this.AddFigure);
            this.Controls.Add(this.TypeFigureLabel);
            this.Controls.Add(this.DataFiguresGridView);
            this.Controls.Add(this.MovePanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFiguresGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Label MinimazeLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.DataGridView DataFiguresGridView;
        private System.Windows.Forms.Label TypeFigureLabel;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.Button RemoveFigure;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}