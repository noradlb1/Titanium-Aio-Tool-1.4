using System;

// Token: 0x020000E8 RID: 232
internal sealed class Delegate157 : MulticastDelegate
{
	// Token: 0x06000974 RID: 2420
	public extern void Invoke(object object_0, EventHandler eventHandler_0);

	// Token: 0x06000975 RID: 2421 RVA: 0x00005922 File Offset: 0x00003B22
	public static void smethod_0(object object_0, EventHandler eventHandler_0, Delegate157 delegate157_1)
	{
		delegate157_1(object_0, eventHandler_0);
	}

	// Token: 0x06000976 RID: 2422
	public extern Delegate157(object object_0, IntPtr intptr_0);

	// Token: 0x06000977 RID: 2423 RVA: 0x0000592F File Offset: 0x00003B2F
	static Delegate157()
	{
		Class2.smethod_14(typeof(Delegate157).TypeHandle);
	}

	// Token: 0x040001EA RID: 490
	internal static Delegate157 delegate157_0;
}
