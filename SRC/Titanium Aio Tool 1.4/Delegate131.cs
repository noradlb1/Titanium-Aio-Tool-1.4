using System;

// Token: 0x020000CE RID: 206
internal sealed class Delegate131 : MulticastDelegate
{
	// Token: 0x0600090E RID: 2318
	public extern object Invoke(object object_0);

	// Token: 0x0600090F RID: 2319 RVA: 0x000056C0 File Offset: 0x000038C0
	public static object smethod_0(object object_0, Delegate131 delegate131_1)
	{
		return delegate131_1(object_0);
	}

	// Token: 0x06000910 RID: 2320
	public extern Delegate131(object object_0, IntPtr intptr_0);

	// Token: 0x06000911 RID: 2321 RVA: 0x000056CB File Offset: 0x000038CB
	static Delegate131()
	{
		Class2.smethod_14(typeof(Delegate131).TypeHandle);
	}

	// Token: 0x040001D0 RID: 464
	internal static Delegate131 delegate131_0;
}
