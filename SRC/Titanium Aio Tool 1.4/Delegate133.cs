using System;

// Token: 0x020000D0 RID: 208
internal sealed class Delegate133 : MulticastDelegate
{
	// Token: 0x06000916 RID: 2326
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06000917 RID: 2327 RVA: 0x000056EE File Offset: 0x000038EE
	public static bool smethod_0(string string_0, string string_1, Delegate133 delegate133_1)
	{
		return delegate133_1(string_0, string_1);
	}

	// Token: 0x06000918 RID: 2328
	public extern Delegate133(object object_0, IntPtr intptr_0);

	// Token: 0x06000919 RID: 2329 RVA: 0x000056FB File Offset: 0x000038FB
	static Delegate133()
	{
		Class2.smethod_14(typeof(Delegate133).TypeHandle);
	}

	// Token: 0x040001D2 RID: 466
	internal static Delegate133 delegate133_0;
}
