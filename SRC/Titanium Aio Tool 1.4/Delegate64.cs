using System;

// Token: 0x0200008B RID: 139
internal sealed class Delegate64 : MulticastDelegate
{
	// Token: 0x0600080A RID: 2058
	public extern void Invoke(object object_0);

	// Token: 0x0600080B RID: 2059 RVA: 0x000050BD File Offset: 0x000032BD
	public static void smethod_0(object object_0, Delegate64 delegate64_1)
	{
		delegate64_1(object_0);
	}

	// Token: 0x0600080C RID: 2060
	public extern Delegate64(object object_0, IntPtr intptr_0);

	// Token: 0x0600080D RID: 2061 RVA: 0x000050C8 File Offset: 0x000032C8
	static Delegate64()
	{
		Class2.smethod_14(typeof(Delegate64).TypeHandle);
	}

	// Token: 0x0400018D RID: 397
	internal static Delegate64 delegate64_0;
}
