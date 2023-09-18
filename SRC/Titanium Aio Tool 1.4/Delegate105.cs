using System;

// Token: 0x020000B4 RID: 180
internal sealed class Delegate105 : MulticastDelegate
{
	// Token: 0x060008AC RID: 2220
	public extern void Invoke(string string_0, bool bool_0);

	// Token: 0x060008AD RID: 2221 RVA: 0x00005490 File Offset: 0x00003690
	public static void smethod_0(string string_0, bool bool_0, Delegate105 delegate105_1)
	{
		delegate105_1(string_0, bool_0);
	}

	// Token: 0x060008AE RID: 2222
	public extern Delegate105(object object_0, IntPtr intptr_0);

	// Token: 0x060008AF RID: 2223 RVA: 0x0000549D File Offset: 0x0000369D
	static Delegate105()
	{
		Class2.smethod_14(typeof(Delegate105).TypeHandle);
	}

	// Token: 0x040001B6 RID: 438
	internal static Delegate105 delegate105_0;
}
