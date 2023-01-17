// Namespace: App
public static class Crc32 // TypeDefIndex: 13823
{
	// Fields
	private static uint[] s_Table; // 0x0

	// Methods

	// RVA: 0x23C0DE0 Offset: 0x23C0EE1 VA: 0x23C0DE0
	public static void Initialize() { }

	// RVA: 0x23C0F30 Offset: 0x23C1031 VA: 0x23C0F30
	public static uint Calculate(byte[] buf) { }

	// RVA: 0x23C0F60 Offset: 0x23C1061 VA: 0x23C0F60
	public static uint Calculate(byte[] buf, int len) { }

	// RVA: 0x23C0F90 Offset: 0x23C1091 VA: 0x23C0F90
	private static uint UpdateCrc(uint crc, byte[] buf, int len) { }
}

