using System;
using System.Reflection;

// Token: 0x02000011 RID: 17
internal class Class1
{
	// Token: 0x06000180 RID: 384 RVA: 0x0000B4BC File Offset: 0x000096BC
	internal static void smethod_0(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002DD8 File Offset: 0x00000FD8
	internal static Type smethod_1(object object_0, int int_0, Delegate188 delegate188_0)
	{
		return Delegate188.smethod_0(object_0, int_0, delegate188_0);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002DEB File Offset: 0x00000FEB
	internal static int smethod_2(object object_0, Delegate190 delegate190_0)
	{
		return Delegate190.smethod_0(object_0, delegate190_0);
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002DFA File Offset: 0x00000FFA
	internal static object smethod_3(object object_0, int int_0, Delegate191 delegate191_0)
	{
		return Delegate191.smethod_0(object_0, int_0, delegate191_0);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002E0D File Offset: 0x0000100D
	internal static object smethod_4(Type type_0, MethodInfo methodInfo_0, Delegate192 delegate192_0)
	{
		return Delegate192.smethod_0(type_0, methodInfo_0, delegate192_0);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_5()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_6()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_7()
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x000029C2 File Offset: 0x00000BC2
	internal static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
	{
		return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002C62 File Offset: 0x00000E62
	internal static object smethod_9(object object_0, Delegate181 delegate181_0)
	{
		return Delegate181.smethod_0(object_0, delegate181_0);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002E20 File Offset: 0x00001020
	internal static object smethod_10(object object_0, Delegate194 delegate194_0)
	{
		return Delegate194.smethod_0(object_0, delegate194_0);
	}

	// Token: 0x0400003A RID: 58
	internal static Module module_0 = typeof(Class1).Assembly.ManifestModule;

	// Token: 0x02000012 RID: 18
	// (Invoke) Token: 0x0600018E RID: 398
	internal delegate void Delegate0(object o);
}
