using System;

// Token: 0x0200013A RID: 314
internal sealed class Delegate239 : MulticastDelegate
{
	// Token: 0x06000AB8 RID: 2744
	public extern int Invoke(ref IntPtr intptr_0);

	// Token: 0x06000AB9 RID: 2745 RVA: 0x000060A8 File Offset: 0x000042A8
	public static int smethod_0(ref IntPtr intptr_0, Delegate239 delegate239_1)
	{
		return delegate239_1(ref intptr_0);
	}

	// Token: 0x06000ABA RID: 2746
	public extern Delegate239(object object_0, IntPtr intptr_0);

	// Token: 0x06000ABB RID: 2747 RVA: 0x000060B3 File Offset: 0x000042B3
	static Delegate239()
	{
		Class2.smethod_14(typeof(Delegate239).TypeHandle);
	}

	// Token: 0x0400023C RID: 572
	internal static Delegate239 delegate239_0;
}
