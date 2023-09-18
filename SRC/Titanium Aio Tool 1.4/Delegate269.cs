using System;
using System.Reflection;

// Token: 0x02000158 RID: 344
internal sealed class Delegate269 : MulticastDelegate
{
	// Token: 0x06000B30 RID: 2864
	public extern MethodInfo[] Invoke(object object_0, BindingFlags bindingFlags_0);

	// Token: 0x06000B31 RID: 2865 RVA: 0x00006372 File Offset: 0x00004572
	public static MethodInfo[] smethod_0(object object_0, BindingFlags bindingFlags_0, Delegate269 delegate269_1)
	{
		return delegate269_1(object_0, bindingFlags_0);
	}

	// Token: 0x06000B32 RID: 2866
	public extern Delegate269(object object_0, IntPtr intptr_0);

	// Token: 0x06000B33 RID: 2867 RVA: 0x0000637F File Offset: 0x0000457F
	static Delegate269()
	{
		Class2.smethod_14(typeof(Delegate269).TypeHandle);
	}

	// Token: 0x0400025A RID: 602
	internal static Delegate269 delegate269_0;
}
