using System;
using System.Drawing;

// Token: 0x020000E6 RID: 230
internal sealed class Delegate155 : MulticastDelegate
{
	// Token: 0x0600096C RID: 2412
	public extern void Invoke(object object_0, Font font_0);

	// Token: 0x0600096D RID: 2413 RVA: 0x000058F0 File Offset: 0x00003AF0
	public static void smethod_0(object object_0, Font font_0, Delegate155 delegate155_1)
	{
		delegate155_1(object_0, font_0);
	}

	// Token: 0x0600096E RID: 2414
	public extern Delegate155(object object_0, IntPtr intptr_0);

	// Token: 0x0600096F RID: 2415 RVA: 0x000058FD File Offset: 0x00003AFD
	static Delegate155()
	{
		Class2.smethod_14(typeof(Delegate155).TypeHandle);
	}

	// Token: 0x040001E8 RID: 488
	internal static Delegate155 delegate155_0;
}
