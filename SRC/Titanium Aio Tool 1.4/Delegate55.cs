using System;
using System.Drawing;

// Token: 0x02000082 RID: 130
internal sealed class Delegate55 : MulticastDelegate
{
	// Token: 0x060007E6 RID: 2022
	public extern void Invoke(object object_0, Point point_0);

	// Token: 0x060007E7 RID: 2023 RVA: 0x00004FEC File Offset: 0x000031EC
	public static void smethod_0(object object_0, Point point_0, Delegate55 delegate55_1)
	{
		delegate55_1(object_0, point_0);
	}

	// Token: 0x060007E8 RID: 2024
	public extern Delegate55(object object_0, IntPtr intptr_0);

	// Token: 0x060007E9 RID: 2025 RVA: 0x00004FF9 File Offset: 0x000031F9
	static Delegate55()
	{
		Class2.smethod_14(typeof(Delegate55).TypeHandle);
	}

	// Token: 0x04000184 RID: 388
	internal static Delegate55 delegate55_0;
}
