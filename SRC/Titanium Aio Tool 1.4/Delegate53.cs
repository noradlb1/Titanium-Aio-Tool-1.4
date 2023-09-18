using System;
using System.Drawing;

// Token: 0x02000080 RID: 128
internal sealed class Delegate53 : MulticastDelegate
{
	// Token: 0x060007DE RID: 2014
	public extern Rectangle Invoke(object object_0);

	// Token: 0x060007DF RID: 2015 RVA: 0x00004FBC File Offset: 0x000031BC
	public static Rectangle smethod_0(object object_0, Delegate53 delegate53_1)
	{
		return delegate53_1(object_0);
	}

	// Token: 0x060007E0 RID: 2016
	public extern Delegate53(object object_0, IntPtr intptr_0);

	// Token: 0x060007E1 RID: 2017 RVA: 0x00004FC7 File Offset: 0x000031C7
	static Delegate53()
	{
		Class2.smethod_14(typeof(Delegate53).TypeHandle);
	}

	// Token: 0x04000182 RID: 386
	internal static Delegate53 delegate53_0;
}
