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
            LabelX = new Label();
            LabelY = new Label();
            UpButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            DownButton = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.Location = new Point(639, 111);
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
            // UpButton
            // 
            UpButton.Location = new Point(660, 151);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(75, 23);
            UpButton.TabIndex = 6;
            UpButton.Text = "Up";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(624, 192);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(75, 23);
            LeftButton.TabIndex = 7;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(705, 192);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(75, 23);
            RightButton.TabIndex = 8;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(660, 233);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(75, 23);
            DownButton.TabIndex = 9;
            DownButton.Text = "Down";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Dock = DockStyle.Left;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Margin = new Padding(0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(400, 450);
            flowLayoutPanel.TabIndex = 10;
            // 
            // formBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Controls.Add(DownButton);
            Controls.Add(RightButton);
            Controls.Add(LeftButton);
            Controls.Add(UpButton);
            Controls.Add(LabelY);
            Controls.Add(LabelX);
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
        private Button UpButton;
        private Button LeftButton;
        private Button RightButton;
        private Button DownButton;
        private FlowLayoutPanel flowLayoutPanel;
    }
}