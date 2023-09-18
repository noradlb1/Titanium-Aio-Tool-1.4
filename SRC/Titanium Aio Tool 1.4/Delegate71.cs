using System;
using System.Drawing;

// Token: 0x02000092 RID: 146
internal sealed class Delegate71 : MulticastDelegate
{
	// Token: 0x06000826 RID: 2086
	public extern int Invoke(ref Size size_0);

	// Token: 0x06000827 RID: 2087 RVA: 0x00005168 File Offset: 0x00003368
	public static int smethod_0(ref Size size_0, Delegate71 delegate71_0)
	{
		return delegate71_0(ref size_0);
	}

	// Token: 0x06000828 RID: 2088
	public extern Delegate71(object object_0, IntPtr intptr_0);

	// Token: 0x06000829 RID: 2089 RVA: 0x00005173 File Offset: 0x00003373
	static Delegate71()
	{
		Class2.smethod_14(typeof(Delegate71).TypeHandle);
	}

	// Token: 0x04000194 RID: 404
	internal static Delegate71 lbsdbhgkbi;
}
