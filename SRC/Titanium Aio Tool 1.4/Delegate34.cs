using System;

// Token: 0x0200006D RID: 109
internal sealed class Delegate34 : MulticastDelegate
{
	// Token: 0x06000794 RID: 1940
	public extern bool Invoke(object object_0);

	// Token: 0x06000795 RID: 1941 RVA: 0x00004DFF File Offset: 0x00002FFF
	public static bool smethod_0(object object_0, Delegate34 delegate34_1)
	{
		return delegate34_1(object_0);
	}

	// Token: 0x06000796 RID: 1942
	public extern Delegate34(object object_0, IntPtr intptr_0);

	// Token: 0x06000797 RID: 1943 RVA: 0x00004E0A File Offset: 0x0000300A
	static Delegate34()
	{
		Class2.smethod_14(typeof(Delegate34).TypeHandle);
	}

	// Token: 0x0400016F RID: 367
	internal static Delegate34 delegate34_0;
}
