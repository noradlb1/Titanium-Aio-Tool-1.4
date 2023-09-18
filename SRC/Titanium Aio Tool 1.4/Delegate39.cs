using System;
using DiscordRPC;

// Token: 0x02000072 RID: 114
internal sealed class Delegate39 : MulticastDelegate
{
	// Token: 0x060007A8 RID: 1960
	public extern void Invoke(object object_0, Timestamps timestamps_0);

	// Token: 0x060007A9 RID: 1961 RVA: 0x00004E7A File Offset: 0x0000307A
	public static void smethod_0(object object_0, Timestamps timestamps_0, Delegate39 delegate39_1)
	{
		delegate39_1(object_0, timestamps_0);
	}

	// Token: 0x060007AA RID: 1962
	public extern Delegate39(object object_0, IntPtr intptr_0);

	// Token: 0x060007AB RID: 1963 RVA: 0x00004E87 File Offset: 0x00003087
	static Delegate39()
	{
		Class2.smethod_14(typeof(Delegate39).TypeHandle);
	}

	// Token: 0x04000174 RID: 372
	internal static Delegate39 delegate39_0;
}
