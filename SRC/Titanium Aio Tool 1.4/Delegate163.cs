using System;

// Token: 0x020000EE RID: 238
internal sealed class Delegate163 : MulticastDelegate
{
	// Token: 0x0600098B RID: 2443
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x0600098C RID: 2444 RVA: 0x000059A9 File Offset: 0x00003BA9
	public static void smethod_0(object object_0, int int_0, Delegate163 delegate163_1)
	{
		delegate163_1(object_0, int_0);
	}

	// Token: 0x0600098D RID: 2445
	public extern Delegate163(object object_0, IntPtr intptr_0);

	// Token: 0x0600098E RID: 2446 RVA: 0x000059B6 File Offset: 0x00003BB6
	static Delegate163()
	{
		Class2.smethod_14(typeof(Delegate163).TypeHandle);
	}

	// Token: 0x040001F0 RID: 496
	internal static Delegate163 delegate163_0;
}
