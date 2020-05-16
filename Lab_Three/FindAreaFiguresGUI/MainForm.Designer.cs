﻿namespace FindAreaFiguresGUI
{
    partial class MainForm
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
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор площадей";
            // 
            // TypeFigureComboBox
            // 
            this.TypeFigureComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TypeFigureComboBox.Cursor = System.Windows.Forms.Cursors.PanSouth;
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
            this.TypeFigureLabel.Size = new System.Drawing.Size(80, 17);
            this.TypeFigureLabel.TabIndex = 3;
            this.TypeFigureLabel.Text = "Тип фигуры:";
            // 
            // CalcTypeComboBox
            // 
            this.CalcTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.CalcTypeComboBox.Cursor = System.Windows.Forms.Cursors.PanSouth;
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
            this.CalcTypeLabel.Size = new System.Drawing.Size(83, 17);
            this.CalcTypeLabel.TabIndex = 5;
            this.CalcTypeLabel.Text = "Тип расчета:";
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
            this.GiveDimensionButton.Text = "Дай ввести параметры";
            this.GiveDimensionButton.UseVisualStyleBackColor = false;
            this.GiveDimensionButton.Visible = false;
            this.GiveDimensionButton.Click += new System.EventHandler(this.GiveDimensionButton_Click);
            // 
            // DimensionsDataGridView
            // 
            this.DimensionsDataGridView.AllowUserToAddRows = false;
            this.DimensionsDataGridView.AllowUserToDeleteRows = false;
            this.DimensionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DimensionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dimensions,
            this.ValueDimensions});
            this.DimensionsDataGridView.Location = new System.Drawing.Point(11, 151);
            this.DimensionsDataGridView.Name = "DimensionsDataGridView";
            this.DimensionsDataGridView.Size = new System.Drawing.Size(276, 114);
            this.DimensionsDataGridView.TabIndex = 7;
            this.DimensionsDataGridView.Visible = false;
            // 
            // Dimensions
            // 
            this.Dimensions.HeaderText = "Параметры";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            // 
            // ValueDimensions
            // 
            this.ValueDimensions.HeaderText = "Значения";
            this.ValueDimensions.Name = "ValueDimensions";
            // 
            // GetResultButton
            // 
            this.GetResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GetResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetResultButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GetResultButton.Location = new System.Drawing.Point(11, 282);
            this.GetResultButton.Name = "GetResultButton";
            this.GetResultButton.Size = new System.Drawing.Size(276, 23);
            this.GetResultButton.TabIndex = 8;
            this.GetResultButton.Text = "Посчитай";
            this.GetResultButton.UseVisualStyleBackColor = false;
            this.GetResultButton.Click += new System.EventHandler(this.GetResultButton_Click);
            // 
            // FigureAreaTextBox
            // 
            this.FigureAreaTextBox.Location = new System.Drawing.Point(11, 322);
            this.FigureAreaTextBox.Name = "FigureAreaTextBox";
            this.FigureAreaTextBox.Size = new System.Drawing.Size(276, 21);
            this.FigureAreaTextBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(299, 367);
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
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор площади";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDimensions;
        private System.Windows.Forms.Button GetResultButton;
        private System.Windows.Forms.TextBox FigureAreaTextBox;
    }
}

