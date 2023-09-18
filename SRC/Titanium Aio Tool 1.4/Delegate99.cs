using System;

// Token: 0x020000AE RID: 174
internal sealed class Delegate99 : MulticastDelegate
{
	// Token: 0x06000895 RID: 2197
	public extern void Invoke(object object_0);

	// Token: 0x06000896 RID: 2198 RVA: 0x0000540B File Offset: 0x0000360B
	public static void smethod_0(object object_0, Delegate99 delegate99_0)
	{
		delegate99_0(object_0);
	}

	// Token: 0x06000897 RID: 2199
	public extern Delegate99(object object_0, IntPtr intptr_0);

	// Token: 0x06000898 RID: 2200 RVA: 0x00005416 File Offset: 0x00003616
	static Delegate99()
	{
		Class2.smethod_14(typeof(Delegate99).TypeHandle);
	}

	// Token: 0x040001B0 RID: 432
	internal static Delegate99 JyKpsiJlJV;
}
