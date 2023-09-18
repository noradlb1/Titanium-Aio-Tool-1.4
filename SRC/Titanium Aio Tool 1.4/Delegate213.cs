using System;

// Token: 0x02000120 RID: 288
internal sealed class Delegate213 : MulticastDelegate
{
	// Token: 0x06000A51 RID: 2641
	public extern bool Invoke(object object_0);

	// Token: 0x06000A52 RID: 2642 RVA: 0x00005E49 File Offset: 0x00004049
	public static bool smethod_0(object object_0, Delegate213 delegate213_1)
	{
		return delegate213_1(object_0);
	}

	// Token: 0x06000A53 RID: 2643
	public extern Delegate213(object object_0, IntPtr intptr_0);

	// Token: 0x06000A54 RID: 2644 RVA: 0x00005E54 File Offset: 0x00004054
	static Delegate213()
	{
		Class2.smethod_14(typeof(Delegate213).TypeHandle);
	}

	// Token: 0x04000222 RID: 546
	internal static Delegate213 delegate213_0;
}
