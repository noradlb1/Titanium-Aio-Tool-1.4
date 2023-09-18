using System;

// Token: 0x020000DF RID: 223
internal sealed class Delegate148 : MulticastDelegate
{
	// Token: 0x06000952 RID: 2386
	public extern string[] Invoke(string string_0);

	// Token: 0x06000953 RID: 2387 RVA: 0x00005861 File Offset: 0x00003A61
	public static string[] smethod_0(string string_0, Delegate148 delegate148_1)
	{
		return delegate148_1(string_0);
	}

	// Token: 0x06000954 RID: 2388
	public extern Delegate148(object object_0, IntPtr intptr_0);

	// Token: 0x06000955 RID: 2389 RVA: 0x0000586C File Offset: 0x00003A6C
	static Delegate148()
	{
		Class2.smethod_14(typeof(Delegate148).TypeHandle);
	}

	// Token: 0x040001E1 RID: 481
	internal static Delegate148 delegate148_0;
}
