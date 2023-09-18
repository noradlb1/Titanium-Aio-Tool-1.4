using System;
using System.Drawing;

// Token: 0x0200006A RID: 106
internal sealed class Delegate31 : MulticastDelegate
{
	// Token: 0x06000788 RID: 1928
	public extern int Invoke(ref Rectangle rectangle_0);

	// Token: 0x06000789 RID: 1929 RVA: 0x00004DB8 File Offset: 0x00002FB8
	public static int smethod_0(ref Rectangle rectangle_0, Delegate31 delegate31_1)
	{
		return delegate31_1(ref rectangle_0);
	}

	// Token: 0x0600078A RID: 1930
	public extern Delegate31(object object_0, IntPtr intptr_0);

	// Token: 0x0600078B RID: 1931 RVA: 0x00004DC3 File Offset: 0x00002FC3
	static Delegate31()
	{
		Class2.smethod_14(typeof(Delegate31).TypeHandle);
	}

	// Token: 0x0400016C RID: 364
	internal static Delegate31 delegate31_0;
}
