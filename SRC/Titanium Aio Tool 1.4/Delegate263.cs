using System;

// Token: 0x02000152 RID: 338
internal sealed class Delegate263 : MulticastDelegate
{
	// Token: 0x06000B18 RID: 2840
	public extern IntPtr Invoke(ref RuntimeMethodHandle runtimeMethodHandle_0);

	// Token: 0x06000B19 RID: 2841 RVA: 0x000062E6 File Offset: 0x000044E6
	public static IntPtr smethod_0(ref RuntimeMethodHandle runtimeMethodHandle_0, Delegate263 delegate263_1)
	{
		return delegate263_1(ref runtimeMethodHandle_0);
	}

	// Token: 0x06000B1A RID: 2842
	public extern Delegate263(object object_0, IntPtr intptr_0);

	// Token: 0x06000B1B RID: 2843 RVA: 0x000062F1 File Offset: 0x000044F1
	static Delegate263()
	{
		Class2.smethod_14(typeof(Delegate263).TypeHandle);
	}

	// Token: 0x04000254 RID: 596
	internal static Delegate263 delegate263_0;
}
