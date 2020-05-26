namespace FindAreaFiguresGUI
{
    partial class FigureForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureForm));
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MinimazeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeFigureComboBox = new System.Windows.Forms.ComboBox();
            this.TypeFigureLabel = new System.Windows.Forms.Label();
            this.CalcTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CalcTypeLabel = new System.Windows.Forms.Label();
            this.GiveDimensionButton = new System.Windows.Forms.Button();
            this.DimensionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetResultButton = new System.Windows.Forms.Button();
            this.FigureAreaTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionsDataGridView)).BeginInit();
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
            this.MovePanel.Size = new System.Drawing.Size(299, 33);
            this.MovePanel.TabIndex = 0;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            // 
            // MinimazeLabel
            // 
            this.MinimazeLabel.AutoSize = true;
            this.MinimazeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimazeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimazeLabel.Location = new System.Drawing.Point(245, 3);
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
            this.CloseLabel.Location = new System.Drawing.Point(272, 3);
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
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area calculator";
            // 
            // TypeFigureComboBox
            // 
            this.TypeFigureComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TypeFigureComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeFigureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeFigureComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeFigureComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeFigureComboBox.FormattingEnabled = true;
            this.TypeFigureComboBox.Location = new System.Drawing.Point(11, 69);
            this.TypeFigureComboBox.Name = "TypeFigureComboBox";
            this.TypeFigureComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeFigureComboBox.TabIndex = 1;
            this.TypeFigureComboBox.SelectionChangeCommitted += new System.EventHandler(this.TypeFigureComboBox_SelectionChangeCommitted);
            // 
            // TypeFigureLabel
            // 
            this.TypeFigureLabel.AutoSize = true;
            this.TypeFigureLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeFigureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeFigureLabel.Location = new System.Drawing.Point(8, 43);
            this.TypeFigureLabel.Name = "TypeFigureLabel";
            this.TypeFigureLabel.Size = new System.Drawing.Size(76, 17);
            this.TypeFigureLabel.TabIndex = 3;
            this.TypeFigureLabel.Text = "Type figure:";
            // 
            // CalcTypeComboBox
            // 
            this.CalcTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CalcTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CalcTypeComboBox.FormattingEnabled = true;
            this.CalcTypeComboBox.Location = new System.Drawing.Point(166, 69);
            this.CalcTypeComboBox.Name = "CalcTypeComboBox";
            this.CalcTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CalcTypeComboBox.TabIndex = 4;
            this.CalcTypeComboBox.Visible = false;
            this.CalcTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.CalcTypeComboBox_SelectionChangeCommitted);
            // 
            // CalcTypeLabel
            // 
            this.CalcTypeLabel.AutoSize = true;
            this.CalcTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CalcTypeLabel.Location = new System.Drawing.Point(163, 43);
            this.CalcTypeLabel.Name = "CalcTypeLabel";
            this.CalcTypeLabel.Size = new System.Drawing.Size(64, 17);
            this.CalcTypeLabel.TabIndex = 5;
            this.CalcTypeLabel.Text = "Type calc:";
            this.CalcTypeLabel.Visible = false;
            // 
            // GiveDimensionButton
            // 
            this.GiveDimensionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GiveDimensionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GiveDimensionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiveDimensionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveDimensionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GiveDimensionButton.Location = new System.Drawing.Point(11, 108);
            this.GiveDimensionButton.Name = "GiveDimensionButton";
            this.GiveDimensionButton.Size = new System.Drawing.Size(276, 23);
            this.GiveDimensionButton.TabIndex = 6;
            this.GiveDimensionButton.Text = "let me input";
            this.GiveDimensionButton.UseVisualStyleBackColor = false;
            this.GiveDimensionButton.Visible = false;
            this.GiveDimensionButton.Click += new System.EventHandler(this.GiveDimensionButton_Click);
            // 
            // DimensionsDataGridView
            // 
            this.DimensionsDataGridView.AllowUserToAddRows = false;
            this.DimensionsDataGridView.AllowUserToDeleteRows = false;
            this.DimensionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DimensionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DimensionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dimensions,
            this.ValueDimensions});
            this.DimensionsDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DimensionsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.DimensionsDataGridView.Location = new System.Drawing.Point(11, 151);
            this.DimensionsDataGridView.Name = "DimensionsDataGridView";
            this.DimensionsDataGridView.Size = new System.Drawing.Size(276, 97);
            this.DimensionsDataGridView.TabIndex = 7;
            this.DimensionsDataGridView.Visible = false;
            // 
            // Dimensions
            // 
            this.Dimensions.HeaderText = "Dimensions";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            this.Dimensions.Width = 125;
            // 
            // ValueDimensions
            // 
            this.ValueDimensions.HeaderText = "Values";
            this.ValueDimensions.Name = "ValueDimensions";
            this.ValueDimensions.Width = 105;
            // 
            // GetResultButton
            // 
            this.GetResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GetResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetResultButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GetResultButton.Location = new System.Drawing.Point(11, 267);
            this.GetResultButton.Name = "GetResultButton";
            this.GetResultButton.Size = new System.Drawing.Size(276, 23);
            this.GetResultButton.TabIndex = 8;
            this.GetResultButton.Text = "Go!";
            this.GetResultButton.UseVisualStyleBackColor = false;
            this.GetResultButton.Visible = false;
            this.GetResultButton.Click += new System.EventHandler(this.GetResultButton_Click);
            // 
            // FigureAreaTextBox
            // 
            this.FigureAreaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.FigureAreaTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.FigureAreaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FigureAreaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FigureAreaTextBox.Location = new System.Drawing.Point(12, 329);
            this.FigureAreaTextBox.Name = "FigureAreaTextBox";
            this.FigureAreaTextBox.ReadOnly = true;
            this.FigureAreaTextBox.Size = new System.Drawing.Size(276, 22);
            this.FigureAreaTextBox.TabIndex = 9;
            this.FigureAreaTextBox.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResultLabel.Location = new System.Drawing.Point(12, 305);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(46, 17);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.Visible = false;
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GoBackButton.Location = new System.Drawing.Point(12, 372);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(132, 23);
            this.GoBackButton.TabIndex = 11;
            this.GoBackButton.Text = "Save and exit";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackButton.Location = new System.Drawing.Point(156, 372);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(132, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Don\'t save and exit";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(299, 417);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FigureAreaTextBox);
            this.Controls.Add(this.GetResultButton);
            this.Controls.Add(this.DimensionsDataGridView);
            this.Controls.Add(this.GiveDimensionButton);
            this.Controls.Add(this.CalcTypeLabel);
            this.Controls.Add(this.CalcTypeComboBox);
            this.Controls.Add(this.TypeFigureLabel);
            this.Controls.Add(this.TypeFigureComboBox);
            this.Controls.Add(this.MovePanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FigureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.ComboBox TypeFigureComboBox;
        private System.Windows.Forms.Label MinimazeLabel;
        private System.Windows.Forms.Label TypeFigureLabel;
        private System.Windows.Forms.ComboBox CalcTypeComboBox;
        private System.Windows.Forms.Label CalcTypeLabel;
        private System.Windows.Forms.Button GiveDimensionButton;
        private System.Windows.Forms.DataGridView DimensionsDataGridView;
        private System.Windows.Forms.Button GetResultButton;
        private System.Windows.Forms.TextBox FigureAreaTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDimensions;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button BackButton;
    }
}

