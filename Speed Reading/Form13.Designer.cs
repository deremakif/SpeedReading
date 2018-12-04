namespace Speed_Reading
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Back = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Next = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Play = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Back.ImageOptions.Image")));
            this.Btn_Back.Location = new System.Drawing.Point(263, 369);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(47, 38);
            this.Btn_Back.TabIndex = 68;
            // 
            // Btn_Next
            // 
            this.Btn_Next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Next.ImageOptions.Image")));
            this.Btn_Next.Location = new System.Drawing.Point(398, 369);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(47, 38);
            this.Btn_Next.TabIndex = 67;
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.ImageOptions.Image")));
            this.Btn_Pause.Location = new System.Drawing.Point(353, 369);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(47, 38);
            this.Btn_Pause.TabIndex = 66;
            // 
            // Btn_Play
            // 
            this.Btn_Play.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Play.ImageOptions.Image")));
            this.Btn_Play.Location = new System.Drawing.Point(308, 369);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(47, 38);
            this.Btn_Play.TabIndex = 65;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Resize += new System.EventHandler(this.Form13_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.SimpleButton Btn_Back;
        private DevExpress.XtraEditors.SimpleButton Btn_Next;
        private DevExpress.XtraEditors.SimpleButton Btn_Pause;
        private DevExpress.XtraEditors.SimpleButton Btn_Play;
    }
}