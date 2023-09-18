using System;

// Token: 0x020000D3 RID: 211
internal sealed class Delegate136 : MulticastDelegate
{
	// Token: 0x06000922 RID: 2338
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000923 RID: 2339 RVA: 0x00005739 File Offset: 0x00003939
	public static void smethod_0(object object_0, bool bool_0, Delegate136 delegate136_1)
	{
		delegate136_1(object_0, bool_0);
	}

	// Token: 0x06000924 RID: 2340
	public extern Delegate136(object object_0, IntPtr intptr_0);

	// Token: 0x06000925 RID: 2341 RVA: 0x00005746 File Offset: 0x00003946
	static Delegate136()
	{
		Class2.smethod_14(typeof(Delegate136).TypeHandle);
	}

	// Token: 0x040001D5 RID: 469
	internal static Delegate136 delegate136_0;
}
