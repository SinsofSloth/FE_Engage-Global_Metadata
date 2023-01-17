// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474320 Offset: 0x474421 VA: 0x474320
public class CryptoConfig // TypeDefIndex: 966
{
	// Properties
	[MonoLimitationAttribute] // RVA: 0x47E160 Offset: 0x47E261 VA: 0x47E160
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x37D7790 Offset: 0x37D7891 VA: 0x37D7790
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x37D7BE0 Offset: 0x37D7CE1 VA: 0x37D7BE0
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x37D7D90 Offset: 0x37D7E91 VA: 0x37D7D90
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x37D7DA0 Offset: 0x37D7EA1 VA: 0x37D7DA0
	public static object CreateFromName(string name) { }

	// RVA: 0x37D7DB0 Offset: 0x37D7EB1 VA: 0x37D7DB0
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x37D98E0 Offset: 0x37D99E1 VA: 0x37D98E0
	internal static string MapNameToOID(string name, object arg) { }

	// RVA: 0x37D98F0 Offset: 0x37D99F1 VA: 0x37D98F0
	public static string MapNameToOID(string name) { }
}

