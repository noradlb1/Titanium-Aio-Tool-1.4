using System;

// Token: 0x02000085 RID: 133
internal sealed class Delegate58 : MulticastDelegate
{
	// Token: 0x060007F2 RID: 2034
	public extern void Invoke(object object_0);

	// Token: 0x060007F3 RID: 2035 RVA: 0x00005033 File Offset: 0x00003233
	public static void smethod_0(object object_0, Delegate58 delegate58_1)
	{
		delegate58_1(object_0);
	}

	// Token: 0x060007F4 RID: 2036
	public extern Delegate58(object object_0, IntPtr intptr_0);

	// Token: 0x060007F5 RID: 2037 RVA: 0x0000503E File Offset: 0x0000323E
	static Delegate58()
	{
		Class2.smethod_14(typeof(Delegate58).TypeHandle);
	}

	// Token: 0x04000187 RID: 391
	internal static Delegate58 delegate58_0;
}
