using System;

// Token: 0x02000098 RID: 152
internal sealed class Delegate77 : MulticastDelegate
{
	// Token: 0x0600083E RID: 2110
	public extern void Invoke(object object_0);

	// Token: 0x0600083F RID: 2111 RVA: 0x000051F6 File Offset: 0x000033F6
	public static void smethod_0(object object_0, Delegate77 delegate77_1)
	{
		delegate77_1(object_0);
	}

	// Token: 0x06000840 RID: 2112
	public extern Delegate77(object object_0, IntPtr intptr_0);

	// Token: 0x06000841 RID: 2113 RVA: 0x00005201 File Offset: 0x00003401
	static Delegate77()
	{
		Class2.smethod_14(typeof(Delegate77).TypeHandle);
	}

	// Token: 0x0400019A RID: 410
	internal static Delegate77 delegate77_0;
}
