using System;

// Token: 0x020000E4 RID: 228
internal sealed class Delegate153 : MulticastDelegate
{
	// Token: 0x06000965 RID: 2405
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06000966 RID: 2406 RVA: 0x000058CB File Offset: 0x00003ACB
	public static void smethod_0(object object_0, int int_0, Delegate153 delegate153_1)
	{
		delegate153_1(object_0, int_0);
	}

	// Token: 0x06000967 RID: 2407
	public extern Delegate153(object object_0, IntPtr intptr_0);

	// Token: 0x06000968 RID: 2408 RVA: 0x000058D8 File Offset: 0x00003AD8
	static Delegate153()
	{
		Class2.smethod_14(typeof(Delegate153).TypeHandle);
	}

	// Token: 0x040001E6 RID: 486
	internal static Delegate153 delegate153_0;
}
