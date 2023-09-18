using System;

// Token: 0x020000C8 RID: 200
internal sealed class Delegate125 : MulticastDelegate
{
	// Token: 0x060008F7 RID: 2295
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060008F8 RID: 2296 RVA: 0x0000563B File Offset: 0x0000383B
	public static void smethod_0(object object_0, bool bool_0, Delegate125 delegate125_1)
	{
		delegate125_1(object_0, bool_0);
	}

	// Token: 0x060008F9 RID: 2297
	public extern Delegate125(object object_0, IntPtr intptr_0);

	// Token: 0x060008FA RID: 2298 RVA: 0x00005648 File Offset: 0x00003848
	static Delegate125()
	{
		Class2.smethod_14(typeof(Delegate125).TypeHandle);
	}

	// Token: 0x040001CA RID: 458
	internal static Delegate125 delegate125_0;
}
