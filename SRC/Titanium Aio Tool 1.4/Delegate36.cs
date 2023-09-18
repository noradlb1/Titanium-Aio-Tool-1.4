using System;

// Token: 0x0200006F RID: 111
internal sealed class Delegate36 : MulticastDelegate
{
	// Token: 0x0600079C RID: 1948
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600079D RID: 1949 RVA: 0x00004E2F File Offset: 0x0000302F
	public static void smethod_0(object object_0, string string_0, Delegate36 delegate36_1)
	{
		delegate36_1(object_0, string_0);
	}

	// Token: 0x0600079E RID: 1950
	public extern Delegate36(object object_0, IntPtr intptr_0);

	// Token: 0x0600079F RID: 1951 RVA: 0x00004E3C File Offset: 0x0000303C
	static Delegate36()
	{
		Class2.smethod_14(typeof(Delegate36).TypeHandle);
	}

	// Token: 0x04000171 RID: 369
	internal static Delegate36 delegate36_0;
}
