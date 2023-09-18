using System;

// Token: 0x0200012C RID: 300
internal sealed class Delegate225 : MulticastDelegate
{
	// Token: 0x06000A81 RID: 2689
	public extern object Invoke(Type type_0, uint uint_0);

	// Token: 0x06000A82 RID: 2690 RVA: 0x00005F63 File Offset: 0x00004163
	public static object smethod_0(Type type_0, uint uint_0, Delegate225 delegate225_0)
	{
		return delegate225_0(type_0, uint_0);
	}

	// Token: 0x06000A83 RID: 2691
	public extern Delegate225(object object_0, IntPtr intptr_0);

	// Token: 0x06000A84 RID: 2692 RVA: 0x00005F70 File Offset: 0x00004170
	static Delegate225()
	{
		Class2.smethod_14(typeof(Delegate225).TypeHandle);
	}

	// Token: 0x0400022E RID: 558
	internal static Delegate225 ygAnZqivTR;
}
