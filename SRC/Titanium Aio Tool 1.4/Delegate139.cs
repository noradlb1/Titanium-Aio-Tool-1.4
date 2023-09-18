using System;
using System.IO;

// Token: 0x020000D6 RID: 214
internal sealed class Delegate139 : MulticastDelegate
{
	// Token: 0x0600092E RID: 2350
	public extern DirectoryInfo Invoke(object object_0);

	// Token: 0x0600092F RID: 2351 RVA: 0x00005786 File Offset: 0x00003986
	public static DirectoryInfo smethod_0(object object_0, Delegate139 delegate139_1)
	{
		return delegate139_1(object_0);
	}

	// Token: 0x06000930 RID: 2352
	public extern Delegate139(object object_0, IntPtr intptr_0);

	// Token: 0x06000931 RID: 2353 RVA: 0x00005791 File Offset: 0x00003991
	static Delegate139()
	{
		Class2.smethod_14(typeof(Delegate139).TypeHandle);
	}

	// Token: 0x040001D8 RID: 472
	internal static Delegate139 delegate139_0;
}
