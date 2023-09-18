using System;

// Token: 0x02000070 RID: 112
internal sealed class Delegate37 : MulticastDelegate
{
	// Token: 0x060007A0 RID: 1952
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060007A1 RID: 1953 RVA: 0x00004E48 File Offset: 0x00003048
	public static void smethod_0(object object_0, string string_0, Delegate37 delegate37_1)
	{
		delegate37_1(object_0, string_0);
	}

	// Token: 0x060007A2 RID: 1954
	public extern Delegate37(object object_0, IntPtr intptr_0);

	// Token: 0x060007A3 RID: 1955 RVA: 0x00004E55 File Offset: 0x00003055
	static Delegate37()
	{
		Class2.smethod_14(typeof(Delegate37).TypeHandle);
	}

	// Token: 0x04000172 RID: 370
	internal static Delegate37 delegate37_0;
}
