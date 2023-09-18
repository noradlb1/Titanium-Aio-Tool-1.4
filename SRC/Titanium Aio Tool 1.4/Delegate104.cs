using System;

// Token: 0x020000B3 RID: 179
internal sealed class Delegate104 : MulticastDelegate
{
	// Token: 0x060008A8 RID: 2216
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060008A9 RID: 2217 RVA: 0x00005477 File Offset: 0x00003677
	public static void smethod_0(object object_0, bool bool_0, Delegate104 delegate104_1)
	{
		delegate104_1(object_0, bool_0);
	}

	// Token: 0x060008AA RID: 2218
	public extern Delegate104(object object_0, IntPtr intptr_0);

	// Token: 0x060008AB RID: 2219 RVA: 0x00005484 File Offset: 0x00003684
	static Delegate104()
	{
		Class2.smethod_14(typeof(Delegate104).TypeHandle);
	}

	// Token: 0x040001B5 RID: 437
	internal static Delegate104 delegate104_0;
}
