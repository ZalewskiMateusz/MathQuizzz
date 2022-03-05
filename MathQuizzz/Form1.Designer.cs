namespace MathQuizzz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timeLeftLbl = new System.Windows.Forms.Label();
            this.timeInfoLbl = new System.Windows.Forms.Label();
            this.leftNumberLbl = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.NumericUpDown();
            this.mathMarkLbl = new System.Windows.Forms.Label();
            this.rightNumberLbl = new System.Windows.Forms.Label();
            this.equalLbl = new System.Windows.Forms.Label();
            this.startTheQuizzBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLeftLbl
            // 
            this.timeLeftLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLeftLbl.Location = new System.Drawing.Point(616, 8);
            this.timeLeftLbl.Name = "timeLeftLbl";
            this.timeLeftLbl.Size = new System.Drawing.Size(177, 37);
            this.timeLeftLbl.TabIndex = 0;
            this.timeLeftLbl.Text = "00:00:00";
            this.timeLeftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeInfoLbl
            // 
            this.timeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeInfoLbl.Location = new System.Drawing.Point(433, 9);
            this.timeInfoLbl.Name = "timeInfoLbl";
            this.timeInfoLbl.Size = new System.Drawing.Size(177, 37);
            this.timeInfoLbl.TabIndex = 1;
            this.timeInfoLbl.Text = "TIME LEFT:";
            this.timeInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftNumberLbl
            // 
            this.leftNumberLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftNumberLbl.Location = new System.Drawing.Point(202, 140);
            this.leftNumberLbl.Name = "leftNumberLbl";
            this.leftNumberLbl.Size = new System.Drawing.Size(75, 75);
            this.leftNumberLbl.TabIndex = 2;
            this.leftNumberLbl.Text = "?";
            this.leftNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(536, 155);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(74, 45);
            this.result.TabIndex = 3;
            // 
            // mathMarkLbl
            // 
            this.mathMarkLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mathMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathMarkLbl.Location = new System.Drawing.Point(283, 140);
            this.mathMarkLbl.Name = "mathMarkLbl";
            this.mathMarkLbl.Size = new System.Drawing.Size(75, 75);
            this.mathMarkLbl.TabIndex = 4;
            this.mathMarkLbl.Text = "+";
            this.mathMarkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightNumberLbl
            // 
            this.rightNumberLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightNumberLbl.Location = new System.Drawing.Point(364, 140);
            this.rightNumberLbl.Name = "rightNumberLbl";
            this.rightNumberLbl.Size = new System.Drawing.Size(75, 75);
            this.rightNumberLbl.TabIndex = 5;
            this.rightNumberLbl.Text = "?";
            this.rightNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLbl
            // 
            this.equalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.equalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalLbl.Location = new System.Drawing.Point(445, 140);
            this.equalLbl.Name = "equalLbl";
            this.equalLbl.Size = new System.Drawing.Size(75, 75);
            this.equalLbl.TabIndex = 6;
            this.equalLbl.Text = "=";
            this.equalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTheQuizzBtn
            // 
            this.startTheQuizzBtn.Location = new System.Drawing.Point(611, 381);
            this.startTheQuizzBtn.Name = "startTheQuizzBtn";
            this.startTheQuizzBtn.Size = new System.Drawing.Size(172, 55);
            this.startTheQuizzBtn.TabIndex = 7;
            this.startTheQuizzBtn.Text = "START THE QUIZZ";
            this.startTheQuizzBtn.UseVisualStyleBackColor = true;
            this.startTheQuizzBtn.Click += new System.EventHandler(this.startTheQuizzBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTheQuizzBtn);
            this.Controls.Add(this.equalLbl);
            this.Controls.Add(this.rightNumberLbl);
            this.Controls.Add(this.mathMarkLbl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.leftNumberLbl);
            this.Controls.Add(this.timeInfoLbl);
            this.Controls.Add(this.timeLeftLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLeftLbl;
        private System.Windows.Forms.Label timeInfoLbl;
        private System.Windows.Forms.Label leftNumberLbl;
        private System.Windows.Forms.NumericUpDown result;
        private System.Windows.Forms.Label mathMarkLbl;
        private System.Windows.Forms.Label rightNumberLbl;
        private System.Windows.Forms.Label equalLbl;
        private System.Windows.Forms.Button startTheQuizzBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

