using System;

// Token: 0x02000124 RID: 292
internal sealed class Delegate217 : MulticastDelegate
{
	// Token: 0x06000A61 RID: 2657
	public extern void Invoke(object object_0);

	// Token: 0x06000A62 RID: 2658 RVA: 0x00005EA9 File Offset: 0x000040A9
	public static void smethod_0(object object_0, Delegate217 delegate217_1)
	{
		delegate217_1(object_0);
	}

	// Token: 0x06000A63 RID: 2659
	public extern Delegate217(object object_0, IntPtr intptr_0);

	// Token: 0x06000A64 RID: 2660 RVA: 0x00005EB4 File Offset: 0x000040B4
	static Delegate217()
	{
		Class2.smethod_14(typeof(Delegate217).TypeHandle);
	}

	// Token: 0x04000226 RID: 550
	internal static Delegate217 delegate217_0;
}
