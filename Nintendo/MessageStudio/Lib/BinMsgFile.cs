// Namespace: Nintendo.MessageStudio.Lib
public class BinMsgFile : BinLibmsFileBase // TypeDefIndex: 15026
{
	// Methods

	// RVA: 0x2264300 Offset: 0x2264401 VA: 0x2264300 Slot: 5
	protected override IntPtr InitObject(IntPtr resourcePtr) { }

	// RVA: 0x2264370 Offset: 0x2264471 VA: 0x2264370 Slot: 6
	protected override void CloseObject(IntPtr objectPtr) { }

	// RVA: 0x22643E0 Offset: 0x22644E1 VA: 0x22643E0
	public int SearchMessageBlock(string block) { }

	// RVA: 0x2264460 Offset: 0x2264561 VA: 0x2264460
	public BlockInfo GetBlockInfo(string block) { }

	// RVA: 0x22645D0 Offset: 0x22646D1 VA: 0x22645D0
	public byte[] GetAttributes(string label) { }

	// RVA: 0x2264660 Offset: 0x2264761 VA: 0x2264660
	public byte[] GetAttributes(int index) { }

	// RVA: 0x22647A0 Offset: 0x22648A1 VA: 0x22647A0
	public sbyte GetInt8Attribute(byte[] attr, int index) { }

	// RVA: 0x2264850 Offset: 0x2264951 VA: 0x2264850
	public byte GetUInt8Attribute(byte[] attr, int index) { }

	// RVA: 0x2264900 Offset: 0x2264A01 VA: 0x2264900
	public short GetInt16Attribute(byte[] attr, int index) { }

	// RVA: 0x22649D0 Offset: 0x2264AD1 VA: 0x22649D0
	public ushort GetUInt16Attribute(byte[] attr, int index) { }

	// RVA: 0x2264AA0 Offset: 0x2264BA1 VA: 0x2264AA0
	public int GetInt32Attribute(byte[] attr, int index) { }

	// RVA: 0x2264B70 Offset: 0x2264C71 VA: 0x2264B70
	public uint GetUInt32Attribute(byte[] attr, int index) { }

	// RVA: 0x2264C40 Offset: 0x2264D41 VA: 0x2264C40
	public float GetFloatAttribute(byte[] attr, int index) { }

	// RVA: 0x2264D10 Offset: 0x2264E11 VA: 0x2264D10
	public double GetDoubleAttribute(byte[] attr, int index) { }

	// RVA: 0x2264DE0 Offset: 0x2264EE1 VA: 0x2264DE0
	public string GetStringAttribute(byte[] attr, int index) { }

	// RVA: 0x2264EF0 Offset: 0x2264FF1 VA: 0x2264EF0
	public int GetListAttribute(byte[] attr, int index) { }

	// RVA: 0x2264FA0 Offset: 0x22650A1 VA: 0x2264FA0
	public int GetStyle(string label) { }

	// RVA: 0x2265020 Offset: 0x2265121 VA: 0x2265020
	public int GetStyle(int index) { }

	// RVA: 0x22650A0 Offset: 0x22651A1 VA: 0x22650A0
	public string GetLabel(int index) { }

	// RVA: 0x2265180 Offset: 0x2265281 VA: 0x2265180
	public int GetTextNum() { }

	// RVA: 0x22651F0 Offset: 0x22652F1 VA: 0x22651F0
	public int GetTextIndex(string label) { }

	// RVA: 0x2265270 Offset: 0x2265371 VA: 0x2265270
	public int GetTextSize(int index) { }

	// RVA: 0x22652F0 Offset: 0x22653F1 VA: 0x22652F0
	public IntPtr GetText(string strLabel) { }

	// RVA: 0x22653A0 Offset: 0x22654A1 VA: 0x22653A0
	public IntPtr GetText(int index) { }

	// RVA: 0x2265450 Offset: 0x2265551 VA: 0x2265450
	public void .ctor() { }
}

