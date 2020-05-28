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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MinimazeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataFiguresGridView = new System.Windows.Forms.DataGridView();
            this.TypeFigureLabel = new System.Windows.Forms.Label();
            this.AddFigure = new System.Windows.Forms.Button();
            this.RemoveFigure = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFiguresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MovePanel.Controls.Add(this.MinimazeLabel);
            this.MovePanel.Controls.Add(this.CloseLabel);
            this.MovePanel.Controls.Add(this.label1);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(430, 33);
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
            this.MinimazeLabel.Location = new System.Drawing.Point(376, 3);
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
            this.CloseLabel.Location = new System.Drawing.Point(403, 3);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(24, 27);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area calculator list";
            // 
            // DataFiguresGridView
            // 
            this.DataFiguresGridView.AllowUserToAddRows = false;
            this.DataFiguresGridView.AllowUserToDeleteRows = false;
            this.DataFiguresGridView.AllowUserToResizeRows = false;
            this.DataFiguresGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataFiguresGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DataFiguresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFiguresGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataFiguresGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DataFiguresGridView.Location = new System.Drawing.Point(11, 75);
            this.DataFiguresGridView.Name = "DataFiguresGridView";
            this.DataFiguresGridView.ReadOnly = true;
            this.DataFiguresGridView.Size = new System.Drawing.Size(409, 246);
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
            this.AddFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFigure.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFigure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddFigure.Location = new System.Drawing.Point(11, 337);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(133, 23);
            this.AddFigure.TabIndex = 10;
            this.AddFigure.Text = "Add Figure";
            this.AddFigure.UseVisualStyleBackColor = false;
            this.AddFigure.Click += new System.EventHandler(this.AddFigure_Click);
            // 
            // RemoveFigure
            // 
            this.RemoveFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RemoveFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveFigure.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFigure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RemoveFigure.Location = new System.Drawing.Point(150, 337);
            this.RemoveFigure.Name = "RemoveFigure";
            this.RemoveFigure.Size = new System.Drawing.Size(133, 23);
            this.RemoveFigure.TabIndex = 11;
            this.RemoveFigure.Text = "Remove Figure";
            this.RemoveFigure.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshButton.Location = new System.Drawing.Point(104, 42);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(133, 24);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(430, 372);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataFiguresGridView;
        private System.Windows.Forms.Label TypeFigureLabel;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.Button RemoveFigure;
        private System.Windows.Forms.Button RefreshButton;
    }
}