using System;

// Token: 0x02000155 RID: 341
internal sealed class Delegate266 : MulticastDelegate
{
	// Token: 0x06000B24 RID: 2852
	public extern IntPtr Invoke(int int_0);

	// Token: 0x06000B25 RID: 2853 RVA: 0x0000632B File Offset: 0x0000452B
	public static IntPtr smethod_0(int int_0, Delegate266 delegate266_1)
	{
		return delegate266_1(int_0);
	}

	// Token: 0x06000B26 RID: 2854
	public extern Delegate266(object object_0, IntPtr intptr_0);

	// Token: 0x06000B27 RID: 2855 RVA: 0x00006336 File Offset: 0x00004536
	static Delegate266()
	{
		Class2.smethod_14(typeof(Delegate266).TypeHandle);
	}

	// Token: 0x04000257 RID: 599
	internal static Delegate266 delegate266_0;
}
