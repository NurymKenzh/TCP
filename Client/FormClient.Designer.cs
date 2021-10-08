
namespace Client
{
    partial class FormClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorkerClient = new System.ComponentModel.BackgroundWorker();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backgroundWorkerClient
            // 
            this.backgroundWorkerClient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerClient_DoWork);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxClient.Location = new System.Drawing.Point(0, 0);
            this.textBoxClient.Multiline = true;
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxClient.Size = new System.Drawing.Size(800, 450);
            this.textBoxClient.TabIndex = 0;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxClient);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerClient;
        private System.Windows.Forms.TextBox textBoxClient;
    }
}

