namespace StudentProfile
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
            btnRefresh = new Button();
            lblPositionInQueue = new Label();
            btnNext = new Button();
            lblPosition = new Label();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(40, 71);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblPositionInQueue
            // 
            lblPositionInQueue.AutoSize = true;
            lblPositionInQueue.Location = new Point(262, 71);
            lblPositionInQueue.Name = "lblPositionInQueue";
            lblPositionInQueue.Size = new Size(124, 20);
            lblPositionInQueue.TabIndex = 1;
            lblPositionInQueue.Text = "Position In Queue";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(40, 131);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosition.Location = new Point(262, 131);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(141, 38);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "P - 10004";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 221);
            Controls.Add(lblPosition);
            Controls.Add(btnNext);
            Controls.Add(lblPositionInQueue);
            Controls.Add(btnRefresh);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Label lblPositionInQueue;
        private Button btnNext;
        private Label lblPosition;
    }
}
