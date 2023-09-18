using System;

// Token: 0x020000DD RID: 221
internal sealed class Delegate146 : MulticastDelegate
{
	// Token: 0x0600094A RID: 2378
	public extern string Invoke();

	// Token: 0x0600094B RID: 2379 RVA: 0x00005831 File Offset: 0x00003A31
	public static string smethod_0(Delegate146 delegate146_1)
	{
		return delegate146_1();
	}

	// Token: 0x0600094C RID: 2380
	public extern Delegate146(object object_0, IntPtr intptr_0);

	// Token: 0x0600094D RID: 2381 RVA: 0x0000583A File Offset: 0x00003A3A
	static Delegate146()
	{
		Class2.smethod_14(typeof(Delegate146).TypeHandle);
	}

	// Token: 0x040001DF RID: 479
	internal static Delegate146 delegate146_0;
}
