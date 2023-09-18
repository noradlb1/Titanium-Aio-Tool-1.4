using System;
using System.Reflection;

// Token: 0x02000024 RID: 36
internal class Class6
{
	// Token: 0x0600029F RID: 671 RVA: 0x00003602 File Offset: 0x00001802
	internal static RuntimeTypeHandle smethod_0(int token)
	{
		return Class6.moduleHandle_0.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0000360F File Offset: 0x0000180F
	internal static RuntimeFieldHandle smethod_1(int token)
	{
		return Class6.moduleHandle_0.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00003076 File Offset: 0x00001276
	internal static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00003376 File Offset: 0x00001576
	internal static object smethod_3(Assembly assembly_0)
	{
		return assembly_0.GetModules();
	}

	// Token: 0x04000068 RID: 104
	internal static ModuleHandle moduleHandle_0 = typeof(Class6).Assembly.GetModules()[0].ModuleHandle;
}
