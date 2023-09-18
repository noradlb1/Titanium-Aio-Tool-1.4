using System;

// Token: 0x020000C2 RID: 194
internal sealed class Delegate119 : MulticastDelegate
{
	// Token: 0x060008E2 RID: 2274
	public extern string Invoke(string string_0, string string_1);

	// Token: 0x060008E3 RID: 2275 RVA: 0x000055CC File Offset: 0x000037CC
	public static string smethod_0(string string_0, string string_1, Delegate119 delegate119_1)
	{
		return delegate119_1(string_0, string_1);
	}

	// Token: 0x060008E4 RID: 2276
	public extern Delegate119(object object_0, IntPtr intptr_0);

	// Token: 0x060008E5 RID: 2277 RVA: 0x000055D9 File Offset: 0x000037D9
	static Delegate119()
	{
		Class2.smethod_14(typeof(Delegate119).TypeHandle);
	}

	// Token: 0x040001C4 RID: 452
	internal static Delegate119 delegate119_0;
}
