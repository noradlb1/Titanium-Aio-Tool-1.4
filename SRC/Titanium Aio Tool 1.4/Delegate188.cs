using System;

// Token: 0x02000107 RID: 263
internal sealed class Delegate188 : MulticastDelegate
{
	// Token: 0x060009ED RID: 2541
	public extern Type Invoke(object object_0, int int_0);

	// Token: 0x060009EE RID: 2542 RVA: 0x00005BF8 File Offset: 0x00003DF8
	public static Type smethod_0(object object_0, int int_0, Delegate188 delegate188_1)
	{
		return delegate188_1(object_0, int_0);
	}

	// Token: 0x060009EF RID: 2543
	public extern Delegate188(object object_0, IntPtr intptr_0);

	// Token: 0x060009F0 RID: 2544 RVA: 0x00005C05 File Offset: 0x00003E05
	static Delegate188()
	{
		Class2.smethod_14(typeof(Delegate188).TypeHandle);
	}

	// Token: 0x04000209 RID: 521
	internal static Delegate188 delegate188_0;
}
