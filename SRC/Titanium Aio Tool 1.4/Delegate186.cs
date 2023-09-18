using System;

// Token: 0x02000105 RID: 261
internal sealed class Delegate186 : MulticastDelegate
{
	// Token: 0x060009E5 RID: 2533
	public extern void Invoke(object object_0, string string_0, object object_1);

	// Token: 0x060009E6 RID: 2534 RVA: 0x00005BC6 File Offset: 0x00003DC6
	public static void smethod_0(object object_0, string string_0, object object_1, Delegate186 delegate186_1)
	{
		delegate186_1(object_0, string_0, object_1);
	}

	// Token: 0x060009E7 RID: 2535
	public extern Delegate186(object object_0, IntPtr intptr_0);

	// Token: 0x060009E8 RID: 2536 RVA: 0x00005BD5 File Offset: 0x00003DD5
	static Delegate186()
	{
		Class2.smethod_14(typeof(Delegate186).TypeHandle);
	}

	// Token: 0x04000207 RID: 519
	internal static Delegate186 delegate186_0;
}
