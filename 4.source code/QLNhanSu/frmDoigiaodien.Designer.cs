namespace QLNhanSu
{
    partial class frmDoigiaodien
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            galleryItemGroup1.Caption = "Group3";
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Location = new System.Drawing.Point(0, 0);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(743, 574);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(722, 570);
            // 
            // frmDoigiaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 574);
            this.Controls.Add(this.galleryControl1);
            this.Name = "frmDoigiaodien";
            this.Text = "frmDoigiaodien";
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}