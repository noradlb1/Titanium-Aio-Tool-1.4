using System;

// Token: 0x020000D4 RID: 212
internal sealed class Delegate137 : MulticastDelegate
{
	// Token: 0x06000926 RID: 2342
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06000927 RID: 2343 RVA: 0x00005752 File Offset: 0x00003952
	public static void smethod_0(object object_0, string string_0, Delegate137 delegate137_1)
	{
		delegate137_1(object_0, string_0);
	}

	// Token: 0x06000928 RID: 2344
	public extern Delegate137(object object_0, IntPtr intptr_0);

	// Token: 0x06000929 RID: 2345 RVA: 0x0000575F File Offset: 0x0000395F
	static Delegate137()
	{
		Class2.smethod_14(typeof(Delegate137).TypeHandle);
	}

	// Token: 0x040001D6 RID: 470
	internal static Delegate137 delegate137_0;
}
