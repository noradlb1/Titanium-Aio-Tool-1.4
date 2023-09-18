using System;

// Token: 0x0200014E RID: 334
internal sealed class Delegate259 : MulticastDelegate
{
	// Token: 0x06000B08 RID: 2824
	public extern bool Invoke(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06000B09 RID: 2825 RVA: 0x00006286 File Offset: 0x00004486
	public static bool smethod_0(IntPtr intptr_0, IntPtr intptr_1, Delegate259 delegate259_1)
	{
		return delegate259_1(intptr_0, intptr_1);
	}

	// Token: 0x06000B0A RID: 2826
	public extern Delegate259(object object_0, IntPtr intptr_0);

	// Token: 0x06000B0B RID: 2827 RVA: 0x00006293 File Offset: 0x00004493
	static Delegate259()
	{
		Class2.smethod_14(typeof(Delegate259).TypeHandle);
	}

	// Token: 0x04000250 RID: 592
	internal static Delegate259 delegate259_0;
}
