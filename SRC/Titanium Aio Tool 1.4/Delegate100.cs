using System;

// Token: 0x020000AF RID: 175
internal sealed class Delegate100 : MulticastDelegate
{
	// Token: 0x06000899 RID: 2201
	public extern string Invoke(string string_0, object object_0);

	// Token: 0x0600089A RID: 2202 RVA: 0x00005422 File Offset: 0x00003622
	public static string smethod_0(string string_0, object object_0, Delegate100 delegate100_1)
	{
		return delegate100_1(string_0, object_0);
	}

	// Token: 0x0600089B RID: 2203
	public extern Delegate100(object object_0, IntPtr intptr_0);

	// Token: 0x0600089C RID: 2204 RVA: 0x0000542F File Offset: 0x0000362F
	static Delegate100()
	{
		Class2.smethod_14(typeof(Delegate100).TypeHandle);
	}

	// Token: 0x040001B1 RID: 433
	internal static Delegate100 delegate100_0;
}
