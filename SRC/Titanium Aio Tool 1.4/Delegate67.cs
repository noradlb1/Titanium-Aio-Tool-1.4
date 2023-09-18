using System;

// Token: 0x0200008E RID: 142
internal sealed class Delegate67 : MulticastDelegate
{
	// Token: 0x06000816 RID: 2070
	public extern void Invoke(object object_0);

	// Token: 0x06000817 RID: 2071 RVA: 0x0000510C File Offset: 0x0000330C
	public static void smethod_0(object object_0, Delegate67 delegate67_1)
	{
		delegate67_1(object_0);
	}

	// Token: 0x06000818 RID: 2072
	public extern Delegate67(object object_0, IntPtr intptr_0);

	// Token: 0x06000819 RID: 2073 RVA: 0x00005117 File Offset: 0x00003317
	static Delegate67()
	{
		Class2.smethod_14(typeof(Delegate67).TypeHandle);
	}

	// Token: 0x04000190 RID: 400
	internal static Delegate67 delegate67_0;
}
