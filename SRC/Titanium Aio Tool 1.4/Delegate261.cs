using System;

// Token: 0x02000150 RID: 336
internal sealed class Delegate261 : MulticastDelegate
{
	// Token: 0x06000B10 RID: 2832
	public extern int Invoke(object object_0);

	// Token: 0x06000B11 RID: 2833 RVA: 0x000062B8 File Offset: 0x000044B8
	public static int smethod_0(object object_0, Delegate261 delegate261_1)
	{
		return delegate261_1(object_0);
	}

	// Token: 0x06000B12 RID: 2834
	public extern Delegate261(object object_0, IntPtr intptr_0);

	// Token: 0x06000B13 RID: 2835 RVA: 0x000062C3 File Offset: 0x000044C3
	static Delegate261()
	{
		Class2.smethod_14(typeof(Delegate261).TypeHandle);
	}

	// Token: 0x04000252 RID: 594
	internal static Delegate261 delegate261_0;
}
