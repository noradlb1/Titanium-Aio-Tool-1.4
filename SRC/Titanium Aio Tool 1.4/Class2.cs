using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000013 RID: 19
internal class Class2
{
	// Token: 0x06000191 RID: 401 RVA: 0x0000B55C File Offset: 0x0000975C
	static Class2()
	{
		Class2.tMmvmVecn = typeof(Class2).Assembly;
		Class2.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class2.bool_4 = false;
		Class2.bool_0 = false;
		Class2.object_1 = null;
		Class2.dictionary_0 = null;
		Class2.object_0 = new object();
		Class2.int_1 = 0;
		Class2.object_2 = new object();
		Class2.list_1 = null;
		Class2.list_0 = null;
		Class2.byte_1 = new byte[0];
		Class2.byte_0 = new byte[0];
		Class2.intptr_3 = IntPtr.Zero;
		Class2.intptr_1 = IntPtr.Zero;
		Class2.string_0 = new string[0];
		Class2.int_3 = new int[0];
		Class2.int_2 = 1;
		Class2.bool_1 = false;
		Class2.sortedList_0 = new SortedList();
		Class2.int_5 = 0;
		Class2.long_0 = 0L;
		Class2.delegate2_1 = null;
		Class2.delegate2_0 = null;
		Class2.long_1 = 0L;
		Class2.int_0 = 0;
		Class2.bool_3 = false;
		Class2.BmwDsdqaTf = false;
		Class2.int_4 = 0;
		Class2.intptr_2 = IntPtr.Zero;
		Class2.firstrundone = false;
		Class2.hashtable_0 = new Hashtable();
		Class2.delegate4_0 = null;
		Class2.delegate5_0 = null;
		Class2.delegate6_0 = null;
		Class2.delegate7_0 = null;
		Class2.delegate8_0 = null;
		Class2.delegate9_0 = null;
		Class2.intptr_0 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002240 File Offset: 0x00000440
	private void method_0()
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000B6D8 File Offset: 0x000098D8
	internal static byte[] smethod_0(object object_3)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - object_3.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)object_3.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)object_3.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < object_3.Length; i++)
		{
			array2[i] = object_3[i];
		}
		byte[] array3 = array2;
		int num4 = object_3.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class2.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class2.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class2.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class2.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class2.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class2.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class2.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class2.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class2.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class2.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class2.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class2.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class2.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class2.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class2.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class2.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class2.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002E2F File Offset: 0x0000102F
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_3[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002E58 File Offset: 0x00001058
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_3[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002E81 File Offset: 0x00001081
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_3[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002EA7 File Offset: 0x000010A7
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_3[(int)uint_5] + Class2.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002ECE File Offset: 0x000010CE
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002EE0 File Offset: 0x000010E0
	internal static bool smethod_6()
	{
		if (!Class2.bool_4)
		{
			Class2.smethod_8();
			Class2.bool_4 = true;
		}
		return Class2.bool_0;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002EF9 File Offset: 0x000010F9
	internal Class2()
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000BD38 File Offset: 0x00009F38
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 = (uint)((ulong)(num13 * num13) % 2972135889UL);
			num13 ^= num13 >> 1;
			num13 += num13;
			num13 ^= num13 >> 10;
			num13 += 2288434064U;
			num13 ^= num13 << 3;
			num13 += 95980245U;
			num13 = (2868317296U ^ num13) + num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num14 & num9) >> num10);
				}
			}
			else
			{
				uint num15 = num4 ^ num11;
				array[num6] = (byte)(num15 & 255U);
				array[num6 + 1] = (byte)((num15 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
			}
		}
		Class2.byte_1 = array;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000BF74 File Offset: 0x0000A174
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class2.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class2.bool_0 = true;
			return;
		}
		try
		{
			Class2.bool_0 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002F01 File Offset: 0x00001101
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class2.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class2.smethod_0(byte_2);
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000C040 File Offset: 0x0000A240
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class2.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002F1C File Offset: 0x0000111C
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000C07C File Offset: 0x0000A27C
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_13()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
	public static void smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class2.dictionary_0 == null)
			{
				object obj = Class2.object_0;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class2).Assembly.GetManifestResourceStream("5QoPIrapxlQXF6qQH1.cy9wZEGgIhRq9ZrFO5"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							num10 = (uint)((ulong)(num10 * num10) % 2972135889UL);
							num10 ^= num10 >> 1;
							num10 += num10;
							num10 ^= num10 >> 10;
							num10 += 2288434064U;
							num10 ^= num10 << 3;
							num10 += 95980245U;
							num10 = (2868317296U ^ num10) + num10;
							num3 = num9 + (uint)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num11 & num5) >> num6);
								}
							}
							else
							{
								uint num12 = num3 ^ num7;
								array2[num4] = (byte)(num12 & 255U);
								array2[num4 + 1] = (byte)((num12 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num12 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num12 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num13 = array.Length / 8;
						Class2.Class5 @class = new Class2.Class5(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class2.dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num14 = Class2.dictionary_0[metadataToken];
					bool flag2 = (num14 & 1073741824) > 0;
					num14 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(Class2).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num15 = parameters.Length + 1;
						Type[] array3 = new Type[num15];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num16 = 0; num16 < num15; num16++)
						{
							switch (num16)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num16);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_15()
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0000C5FC File Offset: 0x0000A7FC
	private static void smethod_16(object object_3, int int_6)
	{
		Class9.smethod_2(0, new object[]
		{
			object_3,
			int_6
		}, null);
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0000C63C File Offset: 0x0000A83C
	internal static string smethod_17(int int_6)
	{
		if (Class2.byte_1.Length == 0)
		{
			Class2.list_1 = new List<string>();
			Class2.list_0 = new List<int>();
			Class2.smethod_16(Class2.tMmvmVecn.GetManifestResourceStream("YjDXrV30bQhwtLS7FM.oijJoYKTNFPRfAEEDn"), int_6);
		}
		if (Class2.int_1 < 75)
		{
			if (Class2.tMmvmVecn != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			Class2.int_1++;
		}
		object obj = Class2.object_2;
		lock (obj)
		{
			int num = BitConverter.ToInt32(Class2.byte_1, int_6);
			if (num >= Class2.list_0.Count || Class2.list_0[num] != int_6)
			{
				try
				{
					byte[] array = new byte[num];
					Array.Copy(Class2.byte_1, int_6 + 4, array, 0, num);
					string @string = Encoding.Unicode.GetString(array, 0, array.Length);
					Class2.list_1.Add(@string);
					Class2.list_0.Add(int_6);
					Array.Copy(BitConverter.GetBytes(Class2.list_1.Count - 1), 0, Class2.byte_1, int_6, 4);
					return @string;
				}
				catch
				{
					goto IL_128;
				}
			}
			return Class2.list_1[num];
		}
		IL_128:
		return "";
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000C794 File Offset: 0x0000A994
	internal static string smethod_18(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
	internal static uint smethod_19(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr ptr = intptr_6;
		if (Class2.bool_2)
		{
			ptr = intptr_5;
		}
		long num;
		if (IntPtr.Size == 4)
		{
			num = (long)Marshal.ReadInt32(ptr, IntPtr.Size * 2);
		}
		else
		{
			num = Marshal.ReadInt64(ptr, IntPtr.Size * 2);
		}
		object obj = Class2.hashtable_0[num];
		if (obj == null)
		{
			return Class2.delegate2_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		Class2.Struct0 @struct = (Class2.Struct0)obj;
		IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
		Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
		if (@struct.MuWlxphtb0)
		{
			intptr_7 = intPtr;
			uint_2 = (uint)@struct.byte_0.Length;
			Class2.smethod_28(intptr_7, @struct.byte_0.Length, 64, ref Class2.int_4);
			return 0U;
		}
		Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
		Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
		uint result = 0U;
		if (uint_1 == 216669565U && !Class2.firstrundone)
		{
			Class2.firstrundone = true;
		}
		else
		{
			result = Class2.delegate2_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		return result;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002F2A File Offset: 0x0000112A
	private static int smethod_20()
	{
		return 5;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
	private static void smethod_21()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0000C910 File Offset: 0x0000AB10
	private static Delegate smethod_22(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0000C970 File Offset: 0x0000AB70
	internal unsafe static void smethod_23()
	{
		if (!Class2.bool_1)
		{
			Class2.bool_1 = true;
			long num = 0L;
			Marshal.ReadIntPtr(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt32(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt64(new IntPtr((void*)(&num)), 0);
			Marshal.WriteIntPtr(new IntPtr((void*)(&num)), 0, IntPtr.Zero);
			Marshal.WriteInt32(new IntPtr((void*)(&num)), 0, 0);
			Marshal.WriteInt64(new IntPtr((void*)(&num)), 0, 0L);
			Marshal.Copy(new byte[1], 0, Marshal.AllocCoTaskMem(8), 1);
			Class2.smethod_21();
			if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", false) != null)
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (processModule.ModuleName.ToLower() == "clrjit.dll")
					{
						Version v = new Version(processModule.FileVersionInfo.ProductMajorPart, processModule.FileVersionInfo.ProductMinorPart, processModule.FileVersionInfo.ProductBuildPart, processModule.FileVersionInfo.ProductPrivatePart);
						Version v2 = new Version(4, 0, 30319, 17020);
						Version v3 = new Version(4, 0, 30319, 17921);
						if (v >= v2 && v < v3)
						{
							Class2.bool_2 = true;
							break;
						}
					}
				}
			}
			Class2.Class5 @class = new Class2.Class5(Class2.tMmvmVecn.GetManifestResourceStream("JpFd7eW0fffF5fAsgK.EP1jRMnRVwdVfrh54D"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 121;
			array2[0] = 139;
			array2[0] = 96;
			array2[0] = 225;
			array2[1] = 113;
			array2[1] = 154;
			array2[1] = 215;
			array2[2] = 71;
			array2[2] = 173;
			array2[2] = 11;
			array2[3] = 127;
			array2[3] = 124;
			array2[3] = 154;
			array2[3] = 136;
			array2[3] = 125;
			array2[3] = 252;
			array2[4] = 187;
			array2[4] = 131;
			array2[4] = 158;
			array2[4] = 165;
			array2[5] = 101;
			array2[5] = 144;
			array2[5] = 96;
			array2[5] = 247;
			array2[6] = 145;
			array2[6] = 77;
			array2[6] = 153;
			array2[7] = 168;
			array2[7] = 153;
			array2[7] = 33;
			array2[7] = 91;
			array2[7] = 86;
			array2[7] = 146;
			array2[8] = 146;
			array2[8] = 88;
			array2[8] = 142;
			array2[9] = 211;
			array2[9] = 91;
			array2[9] = 30;
			array2[10] = 113;
			array2[10] = 120;
			array2[10] = 166;
			array2[10] = 143;
			array2[10] = 4;
			array2[11] = 103;
			array2[11] = 129;
			array2[11] = 157;
			array2[12] = 153;
			array2[12] = 106;
			array2[12] = 130;
			array2[12] = 165;
			array2[12] = 124;
			array2[13] = 103;
			array2[13] = 126;
			array2[13] = 103;
			array2[13] = 112;
			array2[14] = 125;
			array2[14] = 126;
			array2[14] = 126;
			array2[14] = 109;
			array2[14] = 165;
			array2[15] = 86;
			array2[15] = 114;
			array2[15] = 144;
			array2[15] = 232;
			array2[16] = 154;
			array2[16] = 143;
			array2[16] = 98;
			array2[16] = 100;
			array2[16] = 146;
			array2[16] = 86;
			array2[17] = 95;
			array2[17] = 61;
			array2[17] = 142;
			array2[17] = 88;
			array2[17] = 205;
			array2[18] = 145;
			array2[18] = 152;
			array2[18] = 155;
			array2[18] = 143;
			array2[18] = 4;
			array2[19] = 145;
			array2[19] = 150;
			array2[19] = 156;
			array2[19] = 211;
			array2[19] = 8;
			array2[20] = 106;
			array2[20] = 69;
			array2[20] = 127;
			array2[20] = 208;
			array2[20] = 239;
			array2[21] = 45;
			array2[21] = 118;
			array2[21] = 75;
			array2[22] = 108;
			array2[22] = 124;
			array2[22] = 124;
			array2[22] = 201;
			array2[23] = 154;
			array2[23] = 66;
			array2[23] = 92;
			array2[23] = 93;
			array2[23] = 161;
			array2[23] = 105;
			array2[24] = 156;
			array2[24] = 120;
			array2[24] = 54;
			array2[24] = 102;
			array2[24] = 122;
			array2[24] = 55;
			array2[25] = 156;
			array2[25] = 58;
			array2[25] = 86;
			array2[25] = 102;
			array2[25] = 191;
			array2[26] = 105;
			array2[26] = 122;
			array2[26] = 92;
			array2[27] = 149;
			array2[27] = 118;
			array2[27] = 131;
			array2[27] = 102;
			array2[27] = 32;
			array2[28] = 134;
			array2[28] = 120;
			array2[28] = 129;
			array2[28] = 202;
			array2[29] = 185;
			array2[29] = 139;
			array2[29] = 159;
			array2[29] = 106;
			array2[30] = 120;
			array2[30] = 69;
			array2[30] = 18;
			array2[31] = 128;
			array2[31] = 86;
			array2[31] = 119;
			array2[31] = 105;
			array2[31] = 97;
			array2[31] = 70;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 121;
			array4[0] = 135;
			array4[0] = 28;
			array4[0] = 130;
			array4[0] = 158;
			array4[0] = 118;
			array4[1] = 146;
			array4[1] = 98;
			array4[1] = 123;
			array4[1] = 160;
			array4[2] = 173;
			array4[2] = 158;
			array4[2] = 249;
			array4[3] = 124;
			array4[3] = 124;
			array4[3] = 124;
			array4[3] = 90;
			array4[3] = 164;
			array4[3] = 114;
			array4[4] = 84;
			array4[4] = 158;
			array4[4] = 111;
			array4[4] = 101;
			array4[4] = 242;
			array4[5] = 128;
			array4[5] = 88;
			array4[5] = 127;
			array4[6] = 112;
			array4[6] = 44;
			array4[6] = 60;
			array4[7] = 135;
			array4[7] = 116;
			array4[7] = 98;
			array4[7] = 115;
			array4[8] = 68;
			array4[8] = 132;
			array4[8] = 146;
			array4[8] = 75;
			array4[8] = 183;
			array4[9] = 193;
			array4[9] = 101;
			array4[9] = 113;
			array4[9] = 68;
			array4[10] = 197;
			array4[10] = 98;
			array4[10] = 62;
			array4[11] = 114;
			array4[11] = 131;
			array4[11] = 106;
			array4[11] = 186;
			array4[11] = 124;
			array4[11] = 207;
			array4[12] = 106;
			array4[12] = 194;
			array4[12] = 59;
			array4[12] = 144;
			array4[12] = 53;
			array4[12] = 237;
			array4[13] = 106;
			array4[13] = 144;
			array4[13] = 140;
			array4[13] = 68;
			array4[13] = 62;
			array4[14] = 149;
			array4[14] = 49;
			array4[14] = 184;
			array4[15] = 104;
			array4[15] = 111;
			array4[15] = 189;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class2.tMmvmVecn.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
				Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
			}
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
					num5 += num9;
					num12 = 0U;
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
				num5 = num5;
				uint num13 = num5;
				uint num14 = num5;
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
			byte[] array8 = array7;
			int num17 = array8.Length / 8;
			byte[] array9;
			byte* ptr;
			if ((array9 = array8) != null && array9.Length != 0)
			{
				ptr = &array9[0];
			}
			else
			{
				ptr = null;
			}
			for (int m = 0; m < num17; m++)
			{
				*(long*)(ptr + m * 8) ^= 1973086326L;
			}
			array9 = null;
			@class = new Class2.Class5(new MemoryStream(array8));
			@class.method_0().Position = 0L;
			long num18 = Marshal.GetHINSTANCE(Class2.tMmvmVecn.GetModules()[0]).ToInt64();
			int int_ = 0;
			int num19 = 0;
			if (Class2.tMmvmVecn.Location == null || Class2.tMmvmVecn.Location.Length == 0)
			{
				num19 = 7680;
			}
			@class.method_3();
			@class.method_3();
			@class.method_3();
			int num20 = @class.method_3();
			int num21 = @class.method_3();
			if (num21 == 4)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Array.Clear(array3, 0, array3.Length);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				Array.Clear(array5, 0, array5.Length);
				memoryStream.Close();
				cryptoStream.Close();
				@class.method_4();
				num20 = @class.method_3();
				num21 = @class.method_3();
			}
			if (num21 == 1)
			{
				IntPtr intptr_ = IntPtr.Zero;
				intptr_ = Class2.smethod_29(56U, 1, (uint)Process.GetCurrentProcess().Id);
				if (IntPtr.Size == 4)
				{
					Class2.int_5 = Marshal.GetHINSTANCE(Class2.tMmvmVecn.GetModules()[0]).ToInt32();
				}
				Class2.long_0 = Marshal.GetHINSTANCE(Class2.tMmvmVecn.GetModules()[0]).ToInt64();
				IntPtr zero = IntPtr.Zero;
				for (int n = 0; n < num20; n++)
				{
					IntPtr intPtr = new IntPtr(Class2.long_0 + (long)@class.method_3() - (long)num19);
					if (Class2.smethod_28(intPtr, 4, 4, ref int_) == 0)
					{
						Class2.smethod_28(intPtr, 4, 8, ref int_);
					}
					if (IntPtr.Size == 4)
					{
						Class2.smethod_27(intptr_, intPtr, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					else
					{
						Class2.smethod_27(intptr_, intPtr, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					Class2.smethod_28(intPtr, 4, int_, ref int_);
				}
				while (@class.method_0().Position < @class.method_0().Length - 1L)
				{
					int num22 = @class.method_3();
					IntPtr intptr_2 = new IntPtr(Class2.long_0 + (long)num22 - (long)num19);
					int num23 = @class.method_3();
					if (Class2.smethod_28(intptr_2, num23 * 4, 4, ref int_) == 0)
					{
						Class2.smethod_28(intptr_2, num23 * 4, 8, ref int_);
					}
					for (int num24 = 0; num24 < num23; num24++)
					{
						Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + (long)(num24 * 4)), @class.method_3());
					}
					Class2.smethod_28(intptr_2, num23 * 4, int_, ref int_);
				}
				Class2.smethod_30(intptr_);
				return;
			}
			for (int num25 = 0; num25 < num20; num25++)
			{
				IntPtr intPtr2 = new IntPtr(num18 + (long)@class.method_3() - (long)num19);
				if (Class2.smethod_28(intPtr2, 4, 4, ref int_) == 0)
				{
					Class2.smethod_28(intPtr2, 4, 8, ref int_);
				}
				Marshal.WriteInt32(intPtr2, @class.method_3());
				Class2.smethod_28(intPtr2, 4, int_, ref int_);
			}
			Class2.hashtable_0 = new Hashtable(@class.method_3() + 1);
			Class2.Struct0 @struct = default(Class2.Struct0);
			@struct.byte_0 = new byte[]
			{
				42
			};
			@struct.MuWlxphtb0 = false;
			Class2.hashtable_0.Add(0L, @struct);
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				int num26 = @class.method_3() - num19;
				int num27 = @class.method_3();
				bool muWlxphtb = false;
				if (num27 >= 1879048192)
				{
					muWlxphtb = true;
				}
				int num28 = @class.method_3();
				byte[] array10 = @class.method_1(num28);
				Class2.Struct0 struct2 = default(Class2.Struct0);
				struct2.byte_0 = array10;
				struct2.MuWlxphtb0 = muWlxphtb;
				Class2.hashtable_0.Add(num18 + (long)num26, struct2);
			}
			Class2.long_1 = Marshal.GetHINSTANCE(typeof(Class2).Assembly.GetModules()[0]).ToInt64();
			if (IntPtr.Size == 4)
			{
				Class2.int_0 = Convert.ToInt32(Class2.long_1);
			}
			byte[] bytes = new byte[]
			{
				109,
				115,
				99,
				111,
				114,
				106,
				105,
				116,
				46,
				100,
				108,
				108
			};
			string @string = Encoding.UTF8.GetString(bytes);
			IntPtr intPtr3 = IntPtr.Zero;
			if (intPtr3 == IntPtr.Zero)
			{
				bytes = new byte[]
				{
					99,
					108,
					114,
					106,
					105,
					116,
					46,
					100,
					108,
					108
				};
				@string = Encoding.UTF8.GetString(bytes);
				intPtr3 = Class2.LoadLibrary(@string);
			}
			byte[] bytes2 = new byte[]
			{
				103,
				101,
				116,
				74,
				105,
				116
			};
			string string2 = Encoding.UTF8.GetString(bytes2);
			IntPtr ptr2 = ((Class2.Delegate3)Class2.smethod_22(Class2.GetProcAddress(intPtr3, string2), typeof(Class2.Delegate3)))();
			long value = 0L;
			if (IntPtr.Size == 4)
			{
				value = (long)Marshal.ReadInt32(ptr2);
			}
			else
			{
				value = Marshal.ReadInt64(ptr2);
			}
			Marshal.ReadIntPtr(ptr2, 0);
			Class2.delegate2_0 = new Class2.Delegate2(Class2.smethod_19);
			IntPtr intPtr4 = IntPtr.Zero;
			intPtr4 = Marshal.GetFunctionPointerForDelegate(Class2.delegate2_0);
			long num29 = 0L;
			if (IntPtr.Size == 4)
			{
				num29 = (long)Marshal.ReadInt32(new IntPtr(value));
			}
			else
			{
				num29 = Marshal.ReadInt64(new IntPtr(value));
			}
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				foreach (object obj2 in currentProcess.Modules)
				{
					ProcessModule processModule2 = (ProcessModule)obj2;
					if (processModule2.ModuleName == @string && (num29 < processModule2.BaseAddress.ToInt64() || num29 > processModule2.BaseAddress.ToInt64() + (long)processModule2.ModuleMemorySize) && typeof(Class2).Assembly.EntryPoint != null)
					{
						return;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (IEnumerator enumerator = currentProcess.Modules.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((ProcessModule)enumerator.Current).BaseAddress.ToInt64() == Class2.long_1)
						{
							break;
						}
					}
				}
			}
			catch
			{
			}
			Class2.delegate2_1 = null;
			try
			{
				Class2.delegate2_1 = (Class2.Delegate2)Class2.smethod_22(new IntPtr(num29), typeof(Class2.Delegate2));
			}
			catch
			{
				try
				{
					Delegate @delegate = Class2.smethod_22(new IntPtr(num29), typeof(Class2.Delegate2));
					Class2.delegate2_1 = (Class2.Delegate2)Delegate.CreateDelegate(typeof(Class2.Delegate2), @delegate.Method);
				}
				catch
				{
				}
			}
			int int_2 = 0;
			if (typeof(Class2).Assembly.EntryPoint != null && typeof(Class2).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class2).Assembly.Location != null && typeof(Class2).Assembly.Location.Length > 0)
			{
				return;
			}
			try
			{
				object value2 = typeof(Class2).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class2).Assembly.ManifestModule.ModuleHandle);
				if (value2 is IntPtr)
				{
					Class2.intptr_2 = (IntPtr)value2;
				}
				if (value2.GetType().ToString() == "System.Reflection.RuntimeModule")
				{
					Class2.intptr_2 = (IntPtr)value2.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value2);
				}
				MemoryStream memoryStream2 = new MemoryStream();
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				if (IntPtr.Size == 4)
				{
					memoryStream2.Write(BitConverter.GetBytes(Class2.intptr_2.ToInt32()), 0, 4);
				}
				else
				{
					memoryStream2.Write(BitConverter.GetBytes(Class2.intptr_2.ToInt64()), 0, 8);
				}
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Position = 0L;
				byte[] array11 = memoryStream2.ToArray();
				memoryStream2.Close();
				uint num30 = 0U;
				try
				{
					byte* value3;
					if ((array9 = array11) != null && array9.Length != 0)
					{
						value3 = &array9[0];
					}
					else
					{
						value3 = null;
					}
					Class2.delegate2_0(new IntPtr((void*)value3), new IntPtr((void*)value3), new IntPtr((void*)value3), 216669565U, new IntPtr((void*)value3), ref num30);
				}
				finally
				{
					array9 = null;
				}
			}
			catch
			{
			}
			RuntimeHelpers.PrepareDelegate(Class2.delegate2_1);
			RuntimeHelpers.PrepareMethod(Class2.delegate2_1.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(Class2.delegate2_0);
			RuntimeHelpers.PrepareMethod(Class2.delegate2_0.Method.MethodHandle);
			byte[] array12;
			if (IntPtr.Size != 4)
			{
				array12 = new byte[]
				{
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					73,
					57,
					64,
					8,
					116,
					12,
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue,
					224,
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue,
					224
				};
			}
			else
			{
				array12 = new byte[]
				{
					85,
					139,
					236,
					139,
					69,
					16,
					129,
					120,
					4,
					125,
					29,
					234,
					12,
					116,
					7,
					184,
					182,
					177,
					74,
					6,
					235,
					5,
					184,
					182,
					146,
					64,
					12,
					93,
					byte.MaxValue,
					224
				};
			}
			IntPtr intPtr5 = Class2.smethod_26(IntPtr.Zero, (uint)array12.Length, 4096U, 64U);
			byte[] array13 = array12;
			byte[] bytes3;
			byte[] bytes4;
			byte[] bytes5;
			if (IntPtr.Size == 4)
			{
				bytes3 = BitConverter.GetBytes(Class2.intptr_2.ToInt32());
				bytes4 = BitConverter.GetBytes(intPtr4.ToInt32());
				bytes5 = BitConverter.GetBytes(Convert.ToInt32(num29));
			}
			else
			{
				bytes3 = BitConverter.GetBytes(Class2.intptr_2.ToInt64());
				bytes4 = BitConverter.GetBytes(intPtr4.ToInt64());
				bytes5 = BitConverter.GetBytes(num29);
			}
			if (IntPtr.Size == 4)
			{
				array13[9] = bytes3[0];
				array13[10] = bytes3[1];
				array13[11] = bytes3[2];
				array13[12] = bytes3[3];
				array13[16] = bytes5[0];
				array13[17] = bytes5[1];
				array13[18] = bytes5[2];
				array13[19] = bytes5[3];
				array13[23] = bytes4[0];
				array13[24] = bytes4[1];
				array13[25] = bytes4[2];
				array13[26] = bytes4[3];
			}
			else
			{
				array13[2] = bytes3[0];
				array13[3] = bytes3[1];
				array13[4] = bytes3[2];
				array13[5] = bytes3[3];
				array13[6] = bytes3[4];
				array13[7] = bytes3[5];
				array13[8] = bytes3[6];
				array13[9] = bytes3[7];
				array13[18] = bytes5[0];
				array13[19] = bytes5[1];
				array13[20] = bytes5[2];
				array13[21] = bytes5[3];
				array13[22] = bytes5[4];
				array13[23] = bytes5[5];
				array13[24] = bytes5[6];
				array13[25] = bytes5[7];
				array13[30] = bytes4[0];
				array13[31] = bytes4[1];
				array13[32] = bytes4[2];
				array13[33] = bytes4[3];
				array13[34] = bytes4[4];
				array13[35] = bytes4[5];
				array13[36] = bytes4[6];
				array13[37] = bytes4[7];
			}
			Marshal.Copy(array13, 0, intPtr5, array13.Length);
			Class2.bool_3 = false;
			Class2.smethod_28(new IntPtr(value), IntPtr.Size, 64, ref int_2);
			Marshal.WriteIntPtr(new IntPtr(value), intPtr5);
			Class2.smethod_28(new IntPtr(value), IntPtr.Size, int_2, ref int_2);
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0000E694 File Offset: 0x0000C894
	internal static object smethod_24(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_0).Location))
			{
				return ((Assembly)assembly_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString()))
			{
				return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x060001AE RID: 430
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x060001AF RID: 431
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x060001B0 RID: 432 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
	private static IntPtr smethod_25(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class2.delegate4_0 == null)
		{
			Class2.delegate4_0 = (Class2.Delegate4)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Find ".Trim() + "ResourceA"), typeof(Class2.Delegate4));
		}
		return Class2.delegate4_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0000E7FC File Offset: 0x0000C9FC
	private static IntPtr smethod_26(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class2.delegate5_0 == null)
		{
			Class2.delegate5_0 = (Class2.Delegate5)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Virtual ".Trim() + "Alloc"), typeof(Class2.Delegate5));
		}
		return Class2.delegate5_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0000E858 File Offset: 0x0000CA58
	private static int smethod_27(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class2.delegate6_0 == null)
		{
			Class2.delegate6_0 = (Class2.Delegate6)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class2.Delegate6));
		}
		return Class2.delegate6_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
	private static int smethod_28(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class2.delegate7_0 == null)
		{
			Class2.delegate7_0 = (Class2.Delegate7)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Virtual ".Trim() + "Protect"), typeof(Class2.Delegate7));
		}
		return Class2.delegate7_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x0000E91C File Offset: 0x0000CB1C
	private static IntPtr smethod_29(uint uint_1, int int_6, uint uint_2)
	{
		if (Class2.delegate8_0 == null)
		{
			Class2.delegate8_0 = (Class2.Delegate8)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Open ".Trim() + "Process"), typeof(Class2.Delegate8));
		}
		return Class2.delegate8_0(uint_1, int_6, uint_2);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0000E974 File Offset: 0x0000CB74
	private static int smethod_30(IntPtr intptr_4)
	{
		if (Class2.delegate9_0 == null)
		{
			Class2.delegate9_0 = (Class2.Delegate9)Marshal.GetDelegateForFunctionPointer(Class2.GetProcAddress(Class2.smethod_31(), "Close ".Trim() + "Handle"), typeof(Class2.Delegate9));
		}
		return Class2.delegate9_0(intptr_4);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002F2D File Offset: 0x0000112D
	private static IntPtr smethod_31()
	{
		if (Class2.intptr_0 == IntPtr.Zero)
		{
			Class2.intptr_0 = Class2.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class2.intptr_0;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0000E9CC File Offset: 0x0000CBCC
	private static byte[] smethod_32(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002F63 File Offset: 0x00001163
	internal static byte[] smethod_33(MemoryStream memoryStream_0)
	{
		return ((MemoryStream)memoryStream_0).ToArray();
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0000EA2C File Offset: 0x0000CC2C
	private static byte[] smethod_34(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			203,
			236,
			119,
			87,
			92,
			59,
			189,
			58,
			61,
			195,
			150,
			212,
			138,
			186,
			59,
			89,
			234,
			159,
			193,
			66,
			141,
			44,
			210,
			252,
			102,
			73,
			36,
			53,
			208,
			229,
			169,
			234
		};
		symmetricAlgorithm.IV = new byte[]
		{
			249,
			230,
			180,
			62,
			1,
			93,
			142,
			254,
			40,
			175,
			155,
			0,
			82,
			52,
			174,
			35
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class2.smethod_33(stream);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0000EA98 File Offset: 0x0000CC98
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0000EA98 File Offset: 0x0000CC98
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000EA98 File Offset: 0x0000CC98
	private byte[] method_4()
	{
		return null;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0000EA98 File Offset: 0x0000CC98
	private byte[] method_5()
	{
		return null;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
	private byte[] method_6()
	{
		return null;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
	private byte[] method_7()
	{
		return null;
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002F70 File Offset: 0x00001170
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002F8B File Offset: 0x0000118B
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
	internal byte[] method_10()
	{
		return null;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000EA98 File Offset: 0x0000CC98
	internal byte[] method_11()
	{
		return null;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002FA6 File Offset: 0x000011A6
	internal static object smethod_35(Class2.Class5 class5_0)
	{
		return class5_0.method_0();
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002D69 File Offset: 0x00000F69
	internal static void smethod_36(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002FB1 File Offset: 0x000011B1
	internal static long smethod_37(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00002FBC File Offset: 0x000011BC
	internal static object smethod_38(Class2.Class5 class5_0, int int_6)
	{
		return class5_0.method_1(int_6);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00002FCB File Offset: 0x000011CB
	internal static void smethod_39(Class2.Class5 class5_0)
	{
		class5_0.method_4();
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002FD6 File Offset: 0x000011D6
	internal static void smethod_40(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00002FE1 File Offset: 0x000011E1
	internal static object smethod_41(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002FEC File Offset: 0x000011EC
	internal static object smethod_42(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002FF7 File Offset: 0x000011F7
	internal static object smethod_43()
	{
		return Class2.smethod_7();
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002FFE File Offset: 0x000011FE
	internal static void smethod_44(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000300D File Offset: 0x0000120D
	internal static object smethod_45(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00003020 File Offset: 0x00001220
	internal static object smethod_46()
	{
		return new MemoryStream();
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002D2D File Offset: 0x00000F2D
	internal static void smethod_47(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00003027 File Offset: 0x00001227
	internal static void smethod_48(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00003032 File Offset: 0x00001232
	internal static object smethod_49(MemoryStream memoryStream_0)
	{
		return Class2.smethod_33(memoryStream_0);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000303D File Offset: 0x0000123D
	internal static void smethod_50(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00003048 File Offset: 0x00001248
	internal static object smethod_51(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00003053 File Offset: 0x00001253
	internal static bool smethod_52(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 == methodInfo_1;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00003062 File Offset: 0x00001262
	internal static bool smethod_53()
	{
		return null == null;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00003068 File Offset: 0x00001268
	internal static object smethod_54()
	{
		return null;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_55()
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000306B File Offset: 0x0000126B
	internal static void smethod_56(bool bool_5)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_5;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00003076 File Offset: 0x00001276
	internal static Type smethod_57(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00003081 File Offset: 0x00001281
	internal static object smethod_58(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000308C File Offset: 0x0000128C
	internal static int smethod_59(string string_1)
	{
		return string_1.Length;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00003097 File Offset: 0x00001297
	internal static object smethod_60()
	{
		return SHA1.Create();
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000309E File Offset: 0x0000129E
	internal static object smethod_61(string string_1)
	{
		return CryptoConfig.MapNameToOID(string_1);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000030A9 File Offset: 0x000012A9
	internal static bool smethod_62(string string_1)
	{
		return File.Exists(string_1);
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002D83 File Offset: 0x00000F83
	internal static object smethod_63(Assembly assembly_0, string string_1)
	{
		return assembly_0.GetManifestResourceStream(string_1);
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002FA6 File Offset: 0x000011A6
	internal static object smethod_64(Class2.Class5 class5_0)
	{
		return class5_0.method_0();
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002D69 File Offset: 0x00000F69
	internal static void smethod_65(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00002FB1 File Offset: 0x000011B1
	internal static long smethod_66(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002FBC File Offset: 0x000011BC
	internal static object smethod_67(Class2.Class5 class5_0, int int_6)
	{
		return class5_0.method_1(int_6);
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002FF7 File Offset: 0x000011F7
	internal static object smethod_68()
	{
		return Class2.smethod_7();
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002FFE File Offset: 0x000011FE
	internal static void smethod_69(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000300D File Offset: 0x0000120D
	internal static object smethod_70(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00003020 File Offset: 0x00001220
	internal static object smethod_71()
	{
		return new MemoryStream();
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002D2D File Offset: 0x00000F2D
	internal static void smethod_72(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00003027 File Offset: 0x00001227
	internal static void smethod_73(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060001EB RID: 491 RVA: 0x000030B4 File Offset: 0x000012B4
	internal static object smethod_74()
	{
		return Encoding.UTF8;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00003032 File Offset: 0x00001232
	internal static object smethod_75(MemoryStream memoryStream_0)
	{
		return Class2.smethod_33(memoryStream_0);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x000030BB File Offset: 0x000012BB
	internal static object smethod_76(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	// Token: 0x060001EE RID: 494 RVA: 0x000030CA File Offset: 0x000012CA
	internal static void smethod_77(AsymmetricAlgorithm asymmetricAlgorithm_0, string string_1)
	{
		asymmetricAlgorithm_0.FromXmlString(string_1);
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000303D File Offset: 0x0000123D
	internal static void smethod_78(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00002FCB File Offset: 0x000011CB
	internal static void smethod_79(Class2.Class5 class5_0)
	{
		class5_0.method_4();
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x000030D9 File Offset: 0x000012D9
	internal static void smethod_80(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		Class2.smethod_10(hashAlgorithm_0, stream_0, uint_1, byte_2);
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x000030F0 File Offset: 0x000012F0
	internal static ushort smethod_81(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x000030FB File Offset: 0x000012FB
	internal static int smethod_82(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		return stream_0.Read(byte_2, int_6, int_7);
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00003112 File Offset: 0x00001312
	internal static void smethod_83(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		Class2.smethod_11(hashAlgorithm_0, byte_2, int_6, int_7);
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00003129 File Offset: 0x00001329
	internal static long smethod_84(Stream stream_0)
	{
		return stream_0.Position;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00003134 File Offset: 0x00001334
	internal static uint smethod_85(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000313F File Offset: 0x0000133F
	internal static uint smethod_86(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		return Class2.smethod_12(uint_1, int_6, long_2, binaryReader_0);
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00003156 File Offset: 0x00001356
	internal static long smethod_87(long long_2, long long_3)
	{
		return Math.Min(long_2, long_3);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00003165 File Offset: 0x00001365
	internal static object smethod_88(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		return hashAlgorithm_0.TransformFinalBlock(byte_2, int_6, int_7);
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000317C File Offset: 0x0000137C
	internal static object smethod_89(BinaryReader binaryReader_0, int int_6)
	{
		return binaryReader_0.ReadBytes(int_6);
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002FD6 File Offset: 0x000011D6
	internal static void smethod_90(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000318B File Offset: 0x0000138B
	internal static object smethod_91(HashAlgorithm hashAlgorithm_0)
	{
		return hashAlgorithm_0.Hash;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00003196 File Offset: 0x00001396
	internal static bool smethod_92(RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_2, string string_1, byte[] byte_3)
	{
		return rsacryptoServiceProvider_0.VerifyHash(byte_2, string_1, byte_3);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x000031AD File Offset: 0x000013AD
	internal static void smethod_93(BinaryReader binaryReader_0)
	{
		binaryReader_0.Close();
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002FE1 File Offset: 0x000011E1
	internal static object smethod_94(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00002CF9 File Offset: 0x00000EF9
	internal static object smethod_95(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x000031B8 File Offset: 0x000013B8
	internal static object smethod_96(string string_1, string string_2)
	{
		return string_1 + string_2;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00003062 File Offset: 0x00001262
	internal static bool smethod_97()
	{
		return null == null;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00003068 File Offset: 0x00001268
	internal static object smethod_98()
	{
		return null;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x000031C7 File Offset: 0x000013C7
	static int smethod_99()
	{
		return 1;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x000031CA File Offset: 0x000013CA
	internal static IntPtr smethod_100(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadIntPtr(intptr_4, int_6);
	}

	// Token: 0x06000206 RID: 518 RVA: 0x000031D9 File Offset: 0x000013D9
	internal static int smethod_101(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt32(intptr_4, int_6);
	}

	// Token: 0x06000207 RID: 519 RVA: 0x000031E8 File Offset: 0x000013E8
	internal static long smethod_102(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt64(intptr_4, int_6);
	}

	// Token: 0x06000208 RID: 520 RVA: 0x000031F7 File Offset: 0x000013F7
	internal static void smethod_103(IntPtr intptr_4, int int_6, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000320A File Offset: 0x0000140A
	internal static void smethod_104(IntPtr intptr_4, int int_6, int int_7)
	{
		Marshal.WriteInt32(intptr_4, int_6, int_7);
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000321D File Offset: 0x0000141D
	internal static void smethod_105(IntPtr intptr_4, int int_6, long long_2)
	{
		Marshal.WriteInt64(intptr_4, int_6, long_2);
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00003230 File Offset: 0x00001430
	internal static IntPtr smethod_106(int int_6)
	{
		return Marshal.AllocCoTaskMem(int_6);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000323B File Offset: 0x0000143B
	internal static void smethod_107(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
	{
		Marshal.Copy(byte_2, int_6, intptr_4, int_7);
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00003252 File Offset: 0x00001452
	internal static void smethod_108()
	{
		Class2.smethod_21();
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00003259 File Offset: 0x00001459
	internal static object smethod_109()
	{
		return Process.GetCurrentProcess();
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00003260 File Offset: 0x00001460
	internal static object smethod_110(Process process_0)
	{
		return process_0.MainModule;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000326B File Offset: 0x0000146B
	internal static IntPtr smethod_111(ProcessModule processModule_0)
	{
		return processModule_0.BaseAddress;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00003276 File Offset: 0x00001476
	internal static IntPtr smethod_112(IntPtr intptr_4, string string_1, uint uint_1)
	{
		return Class2.smethod_25(intptr_4, string_1, uint_1);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00003289 File Offset: 0x00001489
	internal static bool smethod_113(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002240 File Offset: 0x00000440
	internal static void smethod_114()
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00003298 File Offset: 0x00001498
	internal static int smethod_115()
	{
		return IntPtr.Size;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000329F File Offset: 0x0000149F
	internal static Type smethod_116(string string_1, bool bool_5)
	{
		return Type.GetType(string_1, bool_5);
	}

	// Token: 0x06000216 RID: 534 RVA: 0x000032AE File Offset: 0x000014AE
	internal static bool smethod_117(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x000032BD File Offset: 0x000014BD
	internal static object smethod_118(Process process_0)
	{
		return process_0.Modules;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x000032C8 File Offset: 0x000014C8
	internal static object smethod_119(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	// Token: 0x06000219 RID: 537 RVA: 0x000032D3 File Offset: 0x000014D3
	internal static object smethod_120(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x000032DE File Offset: 0x000014DE
	internal static object smethod_121(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x000032E9 File Offset: 0x000014E9
	internal static object smethod_122(string string_1)
	{
		return string_1.ToLower();
	}

	// Token: 0x0600021C RID: 540 RVA: 0x000032F4 File Offset: 0x000014F4
	internal static bool smethod_123(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00003303 File Offset: 0x00001503
	internal static object smethod_124(ProcessModule processModule_0)
	{
		return processModule_0.FileVersionInfo;
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000330E File Offset: 0x0000150E
	internal static int smethod_125(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMajorPart;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00003319 File Offset: 0x00001519
	internal static int smethod_126(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMinorPart;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00003324 File Offset: 0x00001524
	internal static int smethod_127(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductBuildPart;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000332F File Offset: 0x0000152F
	internal static int smethod_128(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductPrivatePart;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000333A File Offset: 0x0000153A
	internal static bool smethod_129(Version version_0, Version version_1)
	{
		return version_0 >= version_1;
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00003349 File Offset: 0x00001549
	internal static bool smethod_130(Version version_0, Version version_1)
	{
		return version_0 < version_1;
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00003358 File Offset: 0x00001558
	internal static bool smethod_131(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002D78 File Offset: 0x00000F78
	internal static void smethod_132(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002D83 File Offset: 0x00000F83
	internal static object smethod_133(Assembly assembly_0, string string_1)
	{
		return assembly_0.GetManifestResourceStream(string_1);
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002FA6 File Offset: 0x000011A6
	internal static object smethod_134(Class2.Class5 class5_0)
	{
		return class5_0.method_0();
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00002D69 File Offset: 0x00000F69
	internal static void smethod_135(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002FB1 File Offset: 0x000011B1
	internal static long smethod_136(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002FBC File Offset: 0x000011BC
	internal static object smethod_137(Class2.Class5 class5_0, int int_6)
	{
		return class5_0.method_1(int_6);
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002FD6 File Offset: 0x000011D6
	internal static void smethod_138(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002FE1 File Offset: 0x000011E1
	internal static object smethod_139(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002FEC File Offset: 0x000011EC
	internal static object smethod_140(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00003363 File Offset: 0x00001563
	internal static void smethod_141(Array array_0, int int_6, int int_7)
	{
		Array.Clear(array_0, int_6, int_7);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00003376 File Offset: 0x00001576
	internal static object smethod_142(Assembly assembly_0)
	{
		return assembly_0.GetModules();
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00003381 File Offset: 0x00001581
	internal static IntPtr smethod_143(Module module_0)
	{
		return Marshal.GetHINSTANCE(module_0);
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00003081 File Offset: 0x00001281
	internal static object smethod_144(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000308C File Offset: 0x0000128C
	internal static int smethod_145(string string_1)
	{
		return string_1.Length;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000338C File Offset: 0x0000158C
	internal static int smethod_146(Class2.Class5 class5_0)
	{
		return class5_0.method_3();
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002FF7 File Offset: 0x000011F7
	internal static object smethod_147()
	{
		return Class2.smethod_7();
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002FFE File Offset: 0x000011FE
	internal static void smethod_148(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000300D File Offset: 0x0000120D
	internal static object smethod_149(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002D2D File Offset: 0x00000F2D
	internal static void smethod_150(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00003027 File Offset: 0x00001227
	internal static void smethod_151(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00003397 File Offset: 0x00001597
	internal static object smethod_152(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000303D File Offset: 0x0000123D
	internal static void smethod_153(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002FCB File Offset: 0x000011CB
	internal static void smethod_154(Class2.Class5 class5_0)
	{
		class5_0.method_4();
	}

	// Token: 0x0600023C RID: 572 RVA: 0x000033A2 File Offset: 0x000015A2
	internal static int smethod_155(Process process_0)
	{
		return process_0.Id;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x000033AD File Offset: 0x000015AD
	internal static IntPtr smethod_156(uint uint_1, int int_6, uint uint_2)
	{
		return Class2.smethod_29(uint_1, int_6, uint_2);
	}

	// Token: 0x0600023E RID: 574 RVA: 0x000033C0 File Offset: 0x000015C0
	internal static object smethod_157(int int_6)
	{
		return BitConverter.GetBytes(int_6);
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00003129 File Offset: 0x00001329
	internal static long smethod_158(Stream stream_0)
	{
		return stream_0.Position;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x000033CB File Offset: 0x000015CB
	internal static void smethod_159(IntPtr intptr_4, int int_6)
	{
		Marshal.WriteInt32(intptr_4, int_6);
	}

	// Token: 0x06000241 RID: 577 RVA: 0x000033DA File Offset: 0x000015DA
	internal static int smethod_160(IntPtr intptr_4)
	{
		return Class2.smethod_30(intptr_4);
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000033E5 File Offset: 0x000015E5
	internal static void smethod_161(Hashtable hashtable_1, object object_3, object object_4)
	{
		hashtable_1.Add(object_3, object_4);
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00003076 File Offset: 0x00001276
	internal static Type smethod_162(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000244 RID: 580 RVA: 0x000033F8 File Offset: 0x000015F8
	internal static int smethod_163(long long_2)
	{
		return Convert.ToInt32(long_2);
	}

	// Token: 0x06000245 RID: 581 RVA: 0x000030B4 File Offset: 0x000012B4
	internal static object smethod_164()
	{
		return Encoding.UTF8;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000030BB File Offset: 0x000012BB
	internal static object smethod_165(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00003403 File Offset: 0x00001603
	internal static bool smethod_166(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00003412 File Offset: 0x00001612
	internal static object smethod_167(IntPtr intptr_4, Type type_0)
	{
		return Class2.smethod_22(intptr_4, type_0);
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00003421 File Offset: 0x00001621
	internal static IntPtr smethod_168(Class2.Delegate3 delegate3_0)
	{
		return delegate3_0();
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000342C File Offset: 0x0000162C
	internal static int smethod_169(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00003437 File Offset: 0x00001637
	internal static long smethod_170(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00003442 File Offset: 0x00001642
	internal static IntPtr smethod_171(Delegate delegate_0)
	{
		return Marshal.GetFunctionPointerForDelegate(delegate_0);
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0000344D File Offset: 0x0000164D
	internal static int smethod_172(ProcessModule processModule_0)
	{
		return processModule_0.ModuleMemorySize;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00003048 File Offset: 0x00001248
	internal static object smethod_173(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00003458 File Offset: 0x00001658
	internal static bool smethod_174(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 != methodInfo_1;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00003467 File Offset: 0x00001667
	internal static object smethod_175(Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00003472 File Offset: 0x00001672
	internal static object smethod_176(Type type_0, MethodInfo methodInfo_0)
	{
		return Delegate.CreateDelegate(type_0, methodInfo_0);
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00003481 File Offset: 0x00001681
	internal static object smethod_177(MethodBase methodBase_0)
	{
		return methodBase_0.GetParameters();
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000348C File Offset: 0x0000168C
	internal static object smethod_178(Assembly assembly_0)
	{
		return assembly_0.ManifestModule;
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00003497 File Offset: 0x00001697
	internal static ModuleHandle smethod_179(Module module_0)
	{
		return module_0.ModuleHandle;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000034A2 File Offset: 0x000016A2
	internal static Type smethod_180(object object_3)
	{
		return object_3.GetType();
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000034AD File Offset: 0x000016AD
	internal static object smethod_181(FieldInfo fieldInfo_0, object object_3)
	{
		return fieldInfo_0.GetValue(object_3);
	}

	// Token: 0x06000257 RID: 599 RVA: 0x000034BC File Offset: 0x000016BC
	internal static object smethod_182(long long_2)
	{
		return BitConverter.GetBytes(long_2);
	}

	// Token: 0x06000258 RID: 600 RVA: 0x000034C7 File Offset: 0x000016C7
	internal static void smethod_183(Delegate delegate_0)
	{
		RuntimeHelpers.PrepareDelegate(delegate_0);
	}

	// Token: 0x06000259 RID: 601 RVA: 0x000034D2 File Offset: 0x000016D2
	internal static RuntimeMethodHandle smethod_184(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x000034DD File Offset: 0x000016DD
	internal static void smethod_185(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	// Token: 0x0600025B RID: 603 RVA: 0x000034E8 File Offset: 0x000016E8
	internal static void smethod_186(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x000034F7 File Offset: 0x000016F7
	internal static IntPtr smethod_187(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		return Class2.smethod_26(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000350E File Offset: 0x0000170E
	internal static void smethod_188(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00003062 File Offset: 0x00001262
	internal static bool smethod_189()
	{
		return null == null;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00003068 File Offset: 0x00001268
	internal static object smethod_190()
	{
		return null;
	}

	// Token: 0x0400003B RID: 59
	private static Class2.Delegate7 delegate7_0;

	// Token: 0x0400003C RID: 60
	private static uint[] uint_0;

	// Token: 0x0400003D RID: 61
	private static IntPtr intptr_0;

	// Token: 0x0400003E RID: 62
	private static object object_0;

	// Token: 0x0400003F RID: 63
	internal static Assembly tMmvmVecn;

	// Token: 0x04000040 RID: 64
	private static Class2.Delegate5 delegate5_0;

	// Token: 0x04000041 RID: 65
	private static long long_0;

	// Token: 0x04000042 RID: 66
	private static bool bool_0;

	// Token: 0x04000043 RID: 67
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	private static bool firstrundone;

	// Token: 0x04000044 RID: 68
	private static SortedList sortedList_0;

	// Token: 0x04000045 RID: 69
	private static byte[] byte_0;

	// Token: 0x04000046 RID: 70
	internal static object object_1;

	// Token: 0x04000047 RID: 71
	private static IntPtr intptr_1;

	// Token: 0x04000048 RID: 72
	private static string[] string_0;

	// Token: 0x04000049 RID: 73
	private static Class2.Delegate8 delegate8_0;

	// Token: 0x0400004A RID: 74
	private static bool bool_1;

	// Token: 0x0400004B RID: 75
	private static List<int> list_0;

	// Token: 0x0400004C RID: 76
	private static int int_0;

	// Token: 0x0400004D RID: 77
	internal static Class2.Delegate2 delegate2_0;

	// Token: 0x0400004E RID: 78
	private static List<string> list_1;

	// Token: 0x0400004F RID: 79
	internal static Class2.Delegate2 delegate2_1;

	// Token: 0x04000050 RID: 80
	private static int int_1;

	// Token: 0x04000051 RID: 81
	private static Class2.Delegate9 delegate9_0;

	// Token: 0x04000052 RID: 82
	private static int int_2;

	// Token: 0x04000053 RID: 83
	private static bool bool_2 = false;

	// Token: 0x04000054 RID: 84
	private static byte[] byte_1;

	// Token: 0x04000055 RID: 85
	private static bool BmwDsdqaTf;

	// Token: 0x04000056 RID: 86
	private static Class2.Delegate6 delegate6_0;

	// Token: 0x04000057 RID: 87
	private static bool bool_3;

	// Token: 0x04000058 RID: 88
	private static int[] int_3;

	// Token: 0x04000059 RID: 89
	private static long long_1;

	// Token: 0x0400005A RID: 90
	private static IntPtr intptr_2;

	// Token: 0x0400005B RID: 91
	internal static Hashtable hashtable_0;

	// Token: 0x0400005C RID: 92
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x0400005D RID: 93
	private static Class2.Delegate4 delegate4_0;

	// Token: 0x0400005E RID: 94
	private static bool bool_4;

	// Token: 0x0400005F RID: 95
	private static int int_4;

	// Token: 0x04000060 RID: 96
	private static object object_2;

	// Token: 0x04000061 RID: 97
	private static IntPtr intptr_3;

	// Token: 0x04000062 RID: 98
	private static int int_5;

	// Token: 0x02000014 RID: 20
	// (Invoke) Token: 0x06000261 RID: 609
	private delegate void Delegate1(object o);

	// Token: 0x02000015 RID: 21
	internal class Attribute0 : Attribute
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0000351D File Offset: 0x0000171D
		public Attribute0(object object_0)
		{
		}

		// Token: 0x02000016 RID: 22
		internal class Class3<T>
		{
			// Token: 0x06000266 RID: 614 RVA: 0x00003525 File Offset: 0x00001725
			internal static bool smethod_0()
			{
				return Class2.Attribute0.Class3<T>.object_0 == null;
			}

			// Token: 0x06000267 RID: 615 RVA: 0x0000352F File Offset: 0x0000172F
			internal static object smethod_1()
			{
				return Class2.Attribute0.Class3<T>.object_0;
			}

			// Token: 0x04000063 RID: 99
			internal static object object_0;
		}
	}

	// Token: 0x02000017 RID: 23
	internal class Class4
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class2.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00003536 File Offset: 0x00001736
		internal static object smethod_1()
		{
			return Encoding.Unicode;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000353D File Offset: 0x0000173D
		internal static object smethod_2(Encoding encoding_0, string string_0)
		{
			return encoding_0.GetBytes(string_0);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000034E8 File Offset: 0x000016E8
		internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000354C File Offset: 0x0000174C
		internal static object smethod_4(byte[] byte_0)
		{
			return Class2.smethod_9(byte_0);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002FF7 File Offset: 0x000011F7
		internal static object smethod_5()
		{
			return Class2.smethod_7();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003557 File Offset: 0x00001757
		internal static void smethod_6(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
		{
			symmetricAlgorithm_0.IV = byte_0;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003566 File Offset: 0x00001766
		internal static object smethod_7(SymmetricAlgorithm symmetricAlgorithm_0)
		{
			return symmetricAlgorithm_0.CreateEncryptor();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002D2D File Offset: 0x00000F2D
		internal static void smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003397 File Offset: 0x00001597
		internal static object smethod_9(MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003571 File Offset: 0x00001771
		internal static object smethod_10(byte[] byte_0)
		{
			return Convert.ToBase64String(byte_0);
		}
	}

	// Token: 0x02000018 RID: 24
	// (Invoke) Token: 0x06000275 RID: 629
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000019 RID: 25
	// (Invoke) Token: 0x06000279 RID: 633
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x0200001A RID: 26
	internal struct Struct0
	{
		// Token: 0x04000064 RID: 100
		internal bool MuWlxphtb0;

		// Token: 0x04000065 RID: 101
		internal byte[] byte_0;
	}

	// Token: 0x0200001B RID: 27
	internal class Class5
	{
		// Token: 0x0600027C RID: 636 RVA: 0x0000357C File Offset: 0x0000177C
		public Class5(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003590 File Offset: 0x00001790
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000359D File Offset: 0x0000179D
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000035AB File Offset: 0x000017AB
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000035BB File Offset: 0x000017BB
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000035C8 File Offset: 0x000017C8
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000035D5 File Offset: 0x000017D5
		internal static object smethod_0(BinaryReader binaryReader_1)
		{
			return binaryReader_1.BaseStream;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000317C File Offset: 0x0000137C
		internal static object smethod_1(BinaryReader binaryReader_1, int int_0)
		{
			return binaryReader_1.ReadBytes(int_0);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000035E0 File Offset: 0x000017E0
		internal static int smethod_2(BinaryReader binaryReader_1, byte[] byte_0, int int_0, int int_1)
		{
			return binaryReader_1.Read(byte_0, int_0, int_1);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000035F7 File Offset: 0x000017F7
		internal static int smethod_3(BinaryReader binaryReader_1)
		{
			return binaryReader_1.ReadInt32();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000031AD File Offset: 0x000013AD
		internal static void smethod_4(BinaryReader binaryReader_1)
		{
			binaryReader_1.Close();
		}

		// Token: 0x04000066 RID: 102
		private BinaryReader binaryReader_0;
	}

	// Token: 0x0200001C RID: 28
	// (Invoke) Token: 0x06000288 RID: 648
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x0600028C RID: 652
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x0200001E RID: 30
	// (Invoke) Token: 0x06000290 RID: 656
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x0200001F RID: 31
	// (Invoke) Token: 0x06000294 RID: 660
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x06000298 RID: 664
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000021 RID: 33
	// (Invoke) Token: 0x0600029C RID: 668
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x02000022 RID: 34
	[Flags]
	private enum Enum0
	{

	}
}
