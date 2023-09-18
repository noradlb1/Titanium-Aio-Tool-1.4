using System;
using System.Drawing;

// Token: 0x0200006B RID: 107
internal sealed class Delegate32 : MulticastDelegate
{
	// Token: 0x0600078C RID: 1932
	public extern int Invoke(ref Rectangle rectangle_0);

	// Token: 0x0600078D RID: 1933 RVA: 0x00004DCF File Offset: 0x00002FCF
	public static int smethod_0(ref Rectangle rectangle_0, Delegate32 delegate32_1)
	{
		return delegate32_1(ref rectangle_0);
	}

	// Token: 0x0600078E RID: 1934
	public extern Delegate32(object object_0, IntPtr intptr_0);

	// Token: 0x0600078F RID: 1935 RVA: 0x00004DDA File Offset: 0x00002FDA
	static Delegate32()
	{
		Class2.smethod_14(typeof(Delegate32).TypeHandle);
	}

	// Token: 0x0400016D RID: 365
	internal static Delegate32 delegate32_0;
}
