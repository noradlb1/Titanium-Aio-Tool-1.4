using System;

// Token: 0x020000C1 RID: 193
internal sealed class Delegate118 : MulticastDelegate
{
	// Token: 0x060008DE RID: 2270
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060008DF RID: 2271 RVA: 0x000055B3 File Offset: 0x000037B3
	public static void smethod_0(object object_0, bool bool_0, Delegate118 delegate118_1)
	{
		delegate118_1(object_0, bool_0);
	}

	// Token: 0x060008E0 RID: 2272
	public extern Delegate118(object object_0, IntPtr intptr_0);

	// Token: 0x060008E1 RID: 2273 RVA: 0x000055C0 File Offset: 0x000037C0
	static Delegate118()
	{
		Class2.smethod_14(typeof(Delegate118).TypeHandle);
	}

	// Token: 0x040001C3 RID: 451
	internal static Delegate118 delegate118_0;
}
