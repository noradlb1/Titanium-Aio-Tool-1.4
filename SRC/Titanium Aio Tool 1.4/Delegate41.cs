using System;

// Token: 0x02000074 RID: 116
internal sealed class Delegate41 : MulticastDelegate
{
	// Token: 0x060007B0 RID: 1968
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007B1 RID: 1969 RVA: 0x00004EAC File Offset: 0x000030AC
	public static void smethod_0(object object_0, string string_0, Delegate41 delegate41_1)
	{
		delegate41_1(object_0, string_0);
	}

	// Token: 0x060007B2 RID: 1970
	public extern Delegate41(object object_0, IntPtr intptr_0);

	// Token: 0x060007B3 RID: 1971 RVA: 0x00004EB9 File Offset: 0x000030B9
	static Delegate41()
	{
		Class2.smethod_14(typeof(Delegate41).TypeHandle);
	}

	// Token: 0x04000176 RID: 374
	internal static Delegate41 delegate41_0;
}
