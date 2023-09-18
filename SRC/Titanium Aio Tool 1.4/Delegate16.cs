using System;

// Token: 0x0200005B RID: 91
internal sealed class Delegate16 : MulticastDelegate
{
	// Token: 0x0600074C RID: 1868
	public extern int Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x0600074D RID: 1869 RVA: 0x00004C43 File Offset: 0x00002E43
	public static int smethod_0(ref TimeSpan timeSpan_0, Delegate16 delegate16_1)
	{
		return delegate16_1(ref timeSpan_0);
	}

	// Token: 0x0600074E RID: 1870
	public extern Delegate16(object object_0, IntPtr intptr_0);

	// Token: 0x0600074F RID: 1871 RVA: 0x00004C4E File Offset: 0x00002E4E
	static Delegate16()
	{
		Class2.smethod_14(typeof(Delegate16).TypeHandle);
	}

	// Token: 0x0400015D RID: 349
	internal static Delegate16 delegate16_0;
}
