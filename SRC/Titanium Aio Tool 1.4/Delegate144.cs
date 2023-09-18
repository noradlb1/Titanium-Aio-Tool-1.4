using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x020000DB RID: 219
internal sealed class Delegate144 : MulticastDelegate
{
	// Token: 0x06000942 RID: 2370
	public extern CallSiteBinder Invoke(CSharpBinderFlags csharpBinderFlags_0, Type type_0, Type type_1);

	// Token: 0x06000943 RID: 2371 RVA: 0x000057FF File Offset: 0x000039FF
	public static CallSiteBinder smethod_0(CSharpBinderFlags csharpBinderFlags_0, Type type_0, Type type_1, Delegate144 delegate144_1)
	{
		return delegate144_1(csharpBinderFlags_0, type_0, type_1);
	}

	// Token: 0x06000944 RID: 2372
	public extern Delegate144(object object_0, IntPtr intptr_0);

	// Token: 0x06000945 RID: 2373 RVA: 0x0000580E File Offset: 0x00003A0E
	static Delegate144()
	{
		Class2.smethod_14(typeof(Delegate144).TypeHandle);
	}

	// Token: 0x040001DD RID: 477
	internal static Delegate144 delegate144_0;
}
