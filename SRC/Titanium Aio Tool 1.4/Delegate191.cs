using System;
using System.Reflection;

// Token: 0x0200010A RID: 266
internal sealed class Delegate191 : MulticastDelegate
{
	// Token: 0x060009F9 RID: 2553
	public extern MethodBase Invoke(object object_0, int int_0);

	// Token: 0x060009FA RID: 2554 RVA: 0x00005C3F File Offset: 0x00003E3F
	public static MethodBase smethod_0(object object_0, int int_0, Delegate191 delegate191_0)
	{
		return delegate191_0(object_0, int_0);
	}

	// Token: 0x060009FB RID: 2555
	public extern Delegate191(object object_0, IntPtr intptr_0);

	// Token: 0x060009FC RID: 2556 RVA: 0x00005C4C File Offset: 0x00003E4C
	static Delegate191()
	{
		Class2.smethod_14(typeof(Delegate191).TypeHandle);
	}

	// Token: 0x0400020C RID: 524
	internal static Delegate191 awjWrasDlA;
}
