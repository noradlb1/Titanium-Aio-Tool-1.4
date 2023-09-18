using System;

// Token: 0x02000083 RID: 131
internal sealed class Delegate56 : MulticastDelegate
{
	// Token: 0x060007EA RID: 2026
	public extern void Invoke(object object_0);

	// Token: 0x060007EB RID: 2027 RVA: 0x00005005 File Offset: 0x00003205
	public static void smethod_0(object object_0, Delegate56 delegate56_1)
	{
		delegate56_1(object_0);
	}

	// Token: 0x060007EC RID: 2028
	public extern Delegate56(object object_0, IntPtr intptr_0);

	// Token: 0x060007ED RID: 2029 RVA: 0x00005010 File Offset: 0x00003210
	static Delegate56()
	{
		Class2.smethod_14(typeof(Delegate56).TypeHandle);
	}

	// Token: 0x04000185 RID: 389
	internal static Delegate56 delegate56_0;
}
