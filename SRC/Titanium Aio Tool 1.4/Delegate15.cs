using System;

// Token: 0x0200005A RID: 90
internal sealed class Delegate15 : MulticastDelegate
{
	// Token: 0x06000748 RID: 1864
	public extern TimeSpan Invoke(DateTime dateTime_0, DateTime dateTime_1);

	// Token: 0x06000749 RID: 1865 RVA: 0x00004C2A File Offset: 0x00002E2A
	public static TimeSpan smethod_0(DateTime dateTime_0, DateTime dateTime_1, Delegate15 delegate15_1)
	{
		return delegate15_1(dateTime_0, dateTime_1);
	}

	// Token: 0x0600074A RID: 1866
	public extern Delegate15(object object_0, IntPtr intptr_0);

	// Token: 0x0600074B RID: 1867 RVA: 0x00004C37 File Offset: 0x00002E37
	static Delegate15()
	{
		Class2.smethod_14(typeof(Delegate15).TypeHandle);
	}

	// Token: 0x0400015C RID: 348
	internal static Delegate15 delegate15_0;
}
