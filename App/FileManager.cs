// Namespace: App
public class FileManager : FileCommon // TypeDefIndex: 9136
{
	// Fields
	private static Thread s_Thread; // 0x0
	private static uint[] s_CrcTable; // 0x8

	// Methods

	// RVA: 0x2A20B00 Offset: 0x2A20C01 VA: 0x2A20B00
	public static void Initialize() { }

	// RVA: 0x2A20C10 Offset: 0x2A20D11 VA: 0x2A20C10
	private static void BuildCRC32Table() { }

	// RVA: 0x2A206C0 Offset: 0x2A207C1 VA: 0x2A206C0
	public static uint CalcCrc32(byte[] buf) { }

	// RVA: 0x2A20870 Offset: 0x2A20971 VA: 0x2A20870
	public static void Dump() { }

	// RVA: 0x2A20D90 Offset: 0x2A20E91 VA: 0x2A20D90
	public static void Update() { }

	// RVA: 0x2A210D0 Offset: 0x2A211D1 VA: 0x2A210D0
	public static FileData DirectLoad(string path) { }

	// RVA: 0x2A211B0 Offset: 0x2A212B1 VA: 0x2A211B0
	private static void ThreadFunc() { }

	// RVA: 0x2A214F0 Offset: 0x2A215F1 VA: 0x2A214F0
	public void .ctor() { }

	// RVA: 0x2A21560 Offset: 0x2A21661 VA: 0x2A21560
	private static void .cctor() { }
}

