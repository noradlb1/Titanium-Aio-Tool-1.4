using System;
using System.Reflection;

// Token: 0x0200015A RID: 346
internal sealed class Delegate271 : MulticastDelegate
{
	// Token: 0x06000B38 RID: 2872
	public extern bool Invoke(MethodBase methodBase_0, MethodBase methodBase_1);

	// Token: 0x06000B39 RID: 2873 RVA: 0x000063A2 File Offset: 0x000045A2
	public static bool smethod_0(MethodBase methodBase_0, MethodBase methodBase_1, Delegate271 delegate271_1)
	{
		return delegate271_1(methodBase_0, methodBase_1);
	}

	// Token: 0x06000B3A RID: 2874
	public extern Delegate271(object object_0, IntPtr intptr_0);

	// Token: 0x06000B3B RID: 2875 RVA: 0x000063AF File Offset: 0x000045AF
	static Delegate271()
	{
		Class2.smethod_14(typeof(Delegate271).TypeHandle);
	}

	// Token: 0x0400025C RID: 604
	internal static Delegate271 delegate271_0;
}
