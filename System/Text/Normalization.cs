// Namespace: System.Text
internal class Normalization // TypeDefIndex: 480
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x34FDE40 Offset: 0x34FDF41 VA: 0x34FDE40
	private static uint PropValue(int cp) { }

	// RVA: 0x34FDEF0 Offset: 0x34FDFF1 VA: 0x34FDEF0
	private static int CharMapIdx(int cp) { }

	// RVA: 0x34FDFA0 Offset: 0x34FE0A1 VA: 0x34FDFA0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x34FE060 Offset: 0x34FE161 VA: 0x34FE060
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x34FE120 Offset: 0x34FE221 VA: 0x34FE120
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x34FE1E0 Offset: 0x34FE2E1 VA: 0x34FE1E0
	private static string Compose(string source, int checkType) { }

	// RVA: 0x34FE440 Offset: 0x34FE541 VA: 0x34FE440
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x34FE580 Offset: 0x34FE681 VA: 0x34FE580
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x34FE860 Offset: 0x34FE961 VA: 0x34FE860
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x34FEF10 Offset: 0x34FF011 VA: 0x34FEF10
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x34FEB40 Offset: 0x34FEC41 VA: 0x34FEB40
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x34FEF50 Offset: 0x34FF051 VA: 0x34FEF50
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x34FF0D0 Offset: 0x34FF1D1 VA: 0x34FF0D0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x34FE2F0 Offset: 0x34FE3F1 VA: 0x34FE2F0
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x34FF360 Offset: 0x34FF461 VA: 0x34FF360
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x34FF170 Offset: 0x34FF271 VA: 0x34FF170
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x34FE6C0 Offset: 0x34FE7C1 VA: 0x34FE6C0
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x34FF840 Offset: 0x34FF941 VA: 0x34FF840
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x34FF620 Offset: 0x34FF721 VA: 0x34FF620
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x34FF950 Offset: 0x34FFA51 VA: 0x34FF950
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x34FFAF0 Offset: 0x34FFBF1 VA: 0x34FFAF0
	public static string Normalize(string source, int type) { }

	// RVA: 0x34FFC20 Offset: 0x34FFD21 VA: 0x34FFC20
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x34FFC30 Offset: 0x34FFD31 VA: 0x34FFC30
	private static void .cctor() { }
}

