using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000169 RID: 361
internal sealed class Delegate286 : MulticastDelegate
{
	// Token: 0x06000B74 RID: 2932
	public extern void Invoke(object object_0, OpCode opCode_0, FieldInfo fieldInfo_0);

	// Token: 0x06000B75 RID: 2933 RVA: 0x00006519 File Offset: 0x00004719
	public static void smethod_0(object object_0, OpCode opCode_0, FieldInfo fieldInfo_0, Delegate286 delegate286_1)
	{
		delegate286_1(object_0, opCode_0, fieldInfo_0);
	}

	// Token: 0x06000B76 RID: 2934
	public extern Delegate286(object object_0, IntPtr intptr_0);

	// Token: 0x06000B77 RID: 2935 RVA: 0x00006528 File Offset: 0x00004728
	static Delegate286()
	{
		Class2.smethod_14(typeof(Delegate286).TypeHandle);
	}

	// Token: 0x0400026B RID: 619
	internal static Delegate286 delegate286_0;
}
