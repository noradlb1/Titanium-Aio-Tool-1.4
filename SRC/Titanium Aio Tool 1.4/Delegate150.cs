using System;

// Token: 0x020000E1 RID: 225
internal sealed class Delegate150 : MulticastDelegate
{
	// Token: 0x0600095A RID: 2394
	public extern void Invoke(object object_0);

	// Token: 0x0600095B RID: 2395 RVA: 0x0000588F File Offset: 0x00003A8F
	public static void smethod_0(object object_0, Delegate150 delegate150_1)
	{
		delegate150_1(object_0);
	}

	// Token: 0x0600095C RID: 2396
	public extern Delegate150(object object_0, IntPtr intptr_0);

	// Token: 0x0600095D RID: 2397 RVA: 0x0000589A File Offset: 0x00003A9A
	static Delegate150()
	{
		Class2.smethod_14(typeof(Delegate150).TypeHandle);
	}

	// Token: 0x040001E3 RID: 483
	internal static Delegate150 delegate150_0;
}
