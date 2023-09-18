using System;
using System.Drawing;

// Token: 0x02000067 RID: 103
internal sealed class Delegate28 : MulticastDelegate
{
	// Token: 0x0600077C RID: 1916
	public extern int Invoke(ref Rectangle rectangle_0);

	// Token: 0x0600077D RID: 1917 RVA: 0x00004D67 File Offset: 0x00002F67
	public static int smethod_0(ref Rectangle rectangle_0, Delegate28 delegate28_1)
	{
		return delegate28_1(ref rectangle_0);
	}

	// Token: 0x0600077E RID: 1918
	public extern Delegate28(object object_0, IntPtr intptr_0);

	// Token: 0x0600077F RID: 1919 RVA: 0x00004D72 File Offset: 0x00002F72
	static Delegate28()
	{
		Class2.smethod_14(typeof(Delegate28).TypeHandle);
	}

	// Token: 0x04000169 RID: 361
	internal static Delegate28 delegate28_0;
}
