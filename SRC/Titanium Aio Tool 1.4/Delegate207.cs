using System;

// Token: 0x0200011A RID: 282
internal sealed class Delegate207 : MulticastDelegate
{
	// Token: 0x06000A39 RID: 2617
	public extern double Invoke(object object_0);

	// Token: 0x06000A3A RID: 2618 RVA: 0x00005DBD File Offset: 0x00003FBD
	public static double smethod_0(object object_0, Delegate207 delegate207_1)
	{
		return delegate207_1(object_0);
	}

	// Token: 0x06000A3B RID: 2619
	public extern Delegate207(object object_0, IntPtr intptr_0);

	// Token: 0x06000A3C RID: 2620 RVA: 0x00005DC8 File Offset: 0x00003FC8
	static Delegate207()
	{
		Class2.smethod_14(typeof(Delegate207).TypeHandle);
	}

	// Token: 0x0400021C RID: 540
	internal static Delegate207 delegate207_0;
}
