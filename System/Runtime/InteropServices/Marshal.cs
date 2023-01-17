// Namespace: System.Runtime.InteropServices
public static class Marshal // TypeDefIndex: 1315
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0x34E4C30 Offset: 0x34E4D31 VA: 0x34E4C30
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x47D560 Offset: 0x47D661 VA: 0x47D560
	// RVA: 0x34E4C40 Offset: 0x34E4D41 VA: 0x34E4C40
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x47D580 Offset: 0x47D681 VA: 0x47D580
	// RVA: 0x34E4C50 Offset: 0x34E4D51 VA: 0x34E4C50
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x34E4CD0 Offset: 0x34E4DD1 VA: 0x34E4CD0
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x34E4CE0 Offset: 0x34E4DE1 VA: 0x34E4CE0
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x34E4CF0 Offset: 0x34E4DF1 VA: 0x34E4CF0
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x34E4D80 Offset: 0x34E4E81 VA: 0x34E4D80
	public static void Copy(char[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x34E4E10 Offset: 0x34E4F11 VA: 0x34E4E10
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x34E4EA0 Offset: 0x34E4FA1 VA: 0x34E4EA0
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x34E4F30 Offset: 0x34E5031 VA: 0x34E4F30
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x47D5A0 Offset: 0x47D6A1 VA: 0x47D5A0
	// RVA: 0x34E4F40 Offset: 0x34E5041 VA: 0x34E4F40
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x34E4F50 Offset: 0x34E5051 VA: 0x34E4F50
	private static void ClearBSTR(IntPtr ptr) { }

	// RVA: 0x34E50D0 Offset: 0x34E51D1 VA: 0x34E50D0
	public static void ZeroFreeBSTR(IntPtr s) { }

	// RVA: 0x34E5140 Offset: 0x34E5241 VA: 0x34E5140
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x34E52F0 Offset: 0x34E53F1 VA: 0x34E52F0
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x34E5360 Offset: 0x34E5461 VA: 0x34E5360
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x47D5C0 Offset: 0x47D6C1 VA: 0x47D5C0
	// RVA: 0x34E5370 Offset: 0x34E5471 VA: 0x34E5370
	public static int GetLastWin32Error() { }

	// RVA: 0x34E5380 Offset: 0x34E5481 VA: 0x34E5380
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x34E5390 Offset: 0x34E5491 VA: 0x34E5390
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	// RVA: 0x34E53A0 Offset: 0x34E54A1 VA: 0x34E53A0
	public static string PtrToStringAuto(IntPtr ptr, int len) { }

	// RVA: 0x34E54B0 Offset: 0x34E55B1 VA: 0x34E54B0
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0x34E54A0 Offset: 0x34E55A1 VA: 0x34E54A0
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x47D5E0 Offset: 0x47D6E1 VA: 0x47D5E0
	// RVA: 0x34E54C0 Offset: 0x34E55C1 VA: 0x34E54C0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2962670 Offset: 0x2962771 VA: 0x2962670
	|-Marshal.PtrToStructure<object>
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|
	|-RVA: 0x2962780 Offset: 0x2962881 VA: 0x2962780
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	|
	|-RVA: 0x29628C0 Offset: 0x29629C1 VA: 0x29628C0
	|-Marshal.PtrToStructure<SoundSystem.LipSyncStructData>
	*/

	// RVA: 0x34E54D0 Offset: 0x34E55D1 VA: 0x34E54D0
	public static byte ReadByte(IntPtr ptr) { }

	// RVA: 0x34E54F0 Offset: 0x34E55F1 VA: 0x34E54F0
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x34E5520 Offset: 0x34E5621 VA: 0x34E5520
	public static short ReadInt16(IntPtr ptr) { }

	// RVA: 0x34E52A0 Offset: 0x34E53A1 VA: 0x34E52A0
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x47D600 Offset: 0x47D701 VA: 0x47D600
	// RVA: 0x34E5580 Offset: 0x34E5681 VA: 0x34E5580
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x47D620 Offset: 0x47D721 VA: 0x47D620
	// RVA: 0x34E5050 Offset: 0x34E5151 VA: 0x34E5050
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x47D640 Offset: 0x47D741 VA: 0x47D640
	// RVA: 0x34E55D0 Offset: 0x34E56D1 VA: 0x34E55D0
	public static long ReadInt64(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x47D660 Offset: 0x47D761 VA: 0x47D660
	// RVA: 0x34E5640 Offset: 0x34E5741 VA: 0x34E5640
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x47D680 Offset: 0x47D781 VA: 0x47D680
	// RVA: 0x34E5760 Offset: 0x34E5861 VA: 0x34E5760
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x47D6A0 Offset: 0x47D7A1 VA: 0x47D6A0
	// RVA: 0x34E5770 Offset: 0x34E5871 VA: 0x34E5770
	public static int Release(IntPtr pUnk) { }

	[ComVisibleAttribute] // RVA: 0x47D6C0 Offset: 0x47D7C1 VA: 0x47D6C0
	// RVA: 0x34E5860 Offset: 0x34E5961 VA: 0x34E5860
	public static int SizeOf(object structure) { }

	// RVA: 0x34E58E0 Offset: 0x34E59E1 VA: 0x34E58E0
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29629F0 Offset: 0x2962AF1 VA: 0x29629F0
	|-Marshal.SizeOf<int>
	|
	|-RVA: 0x2962AA0 Offset: 0x2962BA1 VA: 0x2962AA0
	|-Marshal.SizeOf<object>
	|
	|-RVA: 0x2962B50 Offset: 0x2962C51 VA: 0x2962B50
	|-Marshal.SizeOf<PunctualLightData>
	|
	|-RVA: 0x2962C00 Offset: 0x2962D01 VA: 0x2962C00
	|-Marshal.SizeOf<TileData>
	|
	|-RVA: 0x2962CB0 Offset: 0x2962DB1 VA: 0x2962CB0
	|-Marshal.SizeOf<uint>
	|
	|-RVA: 0x2962D60 Offset: 0x2962E61 VA: 0x2962D60
	|-Marshal.SizeOf<ShaderInput.LightData>
	|
	|-RVA: 0x2962E10 Offset: 0x2962F11 VA: 0x2962E10
	|-Marshal.SizeOf<ShaderInput.ShadowData>
	|
	|-RVA: 0x2962EC0 Offset: 0x2962FC1 VA: 0x2962EC0
	|-Marshal.SizeOf<SoundSystem.LipSyncStructData>
	*/

	// RVA: 0x34E58F0 Offset: 0x34E59F1 VA: 0x34E58F0
	public static IntPtr SecureStringToBSTR(SecureString s) { }

	// RVA: 0x34E5A90 Offset: 0x34E5B91 VA: 0x34E5A90
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0x34E5D80 Offset: 0x34E5E81 VA: 0x34E5D80
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0x47D6E0 Offset: 0x47D7E1 VA: 0x47D6E0
	[ReliabilityContractAttribute] // RVA: 0x47D6E0 Offset: 0x47D7E1 VA: 0x47D6E0
	// RVA: 0x34E5E40 Offset: 0x34E5F41 VA: 0x34E5E40
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2962F70 Offset: 0x2963071 VA: 0x2962F70
	|-Marshal.StructureToPtr<byte>
	|
	|-RVA: 0x2963030 Offset: 0x2963131 VA: 0x2963030
	|-Marshal.StructureToPtr<object>
	|
	|-RVA: 0x29630C0 Offset: 0x29631C1 VA: 0x29630C0
	|-Marshal.StructureToPtr<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2963180 Offset: 0x2963281 VA: 0x2963180
	|-Marshal.StructureToPtr<ushort>
	|
	|-RVA: 0x2963240 Offset: 0x2963341 VA: 0x2963240
	|-Marshal.StructureToPtr<uint>
	|
	|-RVA: 0x2963300 Offset: 0x2963401 VA: 0x2963300
	|-Marshal.StructureToPtr<ulong>
	|
	|-RVA: 0x29633C0 Offset: 0x29634C1 VA: 0x29633C0
	|-Marshal.StructureToPtr<Detail.CppArray>
	|
	|-RVA: 0x2963490 Offset: 0x2963591 VA: 0x2963490
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2963560 Offset: 0x2963661 VA: 0x2963560
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2963630 Offset: 0x2963731 VA: 0x2963630
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2963710 Offset: 0x2963811 VA: 0x2963710
	|-Marshal.StructureToPtr<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x29637E0 Offset: 0x29638E1 VA: 0x29637E0
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x29638B0 Offset: 0x29639B1 VA: 0x29638B0
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2963980 Offset: 0x2963A81 VA: 0x2963980
	|-Marshal.StructureToPtr<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2963A50 Offset: 0x2963B51 VA: 0x2963A50
	|-Marshal.StructureToPtr<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2963B20 Offset: 0x2963C21 VA: 0x2963B20
	|-Marshal.StructureToPtr<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2963C00 Offset: 0x2963D01 VA: 0x2963C00
	|-Marshal.StructureToPtr<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2963CD0 Offset: 0x2963DD1 VA: 0x2963CD0
	|-Marshal.StructureToPtr<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2963DA0 Offset: 0x2963EA1 VA: 0x2963DA0
	|-Marshal.StructureToPtr<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2963E70 Offset: 0x2963F71 VA: 0x2963E70
	|-Marshal.StructureToPtr<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2963F40 Offset: 0x2964041 VA: 0x2963F40
	|-Marshal.StructureToPtr<Detail.Utility.UniqueIdInfoInt>
	*/

	// RVA: 0x34E5A80 Offset: 0x34E5B81 VA: 0x34E5A80
	private static IntPtr BufferToBSTR(Array ptr, int slen) { }

	// RVA: 0x34E5E50 Offset: 0x34E5F51 VA: 0x34E5E50
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2964010 Offset: 0x2964111 VA: 0x2964010
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0x2964090 Offset: 0x2964191 VA: 0x2964090
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0x34E50A0 Offset: 0x34E51A1 VA: 0x34E50A0
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x34E5E60 Offset: 0x34E5F61 VA: 0x34E5E60
	public static void WriteInt16(IntPtr ptr, short val) { }

	// RVA: 0x34E5240 Offset: 0x34E5341 VA: 0x34E5240
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x34E5EB0 Offset: 0x34E5FB1 VA: 0x34E5EB0
	public static void WriteInt16(IntPtr ptr, char val) { }

	// RVA: 0x34E5F50 Offset: 0x34E6051 VA: 0x34E5F50
	public static void WriteInt32(IntPtr ptr, int val) { }

	// RVA: 0x34E5FA0 Offset: 0x34E60A1 VA: 0x34E5FA0
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2962590 Offset: 0x2962691 VA: 0x2962590
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	// RVA: 0x34E5FB0 Offset: 0x34E60B1 VA: 0x34E5FB0
	private static void .cctor() { }
}

