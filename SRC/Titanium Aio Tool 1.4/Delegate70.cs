using System;

// Token: 0x02000091 RID: 145
internal sealed class Delegate70 : MulticastDelegate
{
	// Token: 0x06000822 RID: 2082
	public extern int Invoke(object object_0);

	// Token: 0x06000823 RID: 2083 RVA: 0x00005151 File Offset: 0x00003351
	public static int smethod_0(object object_0, Delegate70 delegate70_1)
	{
		return delegate70_1(object_0);
	}

	// Token: 0x06000824 RID: 2084
	public extern Delegate70(object object_0, IntPtr intptr_0);

	// Token: 0x06000825 RID: 2085 RVA: 0x0000515C File Offset: 0x0000335C
	static Delegate70()
	{
		Class2.smethod_14(typeof(Delegate70).TypeHandle);
	}

	// Token: 0x04000193 RID: 403
	internal static Delegate70 delegate70_0;
}
