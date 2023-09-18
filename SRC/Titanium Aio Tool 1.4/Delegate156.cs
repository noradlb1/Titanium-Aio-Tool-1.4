using System;

// Token: 0x020000E7 RID: 231
internal sealed class Delegate156 : MulticastDelegate
{
	// Token: 0x06000970 RID: 2416
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06000971 RID: 2417 RVA: 0x00005909 File Offset: 0x00003B09
	public static void smethod_0(object object_0, bool bool_0, Delegate156 delegate156_1)
	{
		delegate156_1(object_0, bool_0);
	}

	// Token: 0x06000972 RID: 2418
	public extern Delegate156(object object_0, IntPtr intptr_0);

	// Token: 0x06000973 RID: 2419 RVA: 0x00005916 File Offset: 0x00003B16
	static Delegate156()
	{
		Class2.smethod_14(typeof(Delegate156).TypeHandle);
	}

	// Token: 0x040001E9 RID: 489
	internal static Delegate156 delegate156_0;
}
