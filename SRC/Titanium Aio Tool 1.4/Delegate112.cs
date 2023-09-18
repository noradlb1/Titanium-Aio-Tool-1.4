using System;

// Token: 0x020000BB RID: 187
internal sealed class Delegate112 : MulticastDelegate
{
	// Token: 0x060008C6 RID: 2246
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060008C7 RID: 2247 RVA: 0x00005525 File Offset: 0x00003725
	public static void smethod_0(object object_0, bool bool_0, Delegate112 delegate112_1)
	{
		delegate112_1(object_0, bool_0);
	}

	// Token: 0x060008C8 RID: 2248
	public extern Delegate112(object object_0, IntPtr intptr_0);

	// Token: 0x060008C9 RID: 2249 RVA: 0x00005532 File Offset: 0x00003732
	static Delegate112()
	{
		Class2.smethod_14(typeof(Delegate112).TypeHandle);
	}

	// Token: 0x040001BD RID: 445
	internal static Delegate112 delegate112_0;
}
