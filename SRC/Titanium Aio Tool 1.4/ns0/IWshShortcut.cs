using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200000D RID: 13
	[CompilerGenerated]
	[TypeIdentifier]
	[DefaultMember("FullName")]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600014E RID: 334
		[DispId(0)]
		[IndexerName("FullName")]
		string FullName { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600014F RID: 335
		// (set) Token: 0x06000150 RID: 336
		[DispId(1000)]
		string Arguments { [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000151 RID: 337
		// (set) Token: 0x06000152 RID: 338
		[DispId(1001)]
		string Description { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000153 RID: 339
		void _VtblGap1_2();

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000154 RID: 340
		// (set) Token: 0x06000155 RID: 341
		[DispId(1003)]
		string IconLocation { [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000156 RID: 342
		void _VtblGap2_1();

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		[DispId(1005)]
		string TargetPath { [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000159 RID: 345
		void _VtblGap3_2();

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600015A RID: 346
		// (set) Token: 0x0600015B RID: 347
		[DispId(1007)]
		string WorkingDirectory { [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600015C RID: 348
		void _VtblGap4_1();

		// Token: 0x0600015D RID: 349
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();
	}
}
