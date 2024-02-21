﻿namespace Initial_Consonant_Choice
{
    partial class PracticeEndScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button quitButton;
        private Button practiceAgainButton;
        private Button continueButton;

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
            ButtonsPanel = new TableLayoutPanel();
            PracticeAgainButton = new Button();
            QuitButton = new Button();
            ContinueButton = new Button();
            Page = new FlowLayoutPanel();
            FormTablePanel = new TableLayoutPanel();
            Title = new TextBox();
            ParticipantScoreLabel = new Label();
            ButtonsPanel.SuspendLayout();
            Page.SuspendLayout();
            FormTablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.AutoSize = true;
            ButtonsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonsPanel.ColumnCount = 3;
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsPanel.Controls.Add(PracticeAgainButton, 1, 0);
            ButtonsPanel.Controls.Add(QuitButton, 0, 0);
            ButtonsPanel.Controls.Add(ContinueButton, 2, 0);
            ButtonsPanel.Dock = DockStyle.Fill;
            ButtonsPanel.Location = new Point(10, 108);
            ButtonsPanel.Margin = new Padding(10);
            ButtonsPanel.MaximumSize = new Size(1000, 0);
            ButtonsPanel.MinimumSize = new Size(500, 0);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Padding = new Padding(10);
            ButtonsPanel.RowCount = 1;
            ButtonsPanel.RowStyles.Add(new RowStyle());
            ButtonsPanel.Size = new Size(593, 70);
            ButtonsPanel.TabIndex = 4;
            // 
            // PracticeAgainButton
            // 
            PracticeAgainButton.AutoSize = true;
            PracticeAgainButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PracticeAgainButton.Dock = DockStyle.Top;
            PracticeAgainButton.Location = new Point(231, 10);
            PracticeAgainButton.Margin = new Padding(30, 0, 30, 0);
            PracticeAgainButton.MinimumSize = new Size(100, 50);
            PracticeAgainButton.Name = "PracticeAgainButton";
            PracticeAgainButton.Size = new Size(131, 50);
            PracticeAgainButton.TabIndex = 2;
            PracticeAgainButton.Text = "Practice Again";
            PracticeAgainButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            QuitButton.AutoSize = true;
            QuitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            QuitButton.Dock = DockStyle.Top;
            QuitButton.Location = new Point(40, 10);
            QuitButton.Margin = new Padding(30, 0, 30, 0);
            QuitButton.MinimumSize = new Size(100, 50);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(131, 50);
            QuitButton.TabIndex = 0;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.AutoSize = true;
            ContinueButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContinueButton.Dock = DockStyle.Top;
            ContinueButton.Location = new Point(422, 10);
            ContinueButton.Margin = new Padding(30, 0, 30, 0);
            ContinueButton.MinimumSize = new Size(100, 50);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(131, 50);
            ContinueButton.TabIndex = 3;
            ContinueButton.Text = "Continue To Exercises";
            ContinueButton.UseVisualStyleBackColor = true;
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Page.Controls.Add(FormTablePanel);
            Page.Dock = DockStyle.Fill;
            Page.Location = new Point(10, 10);
            Page.Name = "Page";
            Page.Size = new Size(715, 477);
            Page.TabIndex = 5;
            // 
            // FormTablePanel
            // 
            FormTablePanel.AutoSize = true;
            FormTablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormTablePanel.ColumnCount = 1;
            FormTablePanel.ColumnStyles.Add(new ColumnStyle());
            FormTablePanel.Controls.Add(Title, 0, 0);
            FormTablePanel.Controls.Add(ButtonsPanel, 0, 2);
            FormTablePanel.Controls.Add(ParticipantScoreLabel, 0, 1);
            FormTablePanel.Dock = DockStyle.Fill;
            FormTablePanel.Location = new Point(3, 3);
            FormTablePanel.MaximumSize = new Size(1000, 0);
            FormTablePanel.MinimumSize = new Size(500, 0);
            FormTablePanel.Name = "FormTablePanel";
            FormTablePanel.RowCount = 3;
            FormTablePanel.RowStyles.Add(new RowStyle());
            FormTablePanel.RowStyles.Add(new RowStyle());
            FormTablePanel.RowStyles.Add(new RowStyle());
            FormTablePanel.Size = new Size(613, 188);
            FormTablePanel.TabIndex = 10;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.Control;
            Title.BorderStyle = BorderStyle.None;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(10, 10);
            Title.Margin = new Padding(10);
            Title.Name = "Title";
            Title.Size = new Size(387, 43);
            Title.TabIndex = 5;
            Title.Text = "Practice Session Complete";
            // 
            // ParticipantScoreLabel
            // 
            ParticipantScoreLabel.AutoSize = true;
            ParticipantScoreLabel.Location = new Point(10, 63);
            ParticipantScoreLabel.Margin = new Padding(10, 0, 10, 0);
            ParticipantScoreLabel.Name = "ParticipantScoreLabel";
            ParticipantScoreLabel.Padding = new Padding(0, 10, 0, 10);
            ParticipantScoreLabel.Size = new Size(102, 35);
            ParticipantScoreLabel.TabIndex = 6;
            ParticipantScoreLabel.Text = "Participant Score: ";
            // 
            // PracticeEndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 497);
            Controls.Add(Page);
            Name = "PracticeEndScreen";
            Padding = new Padding(10);
            Text = "Practice Session Complete";
            Load += PracticeEndScreen_Load;
            ButtonsPanel.ResumeLayout(false);
            ButtonsPanel.PerformLayout();
            Page.ResumeLayout(false);
            Page.PerformLayout();
            FormTablePanel.ResumeLayout(false);
            FormTablePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel ButtonsPanel;
        private Button PracticeAgainButton;
        private Button QuitButton;
        private Button ContinueButton;
        private FlowLayoutPanel Page;
        private TextBox Title;
        private TableLayoutPanel FormTablePanel;

        private Label ParticipantScoreLabel;
    }
}