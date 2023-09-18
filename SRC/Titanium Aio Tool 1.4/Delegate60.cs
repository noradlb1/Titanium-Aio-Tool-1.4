using System;

// Token: 0x02000087 RID: 135
internal sealed class Delegate60 : MulticastDelegate
{
	// Token: 0x060007FA RID: 2042
	public extern void Invoke(object object_0);

	// Token: 0x060007FB RID: 2043 RVA: 0x00005061 File Offset: 0x00003261
	public static void smethod_0(object object_0, Delegate60 delegate60_1)
	{
		delegate60_1(object_0);
	}

	// Token: 0x060007FC RID: 2044
	public extern Delegate60(object object_0, IntPtr intptr_0);

	// Token: 0x060007FD RID: 2045 RVA: 0x0000506C File Offset: 0x0000326C
	static Delegate60()
	{
		Class2.smethod_14(typeof(Delegate60).TypeHandle);
	}

	// Token: 0x04000189 RID: 393
	internal static Delegate60 delegate60_0;
}
