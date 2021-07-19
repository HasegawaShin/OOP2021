
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.btOpen_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpen_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(58, 99);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(682, 327);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(58, 34);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(88, 39);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "(1)開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(403, 54);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(126, 19);
            this.tbKeyWord.TabIndex = 2;
            // 
            // btOpen_2
            // 
            this.btOpen_2.Location = new System.Drawing.Point(152, 35);
            this.btOpen_2.Name = "btOpen_2";
            this.btOpen_2.Size = new System.Drawing.Size(88, 38);
            this.btOpen_2.TabIndex = 3;
            this.btOpen_2.Text = "(2)開く...";
            this.btOpen_2.UseVisualStyleBackColor = true;
            this.btOpen_2.Click += new System.EventHandler(this.btOpen_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "キーワード";
            // 
            // btOpen_3
            // 
            this.btOpen_3.Location = new System.Drawing.Point(246, 35);
            this.btOpen_3.Name = "btOpen_3";
            this.btOpen_3.Size = new System.Drawing.Size(88, 38);
            this.btOpen_3.TabIndex = 3;
            this.btOpen_3.Text = "(3)開く...";
            this.btOpen_3.UseVisualStyleBackColor = true;
            this.btOpen_3.Click += new System.EventHandler(this.btOpen_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpen_3);
            this.Controls.Add(this.btOpen_2);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Button btOpen_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpen_3;
    }
}

