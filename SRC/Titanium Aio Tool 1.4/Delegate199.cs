using System;
using System.Reflection;

// Token: 0x02000112 RID: 274
internal sealed class Delegate199 : MulticastDelegate
{
	// Token: 0x06000A19 RID: 2585
	public extern ParameterInfo[] Invoke(object object_0);

	// Token: 0x06000A1A RID: 2586 RVA: 0x00005D03 File Offset: 0x00003F03
	public static ParameterInfo[] smethod_0(object object_0, Delegate199 delegate199_1)
	{
		return delegate199_1(object_0);
	}

	// Token: 0x06000A1B RID: 2587
	public extern Delegate199(object object_0, IntPtr intptr_0);

	// Token: 0x06000A1C RID: 2588 RVA: 0x00005D0E File Offset: 0x00003F0E
	static Delegate199()
	{
		Class2.smethod_14(typeof(Delegate199).TypeHandle);
	}

	// Token: 0x04000214 RID: 532
	internal static Delegate199 delegate199_0;
}
