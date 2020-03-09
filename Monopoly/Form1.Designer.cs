namespace Monopoly
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Map_PictureBox = new System.Windows.Forms.PictureBox();
            this.Player_PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Map_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Map_PictureBox
            // 
            this.Map_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Map_PictureBox.Image")));
            this.Map_PictureBox.Location = new System.Drawing.Point(609, 12);
            this.Map_PictureBox.Name = "Map_PictureBox";
            this.Map_PictureBox.Size = new System.Drawing.Size(400, 400);
            this.Map_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Map_PictureBox.TabIndex = 0;
            this.Map_PictureBox.TabStop = false;
            // 
            // Player_PictureBox
            // 
            this.Player_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Player_PictureBox.Image")));
            this.Player_PictureBox.Location = new System.Drawing.Point(487, 188);
            this.Player_PictureBox.Name = "Player_PictureBox";
            this.Player_PictureBox.Size = new System.Drawing.Size(50, 50);
            this.Player_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player_PictureBox.TabIndex = 1;
            this.Player_PictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "骰子";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "骰子點數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "記分板";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Player_PictureBox);
            this.Controls.Add(this.Map_PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Map_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Map_PictureBox;
        private System.Windows.Forms.PictureBox Player_PictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

