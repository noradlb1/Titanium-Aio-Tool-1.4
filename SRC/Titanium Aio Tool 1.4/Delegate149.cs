using System;

// Token: 0x020000E0 RID: 224
internal sealed class Delegate149 : MulticastDelegate
{
	// Token: 0x06000956 RID: 2390
	public extern void Invoke(string string_0);

	// Token: 0x06000957 RID: 2391 RVA: 0x00005878 File Offset: 0x00003A78
	public static void smethod_0(string string_0, Delegate149 delegate149_1)
	{
		delegate149_1(string_0);
	}

	// Token: 0x06000958 RID: 2392
	public extern Delegate149(object object_0, IntPtr intptr_0);

	// Token: 0x06000959 RID: 2393 RVA: 0x00005883 File Offset: 0x00003A83
	static Delegate149()
	{
		Class2.smethod_14(typeof(Delegate149).TypeHandle);
	}

	// Token: 0x040001E2 RID: 482
	internal static Delegate149 delegate149_0;
}
