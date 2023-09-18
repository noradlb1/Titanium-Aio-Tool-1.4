using System;
using System.Drawing;

// Token: 0x020000F7 RID: 247
internal sealed class Delegate172 : MulticastDelegate
{
	// Token: 0x060009AE RID: 2478
	public extern void Invoke(object object_0, ContentAlignment contentAlignment_0);

	// Token: 0x060009AF RID: 2479 RVA: 0x00005A7D File Offset: 0x00003C7D
	public static void smethod_0(object object_0, ContentAlignment contentAlignment_0, Delegate172 delegate172_1)
	{
		delegate172_1(object_0, contentAlignment_0);
	}

	// Token: 0x060009B0 RID: 2480
	public extern Delegate172(object object_0, IntPtr intptr_0);

	// Token: 0x060009B1 RID: 2481 RVA: 0x00005A8A File Offset: 0x00003C8A
	static Delegate172()
	{
		Class2.smethod_14(typeof(Delegate172).TypeHandle);
	}

	// Token: 0x040001F9 RID: 505
	internal static Delegate172 delegate172_0;
}
