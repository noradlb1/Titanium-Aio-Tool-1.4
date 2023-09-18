using System;

// Token: 0x02000104 RID: 260
internal sealed class Delegate185 : MulticastDelegate
{
	// Token: 0x060009E1 RID: 2529
	public extern object Invoke(object object_0, string string_0);

	// Token: 0x060009E2 RID: 2530 RVA: 0x00005BAD File Offset: 0x00003DAD
	public static object smethod_0(object object_0, string string_0, Delegate185 delegate185_1)
	{
		return delegate185_1(object_0, string_0);
	}

	// Token: 0x060009E3 RID: 2531
	public extern Delegate185(object object_0, IntPtr intptr_0);

	// Token: 0x060009E4 RID: 2532 RVA: 0x00005BBA File Offset: 0x00003DBA
	static Delegate185()
	{
		Class2.smethod_14(typeof(Delegate185).TypeHandle);
	}

	// Token: 0x04000206 RID: 518
	internal static Delegate185 delegate185_0;
}
