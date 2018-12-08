namespace Speed_Reading
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.Btn_Back = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Next = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Play = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Back.ImageOptions.Image")));
            this.Btn_Back.Location = new System.Drawing.Point(556, 596);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(47, 38);
            this.Btn_Back.TabIndex = 76;
            // 
            // Btn_Next
            // 
            this.Btn_Next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.ImageOptions.Image")));
            this.Btn_Next.Location = new System.Drawing.Point(691, 596);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(47, 38);
            this.Btn_Next.TabIndex = 75;
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.ImageOptions.Image")));
            this.Btn_Pause.Location = new System.Drawing.Point(646, 596);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(47, 38);
            this.Btn_Pause.TabIndex = 74;
            // 
            // Btn_Play
            // 
            this.Btn_Play.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Play.ImageOptions.Image")));
            this.Btn_Play.Location = new System.Drawing.Point(601, 596);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(47, 38);
            this.Btn_Play.TabIndex = 73;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Play);
            this.Name = "Form19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form19";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_Back;
        private DevExpress.XtraEditors.SimpleButton Btn_Next;
        private DevExpress.XtraEditors.SimpleButton Btn_Pause;
        private DevExpress.XtraEditors.SimpleButton Btn_Play;
    }
}