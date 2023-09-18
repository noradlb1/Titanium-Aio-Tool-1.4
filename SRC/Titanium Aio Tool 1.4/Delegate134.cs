using System;

// Token: 0x020000D1 RID: 209
internal sealed class Delegate134 : MulticastDelegate
{
	// Token: 0x0600091A RID: 2330
	public extern void Invoke(string string_0, string string_1);

	// Token: 0x0600091B RID: 2331 RVA: 0x00005707 File Offset: 0x00003907
	public static void smethod_0(string string_0, string string_1, Delegate134 delegate134_1)
	{
		delegate134_1(string_0, string_1);
	}

	// Token: 0x0600091C RID: 2332
	public extern Delegate134(object object_0, IntPtr intptr_0);

	// Token: 0x0600091D RID: 2333 RVA: 0x00005714 File Offset: 0x00003914
	static Delegate134()
	{
		Class2.smethod_14(typeof(Delegate134).TypeHandle);
	}

	// Token: 0x040001D3 RID: 467
	internal static Delegate134 delegate134_0;
}
