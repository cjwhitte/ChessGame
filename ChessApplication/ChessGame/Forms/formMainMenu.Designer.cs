namespace ChessApplication.ChessGame
{
    partial class formMainMenu
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
            ChessLabel = new Label();
            SuspendLayout();
            // 
            // ChessLabel
            // 
            ChessLabel.Font = new Font("Corbel", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChessLabel.Location = new Point(0, 0);
            ChessLabel.Name = "ChessLabel";
            ChessLabel.Size = new Size(800, 450);
            ChessLabel.TabIndex = 0;
            ChessLabel.Text = "Chess";
            ChessLabel.TextAlign = ContentAlignment.MiddleCenter;
            ChessLabel.Click += ChessLabel_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChessLabel);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Label ChessLabel;
    }
}