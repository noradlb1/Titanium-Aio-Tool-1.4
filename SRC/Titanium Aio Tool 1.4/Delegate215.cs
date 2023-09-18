using System;

// Token: 0x02000122 RID: 290
internal sealed class Delegate215 : MulticastDelegate
{
	// Token: 0x06000A59 RID: 2649
	public extern long Invoke(object object_0);

	// Token: 0x06000A5A RID: 2650 RVA: 0x00005E79 File Offset: 0x00004079
	public static long smethod_0(object object_0, Delegate215 delegate215_1)
	{
		return delegate215_1(object_0);
	}

	// Token: 0x06000A5B RID: 2651
	public extern Delegate215(object object_0, IntPtr intptr_0);

	// Token: 0x06000A5C RID: 2652 RVA: 0x00005E84 File Offset: 0x00004084
	static Delegate215()
	{
		Class2.smethod_14(typeof(Delegate215).TypeHandle);
	}

	// Token: 0x04000224 RID: 548
	internal static Delegate215 delegate215_0;
}
