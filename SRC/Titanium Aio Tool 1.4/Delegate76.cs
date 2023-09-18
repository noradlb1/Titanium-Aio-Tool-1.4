using System;

// Token: 0x02000097 RID: 151
internal sealed class Delegate76 : MulticastDelegate
{
	// Token: 0x0600083A RID: 2106
	public extern void Invoke(object object_0);

	// Token: 0x0600083B RID: 2107 RVA: 0x000051DF File Offset: 0x000033DF
	public static void smethod_0(object object_0, Delegate76 delegate76_1)
	{
		delegate76_1(object_0);
	}

	// Token: 0x0600083C RID: 2108
	public extern Delegate76(object object_0, IntPtr intptr_0);

	// Token: 0x0600083D RID: 2109 RVA: 0x000051EA File Offset: 0x000033EA
	static Delegate76()
	{
		Class2.smethod_14(typeof(Delegate76).TypeHandle);
	}

	// Token: 0x04000199 RID: 409
	internal static Delegate76 delegate76_0;
}
