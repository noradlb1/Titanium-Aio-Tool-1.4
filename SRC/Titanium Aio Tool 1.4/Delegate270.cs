using System;
using System.Reflection;

// Token: 0x02000159 RID: 345
internal sealed class Delegate270 : MulticastDelegate
{
	// Token: 0x06000B34 RID: 2868
	public extern MethodInfo Invoke(object object_0);

	// Token: 0x06000B35 RID: 2869 RVA: 0x0000638B File Offset: 0x0000458B
	public static MethodInfo smethod_0(object object_0, Delegate270 delegate270_1)
	{
		return delegate270_1(object_0);
	}

	// Token: 0x06000B36 RID: 2870
	public extern Delegate270(object object_0, IntPtr intptr_0);

	// Token: 0x06000B37 RID: 2871 RVA: 0x00006396 File Offset: 0x00004596
	static Delegate270()
	{
		Class2.smethod_14(typeof(Delegate270).TypeHandle);
	}

	// Token: 0x0400025B RID: 603
	internal static Delegate270 delegate270_0;
}
