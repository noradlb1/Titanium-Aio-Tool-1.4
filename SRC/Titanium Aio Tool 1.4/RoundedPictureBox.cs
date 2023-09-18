using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000003 RID: 3
public class RoundedPictureBox : PictureBox
{
	// Token: 0x06000014 RID: 20 RVA: 0x00006718 File Offset: 0x00004918
	protected override void OnPaint(PaintEventArgs pe)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
		graphicsPath.AddArc(rectangle.X, rectangle.Y, 30, 30, 180f, 90f);
		graphicsPath.AddArc(rectangle.X + rectangle.Width - 30, rectangle.Y, 30, 30, 270f, 90f);
		graphicsPath.AddArc(rectangle.X + rectangle.Width - 30, rectangle.Y + rectangle.Height - 30, 30, 30, 0f, 90f);
		graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - 30, 30, 30, 90f, 90f);
		graphicsPath.CloseFigure();
		base.Region = new Region(graphicsPath);
		base.OnPaint(pe);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002263 File Offset: 0x00000463
	internal static int smethod_0(object object_0, Delegate18 delegate18_0)
	{
		return Delegate18.smethod_0(object_0, delegate18_0);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002272 File Offset: 0x00000472
	internal static int smethod_1(object object_0, Delegate19 delegate19_0)
	{
		return Delegate19.smethod_0(object_0, delegate19_0);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000022DD File Offset: 0x000004DD
	internal static void smethod_2(object object_0, int int_0, int int_1, int int_2, int int_3, float float_0, float float_1, Delegate30 delegate30_0)
	{
		Delegate30.smethod_0(object_0, int_0, int_1, int_2, int_3, float_0, float_1, delegate30_0);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000022A8 File Offset: 0x000004A8
	internal static void smethod_3(object object_0, Delegate25 delegate25_0)
	{
		Delegate25.smethod_0(object_0, delegate25_0);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000022B7 File Offset: 0x000004B7
	internal static void smethod_4(object object_0, Region region_0, Delegate26 delegate26_0)
	{
		Delegate26.smethod_0(object_0, region_0, delegate26_0);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002304 File Offset: 0x00000504
	internal static void smethod_5(object object_0, PaintEventArgs paintEventArgs_0, Delegate33 delegate33_0)
	{
		Delegate33.smethod_0(object_0, paintEventArgs_0, delegate33_0);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_6()
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_7()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_8()
	{
	}
}
