using System;

// Token: 0x020000DE RID: 222
internal sealed class Delegate147 : MulticastDelegate
{
	// Token: 0x0600094E RID: 2382
	public extern string Invoke(string string_0, string string_1, string string_2);

	// Token: 0x0600094F RID: 2383 RVA: 0x00005846 File Offset: 0x00003A46
	public static string smethod_0(string string_0, string string_1, string string_2, Delegate147 delegate147_1)
	{
		return delegate147_1(string_0, string_1, string_2);
	}

	// Token: 0x06000950 RID: 2384
	public extern Delegate147(object object_0, IntPtr intptr_0);

	// Token: 0x06000951 RID: 2385 RVA: 0x00005855 File Offset: 0x00003A55
	static Delegate147()
	{
		Class2.smethod_14(typeof(Delegate147).TypeHandle);
	}

	// Token: 0x040001E0 RID: 480
	internal static Delegate147 delegate147_0;
}
