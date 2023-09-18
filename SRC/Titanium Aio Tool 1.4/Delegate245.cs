using System;

// Token: 0x02000140 RID: 320
internal sealed class Delegate245 : MulticastDelegate
{
	// Token: 0x06000AD0 RID: 2768
	public extern void Invoke(object object_0, object object_1, int int_0);

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00006132 File Offset: 0x00004332
	public static void smethod_0(object object_0, object object_1, int int_0, Delegate245 delegate245_1)
	{
		delegate245_1(object_0, object_1, int_0);
	}

	// Token: 0x06000AD2 RID: 2770
	public extern Delegate245(object object_0, IntPtr intptr_0);

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00006141 File Offset: 0x00004341
	static Delegate245()
	{
		Class2.smethod_14(typeof(Delegate245).TypeHandle);
	}

	// Token: 0x04000242 RID: 578
	internal static Delegate245 delegate245_0;
}
