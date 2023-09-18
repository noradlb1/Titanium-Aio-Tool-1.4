using System;

// Token: 0x02000151 RID: 337
internal sealed class Delegate262 : MulticastDelegate
{
	// Token: 0x06000B14 RID: 2836
	public extern RuntimeMethodHandle Invoke(object object_0);

	// Token: 0x06000B15 RID: 2837 RVA: 0x000062CF File Offset: 0x000044CF
	public static RuntimeMethodHandle smethod_0(object object_0, Delegate262 delegate262_1)
	{
		return delegate262_1(object_0);
	}

	// Token: 0x06000B16 RID: 2838
	public extern Delegate262(object object_0, IntPtr intptr_0);

	// Token: 0x06000B17 RID: 2839 RVA: 0x000062DA File Offset: 0x000044DA
	static Delegate262()
	{
		Class2.smethod_14(typeof(Delegate262).TypeHandle);
	}

	// Token: 0x04000253 RID: 595
	internal static Delegate262 delegate262_0;
}
