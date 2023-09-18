using System;

// Token: 0x0200011B RID: 283
internal sealed class Delegate208 : MulticastDelegate
{
	// Token: 0x06000A3D RID: 2621
	public extern void Invoke(object object_0);

	// Token: 0x06000A3E RID: 2622 RVA: 0x00005DD4 File Offset: 0x00003FD4
	public static void smethod_0(object object_0, Delegate208 delegate208_1)
	{
		delegate208_1(object_0);
	}

	// Token: 0x06000A3F RID: 2623
	public extern Delegate208(object object_0, IntPtr intptr_0);

	// Token: 0x06000A40 RID: 2624 RVA: 0x00005DDF File Offset: 0x00003FDF
	static Delegate208()
	{
		Class2.smethod_14(typeof(Delegate208).TypeHandle);
	}

	// Token: 0x0400021D RID: 541
	internal static Delegate208 delegate208_0;
}
