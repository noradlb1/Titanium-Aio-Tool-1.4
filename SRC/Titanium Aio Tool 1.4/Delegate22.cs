using System;

// Token: 0x02000061 RID: 97
internal sealed class Delegate22 : MulticastDelegate
{
	// Token: 0x06000764 RID: 1892
	public extern void Invoke(object object_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5);

	// Token: 0x06000765 RID: 1893 RVA: 0x00004CCD File Offset: 0x00002ECD
	public static void smethod_0(object object_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, Delegate22 delegate22_1)
	{
		delegate22_1(object_0, float_0, float_1, float_2, float_3, float_4, float_5);
	}

	// Token: 0x06000766 RID: 1894
	public extern Delegate22(object object_0, IntPtr intptr_0);

	// Token: 0x06000767 RID: 1895 RVA: 0x00004CE4 File Offset: 0x00002EE4
	static Delegate22()
	{
		Class2.smethod_14(typeof(Delegate22).TypeHandle);
	}

	// Token: 0x04000163 RID: 355
	internal static Delegate22 delegate22_0;
}
