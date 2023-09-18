using System;

// Token: 0x02000147 RID: 327
internal sealed class Delegate252 : MulticastDelegate
{
	// Token: 0x06000AEC RID: 2796
	public extern void Invoke(IntPtr intptr_0);

	// Token: 0x06000AED RID: 2797 RVA: 0x000061DF File Offset: 0x000043DF
	public static void smethod_0(IntPtr intptr_0, Delegate252 delegate252_1)
	{
		delegate252_1(intptr_0);
	}

	// Token: 0x06000AEE RID: 2798
	public extern Delegate252(object object_0, IntPtr intptr_0);

	// Token: 0x06000AEF RID: 2799 RVA: 0x000061EA File Offset: 0x000043EA
	static Delegate252()
	{
		Class2.smethod_14(typeof(Delegate252).TypeHandle);
	}

	// Token: 0x04000249 RID: 585
	internal static Delegate252 delegate252_0;
}
