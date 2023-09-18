using System;

// Token: 0x020000CB RID: 203
internal sealed class Delegate128 : MulticastDelegate
{
	// Token: 0x06000902 RID: 2306
	public extern string Invoke(string string_0, string string_1, string string_2);

	// Token: 0x06000903 RID: 2307 RVA: 0x00005677 File Offset: 0x00003877
	public static string smethod_0(string string_0, string string_1, string string_2, Delegate128 delegate128_1)
	{
		return delegate128_1(string_0, string_1, string_2);
	}

	// Token: 0x06000904 RID: 2308
	public extern Delegate128(object object_0, IntPtr intptr_0);

	// Token: 0x06000905 RID: 2309 RVA: 0x00005686 File Offset: 0x00003886
	static Delegate128()
	{
		Class2.smethod_14(typeof(Delegate128).TypeHandle);
	}

	// Token: 0x040001CD RID: 461
	internal static Delegate128 delegate128_0;
}
