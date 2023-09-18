using System;
using System.Reflection;

// Token: 0x02000145 RID: 325
internal sealed class Delegate250 : MulticastDelegate
{
	// Token: 0x06000AE4 RID: 2788
	public extern bool Invoke(MethodBase methodBase_0, MethodBase methodBase_1);

	// Token: 0x06000AE5 RID: 2789 RVA: 0x000061AF File Offset: 0x000043AF
	public static bool smethod_0(MethodBase methodBase_0, MethodBase methodBase_1, Delegate250 delegate250_1)
	{
		return delegate250_1(methodBase_0, methodBase_1);
	}

	// Token: 0x06000AE6 RID: 2790
	public extern Delegate250(object object_0, IntPtr intptr_0);

	// Token: 0x06000AE7 RID: 2791 RVA: 0x000061BC File Offset: 0x000043BC
	static Delegate250()
	{
		Class2.smethod_14(typeof(Delegate250).TypeHandle);
	}

	// Token: 0x04000247 RID: 583
	internal static Delegate250 delegate250_0;
}
