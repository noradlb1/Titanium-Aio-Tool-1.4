using System;

// Token: 0x02000137 RID: 311
internal sealed class Delegate236 : MulticastDelegate
{
	// Token: 0x06000AAC RID: 2732
	public extern string Invoke(ref ulong ulong_0);

	// Token: 0x06000AAD RID: 2733 RVA: 0x00006063 File Offset: 0x00004263
	public static string smethod_0(ref ulong ulong_0, Delegate236 delegate236_0)
	{
		return delegate236_0(ref ulong_0);
	}

	// Token: 0x06000AAE RID: 2734
	public extern Delegate236(object object_0, IntPtr intptr_0);

	// Token: 0x06000AAF RID: 2735 RVA: 0x0000606E File Offset: 0x0000426E
	static Delegate236()
	{
		Class2.smethod_14(typeof(Delegate236).TypeHandle);
	}

	// Token: 0x04000239 RID: 569
	internal static Delegate236 udrncoxJus;
}
