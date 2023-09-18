using System;
using System.Reflection.Emit;

// Token: 0x0200016B RID: 363
internal sealed class Delegate288 : MulticastDelegate
{
	// Token: 0x06000B7C RID: 2940
	public extern void Invoke(object object_0, OpCode opCode_0, int int_0);

	// Token: 0x06000B7D RID: 2941 RVA: 0x0000654F File Offset: 0x0000474F
	public static void smethod_0(object object_0, OpCode opCode_0, int int_0, Delegate288 delegate288_1)
	{
		delegate288_1(object_0, opCode_0, int_0);
	}

	// Token: 0x06000B7E RID: 2942
	public extern Delegate288(object object_0, IntPtr intptr_0);

	// Token: 0x06000B7F RID: 2943 RVA: 0x0000655E File Offset: 0x0000475E
	static Delegate288()
	{
		Class2.smethod_14(typeof(Delegate288).TypeHandle);
	}

	// Token: 0x0400026D RID: 621
	internal static Delegate288 delegate288_0;
}
