using System;

// Token: 0x02000069 RID: 105
internal sealed class Delegate30 : MulticastDelegate
{
	// Token: 0x06000784 RID: 1924
	public extern void Invoke(object object_0, int int_0, int int_1, int int_2, int int_3, float float_0, float float_1);

	// Token: 0x06000785 RID: 1925 RVA: 0x00004D95 File Offset: 0x00002F95
	public static void smethod_0(object object_0, int int_0, int int_1, int int_2, int int_3, float float_0, float float_1, Delegate30 delegate30_1)
	{
		delegate30_1(object_0, int_0, int_1, int_2, int_3, float_0, float_1);
	}

	// Token: 0x06000786 RID: 1926
	public extern Delegate30(object object_0, IntPtr intptr_0);

	// Token: 0x06000787 RID: 1927 RVA: 0x00004DAC File Offset: 0x00002FAC
	static Delegate30()
	{
		Class2.smethod_14(typeof(Delegate30).TypeHandle);
	}

	// Token: 0x0400016B RID: 363
	internal static Delegate30 delegate30_0;
}
