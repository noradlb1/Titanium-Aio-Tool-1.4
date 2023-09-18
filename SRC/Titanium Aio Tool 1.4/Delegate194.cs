using System;
using System.Reflection;

// Token: 0x0200010D RID: 269
internal sealed class Delegate194 : MulticastDelegate
{
	// Token: 0x06000A05 RID: 2565
	public extern Module Invoke(object object_0);

	// Token: 0x06000A06 RID: 2566 RVA: 0x00005C8C File Offset: 0x00003E8C
	public static Module smethod_0(object object_0, Delegate194 delegate194_1)
	{
		return delegate194_1(object_0);
	}

	// Token: 0x06000A07 RID: 2567
	public extern Delegate194(object object_0, IntPtr intptr_0);

	// Token: 0x06000A08 RID: 2568 RVA: 0x00005C97 File Offset: 0x00003E97
	static Delegate194()
	{
		Class2.smethod_14(typeof(Delegate194).TypeHandle);
	}

	// Token: 0x0400020F RID: 527
	internal static Delegate194 delegate194_0;
}
