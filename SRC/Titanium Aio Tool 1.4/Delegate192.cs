using System;
using System.Reflection;

// Token: 0x0200010B RID: 267
internal sealed class Delegate192 : MulticastDelegate
{
	// Token: 0x060009FD RID: 2557
	public extern Delegate Invoke(Type type_0, MethodInfo methodInfo_0);

	// Token: 0x060009FE RID: 2558 RVA: 0x00005C58 File Offset: 0x00003E58
	public static Delegate smethod_0(Type type_0, MethodInfo methodInfo_0, Delegate192 delegate192_1)
	{
		return delegate192_1(type_0, methodInfo_0);
	}

	// Token: 0x060009FF RID: 2559
	public extern Delegate192(object object_0, IntPtr intptr_0);

	// Token: 0x06000A00 RID: 2560 RVA: 0x00005C65 File Offset: 0x00003E65
	static Delegate192()
	{
		Class2.smethod_14(typeof(Delegate192).TypeHandle);
	}

	// Token: 0x0400020D RID: 525
	internal static Delegate192 delegate192_0;
}
