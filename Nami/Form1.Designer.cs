
namespace Nami_YarukiSwitch {
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
            this.lbGage = new System.Windows.Forms.Label();
            this.btSwitch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜実のやる気ゲージ";
            // 
            // lbGage
            // 
            this.lbGage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbGage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbGage.Location = new System.Drawing.Point(74, 87);
            this.lbGage.Name = "lbGage";
            this.lbGage.Size = new System.Drawing.Size(493, 27);
            this.lbGage.TabIndex = 1;
            // 
            // btSwitch
            // 
            this.btSwitch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSwitch.Location = new System.Drawing.Point(78, 210);
            this.btSwitch.Name = "btSwitch";
            this.btSwitch.Size = new System.Drawing.Size(177, 134);
            this.btSwitch.TabIndex = 2;
            this.btSwitch.Text = "やる気スイッチ";
            this.btSwitch.UseVisualStyleBackColor = true;
            this.btSwitch.Click += new System.EventHandler(this.btSwitch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(363, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "リザルト";
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbResult.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbResult.Location = new System.Drawing.Point(363, 205);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(339, 139);
            this.lbResult.TabIndex = 4;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSwitch);
            this.Controls.Add(this.lbGage);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGage;
        private System.Windows.Forms.Button btSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
    }
}

