using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000164 RID: 356
internal sealed class Delegate281 : MulticastDelegate
{
	// Token: 0x06000B60 RID: 2912
	public extern void Invoke(object object_0, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0);

	// Token: 0x06000B61 RID: 2913 RVA: 0x00006498 File Offset: 0x00004698
	public static void smethod_0(object object_0, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0, Delegate281 delegate281_1)
	{
		delegate281_1(object_0, opCode_0, methodInfo_0, type_0);
	}

	// Token: 0x06000B62 RID: 2914
	public extern Delegate281(object object_0, IntPtr intptr_0);

	// Token: 0x06000B63 RID: 2915 RVA: 0x000064A9 File Offset: 0x000046A9
	static Delegate281()
	{
		Class2.smethod_14(typeof(Delegate281).TypeHandle);
	}

	// Token: 0x04000266 RID: 614
	internal static Delegate281 delegate281_0;
}
