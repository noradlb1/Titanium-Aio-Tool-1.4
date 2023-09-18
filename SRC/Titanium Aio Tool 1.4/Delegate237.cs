using System;

// Token: 0x02000138 RID: 312
internal sealed class Delegate237 : MulticastDelegate
{
	// Token: 0x06000AB0 RID: 2736
	public unsafe extern void* Invoke(IntPtr intptr_0);

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0000607A File Offset: 0x0000427A
	public unsafe static void* smethod_0(IntPtr intptr_0, Delegate237 delegate237_1)
	{
		return delegate237_1(intptr_0);
	}

	// Token: 0x06000AB2 RID: 2738
	public extern Delegate237(object object_0, IntPtr intptr_0);

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00006085 File Offset: 0x00004285
	static Delegate237()
	{
		Class2.smethod_14(typeof(Delegate237).TypeHandle);
	}

	// Token: 0x0400023A RID: 570
	internal static Delegate237 delegate237_0;
}
