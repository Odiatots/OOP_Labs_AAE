namespace FindAreaFiguresGUI
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MinimazeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TypeFigureLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DataFiguresGridView = new System.Windows.Forms.DataGridView();
            this.FigureRadioButton = new System.Windows.Forms.RadioButton();
            this.AreaRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AreaAprRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFiguresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MovePanel.Controls.Add(this.MinimazeLabel);
            this.MovePanel.Controls.Add(this.CloseLabel);
            this.MovePanel.Controls.Add(this.SearchLabel);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(301, 33);
            this.MovePanel.TabIndex = 2;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            // 
            // MinimazeLabel
            // 
            this.MinimazeLabel.AutoSize = true;
            this.MinimazeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimazeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimazeLabel.Location = new System.Drawing.Point(248, 3);
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
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchLabel.Location = new System.Drawing.Point(7, 6);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 21);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            this.SearchLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchLabel_MouseDown);
            this.SearchLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchLabel_MouseMove);
            // 
            // TypeFigureLabel
            // 
            this.TypeFigureLabel.AutoSize = true;
            this.TypeFigureLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeFigureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeFigureLabel.Location = new System.Drawing.Point(8, 45);
            this.TypeFigureLabel.Name = "TypeFigureLabel";
            this.TypeFigureLabel.Size = new System.Drawing.Size(90, 17);
            this.TypeFigureLabel.TabIndex = 10;
            this.TypeFigureLabel.Text = "List of figures:";
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
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.DataFiguresGridView.RowHeadersVisible = false;
            this.DataFiguresGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFiguresGridView.Size = new System.Drawing.Size(280, 246);
            this.DataFiguresGridView.TabIndex = 1;
            // 
            // FigureRadioButton
            // 
            this.FigureRadioButton.AutoSize = true;
            this.FigureRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.FigureRadioButton.Location = new System.Drawing.Point(11, 364);
            this.FigureRadioButton.Name = "FigureRadioButton";
            this.FigureRadioButton.Size = new System.Drawing.Size(139, 18);
            this.FigureRadioButton.TabIndex = 15;
            this.FigureRadioButton.TabStop = true;
            this.FigureRadioButton.Text = "Search by figure name";
            this.FigureRadioButton.UseVisualStyleBackColor = true;
            // 
            // AreaRadioButton
            // 
            this.AreaRadioButton.AutoSize = true;
            this.AreaRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.AreaRadioButton.Location = new System.Drawing.Point(11, 388);
            this.AreaRadioButton.Name = "AreaRadioButton";
            this.AreaRadioButton.Size = new System.Drawing.Size(136, 18);
            this.AreaRadioButton.TabIndex = 16;
            this.AreaRadioButton.TabStop = true;
            this.AreaRadioButton.Text = "Search by area exactly";
            this.AreaRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 336);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(279, 22);
            this.SearchTextBox.TabIndex = 17;
            // 
            // AreaAprRadioButton
            // 
            this.AreaAprRadioButton.AutoSize = true;
            this.AreaAprRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.AreaAprRadioButton.Location = new System.Drawing.Point(11, 412);
            this.AreaAprRadioButton.Name = "AreaAprRadioButton";
            this.AreaAprRadioButton.Size = new System.Drawing.Size(138, 18);
            this.AreaAprRadioButton.TabIndex = 18;
            this.AreaAprRadioButton.TabStop = true;
            this.AreaAprRadioButton.Text = "Search by area approx";
            this.AreaAprRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.Location = new System.Drawing.Point(156, 364);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(135, 66);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(301, 439);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AreaAprRadioButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AreaRadioButton);
            this.Controls.Add(this.FigureRadioButton);
            this.Controls.Add(this.DataFiguresGridView);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TypeFigureLabel);
            this.Controls.Add(this.MovePanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
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
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label TypeFigureLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView DataFiguresGridView;
        private System.Windows.Forms.RadioButton FigureRadioButton;
        private System.Windows.Forms.RadioButton AreaRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton AreaAprRadioButton;
        private System.Windows.Forms.Button SearchButton;
    }
}