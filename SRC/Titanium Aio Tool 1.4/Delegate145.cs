using System;

// Token: 0x020000DC RID: 220
internal sealed class Delegate145 : MulticastDelegate
{
	// Token: 0x06000946 RID: 2374
	public extern string Invoke(string string_0);

	// Token: 0x06000947 RID: 2375 RVA: 0x0000581A File Offset: 0x00003A1A
	public static string smethod_0(string string_0, Delegate145 delegate145_1)
	{
		return delegate145_1(string_0);
	}

	// Token: 0x06000948 RID: 2376
	public extern Delegate145(object object_0, IntPtr intptr_0);

	// Token: 0x06000949 RID: 2377 RVA: 0x00005825 File Offset: 0x00003A25
	static Delegate145()
	{
		Class2.smethod_14(typeof(Delegate145).TypeHandle);
	}

	// Token: 0x040001DE RID: 478
	internal static Delegate145 delegate145_0;
}
