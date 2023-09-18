using System;

// Token: 0x020000CC RID: 204
internal sealed class Delegate129 : MulticastDelegate
{
	// Token: 0x06000906 RID: 2310
	public extern bool Invoke(string string_0);

	// Token: 0x06000907 RID: 2311 RVA: 0x00005692 File Offset: 0x00003892
	public static bool smethod_0(string string_0, Delegate129 delegate129_1)
	{
		return delegate129_1(string_0);
	}

	// Token: 0x06000908 RID: 2312
	public extern Delegate129(object object_0, IntPtr intptr_0);

	// Token: 0x06000909 RID: 2313 RVA: 0x0000569D File Offset: 0x0000389D
	static Delegate129()
	{
		Class2.smethod_14(typeof(Delegate129).TypeHandle);
	}

	// Token: 0x040001CE RID: 462
	internal static Delegate129 delegate129_0;
}
