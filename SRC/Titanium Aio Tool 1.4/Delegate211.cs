using System;

// Token: 0x0200011E RID: 286
internal sealed class Delegate211 : MulticastDelegate
{
	// Token: 0x06000A49 RID: 2633
	public extern bool Invoke(object object_0);

	// Token: 0x06000A4A RID: 2634 RVA: 0x00005E1B File Offset: 0x0000401B
	public static bool smethod_0(object object_0, Delegate211 delegate211_1)
	{
		return delegate211_1(object_0);
	}

	// Token: 0x06000A4B RID: 2635
	public extern Delegate211(object object_0, IntPtr intptr_0);

	// Token: 0x06000A4C RID: 2636 RVA: 0x00005E26 File Offset: 0x00004026
	static Delegate211()
	{
		Class2.smethod_14(typeof(Delegate211).TypeHandle);
	}

	// Token: 0x04000220 RID: 544
	internal static Delegate211 delegate211_0;
}
