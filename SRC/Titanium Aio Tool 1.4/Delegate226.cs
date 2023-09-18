using System;

// Token: 0x0200012D RID: 301
internal sealed class Delegate226 : MulticastDelegate
{
	// Token: 0x06000A85 RID: 2693
	public extern object Invoke(Type type_0, short short_0);

	// Token: 0x06000A86 RID: 2694 RVA: 0x00005F7C File Offset: 0x0000417C
	public static object smethod_0(Type type_0, short short_0, Delegate226 delegate226_1)
	{
		return delegate226_1(type_0, short_0);
	}

	// Token: 0x06000A87 RID: 2695
	public extern Delegate226(object object_0, IntPtr intptr_0);

	// Token: 0x06000A88 RID: 2696 RVA: 0x00005F89 File Offset: 0x00004189
	static Delegate226()
	{
		Class2.smethod_14(typeof(Delegate226).TypeHandle);
	}

	// Token: 0x0400022F RID: 559
	internal static Delegate226 delegate226_0;
}
