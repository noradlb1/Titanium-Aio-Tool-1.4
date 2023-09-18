using System;

// Token: 0x02000139 RID: 313
internal sealed class Delegate238 : MulticastDelegate
{
	// Token: 0x06000AB4 RID: 2740
	public extern long Invoke(ref IntPtr intptr_0);

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00006091 File Offset: 0x00004291
	public static long smethod_0(ref IntPtr intptr_0, Delegate238 delegate238_1)
	{
		return delegate238_1(ref intptr_0);
	}

	// Token: 0x06000AB6 RID: 2742
	public extern Delegate238(object object_0, IntPtr intptr_0);

	// Token: 0x06000AB7 RID: 2743 RVA: 0x0000609C File Offset: 0x0000429C
	static Delegate238()
	{
		Class2.smethod_14(typeof(Delegate238).TypeHandle);
	}

	// Token: 0x0400023B RID: 571
	internal static Delegate238 delegate238_0;
}
