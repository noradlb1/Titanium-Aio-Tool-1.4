using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x0600015E RID: 350 RVA: 0x0000B048 File Offset: 0x00009248
		private static string CultureToString(CultureInfo culture)
		{
			if (culture != null)
			{
				return culture.Name;
			}
			return "";
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000B064 File Offset: 0x00009264
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000B0E4 File Offset: 0x000092E4
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000B11C File Offset: 0x0000931C
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!fullName.EndsWith(".compressed"))
			{
				return executingAssembly.GetManifestResourceStream(fullName);
			}
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
			{
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					AssemblyLoader.CopyTo(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
			}
			return result;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000B1B8 File Offset: 0x000093B8
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000B1D8 File Offset: 0x000093D8
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B204 File Offset: 0x00009404
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000B2C4 File Offset: 0x000094C4
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly == null)
			{
				assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
				if (assembly == null)
				{
					object obj2 = AssemblyLoader.nullCacheLock;
					lock (obj2)
					{
						AssemblyLoader.nullCache[e.Name] = true;
					}
					if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
					{
						assembly = Assembly.Load(assemblyName);
					}
				}
				return assembly;
			}
			return assembly;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000B3AC File Offset: 0x000095AC
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("discordrpc", "costura.discordrpc.dll.compressed");
			AssemblyLoader.symbolNames.Add("discordrpc", "costura.discordrpc.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.accesscontrol", "costura.system.security.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.principal.windows", "costura.system.security.principal.windows.dll.compressed");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000B484 File Offset: 0x00009684
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002CE7 File Offset: 0x00000EE7
		internal static object smethod_0(CultureInfo cultureInfo_0)
		{
			return cultureInfo_0.Name;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002CF2 File Offset: 0x00000EF2
		internal static object smethod_1()
		{
			return AppDomain.CurrentDomain;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002CF9 File Offset: 0x00000EF9
		internal static object smethod_2(AssemblyName assemblyName_0)
		{
			return assemblyName_0.Name;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002D04 File Offset: 0x00000F04
		internal static bool smethod_3(string string_0, string string_1, StringComparison stringComparison_0)
		{
			return string.Equals(string_0, string_1, stringComparison_0);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002D17 File Offset: 0x00000F17
		internal static object smethod_4(AssemblyName assemblyName_0)
		{
			return assemblyName_0.CultureInfo;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002D22 File Offset: 0x00000F22
		internal static object smethod_5(CultureInfo cultureInfo_0)
		{
			return AssemblyLoader.CultureToString(cultureInfo_0);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002D2D File Offset: 0x00000F2D
		internal static void smethod_6(Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002D44 File Offset: 0x00000F44
		internal static object smethod_7()
		{
			return Assembly.GetExecutingAssembly();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002335 File Offset: 0x00000535
		internal static object smethod_8(int int_0)
		{
			return Class2.smethod_17(int_0);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002D4B File Offset: 0x00000F4B
		internal static bool smethod_9(string string_0, string string_1)
		{
			return string_0.EndsWith(string_1);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002D5A File Offset: 0x00000F5A
		internal static void smethod_10(Stream stream_0, Stream stream_1)
		{
			AssemblyLoader.CopyTo(stream_0, stream_1);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002D69 File Offset: 0x00000F69
		internal static void smethod_11(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002D78 File Offset: 0x00000F78
		internal static void smethod_12(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002D83 File Offset: 0x00000F83
		internal static object smethod_13(Assembly assembly_0, string string_0)
		{
			return assembly_0.GetManifestResourceStream(string_0);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002D92 File Offset: 0x00000F92
		internal static void smethod_14(object object_0)
		{
			Monitor.Exit(object_0);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002D9D File Offset: 0x00000F9D
		internal static object smethod_15(ResolveEventArgs resolveEventArgs_0)
		{
			return resolveEventArgs_0.Name;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002DA8 File Offset: 0x00000FA8
		internal static object smethod_16(AssemblyName assemblyName_0)
		{
			return AssemblyLoader.ReadExistingAssembly(assemblyName_0);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002DB3 File Offset: 0x00000FB3
		internal static AssemblyNameFlags smethod_17(AssemblyName assemblyName_0)
		{
			return assemblyName_0.Flags;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002DBE File Offset: 0x00000FBE
		internal static object smethod_18(AssemblyName assemblyName_0)
		{
			return Assembly.Load(assemblyName_0);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_19()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002240 File Offset: 0x00000440
		internal static void smethod_20()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002DC9 File Offset: 0x00000FC9
		internal static void smethod_21(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
		{
			appDomain_0.AssemblyResolve += resolveEventHandler_0;
		}

		// Token: 0x04000035 RID: 53
		private static object nullCacheLock = new object();

		// Token: 0x04000036 RID: 54
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x04000037 RID: 55
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x04000038 RID: 56
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x04000039 RID: 57
		private static int isAttached;
	}
}
