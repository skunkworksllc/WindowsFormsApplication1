namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.buttongenerate = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttongenerate
            // 
            this.buttongenerate.Location = new System.Drawing.Point(13, 39);
            this.buttongenerate.Name = "buttongenerate";
            this.buttongenerate.Size = new System.Drawing.Size(166, 23);
            this.buttongenerate.TabIndex = 0;
            this.buttongenerate.Text = "Generate";
            this.buttongenerate.UseVisualStyleBackColor = true;
            this.buttongenerate.Click += new System.EventHandler(this.buttongenerate_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(13, 13);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(166, 20);
            this.textbox.TabIndex = 1;
            this.textbox.Text = "Enter Text Here";
            this.textbox.Enter += new System.EventHandler(this.textbox_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(80, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Idle";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(55, 117);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Close";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 152);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.buttongenerate);
            this.Name = "frmMain";
            this.Text = "Demo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttongenerate;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button buttonExit;
    }
}

