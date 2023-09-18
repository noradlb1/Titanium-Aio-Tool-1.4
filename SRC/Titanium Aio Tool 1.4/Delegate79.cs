using System;

// Token: 0x0200009A RID: 154
internal sealed class Delegate79 : MulticastDelegate
{
	// Token: 0x06000846 RID: 2118
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06000847 RID: 2119 RVA: 0x00005226 File Offset: 0x00003426
	public static void smethod_0(object object_0, string string_0, Delegate79 delegate79_1)
	{
		delegate79_1(object_0, string_0);
	}

	// Token: 0x06000848 RID: 2120
	public extern Delegate79(object object_0, IntPtr intptr_0);

	// Token: 0x06000849 RID: 2121 RVA: 0x00005233 File Offset: 0x00003433
	static Delegate79()
	{
		Class2.smethod_14(typeof(Delegate79).TypeHandle);
	}

	// Token: 0x0400019C RID: 412
	internal static Delegate79 delegate79_0;
}
