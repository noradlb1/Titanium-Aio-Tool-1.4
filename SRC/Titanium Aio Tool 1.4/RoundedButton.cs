using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public class RoundedButton : Button
{
	// Token: 0x0600000A RID: 10 RVA: 0x000065DC File Offset: 0x000047DC
	protected override void OnPaint(PaintEventArgs e)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		RectangleF rectangleF = new RectangleF(0f, 0f, (float)(base.Width - 1), (float)(base.Height - 1));
		int num = this.cornerRadius * 2;
		graphicsPath.AddArc(rectangleF.X, rectangleF.Y, (float)num, (float)num, 180f, 90f);
		graphicsPath.AddArc(rectangleF.X + rectangleF.Width - (float)num, rectangleF.Y, (float)num, (float)num, 270f, 90f);
		graphicsPath.AddArc(rectangleF.X + rectangleF.Width - (float)num, rectangleF.Y + rectangleF.Height - (float)num, (float)num, (float)num, 0f, 90f);
		graphicsPath.AddArc(rectangleF.X, rectangleF.Y + rectangleF.Height - (float)num, (float)num, (float)num, 90f, 90f);
		graphicsPath.CloseFigure();
		base.Region = new Region(graphicsPath);
		base.OnPaint(e);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002263 File Offset: 0x00000463
	internal static int smethod_0(object object_0, Delegate18 delegate18_0)
	{
		return Delegate18.smethod_0(object_0, delegate18_0);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002272 File Offset: 0x00000472
	internal static int smethod_1(object object_0, Delegate19 delegate19_0)
	{
		return Delegate19.smethod_0(object_0, delegate19_0);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002281 File Offset: 0x00000481
	internal static void smethod_2(object object_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, Delegate22 delegate22_0)
	{
		Delegate22.smethod_0(object_0, float_0, float_1, float_2, float_3, float_4, float_5, delegate22_0);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000022A8 File Offset: 0x000004A8
	internal static void smethod_3(object object_0, Delegate25 delegate25_0)
	{
		Delegate25.smethod_0(object_0, delegate25_0);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000022B7 File Offset: 0x000004B7
	internal static void smethod_4(object object_0, Region region_0, Delegate26 delegate26_0)
	{
		Delegate26.smethod_0(object_0, region_0, delegate26_0);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000022CA File Offset: 0x000004CA
	internal static void smethod_5(object object_0, PaintEventArgs paintEventArgs_0, Delegate27 delegate27_0)
	{
		Delegate27.smethod_0(object_0, paintEventArgs_0, delegate27_0);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_6()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_7()
	{
	}

	// Token: 0x04000002 RID: 2
	private int cornerRadius = 20;
}
