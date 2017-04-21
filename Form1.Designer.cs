namespace Example01
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldatetime = new System.Windows.Forms.Label();
            this.btnExce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Location = new System.Drawing.Point(36, 29);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(35, 12);
            this.lbldatetime.TabIndex = 0;
            this.lbldatetime.Text = "label1";
            // 
            // btnExce
            // 
            this.btnExce.Location = new System.Drawing.Point(112, 137);
            this.btnExce.Name = "btnExce";
            this.btnExce.Size = new System.Drawing.Size(71, 24);
            this.btnExce.TabIndex = 1;
            this.btnExce.Text = "日時取得";
            this.btnExce.UseVisualStyleBackColor = true;
            this.btnExce.Click += new System.EventHandler(this.btnExce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExce);
            this.Controls.Add(this.lbldatetime);
            this.Name = "Form1";
            this.Text = "現在日時の表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Button btnExce;
    }
}

