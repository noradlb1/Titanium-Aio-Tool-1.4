using System;

// Token: 0x02000084 RID: 132
internal sealed class Delegate57 : MulticastDelegate
{
	// Token: 0x060007EE RID: 2030
	public extern void Invoke(object object_0);

	// Token: 0x060007EF RID: 2031 RVA: 0x0000501C File Offset: 0x0000321C
	public static void smethod_0(object object_0, Delegate57 delegate57_1)
	{
		delegate57_1(object_0);
	}

	// Token: 0x060007F0 RID: 2032
	public extern Delegate57(object object_0, IntPtr intptr_0);

	// Token: 0x060007F1 RID: 2033 RVA: 0x00005027 File Offset: 0x00003227
	static Delegate57()
	{
		Class2.smethod_14(typeof(Delegate57).TypeHandle);
	}

	// Token: 0x04000186 RID: 390
	internal static Delegate57 delegate57_0;
}
