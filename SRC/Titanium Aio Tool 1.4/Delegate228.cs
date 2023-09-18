using System;

// Token: 0x0200012F RID: 303
internal sealed class Delegate228 : MulticastDelegate
{
	// Token: 0x06000A8D RID: 2701
	public extern object Invoke(Type type_0, byte byte_0);

	// Token: 0x06000A8E RID: 2702 RVA: 0x00005FAE File Offset: 0x000041AE
	public static object smethod_0(Type type_0, byte byte_0, Delegate228 delegate228_0)
	{
		return delegate228_0(type_0, byte_0);
	}

	// Token: 0x06000A8F RID: 2703
	public extern Delegate228(object object_0, IntPtr intptr_0);

	// Token: 0x06000A90 RID: 2704 RVA: 0x00005FBB File Offset: 0x000041BB
	static Delegate228()
	{
		Class2.smethod_14(typeof(Delegate228).TypeHandle);
	}

	// Token: 0x04000231 RID: 561
	internal static Delegate228 OdBnhRoyKX;
}
