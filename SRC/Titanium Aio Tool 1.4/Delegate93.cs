using System;

// Token: 0x020000A8 RID: 168
internal sealed class Delegate93 : MulticastDelegate
{
	// Token: 0x0600087D RID: 2173
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600087E RID: 2174 RVA: 0x00005377 File Offset: 0x00003577
	public static void smethod_0(object object_0, string string_0, Delegate93 delegate93_1)
	{
		delegate93_1(object_0, string_0);
	}

	// Token: 0x0600087F RID: 2175
	public extern Delegate93(object object_0, IntPtr intptr_0);

	// Token: 0x06000880 RID: 2176 RVA: 0x00005384 File Offset: 0x00003584
	static Delegate93()
	{
		Class2.smethod_14(typeof(Delegate93).TypeHandle);
	}

	// Token: 0x040001AA RID: 426
	internal static Delegate93 delegate93_0;
}
