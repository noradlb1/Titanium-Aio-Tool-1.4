using System;

// Token: 0x02000110 RID: 272
internal sealed class Delegate197 : MulticastDelegate
{
	// Token: 0x06000A11 RID: 2577
	public extern void Invoke(object object_0, long long_0);

	// Token: 0x06000A12 RID: 2578 RVA: 0x00005CD3 File Offset: 0x00003ED3
	public static void smethod_0(object object_0, long long_0, Delegate197 delegate197_1)
	{
		delegate197_1(object_0, long_0);
	}

	// Token: 0x06000A13 RID: 2579
	public extern Delegate197(object object_0, IntPtr intptr_0);

	// Token: 0x06000A14 RID: 2580 RVA: 0x00005CE0 File Offset: 0x00003EE0
	static Delegate197()
	{
		Class2.smethod_14(typeof(Delegate197).TypeHandle);
	}

	// Token: 0x04000212 RID: 530
	internal static Delegate197 delegate197_0;
}
