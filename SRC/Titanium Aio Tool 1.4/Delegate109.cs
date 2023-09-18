using System;

// Token: 0x020000B8 RID: 184
internal sealed class Delegate109 : MulticastDelegate
{
	// Token: 0x060008BA RID: 2234
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060008BB RID: 2235 RVA: 0x000054DA File Offset: 0x000036DA
	public static void smethod_0(object object_0, string string_0, Delegate109 delegate109_1)
	{
		delegate109_1(object_0, string_0);
	}

	// Token: 0x060008BC RID: 2236
	public extern Delegate109(object object_0, IntPtr intptr_0);

	// Token: 0x060008BD RID: 2237 RVA: 0x000054E7 File Offset: 0x000036E7
	static Delegate109()
	{
		Class2.smethod_14(typeof(Delegate109).TypeHandle);
	}

	// Token: 0x040001BA RID: 442
	internal static Delegate109 delegate109_0;
}
