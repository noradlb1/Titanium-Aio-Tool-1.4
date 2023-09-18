using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x02000028 RID: 40
internal class Class9
{
	// Token: 0x060002CB RID: 715 RVA: 0x0000372C File Offset: 0x0000192C
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000FF70 File Offset: 0x0000E170
	internal static object[] smethod_1<T>(int int_1, object object_1, object object_2, ref T gparam_0)
	{
		Class9.Class15 @class = null;
		object obj = Class9.object_0;
		lock (obj)
		{
			if (!Class9.bool_0)
			{
				Class9.bool_0 = true;
				Class9.smethod_4();
			}
			if (Class9.class15_0[int_1] != null)
			{
				@class = Class9.class15_0[int_1];
			}
			else
			{
				Class9.binaryReader_0.BaseStream.Position = (long)Class9.int_0[int_1];
				@class = new Class9.Class15();
				Module module = typeof(Class9).Module;
				int metadataToken = Class9.smethod_6(Class9.binaryReader_0);
				int num = Class9.smethod_6(Class9.binaryReader_0);
				int num2 = Class9.smethod_6(Class9.binaryReader_0);
				int num3 = Class9.smethod_6(Class9.binaryReader_0);
				@class.object_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.object_0.GetParameters();
				@class.class11_0 = new Class9.Class11[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class9.Class11 class2 = new Class9.Class11();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class11_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class9.Enum2 enum2_;
					if (type == typeof(string))
					{
						enum2_ = (Class9.Enum2)14;
					}
					else if (type == typeof(byte))
					{
						enum2_ = (Class9.Enum2)2;
					}
					else if (type == typeof(sbyte))
					{
						enum2_ = (Class9.Enum2)1;
					}
					else if (type == typeof(short))
					{
						enum2_ = (Class9.Enum2)3;
					}
					else if (type == typeof(ushort))
					{
						enum2_ = (Class9.Enum2)4;
					}
					else if (type == typeof(int))
					{
						enum2_ = (Class9.Enum2)5;
					}
					else if (type == typeof(uint))
					{
						enum2_ = (Class9.Enum2)6;
					}
					else if (type == typeof(long))
					{
						enum2_ = (Class9.Enum2)7;
					}
					else if (type == typeof(ulong))
					{
						enum2_ = (Class9.Enum2)8;
					}
					else if (type == typeof(float))
					{
						enum2_ = (Class9.Enum2)9;
					}
					else if (type == typeof(double))
					{
						enum2_ = (Class9.Enum2)10;
					}
					else if (type == typeof(bool))
					{
						enum2_ = (Class9.Enum2)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum2_ = (Class9.Enum2)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum2_ = (Class9.Enum2)13;
					}
					else if (type == typeof(char))
					{
						enum2_ = (Class9.Enum2)15;
					}
					else
					{
						enum2_ = (Class9.Enum2)0;
					}
					class2.enum2_0 = enum2_;
				}
				@class.UqaYjxudZI = new List<Class9.Class12>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class9.smethod_6(Class9.binaryReader_0);
					Class9.Class12 class3 = new Class9.Class12();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum2_0 = (Class9.Enum2)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.UqaYjxudZI.Add(class3);
				}
				@class.list_1 = new List<Class9.Class13>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class9.smethod_6(Class9.binaryReader_0);
					int int_2 = Class9.smethod_6(Class9.binaryReader_0);
					Class9.Class13 class4 = new Class9.Class13();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class9.Class14 class5 = new Class9.Class14();
					class4.class14_0 = class5;
					num5 = Class9.smethod_6(Class9.binaryReader_0);
					int_2 = Class9.smethod_6(Class9.binaryReader_0);
					int num6 = Class9.smethod_6(Class9.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class9.smethod_6(Class9.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class9.smethod_6(Class9.binaryReader_0);
					}
					else
					{
						Class9.smethod_6(Class9.binaryReader_0);
					}
					@class.list_1.Add(class4);
				}
				@class.list_1.Sort(new Comparison<Class9.Class13>(Class9.Class35<T>.<>9.method_0));
				@class.list_0 = new List<Class9.Class10>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class9.Class10 class6 = new Class9.Class10();
					byte b = Class9.binaryReader_0.ReadByte();
					class6.enum4_0 = (Class9.Enum4)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class9.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class9.smethod_6(Class9.binaryReader_0);
							break;
						case 2:
							obj2 = Class9.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class9.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class9.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class9.smethod_6(Class9.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class9.smethod_6(Class9.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class9.class15_0[int_1] = @class;
			}
		}
		Class9.Class18 class7 = new Class9.Class18();
		class7.class15_0 = @class;
		ParameterInfo[] parameters2 = @class.object_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.object_0 is MethodInfo && ((MethodInfo)@class.object_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.object_0.IsStatic)
		{
			class7.class20_0 = new Class9.Class20[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class20_0[n] = Class9.Class20.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class20_0 = new Class9.Class20[parameters2.Length + 1];
			if (@class.object_0.DeclaringType.IsValueType)
			{
				class7.class20_0[0] = new Class9.Class31(new Class9.Class32(object_2), @class.object_0.DeclaringType);
			}
			else
			{
				class7.class20_0[0] = new Class9.Class32(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class20_0[num10 + 1] = Class9.Class20.smethod_1(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class20_0[num10 + 1] = Class9.Class20.smethod_1(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class20_1 = new Class9.Class20[@class.UqaYjxudZI.Count];
		for (int num11 = 0; num11 < @class.UqaYjxudZI.Count; num11++)
		{
			Class9.Class12 class8 = @class.UqaYjxudZI[num11];
			switch (class8.enum2_0)
			{
			case (Class9.Enum2)0:
				class7.class20_1[num11] = null;
				break;
			case (Class9.Enum2)1:
			case (Class9.Enum2)2:
			case (Class9.Enum2)3:
			case (Class9.Enum2)4:
			case (Class9.Enum2)5:
			case (Class9.Enum2)6:
			case (Class9.Enum2)11:
			case (Class9.Enum2)15:
				class7.class20_1[num11] = new Class9.Class22(0, class8.enum2_0);
				break;
			case (Class9.Enum2)7:
			case (Class9.Enum2)8:
				class7.class20_1[num11] = new Class9.Class23(0L, class8.enum2_0);
				break;
			case (Class9.Enum2)9:
			case (Class9.Enum2)10:
				class7.class20_1[num11] = new Class9.Class25(0.0, class8.enum2_0);
				break;
			case (Class9.Enum2)12:
				class7.class20_1[num11] = new Class9.Class24(IntPtr.Zero);
				break;
			case (Class9.Enum2)13:
				class7.class20_1[num11] = new Class9.Class24(UIntPtr.Zero);
				break;
			case (Class9.Enum2)14:
				class7.class20_1[num11] = null;
				break;
			case (Class9.Enum2)16:
				class7.class20_1[num11] = new Class9.Class32(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.object_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.object_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class20_2 != null)
			{
				array2[0] = class7.class20_2.vmethod_3(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class20_0[num14] != null)
					{
						if (@class.object_0.IsStatic)
						{
							array2[num13] = class7.class20_0[num14].vmethod_3(type2);
						}
						else
						{
							array2[num13] = class7.class20_0[num14 + 1].vmethod_3(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.object_0.IsStatic && @class.object_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class20_0[0].vmethod_3(@class.object_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00010950 File Offset: 0x0000EB50
	internal static object[] smethod_2(int int_1, object object_1, object object_2)
	{
		int num = 0;
		return Class9.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00003734 File Offset: 0x00001934
	internal static object[] smethod_3<T>(int int_1, object object_1, ref T gparam_0)
	{
		return Class9.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0001096C File Offset: 0x0000EB6C
	internal static void smethod_4()
	{
		if (Class9.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class9).Assembly.GetManifestResourceStream("wKSmrXvaguTTqUrTpu.iQx89eQ4m4X1RDnto1"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class9.smethod_5(byte_);
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x000109D4 File Offset: 0x0000EBD4
	internal static void smethod_5(byte[] byte_1)
	{
		Class9.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class9.byte_0 = new byte[255];
		int num = Class9.smethod_6(Class9.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class9.binaryReader_0.ReadByte();
			Class9.byte_0[num2] = Class9.binaryReader_0.ReadByte();
		}
		num = Class9.smethod_6(Class9.binaryReader_0);
		Class9.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class9.list_0.Add(Encoding.Unicode.GetString(Class9.binaryReader_0.ReadBytes(Class9.smethod_6(Class9.binaryReader_0))));
		}
		num = Class9.smethod_6(Class9.binaryReader_0);
		Class9.class15_0 = new Class9.Class15[num];
		Class9.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class9.class15_0[k] = null;
			Class9.int_0[k] = Class9.smethod_6(Class9.binaryReader_0);
		}
		int num3 = (int)Class9.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class9.int_0[l];
			Class9.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00010B1C File Offset: 0x0000ED1C
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num < 128U)
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x000029C2 File Offset: 0x00000BC2
	internal static Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
	{
		return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002C62 File Offset: 0x00000E62
	internal static object smethod_8(object object_1, Delegate181 delegate181_0)
	{
		return Delegate181.smethod_0(object_1, delegate181_0);
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00003749 File Offset: 0x00001949
	internal static object smethod_9(object object_1, string string_0, Delegate214 delegate214_0)
	{
		return Delegate214.smethod_0(object_1, string_0, delegate214_0);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000375C File Offset: 0x0000195C
	internal static object smethod_10(object object_1, Delegate196 delegate196_0)
	{
		return Delegate196.smethod_0(object_1, delegate196_0);
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000376B File Offset: 0x0000196B
	internal static long smethod_11(object object_1, Delegate215 delegate215_0)
	{
		return Delegate215.smethod_0(object_1, delegate215_0);
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000377A File Offset: 0x0000197A
	internal static object smethod_12(object object_1, int int_1, Delegate216 delegate216_0)
	{
		return Delegate216.smethod_0(object_1, int_1, delegate216_0);
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000378D File Offset: 0x0000198D
	internal static void smethod_13(object object_1, Delegate217 delegate217_0)
	{
		Delegate217.smethod_0(object_1, delegate217_0);
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000379C File Offset: 0x0000199C
	internal static int smethod_14(BinaryReader binaryReader_1)
	{
		return Class9.smethod_6(binaryReader_1);
	}

	// Token: 0x060002DC RID: 732 RVA: 0x000037A7 File Offset: 0x000019A7
	internal static byte smethod_15(object object_1, Delegate204 delegate204_0)
	{
		return Delegate204.smethod_0(object_1, delegate204_0);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x000037B6 File Offset: 0x000019B6
	internal static object smethod_16(object object_1, byte[] byte_1, Delegate219 delegate219_0)
	{
		return Delegate219.smethod_0(object_1, byte_1, delegate219_0);
	}

	// Token: 0x060002DE RID: 734 RVA: 0x000037C9 File Offset: 0x000019C9
	internal static long smethod_17(object object_1, Delegate220 delegate220_0)
	{
		return Delegate220.smethod_0(object_1, delegate220_0);
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_18()
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_19()
	{
	}

	// Token: 0x0400006E RID: 110
	internal static Class9.Class15[] class15_0 = null;

	// Token: 0x0400006F RID: 111
	internal static int[] int_0 = null;

	// Token: 0x04000070 RID: 112
	internal static List<string> list_0;

	// Token: 0x04000071 RID: 113
	private static BinaryReader binaryReader_0;

	// Token: 0x04000072 RID: 114
	private static byte[] byte_0;

	// Token: 0x04000073 RID: 115
	private static bool bool_0 = false;

	// Token: 0x04000074 RID: 116
	private static object object_0 = new object();

	// Token: 0x02000029 RID: 41
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct1
	{
		// Token: 0x04000075 RID: 117
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000076 RID: 118
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000077 RID: 119
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000078 RID: 120
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000079 RID: 121
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x0400007A RID: 122
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x0200002A RID: 42
	private class Class22 : Class9.Class21
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			this.struct1_0 = ((Class9.Class22)class20_0).struct1_0;
			this.enum2_0 = ((Class9.Class22)class20_0).enum2_0;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_9(class20_0);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00010C08 File Offset: 0x0000EE08
		public Class22(bool bool_0)
		{
			this.enum5_0 = (Class9.Enum5)1;
			if (!bool_0)
			{
				this.struct1_0.int_0 = 0;
			}
			else
			{
				this.struct1_0.int_0 = 1;
			}
			this.enum2_0 = (Class9.Enum2)11;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00010C48 File Offset: 0x0000EE48
		public Class22(Class9.Class22 class22_0)
		{
			this.enum5_0 = class22_0.enum5_0;
			this.struct1_0.int_0 = class22_0.struct1_0.int_0;
			this.enum2_0 = class22_0.enum2_0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000037D8 File Offset: 0x000019D8
		public override Class9.Class21 vmethod_69()
		{
			return new Class9.Class22(this);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public Class22(int int_0)
		{
			this.enum5_0 = (Class9.Enum5)1;
			this.struct1_0.int_0 = int_0;
			this.enum2_0 = (Class9.Enum2)5;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00010CBC File Offset: 0x0000EEBC
		public Class22(uint uint_0)
		{
			this.enum5_0 = (Class9.Enum5)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum2_0 = (Class9.Enum2)6;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00010CEC File Offset: 0x0000EEEC
		public Class22(int int_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)1;
			this.struct1_0.int_0 = int_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00010D1C File Offset: 0x0000EF1C
		public Class22(uint uint_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010D4C File Offset: 0x0000EF4C
		public override bool vmethod_10()
		{
			Class9.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class9.Enum2)1:
			case (Class9.Enum2)3:
			case (Class9.Enum2)5:
			case (Class9.Enum2)7:
				goto IL_4A;
			case (Class9.Enum2)2:
			case (Class9.Enum2)4:
			case (Class9.Enum2)6:
				break;
			default:
				if (@enum == (Class9.Enum2)11)
				{
					goto IL_4A;
				}
				if (@enum == (Class9.Enum2)15)
				{
					goto IL_4A;
				}
				break;
			}
			return this.struct1_0.uint_0 == 0U;
			IL_4A:
			return this.struct1_0.int_0 == 0;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000037E0 File Offset: 0x000019E0
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		public override Class9.Class20 vmethod_11(Class9.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class9.Enum2)1:
				return this.vmethod_13();
			case (Class9.Enum2)2:
				return this.vmethod_14();
			case (Class9.Enum2)3:
				return this.vmethod_15();
			case (Class9.Enum2)4:
				return this.vmethod_16();
			case (Class9.Enum2)5:
				return this.vmethod_17();
			case (Class9.Enum2)6:
				return this.vmethod_18();
			case (Class9.Enum2)11:
				return this.vmethod_12();
			case (Class9.Enum2)15:
				return this.method_7();
			case (Class9.Enum2)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class9.Enum6)4).ToString());
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00010E60 File Offset: 0x0000F060
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum2_0)
				{
				case (Class9.Enum2)1:
					return this.struct1_0.sbyte_0;
				case (Class9.Enum2)2:
					return this.struct1_0.byte_0;
				case (Class9.Enum2)3:
					return this.struct1_0.short_0;
				case (Class9.Enum2)4:
					return this.struct1_0.ushort_0;
				case (Class9.Enum2)5:
					return this.struct1_0.int_0;
				case (Class9.Enum2)6:
					return this.struct1_0.uint_0;
				case (Class9.Enum2)7:
					return (long)this.struct1_0.int_0;
				case (Class9.Enum2)8:
					return (ulong)this.struct1_0.uint_0;
				case (Class9.Enum2)11:
					return this.yQwppAuByG();
				case (Class9.Enum2)15:
					return (char)this.struct1_0.int_0;
				}
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct1_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct1_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct1_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct1_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct1_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct1_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct1_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct1_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct1_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct1_0.uint_0);
			}
			if (type_0.IsEnum)
			{
				return this.method_6(type_0);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000111A0 File Offset: 0x0000F3A0
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct1_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct1_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct1_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct1_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct1_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct1_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct1_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct1_0.uint_0);
			}
			if (!(underlyingType == typeof(char)))
			{
				return Enum.ToObject(type_0, this.struct1_0.int_0);
			}
			return Enum.ToObject(type_0, (ushort)this.struct1_0.int_0);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001131C File Offset: 0x0000F51C
		public override Class9.Class22 vmethod_12()
		{
			return new Class9.Class22(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000037EB File Offset: 0x000019EB
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000037F3 File Offset: 0x000019F3
		public override Class9.Class22 vmethod_13()
		{
			return new Class9.Class22((int)this.struct1_0.sbyte_0, (Class9.Enum2)1);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003806 File Offset: 0x00001A06
		public Class9.Class22 method_7()
		{
			return new Class9.Class22(this.struct1_0.int_0, (Class9.Enum2)15);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000381A File Offset: 0x00001A1A
		public override Class9.Class22 vmethod_14()
		{
			return new Class9.Class22((uint)this.struct1_0.byte_0, (Class9.Enum2)2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000382D File Offset: 0x00001A2D
		public override Class9.Class22 vmethod_15()
		{
			return new Class9.Class22((int)this.struct1_0.short_0, (Class9.Enum2)3);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003840 File Offset: 0x00001A40
		public override Class9.Class22 vmethod_16()
		{
			return new Class9.Class22((uint)this.struct1_0.ushort_0, (Class9.Enum2)4);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003853 File Offset: 0x00001A53
		public override Class9.Class22 vmethod_17()
		{
			return new Class9.Class22(this.struct1_0.int_0, (Class9.Enum2)5);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003866 File Offset: 0x00001A66
		public override Class9.Class22 vmethod_18()
		{
			return new Class9.Class22(this.struct1_0.uint_0, (Class9.Enum2)6);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003879 File Offset: 0x00001A79
		public override Class9.Class23 vmethod_19()
		{
			return new Class9.Class23((long)this.struct1_0.int_0, (Class9.Enum2)7);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000388D File Offset: 0x00001A8D
		public override Class9.Class23 vmethod_20()
		{
			return new Class9.Class23((ulong)this.struct1_0.uint_0, (Class9.Enum2)8);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000038A1 File Offset: 0x00001AA1
		public override Class9.Class22 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000038A9 File Offset: 0x00001AA9
		public override Class9.Class22 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000038B1 File Offset: 0x00001AB1
		public override Class9.Class22 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000038B9 File Offset: 0x00001AB9
		public override Class9.Class23 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000038C1 File Offset: 0x00001AC1
		public override Class9.Class22 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000038C9 File Offset: 0x00001AC9
		public override Class9.Class22 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000038D1 File Offset: 0x00001AD1
		public override Class9.Class22 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000038D9 File Offset: 0x00001AD9
		public override Class9.Class23 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000038E1 File Offset: 0x00001AE1
		public override Class9.Class22 vmethod_29()
		{
			return new Class9.Class22((int)(checked((sbyte)this.struct1_0.int_0)), (Class9.Enum2)1);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000038F5 File Offset: 0x00001AF5
		public override Class9.Class22 vmethod_30()
		{
			return new Class9.Class22((int)(checked((sbyte)this.struct1_0.uint_0)), (Class9.Enum2)1);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003909 File Offset: 0x00001B09
		public override Class9.Class22 vmethod_31()
		{
			return new Class9.Class22((int)(checked((short)this.struct1_0.int_0)), (Class9.Enum2)3);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000391D File Offset: 0x00001B1D
		public override Class9.Class22 vmethod_32()
		{
			return new Class9.Class22((int)(checked((short)this.struct1_0.uint_0)), (Class9.Enum2)3);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003853 File Offset: 0x00001A53
		public override Class9.Class22 vmethod_33()
		{
			return new Class9.Class22(this.struct1_0.int_0, (Class9.Enum2)5);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003931 File Offset: 0x00001B31
		public override Class9.Class22 vmethod_34()
		{
			return new Class9.Class22(checked((int)this.struct1_0.uint_0), (Class9.Enum2)5);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003879 File Offset: 0x00001A79
		public override Class9.Class23 vmethod_35()
		{
			return new Class9.Class23((long)this.struct1_0.int_0, (Class9.Enum2)7);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003945 File Offset: 0x00001B45
		public override Class9.Class23 vmethod_36()
		{
			return new Class9.Class23((long)((ulong)this.struct1_0.uint_0), (Class9.Enum2)7);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003959 File Offset: 0x00001B59
		public override Class9.Class22 vmethod_37()
		{
			return new Class9.Class22((int)(checked((byte)this.struct1_0.int_0)), (Class9.Enum2)2);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000396D File Offset: 0x00001B6D
		public override Class9.Class22 vmethod_38()
		{
			return new Class9.Class22((int)(checked((byte)this.struct1_0.uint_0)), (Class9.Enum2)2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003981 File Offset: 0x00001B81
		public override Class9.Class22 vmethod_39()
		{
			return new Class9.Class22((int)(checked((ushort)this.struct1_0.int_0)), (Class9.Enum2)4);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003995 File Offset: 0x00001B95
		public override Class9.Class22 vmethod_40()
		{
			return new Class9.Class22((int)(checked((ushort)this.struct1_0.uint_0)), (Class9.Enum2)4);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000039A9 File Offset: 0x00001BA9
		public override Class9.Class22 vmethod_41()
		{
			return new Class9.Class22(checked((uint)this.struct1_0.int_0), (Class9.Enum2)6);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003866 File Offset: 0x00001A66
		public override Class9.Class22 vmethod_42()
		{
			return new Class9.Class22(this.struct1_0.uint_0, (Class9.Enum2)6);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000039BD File Offset: 0x00001BBD
		public override Class9.Class23 vmethod_43()
		{
			return new Class9.Class23(checked((ulong)this.struct1_0.int_0), (Class9.Enum2)8);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000388D File Offset: 0x00001A8D
		public override Class9.Class23 vmethod_44()
		{
			return new Class9.Class23((ulong)this.struct1_0.uint_0, (Class9.Enum2)8);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000039D1 File Offset: 0x00001BD1
		public override Class9.Class25 vmethod_45()
		{
			return new Class9.Class25((float)this.struct1_0.int_0);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000039E4 File Offset: 0x00001BE4
		public override Class9.Class25 vmethod_46()
		{
			return new Class9.Class25((double)this.struct1_0.int_0);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000039F7 File Offset: 0x00001BF7
		public override Class9.Class25 zLqpmHyYrP()
		{
			return new Class9.Class25(this.struct1_0.uint_0);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0001133C File Offset: 0x0000F53C
		public override Class9.Class24 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_24().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00011380 File Offset: 0x0000F580
		public override Class9.Class24 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public override Class9.Class24 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_35().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011408 File Offset: 0x0000F608
		public override Class9.Class24 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0001144C File Offset: 0x0000F64C
		public override Class9.Class24 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_36().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011490 File Offset: 0x0000F690
		public override Class9.Class24 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000114D4 File Offset: 0x0000F6D4
		public override Class9.Class20 vmethod_53()
		{
			Class9.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class9.Enum2)1:
			case (Class9.Enum2)3:
			case (Class9.Enum2)5:
				goto IL_47;
			case (Class9.Enum2)2:
			case (Class9.Enum2)4:
				break;
			default:
				if (@enum == (Class9.Enum2)11)
				{
					goto IL_47;
				}
				if (@enum == (Class9.Enum2)15)
				{
					goto IL_47;
				}
				break;
			}
			return new Class9.Class22((int)(-(int)((ulong)this.struct1_0.uint_0)));
			IL_47:
			return new Class9.Class22(-this.struct1_0.int_0);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001153C File Offset: 0x0000F73C
		public override Class9.Class20 Add(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 + ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).Add(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000115A0 File Offset: 0x0000F7A0
		public override Class9.Class20 vmethod_54(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.int_0 + ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_54(this);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00011604 File Offset: 0x0000F804
		public override Class9.Class20 vmethod_55(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.uint_0 + ((Class9.Class22)class20_0).struct1_0.uint_0));
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).vmethod_55(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00011668 File Offset: 0x0000F868
		public override Class9.Class20 vmethod_56(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 - ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_8(this);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000116CC File Offset: 0x0000F8CC
		public override Class9.Class20 vmethod_57(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.int_0 - ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).method_9(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00011730 File Offset: 0x0000F930
		public override Class9.Class20 vmethod_58(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.uint_0 - ((Class9.Class22)class20_0).struct1_0.uint_0));
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_10(this);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00011794 File Offset: 0x0000F994
		public override Class9.Class20 vmethod_59(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 * ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_59(this);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000117F8 File Offset: 0x0000F9F8
		public override Class9.Class20 vmethod_60(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.int_0 * ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_60(this);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001185C File Offset: 0x0000FA5C
		public override Class9.Class20 vmethod_61(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(checked(this.struct1_0.uint_0 * ((Class9.Class22)class20_0).struct1_0.uint_0));
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_61(this);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000118C0 File Offset: 0x0000FAC0
		public override Class9.Class20 vmethod_62(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 / ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_11(this);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011924 File Offset: 0x0000FB24
		public override Class9.Class20 vmethod_63(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.uint_0 / ((Class9.Class22)class20_0).struct1_0.uint_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_12(this);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00011988 File Offset: 0x0000FB88
		public override Class9.Class20 vmethod_64(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 % ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_13(this);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000119EC File Offset: 0x0000FBEC
		public override Class9.Class20 vmethod_65(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.uint_0 % ((Class9.Class22)class20_0).struct1_0.uint_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_14(this);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00011A50 File Offset: 0x0000FC50
		public override Class9.Class20 vmethod_66(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 & ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_66(this);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		public override Class9.Class20 vmethod_67(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 | ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_67(this);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003A0B File Offset: 0x00001C0B
		public override Class9.Class20 vmethod_68()
		{
			return new Class9.Class22(~this.struct1_0.int_0);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011B18 File Offset: 0x0000FD18
		public override Class9.Class20 igEvpBpxrl(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 ^ ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).igEvpBpxrl(this);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00011B7C File Offset: 0x0000FD7C
		public override Class9.Class20 vmethod_70(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 << ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_17(this);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		public override Class9.Class20 vmethod_71(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.int_0 >> ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_16(this);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00011C44 File Offset: 0x0000FE44
		public override Class9.Class20 vmethod_72(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return new Class9.Class22(this.struct1_0.uint_0 >> ((Class9.Class22)class20_0).struct1_0.int_0);
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).method_15(this);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public override string ToString()
		{
			Class9.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class9.Enum2)1:
			case (Class9.Enum2)3:
			case (Class9.Enum2)5:
				goto IL_3E;
			case (Class9.Enum2)2:
			case (Class9.Enum2)4:
				break;
			default:
				if (@enum == (Class9.Enum2)11)
				{
					goto IL_3E;
				}
				break;
			}
			return this.struct1_0.uint_0.ToString();
			IL_3E:
			return this.struct1_0.int_0.ToString();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003A1E File Offset: 0x00001C1E
		internal override Class9.Class20 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00011D04 File Offset: 0x0000FF04
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return ((Class9.Class32)class20_0).vmethod_4(this);
			}
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_4(this);
			}
			Class9.Class20 @class = class20_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (!@class.method_1())
			{
				return ((Class9.Class24)@class).vmethod_4(this);
			}
			return this.struct1_0.int_0 == ((Class9.Class22)@class).struct1_0.int_0;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00011D90 File Offset: 0x0000FF90
		private static Class9.Class21 smethod_24(Class9.Class20 class20_0)
		{
			Class9.Class21 @class = class20_0 as Class9.Class21;
			if (@class == null && class20_0.iFavIhWly7())
			{
				@class = (class20_0.vmethod_7() as Class9.Class21);
			}
			return @class;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_5(this);
			}
			Class9.Class20 @class = class20_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (!@class.method_1())
			{
				return ((Class9.Class24)@class).vmethod_5(this);
			}
			return this.struct1_0.uint_0 != ((Class9.Class22)@class).struct1_0.uint_0;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00011E44 File Offset: 0x00010044
		public override bool vmethod_73(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.int_0 >= ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).vmethod_77(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011EA4 File Offset: 0x000100A4
		public override bool vmethod_74(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.uint_0 >= ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).vmethod_78(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00011F04 File Offset: 0x00010104
		public override bool vmethod_75(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.int_0 > ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).vmethod_79(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00011F64 File Offset: 0x00010164
		public override bool vmethod_76(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.uint_0 > ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_80(this);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00011FC4 File Offset: 0x000101C4
		public override bool vmethod_77(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.int_0 <= ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_73(this);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00012024 File Offset: 0x00010224
		public override bool vmethod_78(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.uint_0 <= ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_74(this);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00012084 File Offset: 0x00010284
		public override bool vmethod_79(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.int_0 < ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			if (!class20_0.method_2())
			{
				throw new Class9.Exception1();
			}
			return ((Class9.Class24)class20_0).vmethod_75(this);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000120E4 File Offset: 0x000102E4
		public override bool vmethod_80(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				return this.struct1_0.uint_0 < ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			if (class20_0.method_2())
			{
				return ((Class9.Class24)class20_0).vmethod_76(this);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_25()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_26()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003A21 File Offset: 0x00001C21
		internal static bool smethod_27(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_10();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003A2C File Offset: 0x00001C2C
		internal static object smethod_28(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_17();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003A37 File Offset: 0x00001C37
		internal static object smethod_29(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_18();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003A42 File Offset: 0x00001C42
		internal static object smethod_30(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_12();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003A4D File Offset: 0x00001C4D
		internal static object smethod_31(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_13();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003A58 File Offset: 0x00001C58
		internal static object smethod_32(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_14();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003A63 File Offset: 0x00001C63
		internal static object smethod_33(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_16();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_34(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003A81 File Offset: 0x00001C81
		internal static bool smethod_35(object object_0, Delegate201 delegate201_0)
		{
			return Delegate201.smethod_0(object_0, delegate201_0);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_36(object object_0, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_0, delegate202_0);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003A9F File Offset: 0x00001C9F
		internal static Type smethod_37(Type type_0, Delegate221 delegate221_0)
		{
			return Delegate221.smethod_0(type_0, delegate221_0);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_38(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_39(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003AC1 File Offset: 0x00001CC1
		internal static bool smethod_40(Class9.Class21 class21_0)
		{
			return class21_0.yQwppAuByG();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003ACC File Offset: 0x00001CCC
		internal static bool smethod_41(object object_0, Delegate222 delegate222_0)
		{
			return Delegate222.smethod_0(object_0, delegate222_0);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003ADB File Offset: 0x00001CDB
		internal static Type smethod_42(Type type_0, Delegate223 delegate223_0)
		{
			return Delegate223.smethod_0(type_0, delegate223_0);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003AEA File Offset: 0x00001CEA
		internal static object smethod_43(Type type_0, int int_0, Delegate224 delegate224_0)
		{
			return Delegate224.smethod_0(type_0, int_0, delegate224_0);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003AFD File Offset: 0x00001CFD
		internal static object smethod_44(Type type_0, uint uint_0, Delegate225 delegate225_0)
		{
			return Delegate225.smethod_0(type_0, uint_0, delegate225_0);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003B10 File Offset: 0x00001D10
		internal static object smethod_45(Type type_0, ushort ushort_0, Delegate227 delegate227_0)
		{
			return Delegate227.smethod_0(type_0, ushort_0, delegate227_0);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003B23 File Offset: 0x00001D23
		internal static object smethod_46(Type type_0, byte byte_0, Delegate228 delegate228_0)
		{
			return Delegate228.smethod_0(type_0, byte_0, delegate228_0);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003B36 File Offset: 0x00001D36
		internal static object smethod_47(Type type_0, sbyte sbyte_0, Delegate229 delegate229_0)
		{
			return Delegate229.smethod_0(type_0, sbyte_0, delegate229_0);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003B49 File Offset: 0x00001D49
		internal static object smethod_48(Type type_0, long long_0, Delegate230 delegate230_0)
		{
			return Delegate230.smethod_0(type_0, long_0, delegate230_0);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003B5C File Offset: 0x00001D5C
		internal static object smethod_49(Type type_0, ulong ulong_0, Delegate231 delegate231_0)
		{
			return Delegate231.smethod_0(type_0, ulong_0, delegate231_0);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003B6F File Offset: 0x00001D6F
		internal static object smethod_50(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_20();
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003B7A File Offset: 0x00001D7A
		internal static int smethod_51(Delegate232 delegate232_0)
		{
			return delegate232_0();
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003B85 File Offset: 0x00001D85
		internal static object smethod_52(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_28();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003B90 File Offset: 0x00001D90
		internal static object smethod_53(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_27();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003B9B File Offset: 0x00001D9B
		internal static object smethod_54(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_35();
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003BA6 File Offset: 0x00001DA6
		internal static object smethod_55(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_33();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003BB1 File Offset: 0x00001DB1
		internal static object smethod_56(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_41();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003BBC File Offset: 0x00001DBC
		internal static object smethod_57(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_36();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003BC7 File Offset: 0x00001DC7
		internal static object smethod_58(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_34();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003BD2 File Offset: 0x00001DD2
		internal static object smethod_59(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_44();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003BDD File Offset: 0x00001DDD
		internal static object smethod_60(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_42();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_61(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_62(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003BFE File Offset: 0x00001DFE
		internal static bool smethod_63(Class9.Class20 class20_0)
		{
			return class20_0.method_1();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003C09 File Offset: 0x00001E09
		internal static bool smethod_64(Class9.Class20 class20_0)
		{
			return class20_0.method_2();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003C14 File Offset: 0x00001E14
		internal static object smethod_65(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.Add(class20_0);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003C23 File Offset: 0x00001E23
		internal static object smethod_66(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_55(class20_0);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003C32 File Offset: 0x00001E32
		internal static object smethod_67(Class9.Class24 class24_0, Class9.Class20 class20_0)
		{
			return class24_0.method_8(class20_0);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003C41 File Offset: 0x00001E41
		internal static object smethod_68(Class9.Class24 class24_0, Class9.Class20 class20_0)
		{
			return class24_0.method_9(class20_0);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003C50 File Offset: 0x00001E50
		internal static object smethod_69(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_59(class20_0);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003C5F File Offset: 0x00001E5F
		internal static object smethod_70(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_60(class20_0);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003C6E File Offset: 0x00001E6E
		internal static object smethod_71(Class9.Class24 class24_0, Class9.Class20 class20_0)
		{
			return class24_0.method_11(class20_0);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003C7D File Offset: 0x00001E7D
		internal static object smethod_72(Class9.Class24 class24_0, Class9.Class20 class20_0)
		{
			return class24_0.method_12(class20_0);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003C8C File Offset: 0x00001E8C
		internal static object smethod_73(Class9.Class24 class24_0, Class9.Class20 class20_0)
		{
			return class24_0.method_13(class20_0);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003C9B File Offset: 0x00001E9B
		internal static object smethod_74(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_66(class20_0);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003CAA File Offset: 0x00001EAA
		internal static object smethod_75(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_67(class20_0);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003CB9 File Offset: 0x00001EB9
		internal static object smethod_76(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.igEvpBpxrl(class20_0);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003CC8 File Offset: 0x00001EC8
		internal static object smethod_77(Class9.Class24 class24_0, Class9.Class22 class22_0)
		{
			return class24_0.method_16(class22_0);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003CD7 File Offset: 0x00001ED7
		internal static object smethod_78(Class9.Class24 class24_0, Class9.Class22 class22_0)
		{
			return class24_0.method_15(class22_0);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_79(Class9.Class20 class20_0)
		{
			return class20_0.method_0();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_80(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_4(class20_1);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003D00 File Offset: 0x00001F00
		internal static bool smethod_81(Class9.Class20 class20_0)
		{
			return class20_0.method_3();
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_82(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_5(class20_1);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_83(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_8();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003D25 File Offset: 0x00001F25
		internal static bool smethod_84(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_78(class20_0);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003D34 File Offset: 0x00001F34
		internal static bool smethod_85(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_80(class20_0);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003D43 File Offset: 0x00001F43
		internal static bool smethod_86(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_73(class20_0);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003D52 File Offset: 0x00001F52
		internal static bool smethod_87(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_74(class20_0);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003D61 File Offset: 0x00001F61
		internal static bool smethod_88(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_75(class20_0);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003D70 File Offset: 0x00001F70
		internal static bool smethod_89(Class9.Class21 class21_0, Class9.Class20 class20_0)
		{
			return class21_0.vmethod_76(class20_0);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_90()
		{
		}

		// Token: 0x0400007B RID: 123
		public Class9.Struct1 struct1_0;

		// Token: 0x0400007C RID: 124
		public Class9.Enum2 enum2_0;
	}

	// Token: 0x0200002B RID: 43
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct2
	{
		// Token: 0x0400007D RID: 125
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x0400007E RID: 126
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x0400007F RID: 127
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000080 RID: 128
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000081 RID: 129
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000082 RID: 130
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x04000083 RID: 131
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x04000084 RID: 132
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x0200002C RID: 44
	private class Class23 : Class9.Class21
	{
		// Token: 0x06000380 RID: 896 RVA: 0x00012144 File Offset: 0x00010344
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			this.struct2_0 = ((Class9.Class23)class20_0).struct2_0;
			this.enum2_0 = ((Class9.Class23)class20_0).enum2_0;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_9(class20_0);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00012174 File Offset: 0x00010374
		public Class23(long long_0)
		{
			this.enum5_0 = (Class9.Enum5)2;
			this.struct2_0.long_0 = long_0;
			this.enum2_0 = (Class9.Enum2)7;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000121A4 File Offset: 0x000103A4
		public Class23(Class9.Class23 class23_0)
		{
			this.enum5_0 = class23_0.enum5_0;
			this.struct2_0.long_0 = class23_0.struct2_0.long_0;
			this.enum2_0 = class23_0.enum2_0;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00003D7F File Offset: 0x00001F7F
		public override Class9.Class21 vmethod_69()
		{
			return new Class9.Class23(this);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000121E8 File Offset: 0x000103E8
		public Class23(long long_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)2;
			this.struct2_0.long_0 = long_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00012218 File Offset: 0x00010418
		public Class23(ulong ulong_0)
		{
			this.enum5_0 = (Class9.Enum5)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum2_0 = (Class9.Enum2)8;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00012248 File Offset: 0x00010448
		public Class23(ulong ulong_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00012278 File Offset: 0x00010478
		public override bool vmethod_10()
		{
			if (this.enum2_0 == (Class9.Enum2)7)
			{
				return this.struct2_0.long_0 == 0L;
			}
			return this.struct2_0.ulong_0 == 0UL;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000037E0 File Offset: 0x000019E0
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000122BC File Offset: 0x000104BC
		public override Class9.Class20 vmethod_11(Class9.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class9.Enum2)1:
				return this.vmethod_13();
			case (Class9.Enum2)2:
				return this.vmethod_14();
			case (Class9.Enum2)3:
				return this.vmethod_15();
			case (Class9.Enum2)4:
				return this.vmethod_16();
			case (Class9.Enum2)5:
				return this.vmethod_17();
			case (Class9.Enum2)6:
				return this.vmethod_18();
			case (Class9.Enum2)7:
				return this.vmethod_19();
			case (Class9.Enum2)8:
				return this.vmethod_20();
			case (Class9.Enum2)11:
				return this.vmethod_12();
			case (Class9.Enum2)15:
				return this.method_7();
			case (Class9.Enum2)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class9.Enum6)4).ToString());
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00012378 File Offset: 0x00010578
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum2_0)
				{
				case (Class9.Enum2)1:
					return this.struct2_0.sbyte_0;
				case (Class9.Enum2)2:
					return this.struct2_0.byte_0;
				case (Class9.Enum2)3:
					return this.struct2_0.short_0;
				case (Class9.Enum2)4:
					return this.struct2_0.ushort_0;
				case (Class9.Enum2)5:
					return this.struct2_0.int_0;
				case (Class9.Enum2)6:
					return this.struct2_0.uint_0;
				case (Class9.Enum2)7:
					return this.struct2_0.long_0;
				case (Class9.Enum2)8:
					return this.struct2_0.ulong_0;
				case (Class9.Enum2)11:
					return this.yQwppAuByG();
				case (Class9.Enum2)15:
					return (char)this.struct2_0.int_0;
				}
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct2_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct2_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct2_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct2_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct2_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct2_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct2_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct2_0.long_0;
			}
			if (type_0.IsEnum)
			{
				return this.method_6(type_0);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00012644 File Offset: 0x00010844
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct2_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct2_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct2_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct2_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct2_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct2_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct2_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct2_0.ulong_0);
			}
			if (!(underlyingType == typeof(char)))
			{
				return Enum.ToObject(type_0, this.struct2_0.long_0);
			}
			return Enum.ToObject(type_0, (ushort)this.struct2_0.int_0);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001131C File Offset: 0x0000F51C
		public override Class9.Class22 vmethod_12()
		{
			return new Class9.Class22(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000037EB File Offset: 0x000019EB
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00003D87 File Offset: 0x00001F87
		public Class9.Class22 method_7()
		{
			return new Class9.Class22((int)this.struct2_0.sbyte_0, (Class9.Enum2)15);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00003D9B File Offset: 0x00001F9B
		public override Class9.Class22 vmethod_13()
		{
			return new Class9.Class22((int)this.struct2_0.sbyte_0, (Class9.Enum2)1);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00003DAE File Offset: 0x00001FAE
		public override Class9.Class22 vmethod_14()
		{
			return new Class9.Class22((uint)this.struct2_0.byte_0, (Class9.Enum2)2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003DC1 File Offset: 0x00001FC1
		public override Class9.Class22 vmethod_15()
		{
			return new Class9.Class22((int)this.struct2_0.short_0, (Class9.Enum2)3);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public override Class9.Class22 vmethod_16()
		{
			return new Class9.Class22((uint)this.struct2_0.ushort_0, (Class9.Enum2)4);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00003DE7 File Offset: 0x00001FE7
		public override Class9.Class22 vmethod_17()
		{
			return new Class9.Class22(this.struct2_0.int_0, (Class9.Enum2)5);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00003DFA File Offset: 0x00001FFA
		public override Class9.Class22 vmethod_18()
		{
			return new Class9.Class22(this.struct2_0.uint_0, (Class9.Enum2)6);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003E0D File Offset: 0x0000200D
		public override Class9.Class23 vmethod_19()
		{
			return new Class9.Class23(this.struct2_0.long_0, (Class9.Enum2)7);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003E20 File Offset: 0x00002020
		public override Class9.Class23 vmethod_20()
		{
			return new Class9.Class23(this.struct2_0.ulong_0, (Class9.Enum2)8);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000038A1 File Offset: 0x00001AA1
		public override Class9.Class22 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000038A9 File Offset: 0x00001AA9
		public override Class9.Class22 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000038B1 File Offset: 0x00001AB1
		public override Class9.Class22 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000038B9 File Offset: 0x00001AB9
		public override Class9.Class23 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000038C1 File Offset: 0x00001AC1
		public override Class9.Class22 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000038C9 File Offset: 0x00001AC9
		public override Class9.Class22 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000038D1 File Offset: 0x00001AD1
		public override Class9.Class22 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000038D9 File Offset: 0x00001AD9
		public override Class9.Class23 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00003E33 File Offset: 0x00002033
		public override Class9.Class22 vmethod_29()
		{
			return new Class9.Class22((int)(checked((sbyte)this.struct2_0.long_0)), (Class9.Enum2)1);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00003E47 File Offset: 0x00002047
		public override Class9.Class22 vmethod_30()
		{
			return new Class9.Class22((int)(checked((sbyte)this.struct2_0.ulong_0)), (Class9.Enum2)1);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00003E5B File Offset: 0x0000205B
		public override Class9.Class22 vmethod_31()
		{
			return new Class9.Class22((int)(checked((short)this.struct2_0.long_0)), (Class9.Enum2)3);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00003E6F File Offset: 0x0000206F
		public override Class9.Class22 vmethod_32()
		{
			return new Class9.Class22((int)(checked((short)this.struct2_0.ulong_0)), (Class9.Enum2)3);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003E83 File Offset: 0x00002083
		public override Class9.Class22 vmethod_33()
		{
			return new Class9.Class22(checked((int)this.struct2_0.long_0), (Class9.Enum2)5);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00003E97 File Offset: 0x00002097
		public override Class9.Class22 vmethod_34()
		{
			return new Class9.Class22(checked((int)this.struct2_0.ulong_0), (Class9.Enum2)5);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00003E0D File Offset: 0x0000200D
		public override Class9.Class23 vmethod_35()
		{
			return new Class9.Class23(this.struct2_0.long_0, (Class9.Enum2)7);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00003EAB File Offset: 0x000020AB
		public override Class9.Class23 vmethod_36()
		{
			return new Class9.Class23(checked((long)this.struct2_0.ulong_0), (Class9.Enum2)7);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003EBF File Offset: 0x000020BF
		public override Class9.Class22 vmethod_37()
		{
			return new Class9.Class22((int)(checked((byte)this.struct2_0.long_0)), (Class9.Enum2)2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003ED3 File Offset: 0x000020D3
		public override Class9.Class22 vmethod_38()
		{
			return new Class9.Class22((int)(checked((byte)this.struct2_0.ulong_0)), (Class9.Enum2)2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003EE7 File Offset: 0x000020E7
		public override Class9.Class22 vmethod_39()
		{
			return new Class9.Class22((int)(checked((ushort)this.struct2_0.long_0)), (Class9.Enum2)4);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003EFB File Offset: 0x000020FB
		public override Class9.Class22 vmethod_40()
		{
			return new Class9.Class22((int)(checked((ushort)this.struct2_0.ulong_0)), (Class9.Enum2)4);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003F0F File Offset: 0x0000210F
		public override Class9.Class22 vmethod_41()
		{
			return new Class9.Class22(checked((uint)this.struct2_0.long_0), (Class9.Enum2)6);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003F23 File Offset: 0x00002123
		public override Class9.Class22 vmethod_42()
		{
			return new Class9.Class22(checked((uint)this.struct2_0.ulong_0), (Class9.Enum2)6);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003F37 File Offset: 0x00002137
		public override Class9.Class23 vmethod_43()
		{
			return new Class9.Class23(checked((ulong)this.struct2_0.long_0), (Class9.Enum2)8);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003E20 File Offset: 0x00002020
		public override Class9.Class23 vmethod_44()
		{
			return new Class9.Class23(this.struct2_0.ulong_0, (Class9.Enum2)8);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003F4B File Offset: 0x0000214B
		public override Class9.Class25 vmethod_45()
		{
			return new Class9.Class25((float)this.struct2_0.long_0);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003F5E File Offset: 0x0000215E
		public override Class9.Class25 vmethod_46()
		{
			return new Class9.Class25((double)this.struct2_0.long_0);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003F71 File Offset: 0x00002171
		public override Class9.Class25 zLqpmHyYrP()
		{
			return new Class9.Class25(this.struct2_0.ulong_0);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001133C File Offset: 0x0000F53C
		public override Class9.Class24 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_24().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00011380 File Offset: 0x0000F580
		public override Class9.Class24 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public override Class9.Class24 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_35().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00011408 File Offset: 0x0000F608
		public override Class9.Class24 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001144C File Offset: 0x0000F64C
		public override Class9.Class24 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_36().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000127C4 File Offset: 0x000109C4
		public override Class9.Class24 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)(checked((uint)this.struct2_0.ulong_0)));
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00003F85 File Offset: 0x00002185
		public override Class9.Class20 vmethod_53()
		{
			return new Class9.Class23(-this.struct2_0.long_0);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000127FC File Offset: 0x000109FC
		public override Class9.Class20 Add(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 + ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00012848 File Offset: 0x00010A48
		public override Class9.Class20 vmethod_54(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.long_0 + ((Class9.Class23)class20_0).struct2_0.long_0));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00012894 File Offset: 0x00010A94
		public override Class9.Class20 vmethod_55(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.ulong_0 + ((Class9.Class23)class20_0).struct2_0.ulong_0));
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000128E0 File Offset: 0x00010AE0
		public override Class9.Class20 vmethod_56(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 - ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0001292C File Offset: 0x00010B2C
		public override Class9.Class20 vmethod_57(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.long_0 - ((Class9.Class23)class20_0).struct2_0.long_0));
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00012978 File Offset: 0x00010B78
		public override Class9.Class20 vmethod_58(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.ulong_0 - ((Class9.Class23)class20_0).struct2_0.ulong_0));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000129C4 File Offset: 0x00010BC4
		public override Class9.Class20 vmethod_59(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 * ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00012A10 File Offset: 0x00010C10
		public override Class9.Class20 vmethod_60(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.long_0 * ((Class9.Class23)class20_0).struct2_0.long_0));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00012A5C File Offset: 0x00010C5C
		public override Class9.Class20 vmethod_61(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(checked(this.struct2_0.ulong_0 * ((Class9.Class23)class20_0).struct2_0.ulong_0));
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00012AA8 File Offset: 0x00010CA8
		public override Class9.Class20 vmethod_62(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 / ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00012AF4 File Offset: 0x00010CF4
		public override Class9.Class20 vmethod_63(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.ulong_0 / ((Class9.Class23)class20_0).struct2_0.ulong_0);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00012B40 File Offset: 0x00010D40
		public override Class9.Class20 vmethod_64(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 % ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00012B8C File Offset: 0x00010D8C
		public override Class9.Class20 vmethod_65(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.ulong_0 % ((Class9.Class23)class20_0).struct2_0.ulong_0);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00012BD8 File Offset: 0x00010DD8
		public override Class9.Class20 vmethod_66(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 & ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00012C24 File Offset: 0x00010E24
		public override Class9.Class20 vmethod_67(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 | ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00003F98 File Offset: 0x00002198
		public override Class9.Class20 vmethod_68()
		{
			return new Class9.Class23(~this.struct2_0.long_0);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00012C70 File Offset: 0x00010E70
		public override Class9.Class20 igEvpBpxrl(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 ^ ((Class9.Class23)class20_0).struct2_0.long_0);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00012CBC File Offset: 0x00010EBC
		public override Class9.Class20 vmethod_70(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_3())
			{
				return new Class9.Class23(this.struct2_0.long_0 << ((Class9.Class23)class20_0).struct2_0.int_0);
			}
			if (class20_0.vmethod_2())
			{
				return new Class9.Class23(this.struct2_0.long_0 << ((Class9.Class21)class20_0).vmethod_17().struct1_0.int_0);
			}
			throw new Class9.Exception1();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00012D40 File Offset: 0x00010F40
		public override Class9.Class20 vmethod_71(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_3())
			{
				return new Class9.Class23(this.struct2_0.long_0 >> ((Class9.Class23)class20_0).struct2_0.int_0);
			}
			if (!class20_0.vmethod_2())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.long_0 >> ((Class9.Class21)class20_0).vmethod_17().struct1_0.int_0);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00012DC4 File Offset: 0x00010FC4
		public override Class9.Class20 vmethod_72(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_3())
			{
				return new Class9.Class23(this.struct2_0.ulong_0 >> ((Class9.Class23)class20_0).struct2_0.int_0);
			}
			if (!class20_0.vmethod_2())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class23(this.struct2_0.ulong_0 >> ((Class9.Class21)class20_0).vmethod_17().struct1_0.int_0);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00012E48 File Offset: 0x00011048
		public override string ToString()
		{
			if (this.enum2_0 == (Class9.Enum2)7)
			{
				return this.struct2_0.long_0.ToString();
			}
			return this.struct2_0.ulong_0.ToString();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003A1E File Offset: 0x00001C1E
		internal override Class9.Class20 vmethod_7()
		{
			return this;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00012E80 File Offset: 0x00011080
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return ((Class9.Class32)class20_0).vmethod_4(this);
			}
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_4(this);
			}
			Class9.Class20 @class = class20_0.vmethod_7();
			return @class.method_3() && this.struct2_0.long_0 == ((Class9.Class23)@class).struct2_0.long_0;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00011D90 File Offset: 0x0000FF90
		private static Class9.Class21 smethod_24(Class9.Class20 class20_0)
		{
			Class9.Class21 @class = class20_0 as Class9.Class21;
			if (@class == null && class20_0.iFavIhWly7())
			{
				@class = (class20_0.vmethod_7() as Class9.Class21);
			}
			return @class;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00012EE8 File Offset: 0x000110E8
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (!class20_0.iFavIhWly7())
			{
				Class9.Class20 @class = class20_0.vmethod_7();
				return @class.method_3() && this.struct2_0.ulong_0 != ((Class9.Class23)@class).struct2_0.ulong_0;
			}
			return ((Class9.Class26)class20_0).vmethod_5(this);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00012F48 File Offset: 0x00011148
		public override bool vmethod_73(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.long_0 >= ((Class9.Class23)class20_0).struct2_0.long_0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00012F94 File Offset: 0x00011194
		public override bool vmethod_74(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.ulong_0 >= ((Class9.Class23)class20_0).struct2_0.ulong_0;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00012FE0 File Offset: 0x000111E0
		public override bool vmethod_75(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.long_0 > ((Class9.Class23)class20_0).struct2_0.long_0;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00013028 File Offset: 0x00011228
		public override bool vmethod_76(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.ulong_0 > ((Class9.Class23)class20_0).struct2_0.ulong_0;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00013070 File Offset: 0x00011270
		public override bool vmethod_77(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.long_0 <= ((Class9.Class23)class20_0).struct2_0.long_0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000130BC File Offset: 0x000112BC
		public override bool vmethod_78(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.ulong_0 <= ((Class9.Class23)class20_0).struct2_0.ulong_0;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00013108 File Offset: 0x00011308
		public override bool vmethod_79(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.long_0 < ((Class9.Class23)class20_0).struct2_0.long_0;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00013150 File Offset: 0x00011350
		public override bool vmethod_80(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_3())
			{
				throw new Class9.Exception1();
			}
			return this.struct2_0.ulong_0 < ((Class9.Class23)class20_0).struct2_0.ulong_0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void smethod_25(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			class20_0.vmethod_9(class20_1);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_26()
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_27()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00003A21 File Offset: 0x00001C21
		internal static bool smethod_28(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_10();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003FBA File Offset: 0x000021BA
		internal static object smethod_29(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_19();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00003B6F File Offset: 0x00001D6F
		internal static object smethod_30(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_20();
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003A42 File Offset: 0x00001C42
		internal static object smethod_31(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_12();
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003A4D File Offset: 0x00001C4D
		internal static object smethod_32(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_13();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003A58 File Offset: 0x00001C58
		internal static object smethod_33(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_14();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003FC5 File Offset: 0x000021C5
		internal static object smethod_34(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_15();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00003A63 File Offset: 0x00001C63
		internal static object smethod_35(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_16();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003A37 File Offset: 0x00001C37
		internal static object smethod_36(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_18();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003FD0 File Offset: 0x000021D0
		internal static object smethod_37(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_69();
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_38(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_39(object object_0, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_0, delegate202_0);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_40(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_41(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003AC1 File Offset: 0x00001CC1
		internal static bool smethod_42(Class9.Class21 class21_0)
		{
			return class21_0.yQwppAuByG();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003ACC File Offset: 0x00001CCC
		internal static bool smethod_43(object object_0, Delegate222 delegate222_0)
		{
			return Delegate222.smethod_0(object_0, delegate222_0);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003ADB File Offset: 0x00001CDB
		internal static Type smethod_44(Type type_0, Delegate223 delegate223_0)
		{
			return Delegate223.smethod_0(type_0, delegate223_0);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003AEA File Offset: 0x00001CEA
		internal static object smethod_45(Type type_0, int int_0, Delegate224 delegate224_0)
		{
			return Delegate224.smethod_0(type_0, int_0, delegate224_0);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003AFD File Offset: 0x00001CFD
		internal static object smethod_46(Type type_0, uint uint_0, Delegate225 delegate225_0)
		{
			return Delegate225.smethod_0(type_0, uint_0, delegate225_0);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003FDB File Offset: 0x000021DB
		internal static object smethod_47(Type type_0, short short_0, Delegate226 delegate226_0)
		{
			return Delegate226.smethod_0(type_0, short_0, delegate226_0);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003B10 File Offset: 0x00001D10
		internal static object smethod_48(Type type_0, ushort ushort_0, Delegate227 delegate227_0)
		{
			return Delegate227.smethod_0(type_0, ushort_0, delegate227_0);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003B23 File Offset: 0x00001D23
		internal static object smethod_49(Type type_0, byte byte_0, Delegate228 delegate228_0)
		{
			return Delegate228.smethod_0(type_0, byte_0, delegate228_0);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003B49 File Offset: 0x00001D49
		internal static object smethod_50(Type type_0, long long_0, Delegate230 delegate230_0)
		{
			return Delegate230.smethod_0(type_0, long_0, delegate230_0);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003B5C File Offset: 0x00001D5C
		internal static object smethod_51(Type type_0, ulong ulong_0, Delegate231 delegate231_0)
		{
			return Delegate231.smethod_0(type_0, ulong_0, delegate231_0);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003A2C File Offset: 0x00001C2C
		internal static object smethod_52(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_17();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003B7A File Offset: 0x00001D7A
		internal static int smethod_53(Delegate232 delegate232_0)
		{
			return delegate232_0();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003FEE File Offset: 0x000021EE
		internal static object smethod_54(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_24();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003FF9 File Offset: 0x000021F9
		internal static object smethod_55(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_23();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003B85 File Offset: 0x00001D85
		internal static object smethod_56(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_28();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003B90 File Offset: 0x00001D90
		internal static object smethod_57(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_27();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003B9B File Offset: 0x00001D9B
		internal static object smethod_58(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_35();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003BA6 File Offset: 0x00001DA6
		internal static object smethod_59(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_33();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004004 File Offset: 0x00002204
		internal static object smethod_60(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_43();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003BB1 File Offset: 0x00001DB1
		internal static object smethod_61(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_41();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003BBC File Offset: 0x00001DBC
		internal static object smethod_62(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_36();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_63(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_64(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003D00 File Offset: 0x00001F00
		internal static bool smethod_65(Class9.Class20 class20_0)
		{
			return class20_0.method_3();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000400F File Offset: 0x0000220F
		internal static bool smethod_66(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_2();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_67(Class9.Class20 class20_0)
		{
			return class20_0.method_0();
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_68(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_4(class20_1);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_69(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_5(class20_1);
		}

		// Token: 0x04000085 RID: 133
		public Class9.Struct2 struct2_0;

		// Token: 0x04000086 RID: 134
		public Class9.Enum2 enum2_0;
	}

	// Token: 0x0200002D RID: 45
	private class Class24 : Class9.Class21
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x00013198 File Offset: 0x00011398
		internal void method_6(Class9.Class20 class20_0)
		{
			if (!class20_0.method_2())
			{
				this.vmethod_9(class20_0);
				return;
			}
			this.object_0 = ((Class9.Class24)class20_0).object_0;
			this.enum2_0 = ((Class9.Class24)class20_0).enum2_0;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000131D8 File Offset: 0x000113D8
		internal unsafe override void vmethod_9(Class9.Class20 class20_0)
		{
			if (class20_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class9.Class23)this.object_0).struct2_0.long_0);
					IntPtr intPtr = new IntPtr(((Class9.Class23)((Class9.Class24)class20_0).object_0).struct2_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class9.Class22)this.object_0).struct1_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class9.Class22)((Class9.Class24)class20_0).object_0).struct1_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class20_0.vmethod_3(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class9.Class23)this.object_0).struct2_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class9.Class22)this.object_0).struct1_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (type == typeof(char))
				{
					*(short*)((void*)value3) = (short)((char)obj);
					return;
				}
				throw new Class9.Exception1();
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_9(class20_0);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00013500 File Offset: 0x00011700
		public Class24(IntPtr intptr_0)
		{
			this.enum5_0 = (Class9.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(intptr_0.ToInt64());
				this.enum2_0 = (Class9.Enum2)12;
				return;
			}
			this.object_0 = new Class9.Class22(intptr_0.ToInt32());
			this.enum2_0 = (Class9.Enum2)12;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00013558 File Offset: 0x00011758
		public Class24(UIntPtr uintptr_0)
		{
			this.enum5_0 = (Class9.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(uintptr_0.ToUInt64());
				this.enum2_0 = (Class9.Enum2)12;
				return;
			}
			this.object_0 = new Class9.Class22(uintptr_0.ToUInt32());
			this.enum2_0 = (Class9.Enum2)12;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000135B0 File Offset: 0x000117B0
		public Class24()
		{
			this.enum5_0 = (Class9.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(0L);
				this.enum2_0 = (Class9.Enum2)12;
				return;
			}
			this.object_0 = new Class9.Class22(0);
			this.enum2_0 = (Class9.Enum2)12;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000401A File Offset: 0x0000221A
		public override Class9.Class21 vmethod_69()
		{
			return new Class9.Class24
			{
				object_0 = this.object_0.vmethod_69(),
				enum2_0 = this.enum2_0
			};
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00013604 File Offset: 0x00011804
		public Class24(long long_0)
		{
			this.enum5_0 = (Class9.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(long_0);
				this.enum2_0 = (Class9.Enum2)12;
				return;
			}
			this.object_0 = new Class9.Class22((int)long_0);
			this.enum2_0 = (Class9.Enum2)12;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00013650 File Offset: 0x00011850
		public Class24(long long_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(long_0);
				this.enum2_0 = enum2_1;
				return;
			}
			this.object_0 = new Class9.Class22((int)long_0);
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001369C File Offset: 0x0001189C
		public Class24(ulong ulong_0)
		{
			this.enum5_0 = (Class9.Enum5)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(ulong_0);
				this.enum2_0 = (Class9.Enum2)13;
				return;
			}
			this.object_0 = new Class9.Class22((uint)ulong_0);
			this.enum2_0 = (Class9.Enum2)13;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000136E8 File Offset: 0x000118E8
		public Class24(ulong ulong_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class9.Class23(ulong_0);
				this.enum2_0 = enum2_1;
				return;
			}
			this.object_0 = new Class9.Class22((uint)ulong_0);
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000403E File Offset: 0x0000223E
		public override bool vmethod_10()
		{
			return this.object_0.vmethod_10();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000037E0 File Offset: 0x000019E0
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000037EB File Offset: 0x000019EB
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00013734 File Offset: 0x00011934
		public override Class9.Class20 vmethod_11(Class9.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class9.Enum2)1:
				return this.vmethod_13();
			case (Class9.Enum2)2:
				return this.vmethod_14();
			case (Class9.Enum2)3:
				return this.vmethod_15();
			case (Class9.Enum2)4:
				return this.vmethod_16();
			case (Class9.Enum2)5:
				return this.vmethod_17();
			case (Class9.Enum2)6:
				return this.vmethod_18();
			case (Class9.Enum2)7:
				return this.vmethod_19();
			case (Class9.Enum2)8:
				return this.vmethod_20();
			case (Class9.Enum2)11:
				return this.vmethod_12();
			case (Class9.Enum2)12:
				return this;
			case (Class9.Enum2)13:
				return this;
			case (Class9.Enum2)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class9.Enum6)4).ToString());
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000137EC File Offset: 0x000119EC
		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class9.Class23)this.object_0).struct2_0.long_0);
			}
			return new IntPtr(((Class9.Class22)this.object_0).struct1_0.int_0);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00013838 File Offset: 0x00011A38
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(type_0 == typeof(IntPtr)))
			{
				if (!(type_0 == typeof(UIntPtr)))
				{
					if (!(type_0 == null) && !(type_0 == typeof(object)))
					{
						throw new Class9.Exception1();
					}
					if (IntPtr.Size == 8)
					{
						if (this.enum2_0 == (Class9.Enum2)12)
						{
							return new IntPtr(((Class9.Class23)this.object_0).struct2_0.long_0);
						}
						return new UIntPtr(((Class9.Class23)this.object_0).struct2_0.ulong_0);
					}
					else
					{
						if (this.enum2_0 == (Class9.Enum2)12)
						{
							return new IntPtr(((Class9.Class23)this.object_0).struct2_0.int_0);
						}
						return new UIntPtr(((Class9.Class22)this.object_0).struct1_0.uint_0);
					}
				}
				else
				{
					if (IntPtr.Size == 8)
					{
						return new UIntPtr(((Class9.Class23)this.object_0).struct2_0.ulong_0);
					}
					return new UIntPtr(((Class9.Class22)this.object_0).struct1_0.uint_0);
				}
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class9.Class23)this.object_0).struct2_0.long_0);
				}
				return new IntPtr(((Class9.Class22)this.object_0).struct1_0.int_0);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000404B File Offset: 0x0000224B
		public override Class9.Class22 vmethod_12()
		{
			return this.object_0.vmethod_12();
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00004058 File Offset: 0x00002258
		public override Class9.Class22 vmethod_13()
		{
			return this.object_0.vmethod_13();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004065 File Offset: 0x00002265
		public override Class9.Class22 vmethod_14()
		{
			return this.object_0.vmethod_14();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004072 File Offset: 0x00002272
		public override Class9.Class22 vmethod_15()
		{
			return this.object_0.vmethod_15();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000407F File Offset: 0x0000227F
		public override Class9.Class22 vmethod_16()
		{
			return this.object_0.vmethod_16();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000408C File Offset: 0x0000228C
		public override Class9.Class22 vmethod_17()
		{
			return this.object_0.vmethod_17();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00004099 File Offset: 0x00002299
		public override Class9.Class22 vmethod_18()
		{
			return this.object_0.vmethod_18();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000040A6 File Offset: 0x000022A6
		public override Class9.Class23 vmethod_19()
		{
			return this.object_0.vmethod_19();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000040B3 File Offset: 0x000022B3
		public override Class9.Class23 vmethod_20()
		{
			return this.object_0.vmethod_20();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000038A1 File Offset: 0x00001AA1
		public override Class9.Class22 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000038A9 File Offset: 0x00001AA9
		public override Class9.Class22 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000038B1 File Offset: 0x00001AB1
		public override Class9.Class22 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000038B9 File Offset: 0x00001AB9
		public override Class9.Class23 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000038C1 File Offset: 0x00001AC1
		public override Class9.Class22 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000038C9 File Offset: 0x00001AC9
		public override Class9.Class22 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000038D1 File Offset: 0x00001AD1
		public override Class9.Class22 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000038D9 File Offset: 0x00001AD9
		public override Class9.Class23 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000040C0 File Offset: 0x000022C0
		public override Class9.Class22 vmethod_29()
		{
			return this.object_0.vmethod_29();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000040CD File Offset: 0x000022CD
		public override Class9.Class22 vmethod_30()
		{
			return this.object_0.vmethod_30();
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000040DA File Offset: 0x000022DA
		public override Class9.Class22 vmethod_31()
		{
			return this.object_0.vmethod_31();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000040E7 File Offset: 0x000022E7
		public override Class9.Class22 vmethod_32()
		{
			return this.object_0.vmethod_32();
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000040F4 File Offset: 0x000022F4
		public override Class9.Class22 vmethod_33()
		{
			return this.object_0.vmethod_33();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00004101 File Offset: 0x00002301
		public override Class9.Class22 vmethod_34()
		{
			return this.object_0.vmethod_34();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000410E File Offset: 0x0000230E
		public override Class9.Class23 vmethod_35()
		{
			return this.object_0.vmethod_35();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000411B File Offset: 0x0000231B
		public override Class9.Class23 vmethod_36()
		{
			return this.object_0.vmethod_36();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00004128 File Offset: 0x00002328
		public override Class9.Class22 vmethod_37()
		{
			return this.object_0.vmethod_37();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00004135 File Offset: 0x00002335
		public override Class9.Class22 vmethod_38()
		{
			return this.object_0.vmethod_38();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00004142 File Offset: 0x00002342
		public override Class9.Class22 vmethod_39()
		{
			return this.object_0.vmethod_39();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000414F File Offset: 0x0000234F
		public override Class9.Class22 vmethod_40()
		{
			return this.object_0.vmethod_40();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000415C File Offset: 0x0000235C
		public override Class9.Class22 vmethod_41()
		{
			return this.object_0.vmethod_41();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00004169 File Offset: 0x00002369
		public override Class9.Class22 vmethod_42()
		{
			return this.object_0.vmethod_42();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004176 File Offset: 0x00002376
		public override Class9.Class23 vmethod_43()
		{
			return this.object_0.vmethod_43();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004183 File Offset: 0x00002383
		public override Class9.Class23 vmethod_44()
		{
			return this.object_0.vmethod_44();
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004190 File Offset: 0x00002390
		public override Class9.Class25 vmethod_45()
		{
			return this.object_0.vmethod_45();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000419D File Offset: 0x0000239D
		public override Class9.Class25 vmethod_46()
		{
			return this.object_0.vmethod_46();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000041AA File Offset: 0x000023AA
		public override Class9.Class25 zLqpmHyYrP()
		{
			return this.object_0.zLqpmHyYrP();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001133C File Offset: 0x0000F53C
		public override Class9.Class24 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_24().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00011380 File Offset: 0x0000F580
		public override Class9.Class24 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public override Class9.Class24 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_35().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00011408 File Offset: 0x0000F608
		public override Class9.Class24 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001144C File Offset: 0x0000F64C
		public override Class9.Class24 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_36().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00011490 File Offset: 0x0000F690
		public override Class9.Class24 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000139D4 File Offset: 0x00011BD4
		public override Class9.Class20 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(-((Class9.Class23)this.object_0).struct2_0.long_0);
			}
			return new Class9.Class24((long)(-(long)((Class9.Class22)this.object_0).struct1_0.int_0));
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00013A24 File Offset: 0x00011C24
		public override Class9.Class20 Add(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 + ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 + ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 + ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 + ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00013B14 File Offset: 0x00011D14
		public override Class9.Class20 vmethod_54(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 + ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 + ((Class9.Class22)class20_0).struct1_0.int_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 + ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 + ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00013C04 File Offset: 0x00011E04
		public override Class9.Class20 vmethod_55(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 + ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class9.Class24((ulong)(checked(this.vmethod_17().struct1_0.uint_0 + ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 + unchecked((ulong)((Class9.Class22)class20_0).struct1_0.uint_0)));
				}
				return new Class9.Class24((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 + ((Class9.Class22)class20_0).struct1_0.uint_0))));
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00013CF0 File Offset: 0x00011EF0
		public override Class9.Class20 vmethod_56(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 - ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 - ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 - ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 - ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public Class9.Class20 method_8(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class22)class20_0).struct1_0.int_0 - this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0 - this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00013ED0 File Offset: 0x000120D0
		public override Class9.Class20 vmethod_57(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 - ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 - ((Class9.Class22)class20_0).struct1_0.int_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 - ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 - ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00013FC0 File Offset: 0x000121C0
		public Class9.Class20 method_9(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0 - this.vmethod_17().struct1_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0 - this.vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(((Class9.Class22)class20_0).struct1_0.int_0 - this.vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000140B0 File Offset: 0x000122B0
		public override Class9.Class20 vmethod_58(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 - ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class9.Class24((ulong)(checked(this.vmethod_17().struct1_0.uint_0 - ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 - unchecked((ulong)((Class9.Class22)class20_0).struct1_0.uint_0)));
				}
				return new Class9.Class24((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 - ((Class9.Class22)class20_0).struct1_0.uint_0))));
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001419C File Offset: 0x0001239C
		public Class9.Class20 method_10(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0 - this.vmethod_19().struct2_0.ulong_0));
				}
				return new Class9.Class24((ulong)(checked(((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0 - this.vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(unchecked((ulong)((Class9.Class22)class20_0).struct1_0.uint_0) - this.vmethod_19().struct2_0.ulong_0));
				}
				return new Class9.Class24((long)((ulong)(checked(((Class9.Class22)class20_0).struct1_0.uint_0 - this.vmethod_17().struct1_0.uint_0))));
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00014288 File Offset: 0x00012488
		public override Class9.Class20 vmethod_59(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 * ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 * ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 * ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 * ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00014378 File Offset: 0x00012578
		public override Class9.Class20 vmethod_60(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 * ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 * ((Class9.Class22)class20_0).struct1_0.int_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.long_0 * ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0));
				}
				return new Class9.Class24((long)(checked(this.vmethod_17().struct1_0.int_0 * ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00014468 File Offset: 0x00012668
		public override Class9.Class20 vmethod_61(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 * unchecked((ulong)((Class9.Class22)class20_0).struct1_0.uint_0)));
				}
				return new Class9.Class24((long)((ulong)(checked(this.vmethod_17().struct1_0.uint_0 * ((Class9.Class22)class20_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(checked(this.vmethod_19().struct2_0.ulong_0 * ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0));
				}
				return new Class9.Class24((ulong)(checked(this.vmethod_17().struct1_0.uint_0 * ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0)));
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00014554 File Offset: 0x00012754
		public override Class9.Class20 vmethod_62(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 / ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 / ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 / ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 / ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00014644 File Offset: 0x00012844
		public Class9.Class20 method_11(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0 / this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0 / this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0 / this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class22)class20_0).struct1_0.int_0 / this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00014734 File Offset: 0x00012934
		public override Class9.Class20 vmethod_63(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 / ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((long)((ulong)(this.vmethod_17().struct1_0.uint_0 / ((Class9.Class22)class20_0).struct1_0.uint_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 / ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((ulong)(this.vmethod_17().struct1_0.uint_0 / ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0));
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00014824 File Offset: 0x00012A24
		public Class9.Class20 method_12(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0 / this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((long)((ulong)(((Class9.Class22)class20_0).struct1_0.uint_0 / this.vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0 / this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((ulong)(((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0 / this.vmethod_17().struct1_0.uint_0));
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00014914 File Offset: 0x00012B14
		public override Class9.Class20 vmethod_64(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 % ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 % ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 % ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 % ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00014A04 File Offset: 0x00012C04
		public Class9.Class20 method_13(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0 % this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class22)class20_0).struct1_0.int_0 % this.vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0 % this.vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0 % this.vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00014AF4 File Offset: 0x00012CF4
		public override Class9.Class20 vmethod_65(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 % ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((ulong)(this.vmethod_17().struct1_0.uint_0 % ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 % ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((long)((ulong)(this.vmethod_17().struct1_0.uint_0 % ((Class9.Class22)class20_0).struct1_0.uint_0)));
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00014BE4 File Offset: 0x00012DE4
		public Class9.Class20 method_14(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0 % this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((long)((ulong)(((Class9.Class22)class20_0).struct1_0.uint_0 % this.vmethod_17().struct1_0.uint_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0 % this.vmethod_19().struct2_0.ulong_0);
				}
				return new Class9.Class24((ulong)(((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0 % this.vmethod_17().struct1_0.uint_0));
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00014CD4 File Offset: 0x00012ED4
		public override Class9.Class20 vmethod_66(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 & ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 & ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 & ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 & ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00014DC4 File Offset: 0x00012FC4
		public override Class9.Class20 vmethod_67(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 | ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 | ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 | ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 | ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00014EB4 File Offset: 0x000130B4
		public override Class9.Class20 vmethod_68()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(~this.vmethod_19().struct2_0.long_0);
			}
			return new Class9.Class24((long)(~(long)this.vmethod_17().struct1_0.int_0));
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00014EF8 File Offset: 0x000130F8
		public override Class9.Class20 igEvpBpxrl(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 ^ ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 ^ ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 ^ ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 ^ ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00014FE8 File Offset: 0x000131E8
		public override Class9.Class20 vmethod_70(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 << ((Class9.Class24)class20_0).vmethod_19().struct2_0.int_0);
				}
				return new Class9.Class24((long)((long)this.vmethod_17().struct1_0.int_0 << ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 << ((Class9.Class22)class20_0).struct1_0.int_0);
				}
				return new Class9.Class24((long)((long)this.vmethod_17().struct1_0.int_0 << ((Class9.Class22)class20_0).struct1_0.int_0));
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000150E0 File Offset: 0x000132E0
		public override Class9.Class20 vmethod_71(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 >> ((Class9.Class22)class20_0).struct1_0.int_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 >> ((Class9.Class22)class20_0).struct1_0.int_0));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.long_0 >> ((Class9.Class24)class20_0).vmethod_19().struct2_0.int_0);
				}
				return new Class9.Class24((long)(this.vmethod_17().struct1_0.int_0 >> ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0));
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000151D8 File Offset: 0x000133D8
		public override Class9.Class20 vmethod_72(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 >> ((Class9.Class22)class20_0).struct1_0.int_0);
				}
				return new Class9.Class24((long)((ulong)(this.vmethod_17().struct1_0.uint_0 >> ((Class9.Class22)class20_0).struct1_0.int_0)));
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class9.Class24(this.vmethod_19().struct2_0.ulong_0 >> ((Class9.Class24)class20_0).vmethod_19().struct2_0.int_0);
				}
				return new Class9.Class24((long)((ulong)(this.vmethod_17().struct1_0.uint_0 >> ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0)));
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000041B7 File Offset: 0x000023B7
		public Class9.Class20 method_15(Class9.Class22 class22_0)
		{
			return new Class9.Class24((long)((ulong)(class22_0.struct1_0.uint_0 >> this.vmethod_17().struct1_0.int_0)));
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000041DE File Offset: 0x000023DE
		public Class9.Class20 method_16(Class9.Class22 class22_0)
		{
			return new Class9.Class24((long)(class22_0.struct1_0.int_0 >> this.vmethod_19().struct2_0.int_0));
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00004205 File Offset: 0x00002405
		public Class9.Class20 method_17(Class9.Class22 class22_0)
		{
			return new Class9.Class24((long)((long)class22_0.struct1_0.int_0 << this.vmethod_19().struct2_0.int_0));
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000422C File Offset: 0x0000242C
		public override string ToString()
		{
			return this.object_0.ToString();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003A1E File Offset: 0x00001C1E
		internal override Class9.Class20 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000152D0 File Offset: 0x000134D0
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_4(this);
			}
			Class9.Class20 @class = class20_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (!@class.method_1())
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_19().struct2_0.long_0 == ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 == ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 == ((Class9.Class22)class20_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000153AC File Offset: 0x000135AC
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_5(this);
			}
			Class9.Class20 @class = class20_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (!@class.method_1())
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_19().struct2_0.ulong_0 != ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 != ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 != ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001548C File Offset: 0x0001368C
		public override bool vmethod_73(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 >= ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 >= ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 >= ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 >= ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00015578 File Offset: 0x00013778
		public override bool vmethod_74(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 >= ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 >= ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 >= ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 >= ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00015664 File Offset: 0x00013864
		public override bool vmethod_75(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 > ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 > ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 > ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 > ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00015744 File Offset: 0x00013944
		public override bool vmethod_76(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 > ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 > ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 > ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 > ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00015824 File Offset: 0x00013A24
		public override bool vmethod_77(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 <= ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 <= ((Class9.Class22)class20_0).struct1_0.int_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 <= ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 <= ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00015910 File Offset: 0x00013B10
		public override bool vmethod_78(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 <= ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 <= ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 <= ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 <= ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000159FC File Offset: 0x00013BFC
		public override bool vmethod_79(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_1())
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 < ((Class9.Class24)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 < ((Class9.Class24)class20_0).vmethod_17().struct1_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.long_0 < ((Class9.Class22)class20_0).vmethod_19().struct2_0.long_0;
				}
				return this.vmethod_17().struct1_0.int_0 < ((Class9.Class22)class20_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00015ADC File Offset: 0x00013CDC
		public override bool vmethod_80(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (class20_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 < ((Class9.Class22)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 < ((Class9.Class22)class20_0).struct1_0.uint_0;
			}
			else
			{
				if (!class20_0.method_2())
				{
					throw new Class9.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct2_0.ulong_0 < ((Class9.Class24)class20_0).vmethod_19().struct2_0.ulong_0;
				}
				return this.vmethod_17().struct1_0.uint_0 < ((Class9.Class24)class20_0).vmethod_17().struct1_0.uint_0;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00003C09 File Offset: 0x00001E09
		internal static bool smethod_24(Class9.Class20 class20_0)
		{
			return class20_0.method_2();
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003B7A File Offset: 0x00001D7A
		internal static int smethod_25(Delegate232 delegate232_0)
		{
			return delegate232_0();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_26(Class9.Class20 class20_0, Type type_0)
		{
			return class20_0.vmethod_3(type_0);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004248 File Offset: 0x00002448
		internal static Type smethod_27(object object_1, Delegate240 delegate240_0)
		{
			return Delegate240.smethod_0(object_1, delegate240_0);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_28(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_29(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void smethod_30(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			class20_0.vmethod_9(class20_1);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_31()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_32()
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00003FD0 File Offset: 0x000021D0
		internal static object smethod_33(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_69();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00003A21 File Offset: 0x00001C21
		internal static bool smethod_34(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_10();
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00003A4D File Offset: 0x00001C4D
		internal static object smethod_35(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_13();
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00003A63 File Offset: 0x00001C63
		internal static object smethod_36(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_16();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00003A37 File Offset: 0x00001C37
		internal static object smethod_37(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_18();
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00003B6F File Offset: 0x00001D6F
		internal static object smethod_38(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_20();
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_39(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00003A81 File Offset: 0x00001C81
		internal static bool smethod_40(object object_1, Delegate201 delegate201_0)
		{
			return Delegate201.smethod_0(object_1, delegate201_0);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_41(object object_1, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_1, delegate202_0);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00003A42 File Offset: 0x00001C42
		internal static object smethod_42(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_12();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00003A58 File Offset: 0x00001C58
		internal static object smethod_43(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_14();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00003FC5 File Offset: 0x000021C5
		internal static object smethod_44(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_15();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003A2C File Offset: 0x00001C2C
		internal static object smethod_45(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_17();
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00003FBA File Offset: 0x000021BA
		internal static object smethod_46(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_19();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00004257 File Offset: 0x00002457
		internal static object smethod_47(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_30();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00004262 File Offset: 0x00002462
		internal static object smethod_48(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_31();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000426D File Offset: 0x0000246D
		internal static object smethod_49(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_32();
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00003BA6 File Offset: 0x00001DA6
		internal static object smethod_50(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_33();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00003BC7 File Offset: 0x00001DC7
		internal static object smethod_51(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_34();
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003BBC File Offset: 0x00001DBC
		internal static object smethod_52(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_36();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004278 File Offset: 0x00002478
		internal static object smethod_53(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_37();
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00004283 File Offset: 0x00002483
		internal static object smethod_54(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_39();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000428E File Offset: 0x0000248E
		internal static object smethod_55(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_40();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00003BB1 File Offset: 0x00001DB1
		internal static object smethod_56(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_41();
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00004004 File Offset: 0x00002204
		internal static object smethod_57(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_43();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00003BD2 File Offset: 0x00001DD2
		internal static object smethod_58(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_44();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00004299 File Offset: 0x00002499
		internal static object smethod_59(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_45();
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003FEE File Offset: 0x000021EE
		internal static object smethod_60(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_24();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003B85 File Offset: 0x00001D85
		internal static object smethod_61(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_28();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003B90 File Offset: 0x00001D90
		internal static object smethod_62(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_27();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003BDD File Offset: 0x00001DDD
		internal static object smethod_63(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_42();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_64(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_65(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00003BFE File Offset: 0x00001DFE
		internal static bool smethod_66(Class9.Class20 class20_0)
		{
			return class20_0.method_1();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_67(Class9.Class20 class20_0)
		{
			return class20_0.method_0();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_68(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_4(class20_1);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_69(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_8();
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_70()
		{
		}

		// Token: 0x04000087 RID: 135
		public object object_0;

		// Token: 0x04000088 RID: 136
		public Class9.Enum2 enum2_0;
	}

	// Token: 0x0200002E RID: 46
	private abstract class Class21 : Class9.Class20
	{
		// Token: 0x060004A0 RID: 1184
		public abstract bool vmethod_10();

		// Token: 0x060004A1 RID: 1185
		public abstract bool yQwppAuByG();

		// Token: 0x060004A2 RID: 1186
		public abstract Class9.Class20 vmethod_11(Class9.Enum2 enum2_0);

		// Token: 0x060004A3 RID: 1187
		public abstract Class9.Class22 vmethod_12();

		// Token: 0x060004A4 RID: 1188
		public abstract Class9.Class22 vmethod_13();

		// Token: 0x060004A5 RID: 1189
		public abstract Class9.Class22 vmethod_14();

		// Token: 0x060004A6 RID: 1190
		public abstract Class9.Class22 vmethod_15();

		// Token: 0x060004A7 RID: 1191
		public abstract Class9.Class22 vmethod_16();

		// Token: 0x060004A8 RID: 1192
		public abstract Class9.Class22 vmethod_17();

		// Token: 0x060004A9 RID: 1193
		public abstract Class9.Class22 vmethod_18();

		// Token: 0x060004AA RID: 1194
		public abstract Class9.Class23 vmethod_19();

		// Token: 0x060004AB RID: 1195
		public abstract Class9.Class23 vmethod_20();

		// Token: 0x060004AC RID: 1196
		public abstract Class9.Class22 vmethod_21();

		// Token: 0x060004AD RID: 1197
		public abstract Class9.Class22 vmethod_22();

		// Token: 0x060004AE RID: 1198
		public abstract Class9.Class22 vmethod_23();

		// Token: 0x060004AF RID: 1199
		public abstract Class9.Class23 vmethod_24();

		// Token: 0x060004B0 RID: 1200
		public abstract Class9.Class22 vmethod_25();

		// Token: 0x060004B1 RID: 1201
		public abstract Class9.Class22 vmethod_26();

		// Token: 0x060004B2 RID: 1202
		public abstract Class9.Class22 vmethod_27();

		// Token: 0x060004B3 RID: 1203
		public abstract Class9.Class23 vmethod_28();

		// Token: 0x060004B4 RID: 1204
		public abstract Class9.Class22 vmethod_29();

		// Token: 0x060004B5 RID: 1205
		public abstract Class9.Class22 vmethod_30();

		// Token: 0x060004B6 RID: 1206
		public abstract Class9.Class22 vmethod_31();

		// Token: 0x060004B7 RID: 1207
		public abstract Class9.Class22 vmethod_32();

		// Token: 0x060004B8 RID: 1208
		public abstract Class9.Class22 vmethod_33();

		// Token: 0x060004B9 RID: 1209
		public abstract Class9.Class22 vmethod_34();

		// Token: 0x060004BA RID: 1210
		public abstract Class9.Class23 vmethod_35();

		// Token: 0x060004BB RID: 1211
		public abstract Class9.Class23 vmethod_36();

		// Token: 0x060004BC RID: 1212
		public abstract Class9.Class22 vmethod_37();

		// Token: 0x060004BD RID: 1213
		public abstract Class9.Class22 vmethod_38();

		// Token: 0x060004BE RID: 1214
		public abstract Class9.Class22 vmethod_39();

		// Token: 0x060004BF RID: 1215
		public abstract Class9.Class22 vmethod_40();

		// Token: 0x060004C0 RID: 1216
		public abstract Class9.Class22 vmethod_41();

		// Token: 0x060004C1 RID: 1217
		public abstract Class9.Class22 vmethod_42();

		// Token: 0x060004C2 RID: 1218
		public abstract Class9.Class23 vmethod_43();

		// Token: 0x060004C3 RID: 1219
		public abstract Class9.Class23 vmethod_44();

		// Token: 0x060004C4 RID: 1220
		public abstract Class9.Class25 vmethod_45();

		// Token: 0x060004C5 RID: 1221
		public abstract Class9.Class25 vmethod_46();

		// Token: 0x060004C6 RID: 1222
		public abstract Class9.Class25 zLqpmHyYrP();

		// Token: 0x060004C7 RID: 1223
		public abstract Class9.Class24 vmethod_47();

		// Token: 0x060004C8 RID: 1224
		public abstract Class9.Class24 vmethod_48();

		// Token: 0x060004C9 RID: 1225
		public abstract Class9.Class24 vmethod_49();

		// Token: 0x060004CA RID: 1226
		public abstract Class9.Class24 vmethod_50();

		// Token: 0x060004CB RID: 1227
		public abstract Class9.Class24 vmethod_51();

		// Token: 0x060004CC RID: 1228
		public abstract Class9.Class24 vmethod_52();

		// Token: 0x060004CD RID: 1229
		public abstract Class9.Class20 vmethod_53();

		// Token: 0x060004CE RID: 1230
		public abstract Class9.Class20 Add(Class9.Class20 class20_0);

		// Token: 0x060004CF RID: 1231
		public abstract Class9.Class20 vmethod_54(Class9.Class20 class20_0);

		// Token: 0x060004D0 RID: 1232
		public abstract Class9.Class20 vmethod_55(Class9.Class20 class20_0);

		// Token: 0x060004D1 RID: 1233
		public abstract Class9.Class20 vmethod_56(Class9.Class20 class20_0);

		// Token: 0x060004D2 RID: 1234
		public abstract Class9.Class20 vmethod_57(Class9.Class20 class20_0);

		// Token: 0x060004D3 RID: 1235
		public abstract Class9.Class20 vmethod_58(Class9.Class20 class20_0);

		// Token: 0x060004D4 RID: 1236
		public abstract Class9.Class20 vmethod_59(Class9.Class20 class20_0);

		// Token: 0x060004D5 RID: 1237
		public abstract Class9.Class20 vmethod_60(Class9.Class20 class20_0);

		// Token: 0x060004D6 RID: 1238
		public abstract Class9.Class20 vmethod_61(Class9.Class20 class20_0);

		// Token: 0x060004D7 RID: 1239
		public abstract Class9.Class20 vmethod_62(Class9.Class20 class20_0);

		// Token: 0x060004D8 RID: 1240
		public abstract Class9.Class20 vmethod_63(Class9.Class20 class20_0);

		// Token: 0x060004D9 RID: 1241
		public abstract Class9.Class20 vmethod_64(Class9.Class20 class20_0);

		// Token: 0x060004DA RID: 1242
		public abstract Class9.Class20 vmethod_65(Class9.Class20 class20_0);

		// Token: 0x060004DB RID: 1243
		public abstract Class9.Class20 vmethod_66(Class9.Class20 class20_0);

		// Token: 0x060004DC RID: 1244
		public abstract Class9.Class20 vmethod_67(Class9.Class20 class20_0);

		// Token: 0x060004DD RID: 1245
		public abstract Class9.Class20 vmethod_68();

		// Token: 0x060004DE RID: 1246
		public abstract Class9.Class20 igEvpBpxrl(Class9.Class20 class20_0);

		// Token: 0x060004DF RID: 1247
		public abstract Class9.Class21 vmethod_69();

		// Token: 0x060004E0 RID: 1248
		public abstract Class9.Class20 vmethod_70(Class9.Class20 class20_0);

		// Token: 0x060004E1 RID: 1249
		public abstract Class9.Class20 vmethod_71(Class9.Class20 class20_0);

		// Token: 0x060004E2 RID: 1250
		public abstract Class9.Class20 vmethod_72(Class9.Class20 class20_0);

		// Token: 0x060004E3 RID: 1251
		public abstract bool vmethod_73(Class9.Class20 class20_0);

		// Token: 0x060004E4 RID: 1252
		public abstract bool vmethod_74(Class9.Class20 class20_0);

		// Token: 0x060004E5 RID: 1253
		public abstract bool vmethod_75(Class9.Class20 class20_0);

		// Token: 0x060004E6 RID: 1254
		public abstract bool vmethod_76(Class9.Class20 class20_0);

		// Token: 0x060004E7 RID: 1255
		public abstract bool vmethod_77(Class9.Class20 class20_0);

		// Token: 0x060004E8 RID: 1256
		public abstract bool vmethod_78(Class9.Class20 class20_0);

		// Token: 0x060004E9 RID: 1257
		public abstract bool vmethod_79(Class9.Class20 class20_0);

		// Token: 0x060004EA RID: 1258
		public abstract bool vmethod_80(Class9.Class20 class20_0);

		// Token: 0x060004EB RID: 1259 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_2()
		{
			return true;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_21()
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_22()
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}
	}

	// Token: 0x0200002F RID: 47
	private class Class25 : Class9.Class21
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x00015BD0 File Offset: 0x00013DD0
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			this.double_0 = ((Class9.Class25)class20_0).double_0;
			this.enum2_0 = ((Class9.Class25)class20_0).enum2_0;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_9(class20_0);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00015C00 File Offset: 0x00013E00
		public Class25(double double_1)
		{
			this.enum5_0 = (Class9.Enum5)5;
			this.enum2_0 = (Class9.Enum2)10;
			this.double_0 = double_1;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00015C2C File Offset: 0x00013E2C
		public Class25(Class9.Class25 class25_0)
		{
			this.enum5_0 = class25_0.enum5_0;
			this.enum2_0 = class25_0.enum2_0;
			this.double_0 = class25_0.double_0;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000042A4 File Offset: 0x000024A4
		public override Class9.Class21 vmethod_69()
		{
			return new Class9.Class25(this);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00015C64 File Offset: 0x00013E64
		public Class25(double double_1, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)5;
			this.double_0 = double_1;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00015C8C File Offset: 0x00013E8C
		public Class25(float float_0)
		{
			this.enum5_0 = (Class9.Enum5)5;
			this.double_0 = (double)float_0;
			this.enum2_0 = (Class9.Enum2)9;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00015CB8 File Offset: 0x00013EB8
		public Class25(float float_0, Class9.Enum2 enum2_1)
		{
			this.enum5_0 = (Class9.Enum5)5;
			this.double_0 = (double)float_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000042AC File Offset: 0x000024AC
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000037E0 File Offset: 0x000019E0
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000042BF File Offset: 0x000024BF
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00015CE4 File Offset: 0x00013EE4
		public override Class9.Class20 vmethod_11(Class9.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class9.Enum2)1:
				return this.vmethod_13();
			case (Class9.Enum2)2:
				return this.vmethod_14();
			case (Class9.Enum2)3:
				return this.vmethod_15();
			case (Class9.Enum2)4:
				return this.vmethod_16();
			case (Class9.Enum2)5:
				return this.vmethod_17();
			case (Class9.Enum2)6:
				return this.vmethod_18();
			case (Class9.Enum2)7:
				return this.vmethod_19();
			case (Class9.Enum2)8:
				return this.vmethod_20();
			case (Class9.Enum2)9:
				return this.vmethod_45();
			case (Class9.Enum2)10:
				return this.vmethod_46();
			case (Class9.Enum2)11:
				return this.vmethod_12();
			default:
				throw new Exception(((Class9.Enum6)4).ToString());
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00015D88 File Offset: 0x00013F88
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum2_0 == (Class9.Enum2)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00015E28 File Offset: 0x00014028
		public override Class9.Class22 vmethod_12()
		{
			return new Class9.Class22((!this.vmethod_10()) ? 0 : 1);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000037EB File Offset: 0x000019EB
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000042CC File Offset: 0x000024CC
		public override Class9.Class22 vmethod_13()
		{
			return new Class9.Class22((int)((sbyte)this.double_0), (Class9.Enum2)1);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000042DB File Offset: 0x000024DB
		public override Class9.Class22 vmethod_14()
		{
			return new Class9.Class22((uint)((byte)this.double_0), (Class9.Enum2)2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000042EA File Offset: 0x000024EA
		public override Class9.Class22 vmethod_15()
		{
			return new Class9.Class22((int)((short)this.double_0), (Class9.Enum2)3);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000042F9 File Offset: 0x000024F9
		public override Class9.Class22 vmethod_16()
		{
			return new Class9.Class22((uint)((ushort)this.double_0), (Class9.Enum2)4);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004308 File Offset: 0x00002508
		public override Class9.Class22 vmethod_17()
		{
			return new Class9.Class22((int)this.double_0, (Class9.Enum2)5);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004317 File Offset: 0x00002517
		public override Class9.Class22 vmethod_18()
		{
			return new Class9.Class22((uint)this.double_0, (Class9.Enum2)6);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004326 File Offset: 0x00002526
		public override Class9.Class23 vmethod_19()
		{
			return new Class9.Class23((long)this.double_0, (Class9.Enum2)7);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004335 File Offset: 0x00002535
		public override Class9.Class23 vmethod_20()
		{
			return new Class9.Class23((ulong)this.double_0, (Class9.Enum2)8);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000038A1 File Offset: 0x00001AA1
		public override Class9.Class22 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000038A9 File Offset: 0x00001AA9
		public override Class9.Class22 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000038B1 File Offset: 0x00001AB1
		public override Class9.Class22 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000038B9 File Offset: 0x00001AB9
		public override Class9.Class23 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000038C1 File Offset: 0x00001AC1
		public override Class9.Class22 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000038C9 File Offset: 0x00001AC9
		public override Class9.Class22 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000038D1 File Offset: 0x00001AD1
		public override Class9.Class22 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000038D9 File Offset: 0x00001AD9
		public override Class9.Class23 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004344 File Offset: 0x00002544
		public override Class9.Class22 vmethod_29()
		{
			return new Class9.Class22((int)(checked((sbyte)this.double_0)), (Class9.Enum2)1);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004344 File Offset: 0x00002544
		public override Class9.Class22 vmethod_30()
		{
			return new Class9.Class22((int)(checked((sbyte)this.double_0)), (Class9.Enum2)1);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00004353 File Offset: 0x00002553
		public override Class9.Class22 vmethod_31()
		{
			return new Class9.Class22((int)(checked((short)this.double_0)), (Class9.Enum2)3);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00004353 File Offset: 0x00002553
		public override Class9.Class22 vmethod_32()
		{
			return new Class9.Class22((int)(checked((short)this.double_0)), (Class9.Enum2)3);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00004362 File Offset: 0x00002562
		public override Class9.Class22 vmethod_33()
		{
			return new Class9.Class22(checked((int)this.double_0), (Class9.Enum2)5);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004362 File Offset: 0x00002562
		public override Class9.Class22 vmethod_34()
		{
			return new Class9.Class22(checked((int)this.double_0), (Class9.Enum2)5);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004371 File Offset: 0x00002571
		public override Class9.Class23 vmethod_35()
		{
			return new Class9.Class23(checked((long)this.double_0), (Class9.Enum2)7);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00004371 File Offset: 0x00002571
		public override Class9.Class23 vmethod_36()
		{
			return new Class9.Class23(checked((long)this.double_0), (Class9.Enum2)7);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004380 File Offset: 0x00002580
		public override Class9.Class22 vmethod_37()
		{
			return new Class9.Class22((int)(checked((byte)this.double_0)), (Class9.Enum2)2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004380 File Offset: 0x00002580
		public override Class9.Class22 vmethod_38()
		{
			return new Class9.Class22((int)(checked((byte)this.double_0)), (Class9.Enum2)2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000438F File Offset: 0x0000258F
		public override Class9.Class22 vmethod_39()
		{
			return new Class9.Class22((int)(checked((ushort)this.double_0)), (Class9.Enum2)4);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000438F File Offset: 0x0000258F
		public override Class9.Class22 vmethod_40()
		{
			return new Class9.Class22((int)(checked((ushort)this.double_0)), (Class9.Enum2)4);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000439E File Offset: 0x0000259E
		public override Class9.Class22 vmethod_41()
		{
			return new Class9.Class22(checked((uint)this.double_0), (Class9.Enum2)6);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000439E File Offset: 0x0000259E
		public override Class9.Class22 vmethod_42()
		{
			return new Class9.Class22(checked((uint)this.double_0), (Class9.Enum2)6);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000043AD File Offset: 0x000025AD
		public override Class9.Class23 vmethod_43()
		{
			return new Class9.Class23(checked((ulong)this.double_0), (Class9.Enum2)8);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000043AD File Offset: 0x000025AD
		public override Class9.Class23 vmethod_44()
		{
			return new Class9.Class23(checked((ulong)this.double_0), (Class9.Enum2)8);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000043BC File Offset: 0x000025BC
		public override Class9.Class25 vmethod_45()
		{
			return new Class9.Class25((float)this.double_0, (Class9.Enum2)9);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000043CC File Offset: 0x000025CC
		public override Class9.Class25 vmethod_46()
		{
			return new Class9.Class25(this.double_0, (Class9.Enum2)10);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000043DC File Offset: 0x000025DC
		public override Class9.Class25 zLqpmHyYrP()
		{
			return new Class9.Class25(this.double_0);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001133C File Offset: 0x0000F53C
		public override Class9.Class24 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_24().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_23().struct1_0.int_0);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00011380 File Offset: 0x0000F580
		public override Class9.Class24 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_28().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_27().struct1_0.uint_0);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public override Class9.Class24 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_35().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_33().struct1_0.int_0);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00011408 File Offset: 0x0000F608
		public override Class9.Class24 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_43().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_41().struct1_0.uint_0);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001144C File Offset: 0x0000F64C
		public override Class9.Class24 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_36().struct2_0.long_0);
			}
			return new Class9.Class24((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00011490 File Offset: 0x0000F690
		public override Class9.Class24 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class9.Class24(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class9.Class24((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00015E48 File Offset: 0x00014048
		public override Class9.Class20 vmethod_53()
		{
			if (this.enum2_0 == (Class9.Enum2)9)
			{
				return new Class9.Class25((float)(-(float)this.double_0));
			}
			return new Class9.Class25(-this.double_0);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00015E7C File Offset: 0x0001407C
		public override Class9.Class20 Add(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 + ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00015E7C File Offset: 0x0001407C
		public override Class9.Class20 vmethod_54(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 + ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00015E7C File Offset: 0x0001407C
		public override Class9.Class20 vmethod_55(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 + ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00015EC0 File Offset: 0x000140C0
		public override Class9.Class20 vmethod_56(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 - ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00015EC0 File Offset: 0x000140C0
		public override Class9.Class20 vmethod_57(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 - ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00015EC0 File Offset: 0x000140C0
		public override Class9.Class20 vmethod_58(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 - ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00015F04 File Offset: 0x00014104
		public override Class9.Class20 vmethod_59(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4() || !class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 * ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00015F50 File Offset: 0x00014150
		public override Class9.Class20 vmethod_60(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 * ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00015F50 File Offset: 0x00014150
		public override Class9.Class20 vmethod_61(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 * ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00015F94 File Offset: 0x00014194
		public override Class9.Class20 vmethod_62(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 / ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00015F94 File Offset: 0x00014194
		public override Class9.Class20 vmethod_63(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 / ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00015FD8 File Offset: 0x000141D8
		public override Class9.Class20 vmethod_64(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 % ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00015FD8 File Offset: 0x000141D8
		public override Class9.Class20 vmethod_65(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return new Class9.Class25(this.double_0 % ((Class9.Class25)class20_0).double_0);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_66(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_67(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_68()
		{
			throw new Class9.Exception1();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 igEvpBpxrl(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_70(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_71(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000043EA File Offset: 0x000025EA
		public override Class9.Class20 vmethod_72(Class9.Class20 class20_0)
		{
			throw new Class9.Exception1();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00003A1E File Offset: 0x00001C1E
		internal override Class9.Class20 vmethod_7()
		{
			return this;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001601C File Offset: 0x0001421C
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (!class20_0.iFavIhWly7())
			{
				Class9.Class20 @class = class20_0.vmethod_7();
				return @class.method_4() && this.double_0 == ((Class9.Class25)@class).double_0;
			}
			return ((Class9.Class26)class20_0).vmethod_4(this);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00016070 File Offset: 0x00014270
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (class20_0.method_0())
			{
				return false;
			}
			if (!class20_0.iFavIhWly7())
			{
				Class9.Class20 @class = class20_0.vmethod_7();
				return @class.method_4() && this.double_0 != ((Class9.Class25)@class).double_0;
			}
			return ((Class9.Class26)class20_0).vmethod_5(this);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000160C8 File Offset: 0x000142C8
		public override bool vmethod_73(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 >= ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000160C8 File Offset: 0x000142C8
		public override bool vmethod_74(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 >= ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001610C File Offset: 0x0001430C
		public override bool vmethod_75(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 > ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001610C File Offset: 0x0001430C
		public override bool vmethod_76(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 > ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001614C File Offset: 0x0001434C
		public override bool vmethod_77(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 <= ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001614C File Offset: 0x0001434C
		public override bool vmethod_78(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 <= ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00016190 File Offset: 0x00014390
		public override bool vmethod_79(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 < ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00016190 File Offset: 0x00014390
		public override bool vmethod_80(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				class20_0 = class20_0.vmethod_7();
			}
			if (!class20_0.method_4())
			{
				throw new Class9.Exception1();
			}
			return this.double_0 < ((Class9.Class25)class20_0).double_0;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void smethod_24(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			class20_0.vmethod_9(class20_1);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_25()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_26()
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00004299 File Offset: 0x00002499
		internal static object smethod_27(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_45();
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000043F1 File Offset: 0x000025F1
		internal static object smethod_28(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_46();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003A42 File Offset: 0x00001C42
		internal static object smethod_29(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_12();
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00003A58 File Offset: 0x00001C58
		internal static object smethod_30(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_14();
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00003FC5 File Offset: 0x000021C5
		internal static object smethod_31(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_15();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00003A63 File Offset: 0x00001C63
		internal static object smethod_32(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_16();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00003A2C File Offset: 0x00001C2C
		internal static object smethod_33(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_17();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003A37 File Offset: 0x00001C37
		internal static object smethod_34(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_18();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00003B6F File Offset: 0x00001D6F
		internal static object smethod_35(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_20();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_36(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_37(object object_0, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_0, delegate202_0);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_38(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_39(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00003A21 File Offset: 0x00001C21
		internal static bool smethod_40(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_10();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00003AC1 File Offset: 0x00001CC1
		internal static bool smethod_41(Class9.Class21 class21_0)
		{
			return class21_0.yQwppAuByG();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003A4D File Offset: 0x00001C4D
		internal static object smethod_42(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_13();
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00003FBA File Offset: 0x000021BA
		internal static object smethod_43(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_19();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00003B7A File Offset: 0x00001D7A
		internal static int smethod_44(Delegate232 delegate232_0)
		{
			return delegate232_0();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00003FF9 File Offset: 0x000021F9
		internal static object smethod_45(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_23();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003B85 File Offset: 0x00001D85
		internal static object smethod_46(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_28();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003B9B File Offset: 0x00001D9B
		internal static object smethod_47(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_35();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00004004 File Offset: 0x00002204
		internal static object smethod_48(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_43();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00003BC7 File Offset: 0x00001DC7
		internal static object smethod_49(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_34();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00003BD2 File Offset: 0x00001DD2
		internal static object smethod_50(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_44();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00003BDD File Offset: 0x00001DDD
		internal static object smethod_51(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_42();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_52(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_53(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000043FC File Offset: 0x000025FC
		internal static bool smethod_54(Class9.Class20 class20_0)
		{
			return class20_0.method_4();
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_55(Class9.Class20 class20_0)
		{
			return class20_0.method_0();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_56(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_4(class20_1);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_57()
		{
		}

		// Token: 0x04000089 RID: 137
		public double double_0;

		// Token: 0x0400008A RID: 138
		public Class9.Enum2 enum2_0;
	}

	// Token: 0x02000030 RID: 48
	internal enum Enum2 : byte
	{

	}

	// Token: 0x02000031 RID: 49
	internal enum Enum3 : byte
	{

	}

	// Token: 0x02000032 RID: 50
	private class Exception0 : Exception
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x000161D0 File Offset: 0x000143D0
		public Exception0(string string_0) : base(string_0)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}
	}

	// Token: 0x02000033 RID: 51
	private class Exception1 : Exception
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x000161E4 File Offset: 0x000143E4
		public Exception1()
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000161D0 File Offset: 0x000143D0
		public Exception1(string string_0) : base(string_0)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}
	}

	// Token: 0x02000034 RID: 52
	internal class Class10
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x000161F8 File Offset: 0x000143F8
		public override string ToString()
		{
			object obj = this.enum4_0;
			if (this.object_0 == null)
			{
				return obj.ToString();
			}
			return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000028FC File Offset: 0x00000AFC
		internal static object smethod_0(object object_1, Delegate132 delegate132_0)
		{
			return Delegate132.smethod_0(object_1, delegate132_0);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002A27 File Offset: 0x00000C27
		internal static object smethod_1(string string_0, string string_1, string string_2, Delegate147 delegate147_0)
		{
			return Delegate147.smethod_0(string_0, string_1, string_2, delegate147_0);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_3()
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_4()
		{
		}

		// Token: 0x0400008D RID: 141
		internal Class9.Enum4 enum4_0 = (Class9.Enum4)126;

		// Token: 0x0400008E RID: 142
		internal object object_0;
	}

	// Token: 0x02000035 RID: 53
	internal abstract class Class26 : Class9.Class20
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00015BBC File Offset: 0x00013DBC
		public Class26()
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool iFavIhWly7()
		{
			return true;
		}

		// Token: 0x0600057B RID: 1403
		internal abstract IntPtr vmethod_10();

		// Token: 0x0600057C RID: 1404
		internal abstract void vmethod_11(Class9.Class20 class20_0);

		// Token: 0x0600057D RID: 1405 RVA: 0x000031C7 File Offset: 0x000013C7
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_21()
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_22()
		{
		}
	}

	// Token: 0x02000036 RID: 54
	internal class Class27 : Class9.Class26
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x00016260 File Offset: 0x00014460
		public Class27(int int_1, Class9.Class18 class18_1)
		{
			this.class18_0 = class18_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class9.Enum5)7;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00016288 File Offset: 0x00014488
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			if (class20_0 is Class9.Class27)
			{
				this.class18_0 = ((Class9.Class27)class20_0).class18_0;
				this.int_0 = ((Class9.Class27)class20_0).int_0;
				return;
			}
			Class9.Class12 @class = this.class18_0.class15_0.UqaYjxudZI[this.int_0];
			if (class20_0 is Class9.Class26 && (@class.enum2_0 & (Class9.Enum2)226) > (Class9.Enum2)0)
			{
				Class9.Class20 class20_ = (class20_0 as Class9.Class26).vmethod_7();
				this.vmethod_11(class20_);
				return;
			}
			this.vmethod_11(class20_0);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00016314 File Offset: 0x00014514
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_11(class20_0);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004407 File Offset: 0x00002607
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00016328 File Offset: 0x00014528
		internal override void vmethod_11(Class9.Class20 class20_0)
		{
			this.class18_0.class20_1[this.int_0] = class20_0;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00016348 File Offset: 0x00014548
		internal override object vmethod_3(Type type_0)
		{
			if (this.class18_0.class20_1[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00016378 File Offset: 0x00014578
		internal override Class9.Class20 vmethod_7()
		{
			if (this.class18_0.class20_1[this.int_0] != null)
			{
				return this.class18_0.class20_1[this.int_0].vmethod_7();
			}
			return new Class9.Class32(null);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000440E File Offset: 0x0000260E
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000163B8 File Offset: 0x000145B8
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7() && class20_0 is Class9.Class27 && ((Class9.Class27)class20_0).int_0 == this.int_0;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000163F0 File Offset: 0x000145F0
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			return !class20_0.iFavIhWly7() || !(class20_0 is Class9.Class27) || ((Class9.Class27)class20_0).int_0 != this.int_0;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000441B File Offset: 0x0000261B
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_24()
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_25(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_26(Class9.Class26 class26_0, Class9.Class20 class20_0)
		{
			class26_0.vmethod_11(class20_0);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_27(Class9.Class20 class20_0, Type type_0)
		{
			return class20_0.vmethod_3(type_0);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_28(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_8();
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_29(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_30(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_6();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_31()
		{
		}

		// Token: 0x0400008F RID: 143
		private Class9.Class18 class18_0;

		// Token: 0x04000090 RID: 144
		internal int int_0;
	}

	// Token: 0x02000037 RID: 55
	internal class Class28 : Class9.Class26
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00016428 File Offset: 0x00014628
		public Class28(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class9.Enum5)7;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00004407 File Offset: 0x00002607
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00016450 File Offset: 0x00014650
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			if (class20_0 is Class9.Class28)
			{
				this.array_0 = ((Class9.Class28)class20_0).array_0;
				this.int_0 = ((Class9.Class28)class20_0).int_0;
				return;
			}
			this.vmethod_11(class20_0);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00016314 File Offset: 0x00014514
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_11(class20_0);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00016490 File Offset: 0x00014690
		internal override void vmethod_11(Class9.Class20 class20_0)
		{
			this.array_0.SetValue(class20_0.vmethod_3(null), this.int_0);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00004442 File Offset: 0x00002642
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00004450 File Offset: 0x00002650
		internal override Class9.Class20 vmethod_7()
		{
			return Class9.Class20.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000440E File Offset: 0x0000260E
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000164B8 File Offset: 0x000146B8
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (!class20_0.iFavIhWly7())
			{
				return false;
			}
			if (!(class20_0 is Class9.Class28))
			{
				return false;
			}
			Class9.Class28 @class = (Class9.Class28)class20_0;
			return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00016504 File Offset: 0x00014704
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (!class20_0.iFavIhWly7())
			{
				return true;
			}
			if (class20_0 is Class9.Class28)
			{
				Class9.Class28 @class = (Class9.Class28)class20_0;
				return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
			}
			return true;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000441B File Offset: 0x0000261B
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_24(Class9.Class26 class26_0, Class9.Class20 class20_0)
		{
			class26_0.vmethod_11(class20_0);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_25(Class9.Class20 class20_0, Type type_0)
		{
			return class20_0.vmethod_3(type_0);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00004478 File Offset: 0x00002678
		internal static void smethod_26(object object_0, object object_1, int int_1, Delegate245 delegate245_0)
		{
			Delegate245.smethod_0(object_0, object_1, int_1, delegate245_0);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000448F File Offset: 0x0000268F
		internal static object smethod_27(object object_0, int int_1, Delegate246 delegate246_0)
		{
			return Delegate246.smethod_0(object_0, int_1, delegate246_0);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000044A2 File Offset: 0x000026A2
		internal static object smethod_28(Type type_0, object object_0)
		{
			return Class9.Class20.smethod_1(type_0, object_0);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_29(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_30(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_31(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_6();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_32()
		{
		}

		// Token: 0x04000091 RID: 145
		private Array array_0;

		// Token: 0x04000092 RID: 146
		internal int int_0;
	}

	// Token: 0x02000038 RID: 56
	internal class Class29 : Class9.Class26
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00016550 File Offset: 0x00014750
		public Class29(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum5_0 = (Class9.Enum5)7;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004407 File Offset: 0x00002607
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00016578 File Offset: 0x00014778
		internal override void vmethod_11(Class9.Class20 class20_0)
		{
			if (this.object_0 != null && this.object_0 is Class9.Class20)
			{
				this.fieldInfo_0.SetValue(((Class9.Class20)this.object_0).vmethod_3(null), class20_0.vmethod_3(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class20_0.vmethod_3(null));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000165D8 File Offset: 0x000147D8
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			if (class20_0 is Class9.Class29)
			{
				this.fieldInfo_0 = ((Class9.Class29)class20_0).fieldInfo_0;
				this.object_0 = ((Class9.Class29)class20_0).object_0;
				return;
			}
			this.vmethod_11(class20_0);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00016314 File Offset: 0x00014514
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_11(class20_0);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00004442 File Offset: 0x00002642
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00016618 File Offset: 0x00014818
		internal override Class9.Class20 vmethod_7()
		{
			if (this.object_0 != null && this.object_0 is Class9.Class20)
			{
				return Class9.Class20.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class9.Class20)this.object_0).vmethod_3(null)));
			}
			return Class9.Class20.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000440E File Offset: 0x0000260E
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00016688 File Offset: 0x00014888
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (!class20_0.iFavIhWly7())
			{
				return false;
			}
			if (class20_0 is Class9.Class29)
			{
				Class9.Class29 @class = (Class9.Class29)class20_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000166DC File Offset: 0x000148DC
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (!class20_0.iFavIhWly7())
			{
				return true;
			}
			if (!(class20_0 is Class9.Class29))
			{
				return true;
			}
			Class9.Class29 @class = (Class9.Class29)class20_0;
			return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000441B File Offset: 0x0000261B
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_24()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_25(Class9.Class20 class20_0, Type type_0)
		{
			return class20_0.vmethod_3(type_0);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000044B1 File Offset: 0x000026B1
		internal static void smethod_26(object object_1, object object_2, object object_3, Delegate193 delegate193_0)
		{
			Delegate193.smethod_0(object_1, object_2, object_3, delegate193_0);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_27(Class9.Class26 class26_0, Class9.Class20 class20_0)
		{
			class26_0.vmethod_11(class20_0);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000044C8 File Offset: 0x000026C8
		internal static Type smethod_28(object object_1, Delegate247 delegate247_0)
		{
			return Delegate247.smethod_0(object_1, delegate247_0);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000044D7 File Offset: 0x000026D7
		internal static object smethod_29(object object_1, object object_2, Delegate248 delegate248_0)
		{
			return Delegate248.smethod_0(object_1, object_2, delegate248_0);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000044A2 File Offset: 0x000026A2
		internal static object smethod_30(Type type_0, object object_1)
		{
			return Class9.Class20.smethod_1(type_0, object_1);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_31(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_32(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_8();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000044EA File Offset: 0x000026EA
		internal static bool smethod_33(FieldInfo fieldInfo_1, FieldInfo fieldInfo_2, Delegate249 delegate249_0)
		{
			return Delegate249.smethod_0(fieldInfo_1, fieldInfo_2, delegate249_0);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_34(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_35(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_6();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_36()
		{
		}

		// Token: 0x04000093 RID: 147
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000094 RID: 148
		internal object object_0;
	}

	// Token: 0x02000039 RID: 57
	internal class Class30 : Class9.Class26
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x00016730 File Offset: 0x00014930
		public Class30(int int_1, Class9.Class18 class18_1)
		{
			this.class18_0 = class18_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class9.Enum5)7;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004407 File Offset: 0x00002607
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00016758 File Offset: 0x00014958
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			if (class20_0 is Class9.Class30)
			{
				this.class18_0 = ((Class9.Class30)class20_0).class18_0;
				this.int_0 = ((Class9.Class30)class20_0).int_0;
				return;
			}
			this.vmethod_11(class20_0);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00016314 File Offset: 0x00014514
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_11(class20_0);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00016798 File Offset: 0x00014998
		internal override void vmethod_11(Class9.Class20 class20_0)
		{
			this.class18_0.class20_0[this.int_0] = class20_0;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000167B8 File Offset: 0x000149B8
		internal override object vmethod_3(Type type_0)
		{
			if (this.class18_0.class20_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000167E8 File Offset: 0x000149E8
		internal override Class9.Class20 vmethod_7()
		{
			if (this.class18_0.class20_0[this.int_0] == null)
			{
				return new Class9.Class32(null);
			}
			return this.class18_0.class20_0[this.int_0].vmethod_7();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000440E File Offset: 0x0000260E
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00016828 File Offset: 0x00014A28
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7() && class20_0 is Class9.Class30 && ((Class9.Class30)class20_0).int_0 == this.int_0;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0001685C File Offset: 0x00014A5C
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			return !class20_0.iFavIhWly7() || !(class20_0 is Class9.Class30) || ((Class9.Class30)class20_0).int_0 != this.int_0;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000441B File Offset: 0x0000261B
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_24()
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_25(Class9.Class26 class26_0, Class9.Class20 class20_0)
		{
			class26_0.vmethod_11(class20_0);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_26(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_27(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_8();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_28(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_29(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_6();
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_30()
		{
		}

		// Token: 0x04000095 RID: 149
		private Class9.Class18 class18_0;

		// Token: 0x04000096 RID: 150
		internal int int_0;
	}

	// Token: 0x0200003A RID: 58
	internal class Class31 : Class9.Class26
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x00016894 File Offset: 0x00014A94
		public Class31(Class9.Class20 class20_1, Type type_0)
		{
			this.class20_0 = class20_1;
			this.LksYdldxWw = type_0;
			this.enum5_0 = (Class9.Enum5)7;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004407 File Offset: 0x00002607
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000168BC File Offset: 0x00014ABC
		internal override void vmethod_9(Class9.Class20 class20_1)
		{
			if (!(class20_1 is Class9.Class31))
			{
				this.class20_0.vmethod_9(class20_1);
				return;
			}
			this.LksYdldxWw = ((Class9.Class31)class20_1).LksYdldxWw;
			this.class20_0 = ((Class9.Class31)class20_1).class20_0;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00016314 File Offset: 0x00014514
		internal override void vmethod_1(Class9.Class20 class20_1)
		{
			this.vmethod_11(class20_1);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00016900 File Offset: 0x00014B00
		internal override void vmethod_11(Class9.Class20 class20_1)
		{
			this.class20_0 = class20_1;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00016914 File Offset: 0x00014B14
		internal override object vmethod_3(Type type_0)
		{
			if (this.class20_0 == null)
			{
				return new Class9.Class32(null);
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				return this.class20_0.vmethod_3(type_0);
			}
			return this.class20_0.vmethod_3(this.LksYdldxWw);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001696C File Offset: 0x00014B6C
		internal override Class9.Class20 vmethod_7()
		{
			if (this.class20_0 != null)
			{
				return this.class20_0.vmethod_7();
			}
			return new Class9.Class32(null);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000440E File Offset: 0x0000260E
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00016994 File Offset: 0x00014B94
		internal override bool vmethod_4(Class9.Class20 class20_1)
		{
			if (!class20_1.iFavIhWly7())
			{
				return false;
			}
			if (!(class20_1 is Class9.Class31))
			{
				return false;
			}
			Class9.Class31 @class = (Class9.Class31)class20_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return false;
			}
			if (this.class20_0 == null)
			{
				return @class.class20_0 == null;
			}
			return this.class20_0.vmethod_4(@class.class20_0);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000169FC File Offset: 0x00014BFC
		internal override bool vmethod_5(Class9.Class20 class20_1)
		{
			if (!class20_1.iFavIhWly7())
			{
				return true;
			}
			if (!(class20_1 is Class9.Class31))
			{
				return true;
			}
			Class9.Class31 @class = (Class9.Class31)class20_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return true;
			}
			if (this.class20_0 != null)
			{
				return this.class20_0.vmethod_5(@class.class20_0);
			}
			return @class.class20_0 != null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000441B File Offset: 0x0000261B
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_24(Class9.Class26 class26_0, Class9.Class20 class20_1)
		{
			class26_0.vmethod_11(class20_1);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_25(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_26(Class9.Class20 class20_1, Type type_0)
		{
			return class20_1.vmethod_3(type_0);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_27(Class9.Class20 class20_1)
		{
			return class20_1.vmethod_7();
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003D1A File Offset: 0x00001F1A
		internal static bool smethod_28(Class9.Class20 class20_1)
		{
			return class20_1.vmethod_8();
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_29(Class9.Class20 class20_1)
		{
			return class20_1.iFavIhWly7();
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_30(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_31(Class9.Class20 class20_1, Class9.Class20 class20_2)
		{
			return class20_1.vmethod_4(class20_2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_32(Class9.Class20 class20_1, Class9.Class20 class20_2)
		{
			return class20_1.vmethod_5(class20_2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_33(Class9.Class20 class20_1)
		{
			return class20_1.vmethod_6();
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_34()
		{
		}

		// Token: 0x04000097 RID: 151
		private Class9.Class20 class20_0;

		// Token: 0x04000098 RID: 152
		private Type LksYdldxWw;
	}

	// Token: 0x0200003B RID: 59
	internal class Class11
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}

		// Token: 0x04000099 RID: 153
		public int int_0;

		// Token: 0x0400009A RID: 154
		public bool bool_0;

		// Token: 0x0400009B RID: 155
		public Class9.Enum2 enum2_0;
	}

	// Token: 0x0200003C RID: 60
	internal class Class12
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002240 File Offset: 0x00000440
		internal static void EnYotBbxhxcjuKyfQxh()
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}

		// Token: 0x0400009C RID: 156
		public int int_0;

		// Token: 0x0400009D RID: 157
		public Class9.Enum2 enum2_0;

		// Token: 0x0400009E RID: 158
		public bool bool_0;

		// Token: 0x0400009F RID: 159
		public Type type_0 = typeof(object);
	}

	// Token: 0x0200003D RID: 61
	internal class Class13
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x040000A0 RID: 160
		public int int_0;

		// Token: 0x040000A1 RID: 161
		public int int_1;

		// Token: 0x040000A2 RID: 162
		public Class9.Class14 class14_0;
	}

	// Token: 0x0200003E RID: 62
	internal class Class14
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}

		// Token: 0x040000A3 RID: 163
		public int int_0;

		// Token: 0x040000A4 RID: 164
		public int int_1;

		// Token: 0x040000A5 RID: 165
		public byte byte_0;

		// Token: 0x040000A6 RID: 166
		public Type type_0;

		// Token: 0x040000A7 RID: 167
		public int int_2;

		// Token: 0x040000A8 RID: 168
		public int int_3;
	}

	// Token: 0x0200003F RID: 63
	internal class Class15
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_2()
		{
		}

		// Token: 0x040000A9 RID: 169
		internal object object_0;

		// Token: 0x040000AA RID: 170
		internal List<Class9.Class10> list_0;

		// Token: 0x040000AB RID: 171
		internal Class9.Class11[] class11_0;

		// Token: 0x040000AC RID: 172
		internal List<Class9.Class12> UqaYjxudZI;

		// Token: 0x040000AD RID: 173
		internal List<Class9.Class13> list_1;
	}

	// Token: 0x02000040 RID: 64
	private class Class16
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x00016A88 File Offset: 0x00014C88
		public Class16(FieldInfo fieldInfo_0, int int_1)
		{
			this.object_0 = fieldInfo_0;
			this.int_0 = int_1;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x040000AE RID: 174
		internal object object_0;

		// Token: 0x040000AF RID: 175
		internal int int_0;
	}

	// Token: 0x02000041 RID: 65
	private class Class17
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x000044FD File Offset: 0x000026FD
		public Class17(MethodBase methodBase_1, List<Class9.Class16> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016AAC File Offset: 0x00014CAC
		public Class17(MethodBase methodBase_1, Class9.Class16[] class16_0)
		{
			this.list_0.AddRange(class16_0);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00016AD8 File Offset: 0x00014CD8
		public override bool Equals(object obj)
		{
			Class9.Class17 @class = obj as Class9.Class17;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].object_0 != @class.list_0[i].object_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00016B9C File Offset: 0x00014D9C
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class9.Class16 @class in this.list_0)
			{
				int num2 = @class.object_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00016C1C File Offset: 0x00014E1C
		public Class9.Class16 method_0(int int_0)
		{
			foreach (Class9.Class16 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00016C84 File Offset: 0x00014E84
		public bool method_1(int int_0)
		{
			using (List<Class9.Class16>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_0()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_1()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000451E File Offset: 0x0000271E
		internal static bool smethod_2(MethodBase methodBase_1, MethodBase methodBase_2, Delegate250 delegate250_0)
		{
			return Delegate250.smethod_0(methodBase_1, methodBase_2, delegate250_0);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00004531 File Offset: 0x00002731
		internal static int smethod_3(List<Class9.Class16> list_1)
		{
			return list_1.Count;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000044EA File Offset: 0x000026EA
		internal static bool smethod_4(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1, Delegate249 delegate249_0)
		{
			return Delegate249.smethod_0(fieldInfo_0, fieldInfo_1, delegate249_0);
		}

		// Token: 0x040000B0 RID: 176
		private List<Class9.Class16> list_0 = new List<Class9.Class16>();

		// Token: 0x040000B1 RID: 177
		private MethodBase methodBase_0;
	}

	// Token: 0x02000042 RID: 66
	// (Invoke) Token: 0x0600060E RID: 1550
	private delegate object Delegate10(object target, object[] paramters);

	// Token: 0x02000043 RID: 67
	// (Invoke) Token: 0x06000612 RID: 1554
	private delegate object Delegate11(object target);

	// Token: 0x02000044 RID: 68
	// (Invoke) Token: 0x06000616 RID: 1558
	private delegate void Delegate12(IntPtr a, byte b, int c);

	// Token: 0x02000045 RID: 69
	// (Invoke) Token: 0x0600061A RID: 1562
	private delegate void Delegate13(IntPtr s, IntPtr t, uint c);

	// Token: 0x02000046 RID: 70
	internal class Class18
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00016CE4 File Offset: 0x00014EE4
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00016CFC File Offset: 0x00014EFC
		internal void method_1()
		{
			this.class34_0.method_1();
			this.class20_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00016D90 File Offset: 0x00014F90
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class9.Class10 @class = this.class15_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class34_0.method_1();
						int int_ = this.int_1;
						Class9.Class13 class2 = this.method_5(int_, innerException);
						List<Class9.Class13> list = this.method_6(int_, false);
						List<Class9.Class13> list2 = new List<Class9.Class13>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class9.Class13>(Class9.Class18.Class19.<>9.EaecoUppfe));
						Class9.Class13 class3 = null;
						foreach (Class9.Class13 class4 in list2)
						{
							if (class4.class14_0.int_3 != 0)
							{
								this.class34_0.method_2(new Class9.Class32(innerException));
								this.int_1 = class4.class14_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 == null)
						{
							throw innerException;
						}
						this.int_2 = class3.class14_0.int_0;
						this.method_3(int_, class3.class14_0.int_0);
						if (this.int_2 >= 0)
						{
							this.class34_0.method_2(new Class9.Class32(innerException));
							this.int_1 = this.int_2;
							this.int_0 = this.int_1;
							this.int_2 = -1;
							this.method_0();
						}
						return;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class34_0.method_1();
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00017050 File Offset: 0x00015250
		internal void method_3(int int_3, int int_4)
		{
			if (this.class15_0.list_1 != null)
			{
				foreach (Class9.Class13 @class in this.class15_0.list_1)
				{
					if ((@class.class14_0.int_3 == 4 || @class.class14_0.int_3 == 2) && @class.class14_0.int_0 >= int_3 && @class.class14_0.int_1 <= int_4)
					{
						this.int_1 = @class.class14_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00017120 File Offset: 0x00015320
		internal void method_4(int int_3, int int_4)
		{
			if (this.class15_0.list_1 != null)
			{
				foreach (Class9.Class13 @class in this.class15_0.list_1)
				{
					if (@class.class14_0.int_3 == 2 && @class.class14_0.int_0 >= int_3 && @class.class14_0.int_1 <= int_4)
					{
						this.int_1 = @class.class14_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000171E0 File Offset: 0x000153E0
		internal Class9.Class13 method_5(int int_3, Exception exception_1)
		{
			Class9.Class13 @class = null;
			if (this.class15_0.list_1 != null)
			{
				foreach (Class9.Class13 class2 in this.class15_0.list_1)
				{
					if (class2.class14_0 != null && class2.class14_0.int_3 == 0 && (class2.class14_0.type_0 == exception_1.GetType() || (class2.class14_0.type_0 != null && (class2.class14_0.type_0.FullName == exception_1.GetType().FullName || class2.class14_0.type_0.FullName == typeof(object).FullName || class2.class14_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class14_0.int_0 < @class.class14_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00017358 File Offset: 0x00015558
		internal List<Class9.Class13> method_6(int int_3, bool bool_4)
		{
			if (this.class15_0.list_1 == null)
			{
				return null;
			}
			List<Class9.Class13> list = new List<Class9.Class13>();
			foreach (Class9.Class13 @class in this.class15_0.list_1)
			{
				if ((@class.class14_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000173F4 File Offset: 0x000155F4
		private unsafe void method_7(Class9.Class10 class10_0)
		{
			switch (class10_0.enum4_0)
			{
			case (Class9.Enum4)0:
			case (Class9.Enum4)11:
			case (Class9.Enum4)36:
			case (Class9.Enum4)62:
			case (Class9.Enum4)85:
			case (Class9.Enum4)101:
			case (Class9.Enum4)115:
			case (Class9.Enum4)123:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Array array = (Array)this.class34_0.method_4().vmethod_3(null);
				Type type = array.GetType().GetElementType();
				array.SetValue(@class.vmethod_3(type), class2.vmethod_17().struct1_0.int_0);
				return;
			}
			case (Class9.Enum4)1:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class34_0.method_4() as Class9.Class21).vmethod_17().struct1_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class34_0.method_2(new Class9.Class24(intPtr));
				return;
			}
			case (Class9.Enum4)2:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_33());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)3:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_26());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)4:
			{
				object obj = Class9.Class18.object_2;
				lock (obj)
				{
					object obj2 = this.class34_0.method_4().vmethod_3(null);
					Class9.Class20 @class = null;
					if (!Class9.Class18.dictionary_1.TryGetValue(obj2, out @class))
					{
						this.class34_0.method_2(new Class9.Class32(null));
					}
					else
					{
						this.class34_0.method_2(@class);
					}
				}
				return;
			}
			case (Class9.Enum4)5:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_52());
				return;
			}
			case (Class9.Enum4)6:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_22();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)7:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_21());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)8:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				this.class34_0.method_2(new Class9.Class29(fieldInfo, null));
				return;
			}
			case (Class9.Enum4)9:
				this.class34_0.method_2(new Class9.Class22((int)this.object_0));
				return;
			case (Class9.Enum4)10:
				this.int_0 = -3;
				if (this.class34_0.method_0() > 0)
				{
					this.class20_2 = this.class34_0.method_4();
				}
				return;
			case (Class9.Enum4)12:
				if (this.class34_0.method_4().vmethod_5(this.class34_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class9.Enum4)13:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(type, obj));
				return;
			}
			case (Class9.Enum4)14:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_48());
				return;
			}
			case (Class9.Enum4)15:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				Class9.Class20 class20_ = this.class34_0.method_4();
				Class9.Class21 class3 = Class9.Class18.smethod_1(class20_);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_76(@class))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (@class.vmethod_5(class20_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)16:
				this.class34_0.method_2(this.class34_0.method_3());
				return;
			case (Class9.Enum4)17:
			{
				Array array2 = (Array)this.class34_0.method_4().vmethod_3(null);
				this.class34_0.method_2(new Class9.Class22(array2.Length, (Class9.Enum2)5));
				return;
			}
			case (Class9.Enum4)18:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				this.class34_0.method_2(Class9.Class20.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class9.Enum4)19:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_41());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)20:
			case (Class9.Enum4)27:
			case (Class9.Enum4)108:
			case (Class9.Enum4)119:
			case (Class9.Enum4)145:
			case (Class9.Enum4)170:
				return;
			case (Class9.Enum4)21:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_25());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22((int)(*(byte*)((void*)intPtr)), (Class9.Enum2)2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)22:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(double), obj));
				return;
			}
			case (Class9.Enum4)23:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_26());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22((int)(*(ushort*)((void*)intPtr)), (Class9.Enum2)4));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)24:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_24());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class23(*(long*)((void*)intPtr), (Class9.Enum2)7));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)25:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_46();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)26:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class9).Module;
				this.class34_0.method_2(new Class9.Class24(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class9.Enum4)28:
			case (Class9.Enum4)35:
			case (Class9.Enum4)37:
			case (Class9.Enum4)103:
			case (Class9.Enum4)130:
			case (Class9.Enum4)143:
				throw new Class9.Exception1();
			case (Class9.Enum4)29:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class34_0.method_2(class2.vmethod_67(class3));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)30:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)31:
			{
				int num = (int)this.object_0;
				this.class20_1[num] = this.method_8(this.class34_0.method_4(), this.class15_0.UqaYjxudZI[num].enum2_0, this.class15_0.UqaYjxudZI[num].bool_0);
				return;
			}
			case (Class9.Enum4)32:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				Class9.Class20 class4 = this.class34_0.method_4();
				class4.vmethod_7();
				object obj = class4.vmethod_3(null);
				this.class34_0.method_2(new Class9.Class29(fieldInfo, obj));
				return;
			}
			case (Class9.Enum4)33:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = (Class9.Class21)this.class34_0.method_4();
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_57(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)34:
				throw this.exception_0;
			case (Class9.Enum4)38:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_23());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22(*(int*)((void*)intPtr), (Class9.Enum2)5));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)39:
				this.class34_0.method_2(new Class9.Class25((float)this.object_0));
				return;
			case (Class9.Enum4)40:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_23());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)41:
			{
				object obj = Class9.Class18.object_2;
				lock (obj)
				{
					Class9.Class20 @class = this.class34_0.method_4();
					object obj2 = this.class34_0.method_4().vmethod_3(null);
					Class9.Class18.dictionary_1[obj2] = @class;
				}
				return;
			}
			case (Class9.Enum4)42:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_77(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)43:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				bool flag2 = Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_80(@class);
				if (flag2)
				{
					this.class34_0.method_2(new Class9.Class22(1));
					if (!flag2)
					{
						return;
					}
				}
				else
				{
					this.class34_0.method_2(new Class9.Class22(0));
					if (!flag2)
					{
						return;
					}
				}
				this.int_0 = (int)this.object_0 - 1;
				return;
			}
			case (Class9.Enum4)44:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class9.Enum4)45:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				Class9.Class20 class20_ = this.class34_0.method_4();
				Class9.Class21 class3 = Class9.Class18.smethod_1(class20_);
				if (class3 != null && class2 != null)
				{
					if (!class3.vmethod_76(@class))
					{
						this.class34_0.method_2(new Class9.Class22(0));
						return;
					}
					this.class34_0.method_2(new Class9.Class22(1));
					return;
				}
				else
				{
					if (@class.vmethod_5(class20_))
					{
						this.class34_0.method_2(new Class9.Class22(1));
						return;
					}
					this.class34_0.method_2(new Class9.Class22(0));
					return;
				}
				break;
			}
			case (Class9.Enum4)46:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_68());
				return;
			}
			case (Class9.Enum4)47:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class9).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class34_0.method_2(new Class9.Class32(obj));
				return;
			}
			case (Class9.Enum4)48:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_28());
				return;
			}
			case (Class9.Enum4)49:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_37());
				return;
			}
			case (Class9.Enum4)50:
			case (Class9.Enum4)63:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class20 @class = this.class34_0.method_4();
				object obj = @class.vmethod_3(type);
				if (obj == null)
				{
					if (!type.IsValueType)
					{
						@class = new Class9.Class32(null);
					}
					else
					{
						obj = Activator.CreateInstance(type);
						@class = Class9.Class20.smethod_1(type, obj);
					}
				}
				else
				{
					if (type.IsValueType)
					{
						obj = Class9.Class18.smethod_9(obj);
					}
					@class = Class9.Class20.smethod_1(type, obj);
				}
				Class9.Class26 class5 = this.class34_0.method_4() as Class9.Class26;
				if (class5 == null)
				{
					throw new Class9.Exception1();
				}
				class5.vmethod_9(@class);
				return;
			}
			case (Class9.Enum4)51:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_56(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)52:
			{
				Class9.Class20 class6 = Class9.Class18.smethod_6(this.class34_0.method_4());
				Class9.Class20 @class = Class9.Class18.smethod_6(this.class34_0.method_4());
				if (class6.vmethod_4(@class))
				{
					this.class34_0.method_2(new Class9.Class22(1));
					return;
				}
				this.class34_0.method_2(new Class9.Class22(0));
				return;
			}
			case (Class9.Enum4)53:
				this.class34_0.method_2(this.class20_0[(int)this.object_0]);
				return;
			case (Class9.Enum4)54:
			{
				int[] array3 = (int[])this.object_0;
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				long num2 = class2.vmethod_19().struct2_0.long_0;
				if ((num2 < 0L || class2.method_4()) && IntPtr.Size == 4)
				{
					num2 = (long)((int)num2);
				}
				if (class2.method_1())
				{
					Class9.Class22 class7 = (Class9.Class22)class2;
					if (class7.enum2_0 == (Class9.Enum2)6)
					{
						num2 = (long)((ulong)class7.struct1_0.uint_0);
					}
				}
				if (num2 < (long)array3.Length && num2 >= 0L)
				{
					this.int_0 = array3[(int)(checked((IntPtr)num2))] - 1;
				}
				return;
			}
			case (Class9.Enum4)55:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_24();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)56:
				this.bool_2 = true;
				return;
			case (Class9.Enum4)57:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				object obj = this.class34_0.method_4().vmethod_7().vmethod_3(type);
				Class9.Class20 @class = Class9.Class20.smethod_1(type, obj);
				this.class34_0.method_2(@class);
				return;
			}
			case (Class9.Enum4)58:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_47());
				return;
			}
			case (Class9.Enum4)59:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_31());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)60:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_70(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)61:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_43());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)64:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class9.Enum4)65:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class9).Module.ResolveType(num);
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Array array2 = Array.CreateInstance(elementType, class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(new Class9.Class32(array2));
				return;
			}
			case (Class9.Enum4)66:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				object obj = this.class34_0.method_4().vmethod_3(null);
				this.class34_0.method_2(Class9.Class20.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class9.Enum4)67:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_27());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22(*(uint*)((void*)intPtr), (Class9.Enum2)6));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)68:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_80(@class))
				{
					this.class34_0.method_2(new Class9.Class22(1));
					return;
				}
				this.class34_0.method_2(new Class9.Class22(0));
				return;
			}
			case (Class9.Enum4)69:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class9.Enum4)70:
				return;
			case (Class9.Enum4)71:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_21());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22((int)(*(sbyte*)((void*)intPtr)), (Class9.Enum2)1));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)72:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_24());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)73:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_22());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class22((int)(*(short*)((void*)intPtr)), (Class9.Enum2)3));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)74:
			{
				Class9.Class20 @class = this.class20_1[(int)this.object_0];
				this.class34_0.method_2(@class);
				return;
			}
			case (Class9.Enum4)75:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.iFavIhWly7())
				{
					object obj = @class.vmethod_3(null);
					if (obj == null)
					{
						@class = new Class9.Class32(null);
					}
					else
					{
						@class = Class9.Class20.smethod_1(obj.GetType(), obj);
					}
					this.class34_0.method_2(@class);
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)76:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_63(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)77:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class9).Module.ResolveMethod(num);
				Type type = this.class34_0.method_4().vmethod_3(null).GetType();
				List<Type> list = new List<Type>();
				do
				{
					list.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class34_0.method_2(new Class9.Class24(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class9.Enum4)78:
			{
				int num = (int)this.object_0;
				typeof(Class9).Module.ResolveType(num);
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Array array2 = (Array)this.class34_0.method_4().vmethod_3(null);
				this.class34_0.method_2(new Class9.Class28(class2.vmethod_17().struct1_0.int_0, array2));
				return;
			}
			case (Class9.Enum4)79:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_38());
				return;
			}
			case (Class9.Enum4)80:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class9).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array4 = new object[parameters.Length];
				Class9.Class20[] array5 = new Class9.Class20[parameters.Length];
				List<Class9.Class16> list2 = null;
				Class9.Class17 class8 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class9.Class20 @class = this.class34_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag = false;
					if (type.IsByRef)
					{
						Class9.Class29 class9 = @class as Class9.Class29;
						if (class9 != null)
						{
							if (list2 == null)
							{
								list2 = new List<Class9.Class16>();
							}
							list2.Add(new Class9.Class16(class9.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class9.object_0;
							if (!(obj2 is Class9.Class20))
							{
								flag = true;
							}
							else
							{
								@class = (obj2 as Class9.Class20);
							}
						}
					}
					if (!flag)
					{
						if (@class != null)
						{
							obj2 = @class.vmethod_3(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (@class is Class9.Class27)
								{
									((Class9.Class26)@class).vmethod_11(Class9.Class20.smethod_1(type, obj2));
								}
							}
						}
					}
					array5[array4.Length - 1 - i] = @class;
					array4[array4.Length - 1 - i] = obj2;
				}
				Class9.Delegate10 @delegate = null;
				if (list2 != null)
				{
					class8 = new Class9.Class17(constructorInfo, list2);
					@delegate = Class9.Class18.smethod_4(constructorInfo, true, class8);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array4);
				}
				else
				{
					obj = constructorInfo.Invoke(array4);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class8 == null || !class8.method_1(j)))
					{
						if (!array5[j].method_2())
						{
							if (array5[j] is Class9.Class27)
							{
								array5[j].vmethod_9(Class9.Class20.smethod_1(parameters[j].ParameterType.GetElementType(), array4[j]));
							}
							else
							{
								array5[j].vmethod_9(Class9.Class20.smethod_1(parameters[j].ParameterType, array4[j]));
							}
						}
						else
						{
							((Class9.Class24)array5[j]).method_6(Class9.Class20.smethod_1(parameters[j].ParameterType, array4[j]));
						}
					}
				}
				this.class34_0.method_2(Class9.Class20.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class9.Enum4)81:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Array array6 = (Array)this.class34_0.method_4().vmethod_3(null);
				object obj = array6.GetValue(class2.vmethod_17().struct1_0.int_0);
				Type type = array6.GetType().GetElementType();
				this.class34_0.method_2(Class9.Class20.smethod_1(type, obj));
				return;
			}
			case (Class9.Enum4)82:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_73(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)83:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_54(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)84:
				this.class34_0.method_2(new Class9.Class27((int)this.object_0, this));
				return;
			case (Class9.Enum4)86:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_39());
				return;
			}
			case (Class9.Enum4)87:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_32());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)88:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_64(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)89:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_79(@class))
				{
					this.class34_0.method_2(new Class9.Class22(1));
					return;
				}
				this.class34_0.method_2(new Class9.Class22(0));
				return;
			}
			case (Class9.Enum4)90:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				((Array)this.class34_0.method_4().vmethod_3(null)).SetValue(@class.vmethod_3(type), class2.vmethod_17().struct1_0.int_0);
				return;
			}
			case (Class9.Enum4)91:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.zLqpmHyYrP());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)92:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_62(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)93:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_45());
				return;
			}
			case (Class9.Enum4)94:
				this.class34_0.method_2(((Class9.Class21)this.class34_0.method_4()).vmethod_53());
				return;
			case (Class9.Enum4)95:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_34());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)96:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_25());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)97:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_46());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class25(*(double*)((void*)intPtr), (Class9.Enum2)10));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)98:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(float), obj));
				return;
			}
			case (Class9.Enum4)99:
				this.class34_0.method_2(new Class9.Class23((long)this.object_0));
				return;
			case (Class9.Enum4)100:
				this.method_12(false);
				return;
			case (Class9.Enum4)102:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_65(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)104:
			{
				if (Class9.list_0.Count != 0)
				{
					this.class34_0.method_2(new Class9.Class33(Class9.list_0[(int)this.object_0]));
					return;
				}
				Module module = typeof(Class9).Module;
				this.class34_0.method_2(new Class9.Class33(module.ResolveString((int)this.object_0 | 1879048192)));
				return;
			}
			case (Class9.Enum4)105:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class9.Enum4)106:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_42());
				return;
			}
			case (Class9.Enum4)107:
			{
				int num = (int)this.object_0;
				uint num3 = (uint)Class9.Class18.smethod_0(typeof(Class9).Module.ResolveType(num));
				this.class34_0.method_2(new Class9.Class22(num3, (Class9.Enum2)6));
				return;
			}
			case (Class9.Enum4)109:
				this.bool_3 = (bool)this.class34_0.method_4().vmethod_3(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class9.Enum4)110:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_21();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)111:
				this.class34_0.method_2(new Class9.Class25((double)this.object_0));
				return;
			case (Class9.Enum4)112:
			{
				Class9.Class21 class2 = this.class34_0.method_4() as Class9.Class21;
				IntPtr intPtr = Class9.Class18.smethod_8(this.class34_0.method_4());
				IntPtr intPtr2 = Class9.Class18.smethod_8(this.class34_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num3 = class2.vmethod_18().struct1_0.uint_0;
					Class9.Class18.smethod_11(intPtr2, intPtr, num3);
				}
				return;
			}
			case (Class9.Enum4)113:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(short), obj));
				return;
			}
			case (Class9.Enum4)114:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(long), obj));
				return;
			}
			case (Class9.Enum4)116:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_30());
				return;
			}
			case (Class9.Enum4)117:
			{
				int num = (int)this.object_0;
				if (this.class15_0.object_0.IsStatic)
				{
					this.class20_0[num] = this.method_8(this.class34_0.method_4(), this.class15_0.class11_0[num].enum2_0, false);
					return;
				}
				this.class20_0[num] = this.method_8(this.class34_0.method_4(), this.class15_0.class11_0[num - 1].enum2_0, false);
				return;
			}
			case (Class9.Enum4)118:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_59(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)120:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_79(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)121:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_46());
				return;
			}
			case (Class9.Enum4)122:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_49());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)124:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_36());
				return;
			}
			case (Class9.Enum4)125:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_40());
				return;
			}
			case (Class9.Enum4)126:
				this.method_12(true);
				return;
			case (Class9.Enum4)127:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_60(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)128:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class9.Enum4)129:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class26 class10 = this.class34_0.method_4() as Class9.Class26;
				if (class10 == null)
				{
					throw new Class9.Exception1();
				}
				if (!type.IsValueType)
				{
					class10.vmethod_11(new Class9.Class32(null));
					return;
				}
				object obj = Activator.CreateInstance(type);
				class10.vmethod_11(Class9.Class20.smethod_1(type, obj));
				return;
			}
			case (Class9.Enum4)131:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_45());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class9.Class24)class2).method_7();
					this.class34_0.method_2(new Class9.Class25(*(float*)((void*)intPtr), (Class9.Enum2)9));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)132:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class20 @class = this.class34_0.method_4();
				object obj = @class.vmethod_3(null);
				if (obj == null)
				{
					this.class34_0.method_2(new Class9.Class32(null));
					return;
				}
				if (type.IsAssignableFrom(obj.GetType()))
				{
					this.class34_0.method_2(@class);
					return;
				}
				this.class34_0.method_2(new Class9.Class32(null));
				return;
			}
			case (Class9.Enum4)133:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(int), obj));
				return;
			}
			case (Class9.Enum4)134:
			{
				Type type = typeof(Class9).Module.ResolveType((int)this.object_0);
				object obj = this.class34_0.method_4().vmethod_3(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class9.Class32 class11 = new Class9.Class32(Class9.Class20.smethod_1(type, Class9.Class18.smethod_9(obj)));
				this.class34_0.method_2(class11);
				return;
			}
			case (Class9.Enum4)135:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_72(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)136:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_51());
				return;
			}
			case (Class9.Enum4)137:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_71(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)138:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_22());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)139:
				this.class34_0.method_2(new Class9.Class32(null));
				return;
			case (Class9.Enum4)140:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_75(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)141:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_27());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)142:
			{
				Class9.Class20 class12 = this.class34_0.method_4();
				Class9.Class20 @class = this.class34_0.method_4();
				if (class12.vmethod_4(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)144:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_47();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)146:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class34_0.method_2(class2.vmethod_66(class3));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)147:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_29());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)148:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				Class9.Class21 class2 = Class9.Class18.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_47());
					return;
				}
				if (class2 == null || !class2.method_2())
				{
					throw new Class9.Exception1();
				}
				IntPtr intPtr = ((Class9.Class24)class2).method_7();
				if (IntPtr.Size == 8)
				{
					long num2 = *(long*)((void*)intPtr);
					this.class34_0.method_2(new Class9.Class24(num2, (Class9.Enum2)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class34_0.method_2(new Class9.Class24((long)num, (Class9.Enum2)12));
				return;
			}
			case (Class9.Enum4)149:
			{
				Class9.Class21 class13 = Class9.Class18.smethod_1(this.class34_0.method_3());
				if (class13 == null)
				{
					throw new ArithmeticException(((Class9.Enum6)0).ToString());
				}
				Class9.Class25 class14 = class13 as Class9.Class25;
				if (class14 != null)
				{
					if (double.IsNaN(class14.double_0))
					{
						throw new OverflowException(((Class9.Enum6)2).ToString());
					}
					if (double.IsInfinity(class14.double_0))
					{
						throw new OverflowException(((Class9.Enum6)1).ToString());
					}
				}
				return;
			}
			case (Class9.Enum4)150:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_74(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)151:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_78(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)152:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				object obj = this.class34_0.method_4().vmethod_3(fieldInfo.FieldType);
				Class9.Class20 @class = this.class34_0.method_4();
				object obj2 = @class.vmethod_3(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (@class is Class9.Class27)
					{
						((Class9.Class26)@class).vmethod_11(Class9.Class20.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class9.Enum4)153:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_35());
				return;
			}
			case (Class9.Enum4)154:
			{
				bool flag = false;
				Class9.Class20 @class = this.class34_0.method_4();
				flag = (@class == null || !@class.vmethod_6());
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)155:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_23();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)156:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class9.Enum4)157:
			{
				Class9.Class21 class2 = this.class34_0.method_4() as Class9.Class21;
				Class9.Class21 class3 = this.class34_0.method_4() as Class9.Class21;
				IntPtr intPtr = Class9.Class18.smethod_8(this.class34_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class3.vmethod_14().struct1_0.byte_0;
					uint num3 = class2.vmethod_18().struct1_0.uint_0;
					Class9.Class18.smethod_10(intPtr, byte_, (int)num3);
				}
				return;
			}
			case (Class9.Enum4)158:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 == null)
				{
					throw new Class9.Exception1();
				}
				this.class34_0.method_2(class2.vmethod_50());
				return;
			}
			case (Class9.Enum4)159:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class != null && @class.vmethod_6())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class9.Enum4)160:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class9).Module.ResolveField(num);
				object obj = this.class34_0.method_4().vmethod_3(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class9.Enum4)161:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_61(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)162:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class9.Class21)@class).vmethod_45();
				}
				this.class34_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class9.Enum4)163:
				this.class34_0.method_4();
				return;
			case (Class9.Enum4)164:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				object obj = ((Array)this.class34_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct1_0.int_0);
				this.class34_0.method_2(Class9.Class20.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class9.Enum4)165:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null)
				{
					this.class34_0.method_2(class2.vmethod_44());
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)166:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class34_0.method_2(class2.igEvpBpxrl(class3));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)167:
				this.class34_0.method_2(this.class34_0.method_4().vmethod_7());
				return;
			case (Class9.Enum4)168:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.Add(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)169:
			{
				Class9.Class20 @class = this.class34_0.method_4();
				if (Class9.Class18.smethod_1(this.class34_0.method_4()).vmethod_75(@class))
				{
					this.class34_0.method_2(new Class9.Class22(1));
					return;
				}
				this.class34_0.method_2(new Class9.Class22(0));
				return;
			}
			case (Class9.Enum4)171:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_58(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)172:
				throw (Exception)this.class34_0.method_4().vmethod_3(null);
			case (Class9.Enum4)173:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class9).Module.ResolveType(num);
				Class9.Class26 class15 = this.class34_0.method_4() as Class9.Class26;
				if (class15 != null)
				{
					object obj = class15.vmethod_3(type);
					Class9.Class20 @class;
					if (obj == null)
					{
						if (!type.IsValueType)
						{
							@class = new Class9.Class32(null);
						}
						else
						{
							obj = Activator.CreateInstance(type);
							@class = Class9.Class20.smethod_1(type, obj);
						}
					}
					else
					{
						if (type.IsValueType)
						{
							obj = Class9.Class18.smethod_9(obj);
						}
						@class = Class9.Class20.smethod_1(type, obj);
					}
					this.class34_0.method_2(@class);
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)174:
			{
				Class9.Class21 class2 = Class9.Class18.smethod_1(this.class34_0.method_4());
				Class9.Class21 class3 = Class9.Class18.smethod_1(this.class34_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class34_0.method_2(class3.vmethod_55(class2));
					return;
				}
				throw new Class9.Exception1();
			}
			case (Class9.Enum4)175:
				this.class34_0.method_2(new Class9.Class30((int)this.object_0, this));
				return;
			default:
				return;
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001A47C File Offset: 0x0001867C
		private Class9.Class20 method_8(Class9.Class20 class20_3, Class9.Enum2 enum2_0, bool bool_4 = false)
		{
			if (!bool_4 && class20_3.iFavIhWly7())
			{
				class20_3 = class20_3.vmethod_7();
			}
			if (class20_3.method_1())
			{
				return ((Class9.Class22)class20_3).vmethod_11(enum2_0);
			}
			if (class20_3.method_3())
			{
				return ((Class9.Class23)class20_3).vmethod_11(enum2_0);
			}
			if (class20_3.method_4())
			{
				return ((Class9.Class25)class20_3).vmethod_11(enum2_0);
			}
			if (!class20_3.method_2())
			{
				return class20_3;
			}
			return ((Class9.Class24)class20_3).vmethod_11(enum2_0);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000453C File Offset: 0x0000273C
		private Class9.Class20 method_9(int int_3)
		{
			return this.class20_1[int_3];
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001A4F4 File Offset: 0x000186F4
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class34_0.method_4());
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001A514 File Offset: 0x00018714
		private static int smethod_0(Type type_0)
		{
			object obj = Class9.Class18.object_1;
			int result;
			lock (obj)
			{
				if (Class9.Class18.dictionary_0 == null)
				{
					Class9.Class18.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (!Class9.Class18.dictionary_0.TryGetValue(type_0, out num))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class9.Class18.dictionary_0[type_0] = num;
						result = num;
					}
					else
					{
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001A5E8 File Offset: 0x000187E8
		private void method_11(int int_3, Class9.Class20 class20_3)
		{
			this.class20_1[int_3] = this.method_8(class20_3, this.class15_0.UqaYjxudZI[int_3].enum2_0, this.class15_0.UqaYjxudZI[int_3].bool_0);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00011D90 File Offset: 0x0000FF90
		private static Class9.Class21 smethod_1(Class9.Class20 class20_3)
		{
			Class9.Class21 @class = class20_3 as Class9.Class21;
			if (@class == null && class20_3.iFavIhWly7())
			{
				@class = (class20_3.vmethod_7() as Class9.Class21);
			}
			return @class;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001A630 File Offset: 0x00018830
		private void method_12(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class9).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class9.Class20[] array2 = new Class9.Class20[parameters.Length];
			List<Class9.Class16> list = null;
			Class9.Class17 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class9.Class20 class2 = this.class34_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class9.Class29 class3 = class2 as Class9.Class29;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class9.Class16>();
						}
						list.Add(new Class9.Class16(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (!(obj is Class9.Class20))
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (!class3.fieldInfo_0.IsStatic)
									{
										obj = Activator.CreateInstance(type);
									}
									else
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									if (class2 is Class9.Class27)
									{
										((Class9.Class26)class2).vmethod_11(Class9.Class20.smethod_1(type, obj));
									}
								}
							}
						}
						else
						{
							class2 = (obj as Class9.Class20);
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_3(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class9.Class27)
							{
								((Class9.Class26)class2).vmethod_11(Class9.Class20.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class9.Delegate10 @delegate = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class9.Class18.smethod_2(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class9.Class17(methodBase, list);
				@delegate = Class9.Class18.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class9.Class20 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class34_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_3(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class9.Class27)
					{
						((Class9.Class26)class4).vmethod_11(Class9.Class20.smethod_1(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class9.Class27)
				{
					((Class9.Class26)class4).vmethod_11(Class9.Class20.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate != null)
			{
				obj3 = @delegate(obj2, array);
			}
			else
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (!array2[j].method_2())
					{
						if (array2[j] is Class9.Class27)
						{
							array2[j].vmethod_9(Class9.Class20.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
						}
						else
						{
							array2[j].vmethod_9(Class9.Class20.smethod_1(parameters[j].ParameterType, array[j]));
						}
					}
					else
					{
						((Class9.Class24)array2[j]).method_6(Class9.Class20.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class34_0.method_2(Class9.Class20.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001AA64 File Offset: 0x00018C64
		private static Class9.Delegate10 smethod_2(object object_6, bool bool_4)
		{
			object obj = Class9.Class18.object_3;
			Class9.Delegate10 result2;
			lock (obj)
			{
				Class9.Delegate10 result = null;
				if (!bool_4)
				{
					if (Class9.Class18.dictionary_3.TryGetValue(object_6, out result))
					{
						return result;
					}
				}
				else if (Class9.Class18.dictionary_2.TryGetValue(object_6, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class9.Class18.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class9.Class18.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class9.Delegate10 @delegate = (Class9.Delegate10)dynamicMethod.CreateDelegate(typeof(Class9.Delegate10));
				if (bool_4)
				{
					Class9.Class18.dictionary_2.Add(object_6, @delegate);
				}
				else
				{
					Class9.Class18.dictionary_3.Add(object_6, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001AF14 File Offset: 0x00019114
		private static Class9.Delegate10 smethod_3(object object_6, bool bool_4, Class9.Class17 class17_0)
		{
			object obj = Class9.Class18.ivacpLcqOn;
			Class9.Delegate10 result2;
			lock (obj)
			{
				Class9.Delegate10 result = null;
				if (!bool_4)
				{
					if (Class9.Class18.dictionary_5.TryGetValue(class17_0, out result))
					{
						return result;
					}
				}
				else if (Class9.Class18.dictionary_4.TryGetValue(class17_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class9), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (class17_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class9.Class18.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class17_0.method_1(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!class17_0.method_1(l))
					{
						if (!parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
					}
					else
					{
						Class9.Class16 @class = class17_0.method_0(l);
						if (!@class.object_0.IsStatic)
						{
							if (@class.object_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
						}
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (class17_0.method_1(m))
						{
							Class9.Class16 class2 = class17_0.method_0(m);
							if (!class2.object_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class9.Class18.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class9.Class18.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
								if (class2.object_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class9.Class18.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class9.Delegate10 @delegate = (Class9.Delegate10)dynamicMethod.CreateDelegate(typeof(Class9.Delegate10));
				if (!bool_4)
				{
					Class9.Class18.dictionary_5.Add(class17_0, @delegate);
				}
				else
				{
					Class9.Class18.dictionary_4.Add(class17_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001B5C0 File Offset: 0x000197C0
		private static Class9.Delegate10 smethod_4(object object_6, bool bool_4, Class9.Class17 class17_0)
		{
			object obj = Class9.Class18.object_4;
			Class9.Delegate10 result;
			lock (obj)
			{
				Class9.Delegate10 @delegate = null;
				if (Class9.Class18.dictionary_6.TryGetValue(class17_0, out @delegate))
				{
					result = @delegate;
				}
				else
				{
					ConstructorInfo constructorInfo = object_6 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class9), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = object_6.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (!parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType;
						}
						else
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
					}
					int num = array.Length;
					if (object_6.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (!class17_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
					}
					if (object_6.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class9.Class18.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class17_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (!class17_0.method_1(l))
						{
							if (parameters[l].ParameterType.IsByRef)
							{
								ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							}
						}
						else
						{
							Class9.Class16 @class = class17_0.method_0(l);
							if (!@class.object_0.IsStatic)
							{
								if (!@class.object_0.DeclaringType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, object_6 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (class17_0.method_1(m))
							{
								Class9.Class16 class2 = class17_0.method_0(m);
								if (class2.object_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class9.Class18.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
									if (class2.object_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class9.Class18.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class9.Class18.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class9.Delegate10 delegate2 = (Class9.Delegate10)dynamicMethod.CreateDelegate(typeof(Class9.Delegate10));
					Class9.Class18.dictionary_6.Add(class17_0, delegate2);
					result = delegate2;
				}
			}
			return result;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		private static Class9.Class20 smethod_6(Class9.Class20 class20_3)
		{
			if (class20_3.vmethod_7().method_0())
			{
				object obj = class20_3.vmethod_3(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class9.Class20 @class = Class9.Class18.smethod_7(Class9.Class20.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class9.Class21;
					}
				}
			}
			return class20_3;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001BC3C File Offset: 0x00019E3C
		private static Class9.Class21 smethod_7(Class9.Class20 class20_3)
		{
			Class9.Class21 @class = class20_3 as Class9.Class21;
			if (@class == null && class20_3.iFavIhWly7())
			{
				@class = (class20_3.vmethod_7() as Class9.Class21);
			}
			return @class;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001BC6C File Offset: 0x00019E6C
		private static IntPtr smethod_8(object object_6)
		{
			if (object_6 == null)
			{
				return IntPtr.Zero;
			}
			if (object_6.method_2())
			{
				return ((Class9.Class24)object_6).method_7();
			}
			if (object_6.iFavIhWly7())
			{
				Class9.Class26 @class = (Class9.Class26)object_6;
				IntPtr result;
				try
				{
					result = @class.vmethod_10();
				}
				catch
				{
					goto IL_2C;
				}
				return result;
			}
			IL_2C:
			object obj = object_6.vmethod_3(typeof(IntPtr));
			if (obj != null && obj.GetType() == typeof(IntPtr))
			{
				return (IntPtr)obj;
			}
			throw new Class9.Exception1();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001BD04 File Offset: 0x00019F04
		private static object smethod_9(object object_6)
		{
			object obj = Class9.Class18.object_5;
			object result;
			lock (obj)
			{
				if (Class9.Class18.dictionary_7 == null)
				{
					Class9.Class18.dictionary_7 = new Dictionary<Type, Class9.Delegate11>();
				}
				if (object_6 != null)
				{
					try
					{
						Type type = object_6.GetType();
						Class9.Delegate11 @delegate;
						if (Class9.Class18.dictionary_7.TryGetValue(type, out @delegate))
						{
							return @delegate(object_6);
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
						{
							typeof(object)
						}, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Ldarg_0);
						ilgenerator.Emit(OpCodes.Unbox_Any, type);
						ilgenerator.Emit(OpCodes.Box, type);
						ilgenerator.Emit(OpCodes.Ret);
						Class9.Delegate11 delegate2 = (Class9.Delegate11)dynamicMethod.CreateDelegate(typeof(Class9.Delegate11));
						Class9.Class18.dictionary_7.Add(type, delegate2);
						return delegate2(object_6);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001BE28 File Offset: 0x0001A028
		private static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class9.Class18.object_5;
			lock (obj)
			{
				if (Class9.Class18.wRecHpubLl == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class9), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class9.Class18.wRecHpubLl = (Class9.Delegate12)dynamicMethod.CreateDelegate(typeof(Class9.Delegate12));
				}
				Class9.Class18.wRecHpubLl(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001BF20 File Offset: 0x0001A120
		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class9.Class18.delegate13_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class9), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class9.Class18.delegate13_0 = (Class9.Delegate13)dynamicMethod.CreateDelegate(typeof(Class9.Delegate13));
			}
			Class9.Class18.delegate13_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004546 File Offset: 0x00002746
		internal static void smethod_12(Class9.Class34 class34_1)
		{
			class34_1.method_1();
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00004551 File Offset: 0x00002751
		internal static void smethod_13(object object_6)
		{
			object_6.Clear();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000455C File Offset: 0x0000275C
		internal static object smethod_14(object object_6, Delegate253 delegate253_0)
		{
			return Delegate253.smethod_0(object_6, delegate253_0);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000456B File Offset: 0x0000276B
		internal static int smethod_15(List<Class9.Class13> list_1)
		{
			return list_1.Count;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004576 File Offset: 0x00002776
		internal static void smethod_16(Class9.Class34 class34_1, Class9.Class20 class20_3)
		{
			class34_1.method_2(class20_3);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_17(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_18(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004585 File Offset: 0x00002785
		internal static object smethod_19(object object_6, Delegate255 delegate255_0)
		{
			return Delegate255.smethod_0(object_6, delegate255_0);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00004594 File Offset: 0x00002794
		internal static Type smethod_20(object object_6, Delegate254 delegate254_0)
		{
			return Delegate254.smethod_0(object_6, delegate254_0);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000290B File Offset: 0x00000B0B
		internal static bool smethod_21(string string_0, string string_1, Delegate133 delegate133_0)
		{
			return Delegate133.smethod_0(string_0, string_1, delegate133_0);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_22(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000045A3 File Offset: 0x000027A3
		internal static object smethod_23(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_26();
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000045AE File Offset: 0x000027AE
		internal static object smethod_24(Class9.Class34 class34_1)
		{
			return class34_1.method_4();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000045B9 File Offset: 0x000027B9
		internal static object smethod_25(Class9.Class20 class20_3)
		{
			return Class9.Class18.smethod_1(class20_3);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00003BA6 File Offset: 0x00001DA6
		internal static object smethod_26(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_33();
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_27(Class9.Class20 class20_3)
		{
			return class20_3.iFavIhWly7();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00003C09 File Offset: 0x00001E09
		internal static bool smethod_28(Class9.Class20 class20_3)
		{
			return class20_3.method_2();
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000045C4 File Offset: 0x000027C4
		internal static IntPtr smethod_29(Class9.Class24 class24_0)
		{
			return class24_0.method_7();
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00003D43 File Offset: 0x00001F43
		internal static bool smethod_30(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_73(class20_3);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000045CF File Offset: 0x000027CF
		internal static object smethod_31(Class9.Class20 class20_3)
		{
			return Class9.Class18.smethod_6(class20_3);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00004299 File Offset: 0x00002499
		internal static object smethod_32(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_45();
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000045DA File Offset: 0x000027DA
		internal static object smethod_33(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_72(class20_3);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00003BBC File Offset: 0x00001DBC
		internal static object smethod_34(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_36();
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00003A2C File Offset: 0x00001C2C
		internal static object smethod_35(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_17();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000448F File Offset: 0x0000268F
		internal static object smethod_36(object object_6, int int_3, Delegate246 delegate246_0)
		{
			return Delegate246.smethod_0(object_6, int_3, delegate246_0);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000044A2 File Offset: 0x000026A2
		internal static object smethod_37(Type type_0, object object_6)
		{
			return Class9.Class20.smethod_1(type_0, object_6);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000045E9 File Offset: 0x000027E9
		internal static object smethod_38(object object_6, Delegate198 delegate198_0)
		{
			return Delegate198.smethod_0(object_6, delegate198_0);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000045F8 File Offset: 0x000027F8
		internal static object smethod_39(object object_6, int int_3, Delegate256 delegate256_0)
		{
			return Delegate256.smethod_0(object_6, int_3, delegate256_0);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_40(Class9.Class20 class20_3, Class9.Class20 class20_4)
		{
			return class20_3.vmethod_5(class20_4);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00003C23 File Offset: 0x00001E23
		internal static object smethod_41(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_55(class20_3);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000400F File Offset: 0x0000220F
		internal static bool smethod_42(Class9.Class20 class20_3)
		{
			return class20_3.vmethod_2();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000460B File Offset: 0x0000280B
		internal static void smethod_43(Class9.Class20 class20_3, Class9.Class20 class20_4)
		{
			class20_3.vmethod_1(class20_4);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000044C8 File Offset: 0x000026C8
		internal static Type smethod_44(object object_6, Delegate247 delegate247_0)
		{
			return Delegate247.smethod_0(object_6, delegate247_0);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000044D7 File Offset: 0x000026D7
		internal static object smethod_45(object object_6, object object_7, Delegate248 delegate248_0)
		{
			return Delegate248.smethod_0(object_6, object_7, delegate248_0);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002DFA File Offset: 0x00000FFA
		internal static object smethod_46(object object_6, int int_3, Delegate191 delegate191_0)
		{
			return Delegate191.smethod_0(object_6, int_3, delegate191_0);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_47(Class9.Class20 class20_3, Type type_0)
		{
			return class20_3.vmethod_3(type_0);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00003C50 File Offset: 0x00001E50
		internal static object smethod_48(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_59(class20_3);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002DD8 File Offset: 0x00000FD8
		internal static Type smethod_49(object object_6, int int_3, Delegate188 delegate188_0)
		{
			return Delegate188.smethod_0(object_6, int_3, delegate188_0);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000461A File Offset: 0x0000281A
		internal static object smethod_50(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_47();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00003B7A File Offset: 0x00001D7A
		internal static int smethod_51(Delegate232 delegate232_0)
		{
			return delegate232_0();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00004437 File Offset: 0x00002637
		internal static bool smethod_52(Class9.Class20 class20_3)
		{
			return class20_3.vmethod_6();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00004625 File Offset: 0x00002825
		internal static object smethod_53(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_71(class20_3);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004634 File Offset: 0x00002834
		internal static object smethod_54(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_53();
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000463F File Offset: 0x0000283F
		internal static object smethod_55(Type type_0, Delegate143 delegate143_0)
		{
			return Delegate143.smethod_0(type_0, delegate143_0);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000464E File Offset: 0x0000284E
		internal static object smethod_56(object object_6)
		{
			return Class9.Class18.smethod_9(object_6);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00004659 File Offset: 0x00002859
		internal static bool smethod_57(object object_6, Type type_0, Delegate258 delegate258_0)
		{
			return Delegate258.smethod_0(object_6, type_0, delegate258_0);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00003D34 File Offset: 0x00001F34
		internal static bool smethod_58(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_80(class20_3);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000466C File Offset: 0x0000286C
		internal static object smethod_59(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_52();
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00004248 File Offset: 0x00002448
		internal static Type smethod_60(object object_6, Delegate240 delegate240_0)
		{
			return Delegate240.smethod_0(object_6, delegate240_0);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00004677 File Offset: 0x00002877
		internal static bool smethod_61(object object_6, Delegate213 delegate213_0)
		{
			return Delegate213.smethod_0(object_6, delegate213_0);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00004686 File Offset: 0x00002886
		internal static Type smethod_62(object object_6, Delegate212 delegate212_0)
		{
			return Delegate212.smethod_0(object_6, delegate212_0);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00004428 File Offset: 0x00002628
		internal static void smethod_63(Class9.Class26 class26_0, Class9.Class20 class20_3)
		{
			class26_0.vmethod_11(class20_3);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000044B1 File Offset: 0x000026B1
		internal static void smethod_64(object object_6, object object_7, object object_8, Delegate193 delegate193_0)
		{
			Delegate193.smethod_0(object_6, object_7, object_8, delegate193_0);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00003D61 File Offset: 0x00001F61
		internal static bool smethod_65(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_75(class20_3);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00004695 File Offset: 0x00002895
		internal static object smethod_66(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_51();
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000046A0 File Offset: 0x000028A0
		internal static object smethod_67(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_56(class20_3);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00003B9B File Offset: 0x00001D9B
		internal static object smethod_68(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_35();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000046AF File Offset: 0x000028AF
		internal static bool smethod_69(object object_6, Delegate211 delegate211_0)
		{
			return Delegate211.smethod_0(object_6, delegate211_0);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000046BE File Offset: 0x000028BE
		internal static IntPtr smethod_70(object object_6)
		{
			return Class9.Class18.smethod_8(object_6);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000046C9 File Offset: 0x000028C9
		internal static bool smethod_71(IntPtr intptr_0, IntPtr intptr_1, Delegate259 delegate259_0)
		{
			return Delegate259.smethod_0(intptr_0, intptr_1, delegate259_0);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00003A37 File Offset: 0x00001C37
		internal static object smethod_72(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_18();
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000046DC File Offset: 0x000028DC
		internal static void smethod_73(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			Class9.Class18.smethod_11(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00003FF9 File Offset: 0x000021F9
		internal static object smethod_74(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_23();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00003FBA File Offset: 0x000021BA
		internal static object smethod_75(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_19();
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000043FC File Offset: 0x000025FC
		internal static bool smethod_76(Class9.Class20 class20_3)
		{
			return class20_3.method_4();
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00003BFE File Offset: 0x00001DFE
		internal static bool smethod_77(Class9.Class20 class20_3)
		{
			return class20_3.method_1();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000046EF File Offset: 0x000028EF
		internal static int smethod_78(List<string> list_1)
		{
			return list_1.Count;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000046FA File Offset: 0x000028FA
		internal static object smethod_79(object object_6, int int_3, Delegate260 delegate260_0)
		{
			return Delegate260.smethod_0(object_6, int_3, delegate260_0);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00003BC7 File Offset: 0x00001DC7
		internal static object smethod_80(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_34();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000470D File Offset: 0x0000290D
		internal static object smethod_81(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_38();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00004718 File Offset: 0x00002918
		internal static object smethod_82(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_49();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00004723 File Offset: 0x00002923
		internal static object smethod_83(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_22();
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000472E File Offset: 0x0000292E
		internal static object smethod_84(Class9.Class21 class21_0)
		{
			return class21_0.zLqpmHyYrP();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00003BB1 File Offset: 0x00001DB1
		internal static object smethod_85(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_41();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00003A58 File Offset: 0x00001C58
		internal static object smethod_86(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_14();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00004739 File Offset: 0x00002939
		internal static void smethod_87(IntPtr intptr_0, byte byte_0, int int_3)
		{
			Class9.Class18.smethod_10(intptr_0, byte_0, int_3);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00004283 File Offset: 0x00002483
		internal static object smethod_88(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_39();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000474C File Offset: 0x0000294C
		internal static int smethod_89(object object_6, Delegate261 delegate261_0)
		{
			return Delegate261.smethod_0(object_6, delegate261_0);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000043F1 File Offset: 0x000025F1
		internal static object smethod_90(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_46();
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00003FEE File Offset: 0x000021EE
		internal static object smethod_91(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_24();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_92(Class9.Class20 class20_3)
		{
			return class20_3.vmethod_7();
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_93(object object_6, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_6, delegate202_0);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00004478 File Offset: 0x00002678
		internal static void smethod_94(object object_6, object object_7, int int_3, Delegate245 delegate245_0)
		{
			Delegate245.smethod_0(object_6, object_7, int_3, delegate245_0);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void smethod_95(Class9.Class20 class20_3, Class9.Class20 class20_4)
		{
			class20_3.vmethod_9(class20_4);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000475B File Offset: 0x0000295B
		internal static object smethod_96(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_70(class20_3);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000476A File Offset: 0x0000296A
		internal static object smethod_97(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_21();
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00003D25 File Offset: 0x00001F25
		internal static bool smethod_98(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_78(class20_3);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00003C9B File Offset: 0x00001E9B
		internal static object smethod_99(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_66(class20_3);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004775 File Offset: 0x00002975
		internal static object smethod_100(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_58(class20_3);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00003CAA File Offset: 0x00001EAA
		internal static object smethod_101(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_67(class20_3);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00003C5F File Offset: 0x00001E5F
		internal static object smethod_102(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_60(class20_3);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00004262 File Offset: 0x00002462
		internal static object smethod_103(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_31();
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00004784 File Offset: 0x00002984
		internal static object smethod_104(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_50();
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000478F File Offset: 0x0000298F
		internal static object smethod_105(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_64(class20_3);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00003B90 File Offset: 0x00001D90
		internal static object smethod_106(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_27();
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000479E File Offset: 0x0000299E
		internal static object smethod_107(Class9.Class34 class34_1)
		{
			return class34_1.method_3();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000047A9 File Offset: 0x000029A9
		internal static bool smethod_108(double double_0, Delegate264 delegate264_0)
		{
			return Delegate264.smethod_0(double_0, delegate264_0);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000047B8 File Offset: 0x000029B8
		internal static bool smethod_109(double double_0, Delegate265 delegate265_0)
		{
			return Delegate265.smethod_0(double_0, delegate265_0);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00004004 File Offset: 0x00002204
		internal static object smethod_110(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_43();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00003D52 File Offset: 0x00001F52
		internal static bool smethod_111(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_74(class20_3);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00003B85 File Offset: 0x00001D85
		internal static object smethod_112(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_28();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00003CB9 File Offset: 0x00001EB9
		internal static object smethod_113(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.igEvpBpxrl(class20_3);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000047C7 File Offset: 0x000029C7
		internal static IntPtr smethod_114(int int_3, Delegate266 delegate266_0)
		{
			return Delegate266.smethod_0(int_3, delegate266_0);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000047D6 File Offset: 0x000029D6
		internal static bool smethod_115(Class9.Class21 class21_0, Class9.Class20 class20_3)
		{
			return class21_0.vmethod_79(class20_3);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000047E5 File Offset: 0x000029E5
		internal static object smethod_116(Type type_0, int int_3, Delegate267 delegate267_0)
		{
			return Delegate267.smethod_0(type_0, int_3, delegate267_0);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000047F8 File Offset: 0x000029F8
		internal static int smethod_117(Class9.Class34 class34_1)
		{
			return class34_1.method_0();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004803 File Offset: 0x00002A03
		internal static Type smethod_118(object object_6, Delegate268 delegate268_0)
		{
			return Delegate268.smethod_0(object_6, delegate268_0);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00004812 File Offset: 0x00002A12
		internal static void smethod_119(List<Type> list_1)
		{
			list_1.Reverse();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000481D File Offset: 0x00002A1D
		internal static object smethod_120(object object_6, Delegate270 delegate270_0)
		{
			return Delegate270.smethod_0(object_6, delegate270_0);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000482C File Offset: 0x00002A2C
		internal static bool smethod_121(MethodBase methodBase_0, MethodBase methodBase_1, Delegate271 delegate271_0)
		{
			return Delegate271.smethod_0(methodBase_0, methodBase_1, delegate271_0);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000483F File Offset: 0x00002A3F
		internal static void smethod_122(object object_6, Delegate208 delegate208_0)
		{
			Delegate208.smethod_0(object_6, delegate208_0);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000484E File Offset: 0x00002A4E
		internal static object smethod_123(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_25();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00003A81 File Offset: 0x00001C81
		internal static bool smethod_124(object object_6, Delegate201 delegate201_0)
		{
			return Delegate201.smethod_0(object_6, delegate201_0);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00004859 File Offset: 0x00002A59
		internal static object smethod_125(object object_6, bool bool_4, Class9.Class17 class17_0)
		{
			return Class9.Class18.smethod_4(object_6, bool_4, class17_0);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000486C File Offset: 0x00002A6C
		internal static object smethod_126(Class9.Delegate10 delegate10_0, object object_6, object[] object_7)
		{
			return delegate10_0(object_6, object_7);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000487F File Offset: 0x00002A7F
		internal static object smethod_127(ConstructorInfo constructorInfo_0, object[] object_6)
		{
			return constructorInfo_0.Invoke(object_6);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000488E File Offset: 0x00002A8E
		internal static bool smethod_128(Class9.Class17 class17_0, int int_3)
		{
			return class17_0.method_1(int_3);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000489D File Offset: 0x00002A9D
		internal static void smethod_129(Class9.Class24 class24_0, Class9.Class20 class20_3)
		{
			class24_0.method_6(class20_3);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000048AC File Offset: 0x00002AAC
		internal static Type smethod_130(object object_6, Delegate200 delegate200_0)
		{
			return Delegate200.smethod_0(object_6, delegate200_0);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000428E File Offset: 0x0000248E
		internal static object smethod_131(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_40();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000048BB File Offset: 0x00002ABB
		internal static object smethod_132(Class9.Class21 class21_0)
		{
			return class21_0.vmethod_48();
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000048C6 File Offset: 0x00002AC6
		internal static object smethod_133(Class9.Class21 class21_0, Class9.Enum2 enum2_0)
		{
			return class21_0.vmethod_11(enum2_0);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00003D00 File Offset: 0x00001F00
		internal static bool smethod_134(Class9.Class20 class20_3)
		{
			return class20_3.method_3();
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000048D5 File Offset: 0x00002AD5
		internal static object smethod_135(object object_6, Delegate272 delegate272_0)
		{
			return Delegate272.smethod_0(object_6, delegate272_0);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000048E4 File Offset: 0x00002AE4
		internal static void smethod_136(object object_6, OpCode opCode_0, Type type_0, Delegate273 delegate273_0)
		{
			Delegate273.smethod_0(object_6, opCode_0, type_0, delegate273_0);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000048FB File Offset: 0x00002AFB
		internal static void smethod_137(object object_6, OpCode opCode_0, Delegate274 delegate274_0)
		{
			Delegate274.smethod_0(object_6, opCode_0, delegate274_0);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000490E File Offset: 0x00002B0E
		internal static object smethod_138(MethodBase methodBase_0, object object_6, object[] object_7)
		{
			return methodBase_0.Invoke(object_6, object_7);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00004921 File Offset: 0x00002B21
		internal static bool smethod_139(object object_6, Delegate275 delegate275_0)
		{
			return Delegate275.smethod_0(object_6, delegate275_0);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00004930 File Offset: 0x00002B30
		internal static object smethod_140(object object_6, bool bool_4, Class9.Class17 class17_0)
		{
			return Class9.Class18.smethod_3(object_6, bool_4, class17_0);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00004943 File Offset: 0x00002B43
		internal static bool smethod_141(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate276 delegate276_0)
		{
			return Delegate276.smethod_0(methodInfo_0, methodInfo_1, delegate276_0);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00004956 File Offset: 0x00002B56
		internal static object smethod_142(object object_6, bool bool_4)
		{
			return Class9.Class18.smethod_2(object_6, bool_4);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00003A9F File Offset: 0x00001C9F
		internal static Type smethod_143(Type type_0, Delegate221 delegate221_0)
		{
			return Delegate221.smethod_0(type_0, delegate221_0);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00004965 File Offset: 0x00002B65
		internal static object smethod_144(Type type_0, Delegate277 delegate277_0)
		{
			return Delegate277.smethod_0(type_0, delegate277_0);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00004974 File Offset: 0x00002B74
		internal static Type smethod_145(object object_6, Delegate209 delegate209_0)
		{
			return Delegate209.smethod_0(object_6, delegate209_0);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00004983 File Offset: 0x00002B83
		internal static object smethod_146(object object_6, Type type_0, Delegate278 delegate278_0)
		{
			return Delegate278.smethod_0(object_6, type_0, delegate278_0);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00004996 File Offset: 0x00002B96
		internal static Type smethod_147(object object_6, Delegate279 delegate279_0)
		{
			return Delegate279.smethod_0(object_6, delegate279_0);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000049A5 File Offset: 0x00002BA5
		internal static void smethod_148(ILGenerator ilgenerator_0, int int_3)
		{
			Class9.Class18.smethod_5(ilgenerator_0, int_3);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000049B4 File Offset: 0x00002BB4
		internal static void smethod_149(object object_6, OpCode opCode_0, LocalBuilder localBuilder_0, Delegate280 delegate280_0)
		{
			Delegate280.smethod_0(object_6, opCode_0, localBuilder_0, delegate280_0);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000049CB File Offset: 0x00002BCB
		internal static void smethod_150(object object_6, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0, Delegate281 delegate281_0)
		{
			Delegate281.smethod_0(object_6, opCode_0, methodInfo_0, type_0, delegate281_0);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000049E6 File Offset: 0x00002BE6
		internal static void smethod_151(object object_6, OpCode opCode_0, ConstructorInfo constructorInfo_0, Delegate282 delegate282_0)
		{
			Delegate282.smethod_0(object_6, opCode_0, constructorInfo_0, delegate282_0);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000049FD File Offset: 0x00002BFD
		internal static bool smethod_152(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate283 delegate283_0)
		{
			return Delegate283.smethod_0(methodInfo_0, methodInfo_1, delegate283_0);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00004A10 File Offset: 0x00002C10
		internal static Type smethod_153(object object_6, Delegate284 delegate284_0)
		{
			return Delegate284.smethod_0(object_6, delegate284_0);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00004A1F File Offset: 0x00002C1F
		internal static object smethod_154(object object_6, Type type_0, Delegate285 delegate285_0)
		{
			return Delegate285.smethod_0(object_6, type_0, delegate285_0);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00004A32 File Offset: 0x00002C32
		internal static object smethod_155(object object_6, Delegate199 delegate199_0)
		{
			return Delegate199.smethod_0(object_6, delegate199_0);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00004A41 File Offset: 0x00002C41
		internal static void smethod_156(object object_6, OpCode opCode_0, FieldInfo fieldInfo_0, Delegate286 delegate286_0)
		{
			Delegate286.smethod_0(object_6, opCode_0, fieldInfo_0, delegate286_0);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00004A58 File Offset: 0x00002C58
		internal static object smethod_157(Class9.Class17 class17_0, int int_3)
		{
			return class17_0.method_0(int_3);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00004A67 File Offset: 0x00002C67
		internal static void smethod_158(object object_6, OpCode opCode_0, int int_3, Delegate288 delegate288_0)
		{
			Delegate288.smethod_0(object_6, opCode_0, int_3, delegate288_0);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_159(Class9.Class20 class20_3)
		{
			return class20_3.method_0();
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00003ADB File Offset: 0x00001CDB
		internal static Type smethod_160(Type type_0, Delegate223 delegate223_0)
		{
			return Delegate223.smethod_0(type_0, delegate223_0);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00004A7E File Offset: 0x00002C7E
		internal static object smethod_161(object object_6, Type type_0, Delegate289 delegate289_0)
		{
			return Delegate289.smethod_0(object_6, type_0, delegate289_0);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00004A91 File Offset: 0x00002C91
		internal static object smethod_162(Class9.Class20 class20_3)
		{
			return Class9.Class18.smethod_7(class20_3);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00004A9C File Offset: 0x00002C9C
		internal static IntPtr smethod_163(Class9.Class26 class26_0)
		{
			return class26_0.vmethod_10();
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00004AA7 File Offset: 0x00002CA7
		internal static object smethod_164(Class9.Delegate11 delegate11_0, object object_6)
		{
			return delegate11_0(object_6);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00004AB6 File Offset: 0x00002CB6
		internal static void smethod_165(Class9.Delegate12 delegate12_0, IntPtr a, byte b, int c)
		{
			delegate12_0(a, b, c);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00004ACD File Offset: 0x00002CCD
		internal static void smethod_166(Class9.Delegate13 delegate13_1, IntPtr s, IntPtr t, uint c)
		{
			delegate13_1(s, t, c);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_167()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_168()
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_169()
		{
		}

		// Token: 0x040000B2 RID: 178
		internal Class9.Class15 class15_0;

		// Token: 0x040000B3 RID: 179
		internal Class9.Class20[] class20_0 = new Class9.Class20[0];

		// Token: 0x040000B4 RID: 180
		internal Class9.Class20[] class20_1 = new Class9.Class20[0];

		// Token: 0x040000B5 RID: 181
		internal Class9.Class34 class34_0 = new Class9.Class34();

		// Token: 0x040000B6 RID: 182
		internal Class9.Class20 class20_2;

		// Token: 0x040000B7 RID: 183
		internal Exception exception_0;

		// Token: 0x040000B8 RID: 184
		internal List<IntPtr> list_0;

		// Token: 0x040000B9 RID: 185
		private int int_0;

		// Token: 0x040000BA RID: 186
		private int int_1;

		// Token: 0x040000BB RID: 187
		private int int_2 = -1;

		// Token: 0x040000BC RID: 188
		private object object_0;

		// Token: 0x040000BD RID: 189
		private bool bool_0;

		// Token: 0x040000BE RID: 190
		private bool bool_1;

		// Token: 0x040000BF RID: 191
		private bool bool_2;

		// Token: 0x040000C0 RID: 192
		private bool bool_3;

		// Token: 0x040000C1 RID: 193
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x040000C2 RID: 194
		private static object object_1 = new object();

		// Token: 0x040000C3 RID: 195
		private static Dictionary<object, Class9.Class20> dictionary_1 = new Dictionary<object, Class9.Class20>();

		// Token: 0x040000C4 RID: 196
		private static object object_2 = new object();

		// Token: 0x040000C5 RID: 197
		private static Dictionary<MethodBase, Class9.Delegate10> dictionary_2 = new Dictionary<MethodBase, Class9.Delegate10>();

		// Token: 0x040000C6 RID: 198
		private static Dictionary<MethodBase, Class9.Delegate10> dictionary_3 = new Dictionary<MethodBase, Class9.Delegate10>();

		// Token: 0x040000C7 RID: 199
		private static object object_3 = new object();

		// Token: 0x040000C8 RID: 200
		private static Dictionary<Class9.Class17, Class9.Delegate10> dictionary_4 = new Dictionary<Class9.Class17, Class9.Delegate10>();

		// Token: 0x040000C9 RID: 201
		private static Dictionary<Class9.Class17, Class9.Delegate10> dictionary_5 = new Dictionary<Class9.Class17, Class9.Delegate10>();

		// Token: 0x040000CA RID: 202
		private static object ivacpLcqOn = new object();

		// Token: 0x040000CB RID: 203
		private static Dictionary<Class9.Class17, Class9.Delegate10> dictionary_6 = new Dictionary<Class9.Class17, Class9.Delegate10>();

		// Token: 0x040000CC RID: 204
		private static object object_4 = new object();

		// Token: 0x040000CD RID: 205
		private static Dictionary<Type, Class9.Delegate11> dictionary_7;

		// Token: 0x040000CE RID: 206
		private static object object_5 = new object();

		// Token: 0x040000CF RID: 207
		private static Class9.Delegate12 wRecHpubLl;

		// Token: 0x040000D0 RID: 208
		private static Class9.Delegate13 delegate13_0;

		// Token: 0x02000047 RID: 71
		[CompilerGenerated]
		[Serializable]
		private sealed class Class19
		{
			// Token: 0x060006D8 RID: 1752 RVA: 0x00004AE4 File Offset: 0x00002CE4
			internal int EaecoUppfe(Class9.Class13 x, Class9.Class13 y)
			{
				return x.class14_0.int_0.CompareTo(y.class14_0.int_0);
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x00002240 File Offset: 0x00000440
			internal static void smethod_0()
			{
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00002240 File Offset: 0x00000440
			internal static void smethod_1()
			{
			}

			// Token: 0x040000D1 RID: 209
			public static readonly Class9.Class18.Class19 <>9 = new Class9.Class18.Class19();

			// Token: 0x040000D2 RID: 210
			public static Comparison<Class9.Class13> <>9__12_0;
		}
	}

	// Token: 0x02000048 RID: 72
	internal enum Enum4 : byte
	{

	}

	// Token: 0x02000049 RID: 73
	internal enum Enum5 : byte
	{

	}

	// Token: 0x0200004A RID: 74
	internal abstract class Class20
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x00006944 File Offset: 0x00004B44
		public Class20()
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00004B01 File Offset: 0x00002D01
		internal bool method_0()
		{
			return this.enum5_0 == (Class9.Enum5)0;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00004B0C File Offset: 0x00002D0C
		internal bool method_1()
		{
			return this.enum5_0 == (Class9.Enum5)1;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		internal bool method_2()
		{
			return this.enum5_0 == (Class9.Enum5)3 || this.enum5_0 == (Class9.Enum5)4;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00004B17 File Offset: 0x00002D17
		internal bool method_3()
		{
			return this.enum5_0 == (Class9.Enum5)2;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00004B22 File Offset: 0x00002D22
		internal bool method_4()
		{
			return this.enum5_0 == (Class9.Enum5)5;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00004B2D File Offset: 0x00002D2D
		internal bool method_5()
		{
			return this.enum5_0 == (Class9.Enum5)6;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004B38 File Offset: 0x00002D38
		internal virtual bool iFavIhWly7()
		{
			return false;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00004B38 File Offset: 0x00002D38
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x060006E4 RID: 1764
		internal abstract void vmethod_1(Class9.Class20 class20_0);

		// Token: 0x060006E5 RID: 1765 RVA: 0x00004B38 File Offset: 0x00002D38
		internal virtual bool vmethod_2()
		{
			return false;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001C0EC File Offset: 0x0001A2EC
		internal Class20(Class9.Enum5 enum5_1)
		{
			this.enum5_0 = enum5_1;
		}

		// Token: 0x060006E7 RID: 1767
		internal abstract object vmethod_3(Type type_0);

		// Token: 0x060006E8 RID: 1768
		internal abstract bool vmethod_4(Class9.Class20 class20_0);

		// Token: 0x060006E9 RID: 1769
		internal abstract bool vmethod_5(Class9.Class20 class20_0);

		// Token: 0x060006EA RID: 1770
		internal abstract bool vmethod_6();

		// Token: 0x060006EB RID: 1771
		internal abstract Class9.Class20 vmethod_7();

		// Token: 0x060006EC RID: 1772 RVA: 0x00004B38 File Offset: 0x00002D38
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x060006ED RID: 1773
		internal abstract void vmethod_9(Class9.Class20 class20_0);

		// Token: 0x060006EE RID: 1774 RVA: 0x0001C108 File Offset: 0x0001A308
		internal static Class9.Enum3 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class9.Enum3)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class9.Enum3)14;
			}
			if (type == typeof(byte))
			{
				return (Class9.Enum3)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class9.Enum3)1;
			}
			if (type == typeof(short))
			{
				return (Class9.Enum3)3;
			}
			if (type == typeof(ushort))
			{
				return (Class9.Enum3)4;
			}
			if (type == typeof(int))
			{
				return (Class9.Enum3)5;
			}
			if (type == typeof(uint))
			{
				return (Class9.Enum3)6;
			}
			if (type == typeof(long))
			{
				return (Class9.Enum3)7;
			}
			if (type == typeof(ulong))
			{
				return (Class9.Enum3)8;
			}
			if (type == typeof(float))
			{
				return (Class9.Enum3)9;
			}
			if (type == typeof(double))
			{
				return (Class9.Enum3)10;
			}
			if (type == typeof(bool))
			{
				return (Class9.Enum3)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class9.Enum3)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class9.Enum3)13;
			}
			if (type == typeof(char))
			{
				return (Class9.Enum3)15;
			}
			if (type == typeof(object))
			{
				return (Class9.Enum3)0;
			}
			if (!type.IsEnum)
			{
				return (Class9.Enum3)17;
			}
			return (Class9.Enum3)16;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		internal static Class9.Class20 smethod_1(Type type_0, object object_0)
		{
			Class9.Enum3 @enum = Class9.Class20.smethod_0(type_0);
			Class9.Enum3 enum2 = (Class9.Enum3)18;
			if (object_0 != null)
			{
				enum2 = Class9.Class20.smethod_0(object_0.GetType());
			}
			Class9.Class20 @class = null;
			switch (@enum)
			{
			case (Class9.Enum3)0:
				if (enum2 == (Class9.Enum3)15)
				{
					@class = new Class9.Class32(object_0);
				}
				else
				{
					@class = Class9.Class20.smethod_2(object_0);
				}
				break;
			case (Class9.Enum3)1:
				if (enum2 <= (Class9.Enum3)2)
				{
					if (enum2 == (Class9.Enum3)1)
					{
						@class = new Class9.Class22((int)((sbyte)object_0), (Class9.Enum2)1);
						break;
					}
					if (enum2 == (Class9.Enum3)2)
					{
						@class = new Class9.Class22((int)((sbyte)((byte)object_0)), (Class9.Enum2)1);
						break;
					}
				}
				else if (enum2 != (Class9.Enum3)11)
				{
					if (enum2 == (Class9.Enum3)15)
					{
						@class = new Class9.Class22((int)((sbyte)((char)object_0)), (Class9.Enum2)1);
						break;
					}
				}
				else
				{
					if (!(bool)object_0)
					{
						@class = new Class9.Class22(0, (Class9.Enum2)1);
						break;
					}
					@class = new Class9.Class22(1, (Class9.Enum2)1);
					break;
				}
				throw new InvalidCastException();
			case (Class9.Enum3)2:
				if (enum2 <= (Class9.Enum3)2)
				{
					if (enum2 == (Class9.Enum3)1)
					{
						@class = new Class9.Class22((int)((byte)((sbyte)object_0)), (Class9.Enum2)2);
						break;
					}
					if (enum2 == (Class9.Enum3)2)
					{
						@class = new Class9.Class22((int)((byte)object_0), (Class9.Enum2)2);
						break;
					}
				}
				else if (enum2 != (Class9.Enum3)11)
				{
					if (enum2 == (Class9.Enum3)15)
					{
						@class = new Class9.Class22((int)((byte)((char)object_0)), (Class9.Enum2)2);
						break;
					}
				}
				else
				{
					if (!(bool)object_0)
					{
						@class = new Class9.Class22(0, (Class9.Enum2)2);
						break;
					}
					@class = new Class9.Class22(1, (Class9.Enum2)2);
					break;
				}
				throw new InvalidCastException();
			case (Class9.Enum3)3:
				if (enum2 != (Class9.Enum3)3)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class22((int)((short)((char)object_0)), (Class9.Enum2)3);
					}
					else if (!(bool)object_0)
					{
						@class = new Class9.Class22(0, (Class9.Enum2)3);
					}
					else
					{
						@class = new Class9.Class22(1, (Class9.Enum2)3);
					}
				}
				else
				{
					@class = new Class9.Class22((int)((short)object_0), (Class9.Enum2)3);
				}
				break;
			case (Class9.Enum3)4:
				if (enum2 != (Class9.Enum3)4)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class22((int)((char)object_0), (Class9.Enum2)4);
					}
					else if (!(bool)object_0)
					{
						@class = new Class9.Class22(0, (Class9.Enum2)4);
					}
					else
					{
						@class = new Class9.Class22(1, (Class9.Enum2)4);
					}
				}
				else
				{
					@class = new Class9.Class22((int)((ushort)object_0), (Class9.Enum2)4);
				}
				break;
			case (Class9.Enum3)5:
				if (enum2 != (Class9.Enum3)5)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class22((int)((char)object_0), (Class9.Enum2)5);
					}
					else if (!(bool)object_0)
					{
						@class = new Class9.Class22(0, (Class9.Enum2)5);
					}
					else
					{
						@class = new Class9.Class22(1, (Class9.Enum2)5);
					}
				}
				else
				{
					@class = new Class9.Class22((int)object_0, (Class9.Enum2)5);
				}
				break;
			case (Class9.Enum3)6:
				if (enum2 != (Class9.Enum3)6)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class22((uint)((char)object_0), (Class9.Enum2)6);
					}
					else if ((bool)object_0)
					{
						@class = new Class9.Class22(1U, (Class9.Enum2)6);
					}
					else
					{
						@class = new Class9.Class22(0U, (Class9.Enum2)6);
					}
				}
				else
				{
					@class = new Class9.Class22((uint)object_0, (Class9.Enum2)6);
				}
				break;
			case (Class9.Enum3)7:
				if (enum2 != (Class9.Enum3)7)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class23((long)((ulong)((char)object_0)), (Class9.Enum2)7);
					}
					else if (!(bool)object_0)
					{
						@class = new Class9.Class23(0L, (Class9.Enum2)7);
					}
					else
					{
						@class = new Class9.Class23(1L, (Class9.Enum2)7);
					}
				}
				else
				{
					@class = new Class9.Class23((long)object_0, (Class9.Enum2)7);
				}
				break;
			case (Class9.Enum3)8:
				if (enum2 != (Class9.Enum3)8)
				{
					if (enum2 != (Class9.Enum3)11)
					{
						if (enum2 != (Class9.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class9.Class23((ulong)((char)object_0), (Class9.Enum2)8);
					}
					else if (!(bool)object_0)
					{
						@class = new Class9.Class23(0UL, (Class9.Enum2)8);
					}
					else
					{
						@class = new Class9.Class23(1UL, (Class9.Enum2)8);
					}
				}
				else
				{
					@class = new Class9.Class23((ulong)object_0, (Class9.Enum2)8);
				}
				break;
			case (Class9.Enum3)9:
				if (enum2 != (Class9.Enum3)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class9.Class25((float)object_0);
				break;
			case (Class9.Enum3)10:
				if (enum2 != (Class9.Enum3)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class9.Class25((double)object_0);
				break;
			case (Class9.Enum3)11:
				switch (enum2)
				{
				case (Class9.Enum3)1:
					@class = new Class9.Class22((sbyte)object_0 != 0);
					goto IL_67D;
				case (Class9.Enum3)2:
					@class = new Class9.Class22((byte)object_0 > 0);
					goto IL_67D;
				case (Class9.Enum3)3:
					@class = new Class9.Class22((short)object_0 != 0);
					goto IL_67D;
				case (Class9.Enum3)4:
					@class = new Class9.Class22((ushort)object_0 > 0);
					goto IL_67D;
				case (Class9.Enum3)5:
					@class = new Class9.Class22((int)object_0 != 0);
					goto IL_67D;
				case (Class9.Enum3)6:
					@class = new Class9.Class22((uint)object_0 > 0U);
					goto IL_67D;
				case (Class9.Enum3)7:
					@class = new Class9.Class22((long)object_0 != 0L);
					goto IL_67D;
				case (Class9.Enum3)8:
					@class = new Class9.Class22((ulong)object_0 > 0UL);
					goto IL_67D;
				case (Class9.Enum3)9:
				case (Class9.Enum3)10:
				case (Class9.Enum3)12:
				case (Class9.Enum3)13:
				case (Class9.Enum3)14:
				case (Class9.Enum3)15:
				case (Class9.Enum3)16:
					throw new InvalidCastException();
				case (Class9.Enum3)11:
					@class = new Class9.Class22((bool)object_0);
					goto IL_67D;
				case (Class9.Enum3)18:
					@class = new Class9.Class22(false);
					goto IL_67D;
				}
				@class = new Class9.Class22(object_0 != null);
				break;
			case (Class9.Enum3)12:
				if (enum2 != (Class9.Enum3)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class9.Class24((IntPtr)object_0);
				break;
			case (Class9.Enum3)13:
				if (enum2 != (Class9.Enum3)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class9.Class24((UIntPtr)object_0);
				break;
			case (Class9.Enum3)14:
				@class = new Class9.Class33(object_0 as string);
				break;
			case (Class9.Enum3)15:
				switch (enum2)
				{
				case (Class9.Enum3)1:
					@class = new Class9.Class22((int)((sbyte)object_0), (Class9.Enum2)15);
					break;
				case (Class9.Enum3)2:
					@class = new Class9.Class22((int)((byte)object_0), (Class9.Enum2)15);
					break;
				case (Class9.Enum3)3:
					@class = new Class9.Class22((int)((short)object_0), (Class9.Enum2)15);
					break;
				case (Class9.Enum3)4:
					@class = new Class9.Class22((int)((ushort)object_0), (Class9.Enum2)15);
					break;
				case (Class9.Enum3)5:
					@class = new Class9.Class22((int)object_0, (Class9.Enum2)15);
					break;
				case (Class9.Enum3)6:
					@class = new Class9.Class22((int)((uint)object_0), (Class9.Enum2)15);
					break;
				default:
					if (enum2 != (Class9.Enum3)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class9.Class22((int)((char)object_0), (Class9.Enum2)15);
					break;
				}
				break;
			case (Class9.Enum3)16:
			case (Class9.Enum3)17:
				@class = Class9.Class20.smethod_2(object_0);
				break;
			case (Class9.Enum3)18:
				throw new InvalidCastException();
			}
			IL_67D:
			if (type_0.IsByRef)
			{
				@class = new Class9.Class31(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001C978 File Offset: 0x0001AB78
		private static Class9.Class20 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class9.Class20 @class = Class9.Class20.smethod_3(Class9.Class20.smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class9.Class21;
				}
			}
			return new Class9.Class32(object_0);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00011D90 File Offset: 0x0000FF90
		private static Class9.Class21 smethod_3(Class9.Class20 class20_0)
		{
			Class9.Class21 @class = class20_0 as Class9.Class21;
			if (@class == null && class20_0.iFavIhWly7())
			{
				@class = (class20_0.vmethod_7() as Class9.Class21);
			}
			return @class;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_4()
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_5()
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_6(Type type_0, Type type_1, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_0, type_1, delegate210_0);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00003A9F File Offset: 0x00001C9F
		internal static Type smethod_7(Type type_0, Delegate221 delegate221_0)
		{
			return Delegate221.smethod_0(type_0, delegate221_0);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_8(Type type_0, Type type_1, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_0, type_1, delegate203_0);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_9(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00004B3B File Offset: 0x00002D3B
		internal static Class9.Enum3 smethod_10(Type type_0)
		{
			return Class9.Class20.smethod_0(type_0);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00004B46 File Offset: 0x00002D46
		internal static object smethod_11(object object_0)
		{
			return Class9.Class20.smethod_2(object_0);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00003A81 File Offset: 0x00001C81
		internal static bool smethod_12(object object_0, Delegate201 delegate201_0)
		{
			return Delegate201.smethod_0(object_0, delegate201_0);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_13(object object_0, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_0, delegate202_0);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00004248 File Offset: 0x00002448
		internal static Type smethod_14(object object_0, Delegate240 delegate240_0)
		{
			return Delegate240.smethod_0(object_0, delegate240_0);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00003ACC File Offset: 0x00001CCC
		internal static bool smethod_15(object object_0, Delegate222 delegate222_0)
		{
			return Delegate222.smethod_0(object_0, delegate222_0);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00003ADB File Offset: 0x00001CDB
		internal static Type smethod_16(Type type_0, Delegate223 delegate223_0)
		{
			return Delegate223.smethod_0(type_0, delegate223_0);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00004B51 File Offset: 0x00002D51
		internal static object smethod_17(Class9.Class20 class20_0)
		{
			return Class9.Class20.smethod_3(class20_0);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_18(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_19(Class9.Class20 class20_0)
		{
			return class20_0.vmethod_7();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_20()
		{
		}

		// Token: 0x040000D5 RID: 213
		internal Class9.Enum5 enum5_0;
	}

	// Token: 0x0200004B RID: 75
	private class Class32 : Class9.Class20
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x0001C9D0 File Offset: 0x0001ABD0
		public Class32() : this(null)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		internal override void vmethod_9(Class9.Class20 class20_1)
		{
			if (class20_1 is Class9.Class32)
			{
				this.class20_0 = ((Class9.Class32)class20_1).class20_0;
				this.type_0 = ((Class9.Class32)class20_1).type_0;
				return;
			}
			this.class20_0 = class20_1.vmethod_7();
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_1)
		{
			this.vmethod_9(class20_1);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001CA28 File Offset: 0x0001AC28
		public Class32(object object_0) : base((Class9.Enum5)0)
		{
			this.class20_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001CA4C File Offset: 0x0001AC4C
		public Class32(object object_0, Type type_1) : base((Class9.Enum5)0)
		{
			this.class20_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001CA70 File Offset: 0x0001AC70
		public override string ToString()
		{
			if (this.class20_0 != null)
			{
				return this.class20_0.ToString();
			}
			return ((Class9.Enum6)5).ToString();
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		internal override object vmethod_3(Type type_1)
		{
			if (this.class20_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class20_0 is Class9.Class20))
			{
				object obj = this.class20_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class9.Class20)this.class20_0).vmethod_3(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class9.Class20)this.class20_0).vmethod_3(this.type_0);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001CC94 File Offset: 0x0001AE94
		internal override bool vmethod_4(Class9.Class20 class20_1)
		{
			if (class20_1.iFavIhWly7())
			{
				return ((Class9.Class26)class20_1).vmethod_4(this);
			}
			object obj = this.vmethod_3(null);
			object obj2 = class20_1.vmethod_3(null);
			return obj == obj2;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001CCCC File Offset: 0x0001AECC
		internal override bool vmethod_5(Class9.Class20 class20_1)
		{
			if (class20_1.iFavIhWly7())
			{
				return ((Class9.Class26)class20_1).vmethod_5(this);
			}
			object obj = this.vmethod_3(null);
			object obj2 = class20_1.vmethod_3(null);
			return obj != obj2;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001CD08 File Offset: 0x0001AF08
		internal override Class9.Class20 vmethod_7()
		{
			Class9.Class20 @class = this.class20_0 as Class9.Class20;
			if (@class != null)
			{
				return @class.vmethod_7();
			}
			return this;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001CD30 File Offset: 0x0001AF30
		internal override bool vmethod_6()
		{
			if (this.class20_0 != null)
			{
				Class9.Class20 @class = this.class20_0 as Class9.Class20;
				return @class == null || @class.vmethod_3(null) != null;
			}
			return false;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_21()
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00003BF3 File Offset: 0x00001DF3
		internal static object smethod_22(Class9.Class20 class20_1)
		{
			return class20_1.vmethod_7();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_23()
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000028FC File Offset: 0x00000AFC
		internal static object smethod_24(object object_0, Delegate132 delegate132_0)
		{
			return Delegate132.smethod_0(object_0, delegate132_0);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00003A81 File Offset: 0x00001C81
		internal static bool smethod_25(object object_0, Delegate201 delegate201_0)
		{
			return Delegate201.smethod_0(object_0, delegate201_0);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00003A90 File Offset: 0x00001C90
		internal static Type smethod_26(object object_0, Delegate202 delegate202_0)
		{
			return Delegate202.smethod_0(object_0, delegate202_0);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00004248 File Offset: 0x00002448
		internal static Type smethod_27(object object_0, Delegate240 delegate240_0)
		{
			return Delegate240.smethod_0(object_0, delegate240_0);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000029C2 File Offset: 0x00000BC2
		internal static Type smethod_28(RuntimeTypeHandle runtimeTypeHandle_0, Delegate75 delegate75_0)
		{
			return Delegate75.smethod_0(runtimeTypeHandle_0, delegate75_0);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00003AAE File Offset: 0x00001CAE
		internal static bool smethod_29(Type type_1, Type type_2, Delegate203 delegate203_0)
		{
			return Delegate203.smethod_0(type_1, type_2, delegate203_0);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004B5C File Offset: 0x00002D5C
		internal static RuntimeMethodHandle smethod_30(object object_0, Delegate262 delegate262_0)
		{
			return Delegate262.smethod_0(object_0, delegate262_0);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00003A6E File Offset: 0x00001C6E
		internal static bool smethod_31(Type type_1, Type type_2, Delegate210 delegate210_0)
		{
			return Delegate210.smethod_0(type_1, type_2, delegate210_0);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_32(Class9.Class20 class20_1, Type type_1)
		{
			return class20_1.vmethod_3(type_1);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004B6B File Offset: 0x00002D6B
		internal static RuntimeTypeHandle smethod_33(object object_0, Delegate292 delegate292_0)
		{
			return Delegate292.smethod_0(object_0, delegate292_0);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_34(Class9.Class20 class20_1)
		{
			return class20_1.iFavIhWly7();
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_35(Class9.Class20 class20_1, Class9.Class20 class20_2)
		{
			return class20_1.vmethod_5(class20_2);
		}

		// Token: 0x040000D6 RID: 214
		public Class9.Class20 class20_0;

		// Token: 0x040000D7 RID: 215
		public Type type_0;
	}

	// Token: 0x0200004C RID: 76
	private class Class33 : Class9.Class20
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x0001CD68 File Offset: 0x0001AF68
		public Class33(string string_1) : base((Class9.Enum5)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001CD84 File Offset: 0x0001AF84
		internal override void vmethod_9(Class9.Class20 class20_0)
		{
			this.string_0 = ((Class9.Class33)class20_0).string_0;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		internal override void vmethod_1(Class9.Class20 class20_0)
		{
			this.vmethod_9(class20_0);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001CDA4 File Offset: 0x0001AFA4
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class9.Enum6)5).ToString();
			}
			return '*'.ToString() + this.string_0 + '*'.ToString();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00004B7A File Offset: 0x00002D7A
		internal override bool vmethod_6()
		{
			return this.string_0 != null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00004B85 File Offset: 0x00002D85
		internal override object vmethod_3(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		internal override bool vmethod_4(Class9.Class20 class20_0)
		{
			if (class20_0.iFavIhWly7())
			{
				return ((Class9.Class26)class20_0).vmethod_4(this);
			}
			object obj = this.string_0;
			object obj2 = class20_0.vmethod_3(null);
			return obj == obj2;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001CE24 File Offset: 0x0001B024
		internal override bool vmethod_5(Class9.Class20 class20_0)
		{
			if (!class20_0.iFavIhWly7())
			{
				object obj = this.string_0;
				object obj2 = class20_0.vmethod_3(null);
				return obj != obj2;
			}
			return ((Class9.Class26)class20_0).vmethod_5(this);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00003A1E File Offset: 0x00001C1E
		internal override Class9.Class20 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_21()
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void smethod_22(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			class20_0.vmethod_9(class20_1);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal static bool smethod_23(Class9.Class20 class20_0)
		{
			return class20_0.iFavIhWly7();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static bool smethod_24(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_4(class20_1);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00003D0B File Offset: 0x00001F0B
		internal static bool smethod_25(Class9.Class20 class20_0, Class9.Class20 class20_1)
		{
			return class20_0.vmethod_5(class20_1);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00004239 File Offset: 0x00002439
		internal static object smethod_26(Class9.Class20 class20_0, Type type_0)
		{
			return class20_0.vmethod_3(type_0);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_27()
		{
		}

		// Token: 0x040000D8 RID: 216
		public string string_0;
	}

	// Token: 0x0200004D RID: 77
	internal class Class34
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x00004B8D File Offset: 0x00002D8D
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001CE74 File Offset: 0x0001B074
		public void method_2(Class9.Class20 class20_0)
		{
			this.list_0.Add(class20_0);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00004B9A File Offset: 0x00002D9A
		public Class9.Class20 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public Class9.Class20 method_4()
		{
			Class9.Class20 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00004BE1 File Offset: 0x00002DE1
		internal static int smethod_0(List<Class9.Class20> list_1)
		{
			return list_1.Count;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00004BEC File Offset: 0x00002DEC
		internal static void smethod_1(List<Class9.Class20> list_1)
		{
			list_1.Clear();
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00004BF7 File Offset: 0x00002DF7
		internal static void smethod_2(List<Class9.Class20> list_1, int int_0)
		{
			list_1.RemoveAt(int_0);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_3()
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_4()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_5()
		{
		}

		// Token: 0x040000D9 RID: 217
		private List<Class9.Class20> list_0 = new List<Class9.Class20>();
	}

	// Token: 0x0200004E RID: 78
	internal enum Enum6
	{

	}

	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	[Serializable]
	private sealed class Class35<T>
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00004AE4 File Offset: 0x00002CE4
		internal int method_0(Class9.Class13 x, Class9.Class13 y)
		{
			return x.class14_0.int_0.CompareTo(y.class14_0.int_0);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00004C06 File Offset: 0x00002E06
		internal static bool smethod_0()
		{
			return Class9.Class35<T>.object_0 == null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00004C10 File Offset: 0x00002E10
		internal static object smethod_1()
		{
			return Class9.Class35<T>.object_0;
		}

		// Token: 0x040000DB RID: 219
		public static readonly Class9.Class35<T> <>9 = new Class9.Class35<T>();

		// Token: 0x040000DC RID: 220
		public static Comparison<Class9.Class13> <>9__45_0;

		// Token: 0x040000DD RID: 221
		private static object object_0;
	}
}
