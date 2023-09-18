using System;
using DiscordRPC;

// Token: 0x0200007A RID: 122
internal sealed class Delegate47 : MulticastDelegate
{
	// Token: 0x060007C8 RID: 1992
	public extern void Invoke(object object_0, RichPresence richPresence_0);

	// Token: 0x060007C9 RID: 1993 RVA: 0x00004F42 File Offset: 0x00003142
	public static void smethod_0(object object_0, RichPresence richPresence_0, Delegate47 delegate47_1)
	{
		delegate47_1(object_0, richPresence_0);
	}

	// Token: 0x060007CA RID: 1994
	public extern Delegate47(object object_0, IntPtr intptr_0);

	// Token: 0x060007CB RID: 1995 RVA: 0x00004F4F File Offset: 0x0000314F
	static Delegate47()
	{
		Class2.smethod_14(typeof(Delegate47).TypeHandle);
	}

	// Token: 0x0400017C RID: 380
	internal static Delegate47 delegate47_0;
}
