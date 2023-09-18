using System;

// Token: 0x020000A9 RID: 169
internal sealed class Delegate94 : MulticastDelegate
{
	// Token: 0x06000881 RID: 2177
	public extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x06000882 RID: 2178 RVA: 0x00005390 File Offset: 0x00003590
	public static void smethod_0(object object_0, EventHandler eventHandler_0, Delegate94 delegate94_1)
	{
		delegate94_1(object_0, eventHandler_0);
	}

	// Token: 0x06000883 RID: 2179
	public extern Delegate94(object object_0, IntPtr intptr_0);

	// Token: 0x06000884 RID: 2180 RVA: 0x0000539D File Offset: 0x0000359D
	static Delegate94()
	{
		Class2.smethod_14(typeof(Delegate94).TypeHandle);
	}

	// Token: 0x040001AB RID: 427
	internal static Delegate94 delegate94_0;
}
