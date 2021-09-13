
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.ListBox();
            this.lbArticleInfo = new System.Windows.Forms.Label();
            this.btOpen_Form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(157, 18);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(523, 24);
            this.tbUrl.TabIndex = 1;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(702, 18);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 24);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitle.FormattingEnabled = true;
            this.lbTitle.ItemHeight = 16;
            this.lbTitle.Location = new System.Drawing.Point(16, 75);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(241, 532);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // lbArticleInfo
            // 
            this.lbArticleInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbArticleInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbArticleInfo.Location = new System.Drawing.Point(263, 169);
            this.lbArticleInfo.Name = "lbArticleInfo";
            this.lbArticleInfo.Size = new System.Drawing.Size(514, 325);
            this.lbArticleInfo.TabIndex = 5;
            // 
            // btOpen_Form2
            // 
            this.btOpen_Form2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen_Form2.Location = new System.Drawing.Point(658, 568);
            this.btOpen_Form2.Name = "btOpen_Form2";
            this.btOpen_Form2.Size = new System.Drawing.Size(119, 39);
            this.btOpen_Form2.TabIndex = 6;
            this.btOpen_Form2.Text = "Webの表示";
            this.btOpen_Form2.UseVisualStyleBackColor = true;
            this.btOpen_Form2.Click += new System.EventHandler(this.btOpen_Form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 624);
            this.Controls.Add(this.btOpen_Form2);
            this.Controls.Add(this.lbArticleInfo);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32094";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.ListBox lbTitle;
        private System.Windows.Forms.Label lbArticleInfo;
        private System.Windows.Forms.Button btOpen_Form2;
    }
}

