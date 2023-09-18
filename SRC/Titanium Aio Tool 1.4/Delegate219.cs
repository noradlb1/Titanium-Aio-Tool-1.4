using System;

// Token: 0x02000126 RID: 294
internal sealed class Delegate219 : MulticastDelegate
{
	// Token: 0x06000A69 RID: 2665
	public extern string Invoke(object object_0, byte[] byte_0);

	// Token: 0x06000A6A RID: 2666 RVA: 0x00005ED5 File Offset: 0x000040D5
	public static string smethod_0(object object_0, byte[] byte_0, Delegate219 delegate219_1)
	{
		return delegate219_1(object_0, byte_0);
	}

	// Token: 0x06000A6B RID: 2667
	public extern Delegate219(object object_0, IntPtr intptr_0);

	// Token: 0x06000A6C RID: 2668 RVA: 0x00005EE2 File Offset: 0x000040E2
	static Delegate219()
	{
		Class2.smethod_14(typeof(Delegate219).TypeHandle);
	}

	// Token: 0x04000228 RID: 552
	internal static Delegate219 delegate219_0;
}
