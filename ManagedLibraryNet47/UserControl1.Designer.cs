namespace ManagedLibrary
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowWinForms = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowWinForms
            // 
            this.btnShowWinForms.Location = new System.Drawing.Point(3, 3);
            this.btnShowWinForms.Name = "btnShowWinForms";
            this.btnShowWinForms.Size = new System.Drawing.Size(285, 23);
            this.btnShowWinForms.TabIndex = 0;
            this.btnShowWinForms.Text = "btn on User Control - clikc me to see WinUI";
            this.btnShowWinForms.UseVisualStyleBackColor = true;
            this.btnShowWinForms.Click += new System.EventHandler(this.btnShowWinForms_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnShowWinForms);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(331, 229);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(624, 374);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowWinForms;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
