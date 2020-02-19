namespace Homework_6
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
            this.CalcButton = new System.Windows.Forms.Button();
            this.EndLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.CalcButton.Location = new System.Drawing.Point(269, 311);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(289, 81);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "按我開始分析";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.EndLabel.Location = new System.Drawing.Point(275, 191);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(0, 40);
            this.EndLabel.TabIndex = 1;
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(310, 115);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(219, 29);
            this.inputTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(79, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "請輸入西元年分:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "年分查六日";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label label2;
    }
}

