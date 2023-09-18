using System;

// Token: 0x02000154 RID: 340
internal sealed class Delegate265 : MulticastDelegate
{
	// Token: 0x06000B20 RID: 2848
	public extern bool Invoke(double double_0);

	// Token: 0x06000B21 RID: 2849 RVA: 0x00006314 File Offset: 0x00004514
	public static bool smethod_0(double double_0, Delegate265 delegate265_1)
	{
		return delegate265_1(double_0);
	}

	// Token: 0x06000B22 RID: 2850
	public extern Delegate265(object object_0, IntPtr intptr_0);

	// Token: 0x06000B23 RID: 2851 RVA: 0x0000631F File Offset: 0x0000451F
	static Delegate265()
	{
		Class2.smethod_14(typeof(Delegate265).TypeHandle);
	}

	// Token: 0x04000256 RID: 598
	internal static Delegate265 delegate265_0;
}
