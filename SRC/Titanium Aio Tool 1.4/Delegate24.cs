using System;
using System.Drawing;

// Token: 0x02000063 RID: 99
internal sealed class Delegate24 : MulticastDelegate
{
	// Token: 0x0600076C RID: 1900
	public extern float Invoke(ref RectangleF rectangleF_0);

	// Token: 0x0600076D RID: 1901 RVA: 0x00004D07 File Offset: 0x00002F07
	public static float smethod_0(ref RectangleF rectangleF_0, Delegate24 delegate24_1)
	{
		return delegate24_1(ref rectangleF_0);
	}

	// Token: 0x0600076E RID: 1902
	public extern Delegate24(object object_0, IntPtr intptr_0);

	// Token: 0x0600076F RID: 1903 RVA: 0x00004D12 File Offset: 0x00002F12
	static Delegate24()
	{
		Class2.smethod_14(typeof(Delegate24).TypeHandle);
	}

	// Token: 0x04000165 RID: 357
	internal static Delegate24 delegate24_0;
}
