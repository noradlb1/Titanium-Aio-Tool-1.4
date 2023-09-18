using System;
using System.Reflection.Emit;

// Token: 0x02000163 RID: 355
internal sealed class Delegate280 : MulticastDelegate
{
	// Token: 0x06000B5C RID: 2908
	public extern void Invoke(object object_0, OpCode opCode_0, LocalBuilder localBuilder_0);

	// Token: 0x06000B5D RID: 2909 RVA: 0x0000647D File Offset: 0x0000467D
	public static void smethod_0(object object_0, OpCode opCode_0, LocalBuilder localBuilder_0, Delegate280 delegate280_1)
	{
		delegate280_1(object_0, opCode_0, localBuilder_0);
	}

	// Token: 0x06000B5E RID: 2910
	public extern Delegate280(object object_0, IntPtr intptr_0);

	// Token: 0x06000B5F RID: 2911 RVA: 0x0000648C File Offset: 0x0000468C
	static Delegate280()
	{
		Class2.smethod_14(typeof(Delegate280).TypeHandle);
	}

	// Token: 0x04000265 RID: 613
	internal static Delegate280 delegate280_0;
}
