using System;

// Token: 0x020000D5 RID: 213
internal sealed class Delegate138 : MulticastDelegate
{
	// Token: 0x0600092A RID: 2346
	public extern void Invoke(object object_0, string string_0, object object_1);

	// Token: 0x0600092B RID: 2347 RVA: 0x0000576B File Offset: 0x0000396B
	public static void smethod_0(object object_0, string string_0, object object_1, Delegate138 delegate138_1)
	{
		delegate138_1(object_0, string_0, object_1);
	}

	// Token: 0x0600092C RID: 2348
	public extern Delegate138(object object_0, IntPtr intptr_0);

	// Token: 0x0600092D RID: 2349 RVA: 0x0000577A File Offset: 0x0000397A
	static Delegate138()
	{
		Class2.smethod_14(typeof(Delegate138).TypeHandle);
	}

	// Token: 0x040001D7 RID: 471
	internal static Delegate138 delegate138_0;
}
