using System;
using System.Reflection;

// Token: 0x02000166 RID: 358
internal sealed class Delegate283 : MulticastDelegate
{
	// Token: 0x06000B68 RID: 2920
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06000B69 RID: 2921 RVA: 0x000064D0 File Offset: 0x000046D0
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate283 delegate283_1)
	{
		return delegate283_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x06000B6A RID: 2922
	public extern Delegate283(object object_0, IntPtr intptr_0);

	// Token: 0x06000B6B RID: 2923 RVA: 0x000064DD File Offset: 0x000046DD
	static Delegate283()
	{
		Class2.smethod_14(typeof(Delegate283).TypeHandle);
	}

	// Token: 0x04000268 RID: 616
	internal static Delegate283 delegate283_0;
}
