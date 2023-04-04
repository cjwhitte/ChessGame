namespace ChessApplication.ChessGame.Forms
{
    partial class formBoard
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
            TextBoxY = new TextBox();
            TextBoxX = new TextBox();
            SelectButton = new Button();
            LabelX = new Label();
            LabelY = new Label();
            SuspendLayout();
            // 
            // TextBoxY
            // 
            TextBoxY.Location = new Point(688, 134);
            TextBoxY.Name = "TextBoxY";
            TextBoxY.Size = new Size(100, 23);
            TextBoxY.TabIndex = 1;
            TextBoxY.TextChanged += TextBoxY_TextChanged;
            // 
            // TextBoxX
            // 
            TextBoxX.Location = new Point(582, 134);
            TextBoxX.Name = "TextBoxX";
            TextBoxX.Size = new Size(100, 23);
            TextBoxX.TabIndex = 2;
            TextBoxX.TextChanged += TextBoxX_TextChanged;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(661, 175);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(75, 23);
            SelectButton.TabIndex = 3;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.Location = new Point(589, 106);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(45, 15);
            LabelX.TabIndex = 4;
            LabelX.Text = "X Value";
            // 
            // LabelY
            // 
            LabelY.AutoSize = true;
            LabelY.Location = new Point(705, 111);
            LabelY.Name = "LabelY";
            LabelY.Size = new Size(45, 15);
            LabelY.TabIndex = 5;
            LabelY.Text = "Y Value";
            // 
            // formBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelY);
            Controls.Add(LabelX);
            Controls.Add(SelectButton);
            Controls.Add(TextBoxX);
            Controls.Add(TextBoxY);
            Name = "formBoard";
            Text = "formBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxX;
        private TextBox TextBoxY;
        private Button SelectButton;
        private Label LabelX;
        private Label LabelY;
    }
}