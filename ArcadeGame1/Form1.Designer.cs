namespace ArcadeGame1
{
    partial class ArcadeMachineLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcadeMachineLabel));
            this.StartButton1 = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.NumberLabel3 = new System.Windows.Forms.Label();
            this.NumberLabel2 = new System.Windows.Forms.Label();
            this.NumberLabel1 = new System.Windows.Forms.Label();
            this.BeginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton1
            // 
            this.StartButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartButton1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.StartButton1.Location = new System.Drawing.Point(104, 64);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(201, 98);
            this.StartButton1.TabIndex = 0;
            this.StartButton1.Text = "Start";
            this.StartButton1.UseMnemonic = false;
            this.StartButton1.UseVisualStyleBackColor = false;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.Location = new System.Drawing.Point(59, 64);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(246, 53);
            this.CountdownLabel.TabIndex = 1;
            this.CountdownLabel.Text = "Game Starts In";
            this.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLabel3
            // 
            this.NumberLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel3.Location = new System.Drawing.Point(302, 64);
            this.NumberLabel3.Name = "NumberLabel3";
            this.NumberLabel3.Size = new System.Drawing.Size(45, 53);
            this.NumberLabel3.TabIndex = 2;
            this.NumberLabel3.Text = "3";
            this.NumberLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumberLabel3.Visible = false;
            this.NumberLabel3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // NumberLabel2
            // 
            this.NumberLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel2.Location = new System.Drawing.Point(303, 64);
            this.NumberLabel2.Name = "NumberLabel2";
            this.NumberLabel2.Size = new System.Drawing.Size(44, 53);
            this.NumberLabel2.TabIndex = 3;
            this.NumberLabel2.Text = "2";
            this.NumberLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumberLabel2.Visible = false;
            // 
            // NumberLabel1
            // 
            this.NumberLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel1.Location = new System.Drawing.Point(303, 64);
            this.NumberLabel1.Name = "NumberLabel1";
            this.NumberLabel1.Size = new System.Drawing.Size(45, 53);
            this.NumberLabel1.TabIndex = 4;
            this.NumberLabel1.Text = "1";
            this.NumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumberLabel1.Visible = false;
            this.NumberLabel1.Click += new System.EventHandler(this.NumberLabel1_Click);
            // 
            // BeginLabel
            // 
            this.BeginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginLabel.Location = new System.Drawing.Point(142, 179);
            this.BeginLabel.Name = "BeginLabel";
            this.BeginLabel.Size = new System.Drawing.Size(125, 47);
            this.BeginLabel.TabIndex = 5;
            this.BeginLabel.Text = "Begin";
            this.BeginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BeginLabel.Click += new System.EventHandler(this.BeginLabel_Click);
            // 
            // ArcadeMachineLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.BeginLabel);
            this.Controls.Add(this.NumberLabel1);
            this.Controls.Add(this.NumberLabel2);
            this.Controls.Add(this.NumberLabel3);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.CountdownLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcadeMachineLabel";
            this.Text = "Arcade Machine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Label NumberLabel3;
        private System.Windows.Forms.Label NumberLabel2;
        private System.Windows.Forms.Label NumberLabel1;
        private System.Windows.Forms.Label BeginLabel;
    }
}

