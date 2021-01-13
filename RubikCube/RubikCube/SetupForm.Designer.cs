namespace RubikCube
{
    partial class SetupForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.setupStartbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.setupSizelabel = new System.Windows.Forms.Label();
            this.setupSizetextBox = new System.Windows.Forms.TextBox();
            this.setUpLevellabel = new System.Windows.Forms.Label();
            this.setupLevelcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // setupStartbutton
            // 
            this.setupStartbutton.Location = new System.Drawing.Point(107, 194);
            this.setupStartbutton.Name = "setupStartbutton";
            this.setupStartbutton.Size = new System.Drawing.Size(335, 37);
            this.setupStartbutton.TabIndex = 0;
            this.setupStartbutton.Text = "START";
            this.setupStartbutton.UseVisualStyleBackColor = true;
            this.setupStartbutton.Click += new System.EventHandler(this.setupStartbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "二次元ルービックキューブへようこそ！！\r\n　　\r\n　　　サイズとレベルを指定してください。";
            // 
            // setupSizelabel
            // 
            this.setupSizelabel.AutoSize = true;
            this.setupSizelabel.Location = new System.Drawing.Point(77, 97);
            this.setupSizelabel.Name = "setupSizelabel";
            this.setupSizelabel.Size = new System.Drawing.Size(51, 18);
            this.setupSizelabel.TabIndex = 2;
            this.setupSizelabel.Text = "サイズ";
            // 
            // setupSizetextBox
            // 
            this.setupSizetextBox.Location = new System.Drawing.Point(80, 119);
            this.setupSizetextBox.Name = "setupSizetextBox";
            this.setupSizetextBox.Size = new System.Drawing.Size(100, 25);
            this.setupSizetextBox.TabIndex = 3;
            // 
            // setUpLevellabel
            // 
            this.setUpLevellabel.AutoSize = true;
            this.setUpLevellabel.Location = new System.Drawing.Point(295, 96);
            this.setUpLevellabel.Name = "setUpLevellabel";
            this.setUpLevellabel.Size = new System.Drawing.Size(52, 18);
            this.setUpLevellabel.TabIndex = 5;
            this.setUpLevellabel.Text = "レベル";
            // 
            // setupLevelcomboBox
            // 
            this.setupLevelcomboBox.FormattingEnabled = true;
            this.setupLevelcomboBox.Items.AddRange(new object[] {
            "レベル１",
            "レベル２",
            "レベル３"});
            this.setupLevelcomboBox.Location = new System.Drawing.Point(298, 119);
            this.setupLevelcomboBox.Name = "setupLevelcomboBox";
            this.setupLevelcomboBox.Size = new System.Drawing.Size(121, 26);
            this.setupLevelcomboBox.TabIndex = 6;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 243);
            this.Controls.Add(this.setupLevelcomboBox);
            this.Controls.Add(this.setUpLevellabel);
            this.Controls.Add(this.setupSizetextBox);
            this.Controls.Add(this.setupSizelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setupStartbutton);
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setupStartbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label setupSizelabel;
        private System.Windows.Forms.TextBox setupSizetextBox;
        private System.Windows.Forms.Label setUpLevellabel;
        private System.Windows.Forms.ComboBox setupLevelcomboBox;
    }
}

