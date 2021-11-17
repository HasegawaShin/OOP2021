
namespace StopWatch {
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
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btLap = new System.Windows.Forms.Button();
            this.lbLapDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(31, 33);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(253, 56);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTimerDisp.Click += new System.EventHandler(this.lbTimerDisp_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(30, 122);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 60);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReset.Location = new System.Drawing.Point(172, 122);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(112, 60);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStop.Location = new System.Drawing.Point(30, 201);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(112, 60);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btLap
            // 
            this.btLap.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLap.Location = new System.Drawing.Point(172, 201);
            this.btLap.Name = "btLap";
            this.btLap.Size = new System.Drawing.Size(112, 60);
            this.btLap.TabIndex = 5;
            this.btLap.Text = "ラップ→";
            this.btLap.UseVisualStyleBackColor = true;
            this.btLap.Click += new System.EventHandler(this.btLap_Click);
            // 
            // lbLapDisp
            // 
            this.lbLapDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLapDisp.FormattingEnabled = true;
            this.lbLapDisp.ItemHeight = 24;
            this.lbLapDisp.Location = new System.Drawing.Point(311, 32);
            this.lbLapDisp.Name = "lbLapDisp";
            this.lbLapDisp.Size = new System.Drawing.Size(208, 220);
            this.lbLapDisp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 289);
            this.Controls.Add(this.lbLapDisp);
            this.Controls.Add(this.btLap);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btLap;
        private System.Windows.Forms.ListBox lbLapDisp;
    }
}

