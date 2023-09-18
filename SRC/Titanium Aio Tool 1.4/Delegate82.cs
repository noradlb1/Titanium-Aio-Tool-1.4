using System;

// Token: 0x0200009D RID: 157
internal sealed class Delegate82 : MulticastDelegate
{
	// Token: 0x06000852 RID: 2130
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000853 RID: 2131 RVA: 0x00005271 File Offset: 0x00003471
	public static void smethod_0(object object_0, bool bool_0, Delegate82 delegate82_1)
	{
		delegate82_1(object_0, bool_0);
	}

	// Token: 0x06000854 RID: 2132
	public extern Delegate82(object object_0, IntPtr intptr_0);

	// Token: 0x06000855 RID: 2133 RVA: 0x0000527E File Offset: 0x0000347E
	static Delegate82()
	{
		Class2.smethod_14(typeof(Delegate82).TypeHandle);
	}

	// Token: 0x0400019F RID: 415
	internal static Delegate82 delegate82_0;
}
