namespace Titanium_Aio_Tool_1._4
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00006D1C File Offset: 0x00004F1C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006D4C File Offset: 0x00004F4C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Titanium_Aio_Tool_1._4.Form1));
			this.roundedPictureBox1 = new global::RoundedPictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.roundedPictureBox1).BeginInit();
			base.SuspendLayout();
			this.roundedPictureBox1.Image = global::Titanium_Aio_Tool_1._4.Properties.Resources.ezgif_com_resize;
			this.roundedPictureBox1.Location = new global::System.Drawing.Point(-1, -4);
			this.roundedPictureBox1.Name = "roundedPictureBox1";
			this.roundedPictureBox1.Size = new global::System.Drawing.Size(356, 286);
			this.roundedPictureBox1.TabIndex = 0;
			this.roundedPictureBox1.TabStop = false;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(352, 261);
			base.Controls.Add(this.roundedPictureBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.No;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.Resize += new global::System.EventHandler(this.Form1_Resize);
			((global::System.ComponentModel.ISupportInitialize)this.roundedPictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000007 RID: 7
		private global::RoundedPictureBox roundedPictureBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Timer timer1;
	}
}
