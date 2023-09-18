using System;

// Token: 0x02000109 RID: 265
internal sealed class Delegate190 : MulticastDelegate
{
	// Token: 0x060009F5 RID: 2549
	public extern int Invoke(object object_0);

	// Token: 0x060009F6 RID: 2550 RVA: 0x00005C28 File Offset: 0x00003E28
	public static int smethod_0(object object_0, Delegate190 delegate190_1)
	{
		return delegate190_1(object_0);
	}

	// Token: 0x060009F7 RID: 2551
	public extern Delegate190(object object_0, IntPtr intptr_0);

	// Token: 0x060009F8 RID: 2552 RVA: 0x00005C33 File Offset: 0x00003E33
	static Delegate190()
	{
		Class2.smethod_14(typeof(Delegate190).TypeHandle);
	}

	// Token: 0x0400020B RID: 523
	internal static Delegate190 delegate190_0;
}
