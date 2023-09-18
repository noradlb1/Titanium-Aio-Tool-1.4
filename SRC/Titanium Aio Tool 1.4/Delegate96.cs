using System;

// Token: 0x020000AB RID: 171
internal sealed class Delegate96 : MulticastDelegate
{
	// Token: 0x06000889 RID: 2185
	public extern void Invoke(object object_0);

	// Token: 0x0600088A RID: 2186 RVA: 0x000053C2 File Offset: 0x000035C2
	public static void smethod_0(object object_0, Delegate96 delegate96_1)
	{
		delegate96_1(object_0);
	}

	// Token: 0x0600088B RID: 2187
	public extern Delegate96(object object_0, IntPtr intptr_0);

	// Token: 0x0600088C RID: 2188 RVA: 0x000053CD File Offset: 0x000035CD
	static Delegate96()
	{
		Class2.smethod_14(typeof(Delegate96).TypeHandle);
	}

	// Token: 0x040001AD RID: 429
	internal static Delegate96 delegate96_0;
}
