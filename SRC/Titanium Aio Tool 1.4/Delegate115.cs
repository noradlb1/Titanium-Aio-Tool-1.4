using System;

// Token: 0x020000BE RID: 190
internal sealed class Delegate115 : MulticastDelegate
{
	// Token: 0x060008D2 RID: 2258
	public extern void Invoke(object object_0);

	// Token: 0x060008D3 RID: 2259 RVA: 0x0000556E File Offset: 0x0000376E
	public static void smethod_0(object object_0, Delegate115 delegate115_1)
	{
		delegate115_1(object_0);
	}

	// Token: 0x060008D4 RID: 2260
	public extern Delegate115(object object_0, IntPtr intptr_0);

	// Token: 0x060008D5 RID: 2261 RVA: 0x00005579 File Offset: 0x00003779
	static Delegate115()
	{
		Class2.smethod_14(typeof(Delegate115).TypeHandle);
	}

	// Token: 0x040001C0 RID: 448
	internal static Delegate115 delegate115_0;
}
