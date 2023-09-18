using System;
using System.Drawing;

// Token: 0x0200005F RID: 95
internal sealed class Delegate20 : MulticastDelegate
{
	// Token: 0x0600075C RID: 1884
	public extern float Invoke(ref RectangleF rectangleF_0);

	// Token: 0x0600075D RID: 1885 RVA: 0x00004C9F File Offset: 0x00002E9F
	public static float smethod_0(ref RectangleF rectangleF_0, Delegate20 delegate20_1)
	{
		return delegate20_1(ref rectangleF_0);
	}

	// Token: 0x0600075E RID: 1886
	public extern Delegate20(object object_0, IntPtr intptr_0);

	// Token: 0x0600075F RID: 1887 RVA: 0x00004CAA File Offset: 0x00002EAA
	static Delegate20()
	{
		Class2.smethod_14(typeof(Delegate20).TypeHandle);
	}

	// Token: 0x04000161 RID: 353
	internal static Delegate20 delegate20_0;
}
