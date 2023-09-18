using System;
using System.Reflection.Emit;

// Token: 0x0200016A RID: 362
internal sealed class Delegate287 : MulticastDelegate
{
	// Token: 0x06000B78 RID: 2936
	public extern void Invoke(object object_0, OpCode opCode_0, sbyte sbyte_0);

	// Token: 0x06000B79 RID: 2937 RVA: 0x00006534 File Offset: 0x00004734
	public static void smethod_0(object object_0, OpCode opCode_0, sbyte sbyte_0, Delegate287 delegate287_1)
	{
		delegate287_1(object_0, opCode_0, sbyte_0);
	}

	// Token: 0x06000B7A RID: 2938
	public extern Delegate287(object object_0, IntPtr intptr_0);

	// Token: 0x06000B7B RID: 2939 RVA: 0x00006543 File Offset: 0x00004743
	static Delegate287()
	{
		Class2.smethod_14(typeof(Delegate287).TypeHandle);
	}

	// Token: 0x0400026C RID: 620
	internal static Delegate287 delegate287_0;
}
