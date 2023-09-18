using System;

// Token: 0x0200016D RID: 365
internal sealed class Delegate290 : MulticastDelegate
{
	// Token: 0x06000B84 RID: 2948
	public extern int Invoke(ref int int_0, int int_1);

	// Token: 0x06000B85 RID: 2949 RVA: 0x00006583 File Offset: 0x00004783
	public static int smethod_0(ref int int_0, int int_1, Delegate290 delegate290_1)
	{
		return delegate290_1(ref int_0, int_1);
	}

	// Token: 0x06000B86 RID: 2950
	public extern Delegate290(object object_0, IntPtr intptr_0);

	// Token: 0x06000B87 RID: 2951 RVA: 0x00006590 File Offset: 0x00004790
	static Delegate290()
	{
		Class2.smethod_14(typeof(Delegate290).TypeHandle);
	}

	// Token: 0x0400026F RID: 623
	internal static Delegate290 delegate290_0;
}
