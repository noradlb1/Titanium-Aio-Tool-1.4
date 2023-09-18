using System;

// Token: 0x02000077 RID: 119
internal sealed class Delegate44 : MulticastDelegate
{
	// Token: 0x060007BC RID: 1980
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007BD RID: 1981 RVA: 0x00004EF7 File Offset: 0x000030F7
	public static void smethod_0(object object_0, string string_0, Delegate44 delegate44_1)
	{
		delegate44_1(object_0, string_0);
	}

	// Token: 0x060007BE RID: 1982
	public extern Delegate44(object object_0, IntPtr intptr_0);

	// Token: 0x060007BF RID: 1983 RVA: 0x00004F04 File Offset: 0x00003104
	static Delegate44()
	{
		Class2.smethod_14(typeof(Delegate44).TypeHandle);
	}

	// Token: 0x04000179 RID: 377
	internal static Delegate44 delegate44_0;
}
