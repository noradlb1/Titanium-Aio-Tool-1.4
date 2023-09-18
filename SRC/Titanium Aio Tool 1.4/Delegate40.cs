using System;
using DiscordRPC;

// Token: 0x02000073 RID: 115
internal sealed class Delegate40 : MulticastDelegate
{
	// Token: 0x060007AC RID: 1964
	public extern void Invoke(object object_0, Button[] button_0);

	// Token: 0x060007AD RID: 1965 RVA: 0x00004E93 File Offset: 0x00003093
	public static void smethod_0(object object_0, Button[] button_0, Delegate40 delegate40_1)
	{
		delegate40_1(object_0, button_0);
	}

	// Token: 0x060007AE RID: 1966
	public extern Delegate40(object object_0, IntPtr intptr_0);

	// Token: 0x060007AF RID: 1967 RVA: 0x00004EA0 File Offset: 0x000030A0
	static Delegate40()
	{
		Class2.smethod_14(typeof(Delegate40).TypeHandle);
	}

	// Token: 0x04000175 RID: 373
	internal static Delegate40 delegate40_0;
}
