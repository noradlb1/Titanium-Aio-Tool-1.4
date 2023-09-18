using System;

// Token: 0x02000153 RID: 339
internal sealed class Delegate264 : MulticastDelegate
{
	// Token: 0x06000B1C RID: 2844
	public extern bool Invoke(double double_0);

	// Token: 0x06000B1D RID: 2845 RVA: 0x000062FD File Offset: 0x000044FD
	public static bool smethod_0(double double_0, Delegate264 delegate264_1)
	{
		return delegate264_1(double_0);
	}

	// Token: 0x06000B1E RID: 2846
	public extern Delegate264(object object_0, IntPtr intptr_0);

	// Token: 0x06000B1F RID: 2847 RVA: 0x00006308 File Offset: 0x00004508
	static Delegate264()
	{
		Class2.smethod_14(typeof(Delegate264).TypeHandle);
	}

	// Token: 0x04000255 RID: 597
	internal static Delegate264 delegate264_0;
}
