using System;

// Token: 0x0200013D RID: 317
internal sealed class Delegate242 : MulticastDelegate
{
	// Token: 0x06000AC4 RID: 2756
	public extern uint Invoke(ref UIntPtr uintptr_0);

	// Token: 0x06000AC5 RID: 2757 RVA: 0x000060ED File Offset: 0x000042ED
	public static uint smethod_0(ref UIntPtr uintptr_0, Delegate242 delegate242_1)
	{
		return delegate242_1(ref uintptr_0);
	}

	// Token: 0x06000AC6 RID: 2758
	public extern Delegate242(object object_0, IntPtr intptr_0);

	// Token: 0x06000AC7 RID: 2759 RVA: 0x000060F8 File Offset: 0x000042F8
	static Delegate242()
	{
		Class2.smethod_14(typeof(Delegate242).TypeHandle);
	}

	// Token: 0x0400023F RID: 575
	internal static Delegate242 delegate242_0;
}
