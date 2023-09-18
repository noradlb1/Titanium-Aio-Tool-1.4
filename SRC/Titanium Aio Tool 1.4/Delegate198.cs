using System;
using System.Reflection;

// Token: 0x02000111 RID: 273
internal sealed class Delegate198 : MulticastDelegate
{
	// Token: 0x06000A15 RID: 2581
	public extern Module Invoke(object object_0);

	// Token: 0x06000A16 RID: 2582 RVA: 0x00005CEC File Offset: 0x00003EEC
	public static Module smethod_0(object object_0, Delegate198 delegate198_1)
	{
		return delegate198_1(object_0);
	}

	// Token: 0x06000A17 RID: 2583
	public extern Delegate198(object object_0, IntPtr intptr_0);

	// Token: 0x06000A18 RID: 2584 RVA: 0x00005CF7 File Offset: 0x00003EF7
	static Delegate198()
	{
		Class2.smethod_14(typeof(Delegate198).TypeHandle);
	}

	// Token: 0x04000213 RID: 531
	internal static Delegate198 delegate198_0;
}
