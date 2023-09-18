using System;

// Token: 0x020000FE RID: 254
internal sealed class Delegate179 : MulticastDelegate
{
	// Token: 0x060009C9 RID: 2505
	public extern void Invoke(bool bool_0);

	// Token: 0x060009CA RID: 2506 RVA: 0x00005B17 File Offset: 0x00003D17
	public static void smethod_0(bool bool_0, Delegate179 delegate179_1)
	{
		delegate179_1(bool_0);
	}

	// Token: 0x060009CB RID: 2507
	public extern Delegate179(object object_0, IntPtr intptr_0);

	// Token: 0x060009CC RID: 2508 RVA: 0x00005B22 File Offset: 0x00003D22
	static Delegate179()
	{
		Class2.smethod_14(typeof(Delegate179).TypeHandle);
	}

	// Token: 0x04000200 RID: 512
	internal static Delegate179 delegate179_0;
}
