using System;
using System.Reflection;

// Token: 0x0200015F RID: 351
internal sealed class Delegate276 : MulticastDelegate
{
	// Token: 0x06000B4C RID: 2892
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06000B4D RID: 2893 RVA: 0x0000641D File Offset: 0x0000461D
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate276 delegate276_1)
	{
		return delegate276_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x06000B4E RID: 2894
	public extern Delegate276(object object_0, IntPtr intptr_0);

	// Token: 0x06000B4F RID: 2895 RVA: 0x0000642A File Offset: 0x0000462A
	static Delegate276()
	{
		Class2.smethod_14(typeof(Delegate276).TypeHandle);
	}

	// Token: 0x04000261 RID: 609
	internal static Delegate276 delegate276_0;
}
