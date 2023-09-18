using System;

// Token: 0x02000071 RID: 113
internal sealed class Delegate38 : MulticastDelegate
{
	// Token: 0x060007A4 RID: 1956
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007A5 RID: 1957 RVA: 0x00004E61 File Offset: 0x00003061
	public static void smethod_0(object object_0, string string_0, Delegate38 delegate38_1)
	{
		delegate38_1(object_0, string_0);
	}

	// Token: 0x060007A6 RID: 1958
	public extern Delegate38(object object_0, IntPtr intptr_0);

	// Token: 0x060007A7 RID: 1959 RVA: 0x00004E6E File Offset: 0x0000306E
	static Delegate38()
	{
		Class2.smethod_14(typeof(Delegate38).TypeHandle);
	}

	// Token: 0x04000173 RID: 371
	internal static Delegate38 delegate38_0;
}
