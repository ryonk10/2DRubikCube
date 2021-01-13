namespace RubikCube
{
    partial class RubikCubeForm
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.backToSetupbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetbutton
            // 
            this.resetbutton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetbutton.Location = new System.Drawing.Point(74, 587);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(251, 34);
            this.resetbutton.TabIndex = 1;
            this.resetbutton.Text = "リセット";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // backToSetupbutton
            // 
            this.backToSetupbutton.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backToSetupbutton.Location = new System.Drawing.Point(424, 587);
            this.backToSetupbutton.Name = "backToSetupbutton";
            this.backToSetupbutton.Size = new System.Drawing.Size(251, 34);
            this.backToSetupbutton.TabIndex = 2;
            this.backToSetupbutton.Text = "設定画面に戻る";
            this.backToSetupbutton.UseVisualStyleBackColor = true;
            this.backToSetupbutton.Click += new System.EventHandler(this.backToSetupbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "二次元ルービックキューブ";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labe.Location = new System.Drawing.Point(552, 27);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(132, 24);
            this.labe.TabIndex = 4;
            this.labe.Text = "クリック回数 :";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelcount.Location = new System.Drawing.Point(690, 27);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(0, 24);
            this.labelcount.TabIndex = 5;
            // 
            // RubikCubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToSetupbutton);
            this.Controls.Add(this.resetbutton);
            this.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "RubikCubeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "がんばれーー";
            this.Load += new System.EventHandler(this.RubikCubeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button backToSetupbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label labelcount;
    }
}