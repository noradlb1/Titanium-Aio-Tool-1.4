using System;
using System.Drawing;

// Token: 0x02000099 RID: 153
internal sealed class Delegate78 : MulticastDelegate
{
	// Token: 0x06000842 RID: 2114
	public extern void Invoke(object object_0, Image image_0);

	// Token: 0x06000843 RID: 2115 RVA: 0x0000520D File Offset: 0x0000340D
	public static void smethod_0(object object_0, Image image_0, Delegate78 delegate78_1)
	{
		delegate78_1(object_0, image_0);
	}

	// Token: 0x06000844 RID: 2116
	public extern Delegate78(object object_0, IntPtr intptr_0);

	// Token: 0x06000845 RID: 2117 RVA: 0x0000521A File Offset: 0x0000341A
	static Delegate78()
	{
		Class2.smethod_14(typeof(Delegate78).TypeHandle);
	}

	// Token: 0x0400019B RID: 411
	internal static Delegate78 delegate78_0;
}
