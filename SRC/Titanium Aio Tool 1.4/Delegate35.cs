using System;

// Token: 0x0200006E RID: 110
internal sealed class Delegate35 : MulticastDelegate
{
	// Token: 0x06000798 RID: 1944
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06000799 RID: 1945 RVA: 0x00004E16 File Offset: 0x00003016
	public static void smethod_0(object object_0, string string_0, Delegate35 delegate35_1)
	{
		delegate35_1(object_0, string_0);
	}

	// Token: 0x0600079A RID: 1946
	public extern Delegate35(object object_0, IntPtr intptr_0);

	// Token: 0x0600079B RID: 1947 RVA: 0x00004E23 File Offset: 0x00003023
	static Delegate35()
	{
		Class2.smethod_14(typeof(Delegate35).TypeHandle);
	}

	// Token: 0x04000170 RID: 368
	internal static Delegate35 delegate35_0;
}
