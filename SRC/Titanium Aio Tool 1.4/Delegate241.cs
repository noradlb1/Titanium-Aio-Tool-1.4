using System;

// Token: 0x0200013C RID: 316
internal sealed class Delegate241 : MulticastDelegate
{
	// Token: 0x06000AC0 RID: 2752
	public extern ulong Invoke(ref UIntPtr uintptr_0);

	// Token: 0x06000AC1 RID: 2753 RVA: 0x000060D6 File Offset: 0x000042D6
	public static ulong smethod_0(ref UIntPtr uintptr_0, Delegate241 delegate241_1)
	{
		return delegate241_1(ref uintptr_0);
	}

	// Token: 0x06000AC2 RID: 2754
	public extern Delegate241(object object_0, IntPtr intptr_0);

	// Token: 0x06000AC3 RID: 2755 RVA: 0x000060E1 File Offset: 0x000042E1
	static Delegate241()
	{
		Class2.smethod_14(typeof(Delegate241).TypeHandle);
	}

	// Token: 0x0400023E RID: 574
	internal static Delegate241 delegate241_0;
}
