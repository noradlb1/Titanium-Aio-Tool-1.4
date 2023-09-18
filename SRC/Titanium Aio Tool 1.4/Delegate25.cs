using System;

// Token: 0x02000064 RID: 100
internal sealed class Delegate25 : MulticastDelegate
{
	// Token: 0x06000770 RID: 1904
	public extern void Invoke(object object_0);

	// Token: 0x06000771 RID: 1905 RVA: 0x00004D1E File Offset: 0x00002F1E
	public static void smethod_0(object object_0, Delegate25 delegate25_1)
	{
		delegate25_1(object_0);
	}

	// Token: 0x06000772 RID: 1906
	public extern Delegate25(object object_0, IntPtr intptr_0);

	// Token: 0x06000773 RID: 1907 RVA: 0x00004D29 File Offset: 0x00002F29
	static Delegate25()
	{
		Class2.smethod_14(typeof(Delegate25).TypeHandle);
	}

	// Token: 0x04000166 RID: 358
	internal static Delegate25 delegate25_0;
}
