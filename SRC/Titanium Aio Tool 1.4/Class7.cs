using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000025 RID: 37
internal class Class7
{
	// Token: 0x060002A5 RID: 677 RVA: 0x0000EB68 File Offset: 0x0000CD68
	private static void smethod_0()
	{
		if (!Class7.bool_0)
		{
			Class2.Class5 @class = new Class2.Class5(typeof(Class2).Assembly.GetManifestResourceStream("CdstBadrUfm4XalApp.un0hZBpusepQmITp4P"));
			@class.method_0().Position = 0L;
			byte[] buffer = new byte[0];
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 67;
			array2[0] = 119;
			array2[0] = 152;
			array2[0] = 227;
			array2[1] = 140;
			array2[1] = 101;
			array2[1] = 161;
			array2[1] = 130;
			array2[1] = 126;
			array2[2] = 93;
			array2[2] = 173;
			array2[2] = 164;
			array2[2] = 221;
			array2[3] = 101;
			array2[3] = 200;
			array2[3] = 120;
			array2[3] = 96;
			array2[4] = 143;
			array2[4] = 91;
			array2[4] = 100;
			array2[4] = 69;
			array2[4] = 176;
			array2[4] = 146;
			array2[5] = 116;
			array2[5] = 88;
			array2[5] = 137;
			array2[5] = 214;
			array2[5] = 206;
			array2[5] = 47;
			array2[6] = 93;
			array2[6] = 134;
			array2[6] = 215;
			array2[6] = 35;
			array2[7] = 170;
			array2[7] = 86;
			array2[7] = 105;
			array2[7] = 170;
			array2[7] = 134;
			array2[8] = 235;
			array2[8] = 99;
			array2[8] = 103;
			array2[8] = 160;
			array2[8] = 3;
			array2[9] = 119;
			array2[9] = 94;
			array2[9] = 112;
			array2[9] = 94;
			array2[9] = 97;
			array2[9] = 129;
			array2[10] = 140;
			array2[10] = 121;
			array2[10] = 118;
			array2[10] = 202;
			array2[11] = 86;
			array2[11] = 158;
			array2[11] = 158;
			array2[11] = 98;
			array2[12] = 180;
			array2[12] = 138;
			array2[12] = 107;
			array2[12] = 148;
			array2[13] = 157;
			array2[13] = 78;
			array2[13] = 57;
			array2[14] = 34;
			array2[14] = 91;
			array2[14] = 111;
			array2[14] = 252;
			array2[15] = 150;
			array2[15] = 160;
			array2[15] = 41;
			array2[15] = 53;
			array2[15] = 93;
			array2[16] = 99;
			array2[16] = 114;
			array2[16] = 224;
			array2[16] = 124;
			array2[16] = 107;
			array2[16] = 137;
			array2[17] = 107;
			array2[17] = 106;
			array2[17] = 126;
			array2[17] = 108;
			array2[17] = 99;
			array2[18] = 159;
			array2[18] = 113;
			array2[18] = 99;
			array2[18] = 76;
			array2[19] = 151;
			array2[19] = 13;
			array2[19] = 153;
			array2[20] = 151;
			array2[20] = 99;
			array2[20] = 194;
			array2[20] = 63;
			array2[20] = 131;
			array2[20] = 234;
			array2[21] = 177;
			array2[21] = 88;
			array2[21] = 157;
			array2[22] = 144;
			array2[22] = 156;
			array2[22] = 94;
			array2[22] = 165;
			array2[22] = 200;
			array2[23] = 162;
			array2[23] = 94;
			array2[23] = 112;
			array2[23] = 156;
			array2[24] = 35;
			array2[24] = 168;
			array2[24] = 69;
			array2[25] = 95;
			array2[25] = 114;
			array2[25] = 38;
			array2[26] = 75;
			array2[26] = 146;
			array2[26] = 129;
			array2[26] = 155;
			array2[26] = 164;
			array2[26] = 129;
			array2[27] = 112;
			array2[27] = 134;
			array2[27] = 49;
			array2[28] = 124;
			array2[28] = 107;
			array2[28] = 240;
			array2[29] = 138;
			array2[29] = 79;
			array2[29] = 158;
			array2[30] = 97;
			array2[30] = 34;
			array2[30] = 103;
			array2[30] = 108;
			array2[30] = 164;
			array2[31] = 132;
			array2[31] = 162;
			array2[31] = 117;
			array2[31] = 105;
			array2[31] = 120;
			array2[31] = 112;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 110;
			array4[0] = 122;
			array4[0] = 196;
			array4[1] = 34;
			array4[1] = 226;
			array4[1] = 102;
			array4[1] = 225;
			array4[2] = 137;
			array4[2] = 105;
			array4[2] = 233;
			array4[3] = 98;
			array4[3] = 120;
			array4[3] = 14;
			array4[4] = 134;
			array4[4] = 166;
			array4[4] = 152;
			array4[4] = 219;
			array4[4] = 189;
			array4[4] = 67;
			array4[5] = 160;
			array4[5] = 144;
			array4[5] = 27;
			array4[6] = 19;
			array4[6] = 72;
			array4[6] = 150;
			array4[6] = 113;
			array4[6] = 175;
			array4[7] = 167;
			array4[7] = 185;
			array4[7] = 116;
			array4[7] = 254;
			array4[8] = 85;
			array4[8] = 144;
			array4[8] = 193;
			array4[8] = 127;
			array4[8] = 41;
			array4[8] = 10;
			array4[9] = 126;
			array4[9] = 107;
			array4[9] = 140;
			array4[9] = 114;
			array4[9] = 176;
			array4[9] = 117;
			array4[10] = 24;
			array4[10] = 135;
			array4[10] = 246;
			array4[11] = 129;
			array4[11] = 126;
			array4[11] = 178;
			array4[12] = 153;
			array4[12] = 89;
			array4[12] = 188;
			array4[12] = 168;
			array4[12] = 144;
			array4[12] = 115;
			array4[13] = 123;
			array4[13] = 145;
			array4[13] = 84;
			array4[13] = 213;
			array4[14] = 174;
			array4[14] = 51;
			array4[14] = 160;
			array4[14] = 118;
			array4[14] = 112;
			array4[14] = 44;
			array4[15] = 122;
			array4[15] = 130;
			array4[15] = 85;
			array4[15] = 86;
			array4[15] = 164;
			array4[15] = 50;
			byte[] array5 = array4;
			int num = 1;
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num2 = array6.Length % 4;
			int num3 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num4 = array3.Length / 4;
			uint num5 = 0U;
			if (num2 > 0)
			{
				num3++;
			}
			for (int j = 0; j < num3; j++)
			{
				int num6 = j % num4;
				int num7 = j * 4;
				uint num8 = (uint)(num6 * 4);
				uint num9 = (uint)((int)array3[(int)(num8 + 3U)] << 24 | (int)array3[(int)(num8 + 2U)] << 16 | (int)array3[(int)(num8 + 1U)] << 8 | (int)array3[(int)num8]);
				uint num10 = 255U;
				int num11 = 0;
				uint num12;
				if (j == num3 - 1 && num2 > 0)
				{
					num12 = 0U;
					num5 += num9;
					for (int k = 0; k < num2; k++)
					{
						if (k > 0)
						{
							num12 <<= 8;
						}
						num12 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num8 = (uint)num7;
					num5 += num9;
					num12 = (uint)((int)array6[(int)(num8 + 3U)] << 24 | (int)array6[(int)(num8 + 2U)] << 16 | (int)array6[(int)(num8 + 1U)] << 8 | (int)array6[(int)num8]);
				}
				uint num14;
				uint num13 = num14 = num5;
				num14 = (uint)((ulong)(num14 * num14) % 2972135889UL);
				num14 ^= num14 >> 1;
				num14 += num14;
				num14 ^= num14 >> 10;
				num14 += 2288434064U;
				num14 ^= num14 << 3;
				num14 += 95980245U;
				num14 = (2868317296U ^ num14) + num14;
				num5 = num13 + (uint)num14;
				if (j == num3 - 1 && num2 > 0)
				{
					uint num15 = num5 ^ num12;
					for (int l = 0; l < num2; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array7[num7 + l] = (byte)((num15 & num10) >> num11);
					}
				}
				else
				{
					uint num16 = num5 ^ num12;
					array7[num7] = (byte)(num16 & 255U);
					array7[num7 + 1] = (byte)((num16 & 65280U) >> 8);
					array7[num7 + 2] = (byte)((num16 & 16711680U) >> 16);
					array7[num7 + 3] = (byte)((num16 & 4278190080U) >> 24);
				}
			}
			buffer = array7;
			if (num == 0)
			{
				Class7.object_0 = Class7.Class8.smethod_6(buffer);
			}
			else if (num != 1)
			{
				Class7.object_0 = Class7.Class8.smethod_6(Class7.Class8.smethod_7(buffer, 0U));
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream deflateStream = new DeflateStream(new MemoryStream(buffer), CompressionMode.Decompress))
				{
					deflateStream.CopyTo(memoryStream);
				}
				Class7.object_0 = Class7.Class8.smethod_6(memoryStream.ToArray());
				memoryStream.Dispose();
			}
			Class7.string_0 = ((Assembly)Class7.object_0).GetManifestResourceNames();
			Class7.bool_0 = true;
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000FA2C File Offset: 0x0000DC2C
	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class7).Assembly)
		{
			if (!Class7.bool_0)
			{
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)Class7.object_0).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000FA8C File Offset: 0x0000DC8C
	private static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Class7.bool_0)
		{
		}
		string name = resolveEventArgs_0.Name;
		for (int i = 0; i < Class7.string_0.Length; i++)
		{
			if (Class7.string_0[i] == name)
			{
				return (Assembly)Class7.object_0;
			}
		}
		return null;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0000361C File Offset: 0x0000181C
	public Class7()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class7.smethod_2;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000363A File Offset: 0x0000183A
	internal static void smethod_3()
	{
		if (!Class7.bool_1)
		{
			Class7.bool_1 = true;
			new Class7();
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00003076 File Offset: 0x00001276
	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002D83 File Offset: 0x00000F83
	internal static object smethod_5(Assembly assembly_0, string string_1)
	{
		return assembly_0.GetManifestResourceStream(string_1);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002FA6 File Offset: 0x000011A6
	internal static object smethod_6(Class2.Class5 class5_0)
	{
		return class5_0.method_0();
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002D69 File Offset: 0x00000F69
	internal static void smethod_7(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002FB1 File Offset: 0x000011B1
	internal static long smethod_8(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002FBC File Offset: 0x000011BC
	internal static object smethod_9(Class2.Class5 class5_0, int int_0)
	{
		return class5_0.method_1(int_0);
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000366E File Offset: 0x0000186E
	internal static object smethod_10(object object_1)
	{
		return Class7.Class8.smethod_6(object_1);
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00003679 File Offset: 0x00001879
	internal static void smethod_11(Stream stream_0, Stream stream_1)
	{
		stream_0.CopyTo(stream_1);
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002D78 File Offset: 0x00000F78
	internal static void smethod_12(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00003397 File Offset: 0x00001597
	internal static object smethod_13(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00003688 File Offset: 0x00001888
	internal static void smethod_14(Stream stream_0)
	{
		stream_0.Dispose();
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00003693 File Offset: 0x00001893
	internal static object smethod_15(object object_1, uint uint_0)
	{
		return Class7.Class8.smethod_7(object_1, uint_0);
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x000036A2 File Offset: 0x000018A2
	internal static object smethod_16(Assembly assembly_0)
	{
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00003062 File Offset: 0x00001262
	internal static bool smethod_17()
	{
		return null == null;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00003068 File Offset: 0x00001268
	internal static object smethod_18()
	{
		return null;
	}

	// Token: 0x04000069 RID: 105
	private static string[] string_0 = new string[0];

	// Token: 0x0400006A RID: 106
	private static object object_0 = null;

	// Token: 0x0400006B RID: 107
	private static bool bool_0 = false;

	// Token: 0x0400006C RID: 108
	private static bool bool_1 = false;

	// Token: 0x02000026 RID: 38
	private enum Enum1
	{

	}

	// Token: 0x02000027 RID: 39
	internal class Class8
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
		{
			uint result = 0U;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)pVoid_0;
			}
			else
			{
				switch (uint_0)
				{
				case 1U:
					result = (uint)(*(byte*)pVoid_0);
					break;
				case 2U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8);
					break;
				case 3U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16);
					break;
				case 4U:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16 | (int)((byte*)pVoid_0)[3] << 24);
					break;
				}
			}
			return result;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		private unsafe static bool smethod_1(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0U;
			while (flag && num < uint_0)
			{
				flag = (((byte*)pVoid_0)[num] == ((byte*)pVoid_1)[num]);
				num += 1U;
			}
			return flag;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000FB78 File Offset: 0x0000DD78
		private unsafe static void smethod_2(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000FB98 File Offset: 0x0000DD98
		private unsafe static void smethod_3(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		private unsafe static void jgnloPbgcx(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5U)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					return;
				}
				byte* ptr = pByte_0 + uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					pByte_0 += 4;
					pByte_1 += 4;
				}
				return;
			}
			else
			{
				if (uint_0 > 8U && pByte_1 + uint_0 < pByte_0)
				{
					Class7.Class8.smethod_3((void*)pByte_0, (void*)pByte_1, uint_0);
					return;
				}
				byte* ptr2 = pByte_0 + uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
				return;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000FC20 File Offset: 0x0000DE20
		private unsafe static uint smethod_4(object object_0, uint uint_0, Class7.Enum1 enum1_0)
		{
			uint result;
			fixed (byte[] array = object_0)
			{
				byte* ptr;
				if (object_0 != null && array.Length != 0)
				{
					ptr = &array[0];
				}
				else
				{
					ptr = null;
				}
				result = *(uint*)(ptr + uint_0 + (IntPtr)enum1_0 * 4);
			}
			return result;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000FC54 File Offset: 0x0000DE54
		private unsafe static uint smethod_5(object object_0, uint uint_0, object object_1)
		{
			byte* ptr;
			if (object_0 != null && object_0.Length != 0)
			{
				ptr = ref object_0[0];
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (object_1 != null && object_1.Length != 0)
			{
				ptr2 = ref object_1[0];
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = ptr + uint_0;
			uint num = 32U;
			byte* ptr4 = ptr3 + 32;
			byte* ptr5 = ptr2;
			uint* ptr6 = (uint*)ptr3;
			byte* ptr7 = ptr2 + Class7.Class8.smethod_0((void*)(ptr6 + 3), 4U);
			uint num2 = 1U;
			uint[] array = new uint[]
			{
				4U,
				0U,
				1U,
				0U,
				2U,
				0U,
				1U,
				0U,
				3U,
				0U,
				1U,
				0U,
				2U,
				0U,
				1U,
				0U
			};
			byte* ptr8 = ptr7 - 4;
			if (Class7.Class8.smethod_0((void*)(ptr6 + 4), 4U) != 1U)
			{
				Class7.Class8.smethod_3((void*)ptr2, (void*)(ptr3 + num), Class7.Class8.smethod_0((void*)(ptr6 + 3), 4U));
				return Class7.Class8.smethod_0((void*)(ptr6 + 3), 4U);
			}
			if (ptr5 >= ptr8)
			{
				ptr4 += 4;
				while (ptr5 < ptr7)
				{
					*ptr5 = *ptr4;
					ptr5++;
					ptr4++;
				}
				return (uint)((long)(ptr5 - ptr2));
			}
			for (;;)
			{
				if (num2 == 1U)
				{
					num2 = Class7.Class8.smethod_0((void*)ptr4, 4U);
					ptr4 += 4;
				}
				uint num3 = Class7.Class8.smethod_0((void*)ptr4, 4U);
				if ((num2 & 1U) == 1U)
				{
					num2 >>= 1;
					if ((num3 & 3U) == 0U)
					{
						uint num4 = (num3 & 255U) >> 2;
						Class7.Class8.jgnloPbgcx(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4++;
					}
					else if ((num3 & 2U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 2;
						Class7.Class8.jgnloPbgcx(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4 += 2;
					}
					else if ((num3 & 1U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 6;
						uint num5 = (num3 >> 2 & 15U) + 3U;
						Class7.Class8.jgnloPbgcx(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 2;
					}
					else if ((num3 & 4U) == 0U)
					{
						uint num4 = (num3 & 16777215U) >> 8;
						uint num5 = (num3 >> 3 & 31U) + 3U;
						Class7.Class8.jgnloPbgcx(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
					else if ((num3 & 8U) == 0U)
					{
						uint num4 = num3 >> 15;
						uint num5 = (num3 >> 4 & 2047U) + 3U;
						Class7.Class8.jgnloPbgcx(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 4;
					}
					else
					{
						byte byte_ = (byte)(num3 >> 16);
						uint num5 = num3 >> 4 & 4095U;
						Class7.Class8.smethod_2((void*)ptr5, byte_, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
				}
				else
				{
					Class7.Class8.jgnloPbgcx(ptr5, ptr4, 4U);
					ptr5 += array[(int)(num2 & 15U)];
					ptr4 += array[(int)(num2 & 15U)];
					num2 >>= (int)((byte)array[(int)(num2 & 15U)]);
					if (ptr5 >= ptr8)
					{
						break;
					}
				}
			}
			while (ptr5 < ptr7)
			{
				if (num2 == 1U)
				{
					ptr4 += 4;
					num2 = 2147483648U;
				}
				*ptr5 = *ptr4;
				ptr5++;
				ptr4++;
				num2 >>= 1;
			}
			return (uint)((long)(ptr5 - ptr2));
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000036AD File Offset: 0x000018AD
		internal static object smethod_6(object object_0)
		{
			return typeof(Assembly).GetMethod("Load ".Trim(), new Type[]
			{
				typeof(byte[])
			}).Invoke(null, new object[]
			{
				object_0
			});
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000FF44 File Offset: 0x0000E144
		public static byte[] smethod_7(object object_0, uint uint_0)
		{
			uint num = Class7.Class8.smethod_4(object_0, uint_0, (Class7.Enum1)3);
			byte[] array = null;
			if (num != 0U)
			{
				array = new byte[num];
				Class7.Class8.smethod_5(object_0, uint_0, array);
			}
			return array;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000036EB File Offset: 0x000018EB
		internal static uint smethod_8(object object_0, uint uint_0, Class7.Enum1 enum1_0)
		{
			return Class7.Class8.smethod_4(object_0, uint_0, enum1_0);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000034E8 File Offset: 0x000016E8
		internal static void smethod_9(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002335 File Offset: 0x00000535
		internal static object smethod_10(int int_0)
		{
			return Class2.smethod_17(int_0);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000036FE File Offset: 0x000018FE
		internal static object smethod_11(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003076 File Offset: 0x00001276
		internal static Type smethod_12(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003709 File Offset: 0x00001909
		internal static uint smethod_13(object object_0, uint uint_0)
		{
			return Class7.Class8.smethod_4(object_0, uint_0, (Class7.Enum1)3);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003719 File Offset: 0x00001919
		internal static uint smethod_14(object object_0, uint uint_0, object object_1)
		{
			return Class7.Class8.smethod_5(object_0, uint_0, object_1);
		}
	}
}
