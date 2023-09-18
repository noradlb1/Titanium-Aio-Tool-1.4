using System;

// Token: 0x020000FA RID: 250
internal sealed class Delegate175 : MulticastDelegate
{
	// Token: 0x060009B9 RID: 2489
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060009BA RID: 2490 RVA: 0x00005ABB File Offset: 0x00003CBB
	public static void smethod_0(object object_0, bool bool_0, Delegate175 delegate175_1)
	{
		delegate175_1(object_0, bool_0);
	}

	// Token: 0x060009BB RID: 2491
	public extern Delegate175(object object_0, IntPtr intptr_0);

	// Token: 0x060009BC RID: 2492 RVA: 0x00005AC8 File Offset: 0x00003CC8
	static Delegate175()
	{
		Class2.smethod_14(typeof(Delegate175).TypeHandle);
	}

	// Token: 0x040001FC RID: 508
	internal static Delegate175 delegate175_0;
}
