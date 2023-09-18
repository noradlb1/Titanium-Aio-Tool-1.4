using System;
using System.Reflection;

// Token: 0x02000144 RID: 324
internal sealed class Delegate249 : MulticastDelegate
{
	// Token: 0x06000AE0 RID: 2784
	public extern bool Invoke(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1);

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00006196 File Offset: 0x00004396
	public static bool smethod_0(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1, Delegate249 delegate249_1)
	{
		return delegate249_1(fieldInfo_0, fieldInfo_1);
	}

	// Token: 0x06000AE2 RID: 2786
	public extern Delegate249(object object_0, IntPtr intptr_0);

	// Token: 0x06000AE3 RID: 2787 RVA: 0x000061A3 File Offset: 0x000043A3
	static Delegate249()
	{
		Class2.smethod_14(typeof(Delegate249).TypeHandle);
	}

	// Token: 0x04000246 RID: 582
	internal static Delegate249 delegate249_0;
}
