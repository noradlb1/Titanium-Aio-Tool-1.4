using System;
using DiscordRPC;

// Token: 0x02000078 RID: 120
internal sealed class Delegate45 : MulticastDelegate
{
	// Token: 0x060007C0 RID: 1984
	public extern void Invoke(object object_0, Assets assets_0);

	// Token: 0x060007C1 RID: 1985 RVA: 0x00004F10 File Offset: 0x00003110
	public static void smethod_0(object object_0, Assets assets_0, Delegate45 delegate45_1)
	{
		delegate45_1(object_0, assets_0);
	}

	// Token: 0x060007C2 RID: 1986
	public extern Delegate45(object object_0, IntPtr intptr_0);

	// Token: 0x060007C3 RID: 1987 RVA: 0x00004F1D File Offset: 0x0000311D
	static Delegate45()
	{
		Class2.smethod_14(typeof(Delegate45).TypeHandle);
	}

	// Token: 0x0400017A RID: 378
	internal static Delegate45 delegate45_0;
}
