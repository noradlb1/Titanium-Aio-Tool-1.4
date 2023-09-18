using System;

// Token: 0x020000AC RID: 172
internal sealed class Delegate97 : MulticastDelegate
{
	// Token: 0x0600088D RID: 2189
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600088E RID: 2190 RVA: 0x000053D9 File Offset: 0x000035D9
	public static void smethod_0(object object_0, bool bool_0, Delegate97 delegate97_1)
	{
		delegate97_1(object_0, bool_0);
	}

	// Token: 0x0600088F RID: 2191
	public extern Delegate97(object object_0, IntPtr intptr_0);

	// Token: 0x06000890 RID: 2192 RVA: 0x000053E6 File Offset: 0x000035E6
	static Delegate97()
	{
		Class2.smethod_14(typeof(Delegate97).TypeHandle);
	}

	// Token: 0x040001AE RID: 430
	internal static Delegate97 delegate97_0;
}
