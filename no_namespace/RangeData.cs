// Namespace: 
public enum RangeData.Targets // TypeDefIndex: 10015
{
	// Fields
	public int value__; // 0x0
	public const RangeData.Targets None = 0;
	public const RangeData.Targets Self = 1;
	public const RangeData.Targets Enemy = 2;
	public const RangeData.Targets Friend = 3;
	public const RangeData.Targets Both = 4;
}

// Namespace: 
public struct RangeData.Offset // TypeDefIndex: 10016
{
	// Fields
	public sbyte X; // 0x0
	public sbyte Z; // 0x1
	public RangeData.Targets Target; // 0x4

	// Methods

	// RVA: 0x1F2AF90 Offset: 0x1F2B091 VA: 0x1F2AF90
	public void .ctor(int x, int z, RangeData.Targets target) { }

	// RVA: 0x1F2AFA0 Offset: 0x1F2B0A1 VA: 0x1F2AFA0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public class RangeData.DirOffsets // TypeDefIndex: 10017
{
	// Fields
	private Dictionary<string, List<RangeData.Offset>>[] m_Offsets; // 0x10
	private Dictionary<string, RangeData.Targets> m_Centers; // 0x18

	// Methods

	// RVA: 0x1F2AAC0 Offset: 0x1F2ABC1 VA: 0x1F2AAC0
	public void .ctor() { }

	// RVA: 0x1F2AD50 Offset: 0x1F2AE51 VA: 0x1F2AD50
	public void AddCenter(string name, RangeData.Targets target) { }

	// RVA: 0x1F2ADC0 Offset: 0x1F2AEC1 VA: 0x1F2ADC0
	public RangeData.Targets GetCenter(string name) { }

	// RVA: 0x1F2AE20 Offset: 0x1F2AF21 VA: 0x1F2AE20
	public Dictionary<string, List<RangeData.Offset>> GetOffest(Dir.Type dir) { }

	// RVA: 0x1F2AED0 Offset: 0x1F2AFD1 VA: 0x1F2AED0
	public void Clear() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2763F0 Offset: 0x2764F1 VA: 0x2763F0
[Serializable]
private sealed class RangeData.<>c // TypeDefIndex: 10018
{
	// Fields
	public static readonly RangeData.<>c <>9; // 0x0
	public static Comparison<RangeData.Offset> <>9__36_0; // 0x8

	// Methods

	// RVA: 0x1F2AA10 Offset: 0x1F2AB11 VA: 0x1F2AA10
	private static void .cctor() { }

	// RVA: 0x1F2AA80 Offset: 0x1F2AB81 VA: 0x1F2AA80
	public void .ctor() { }

	// RVA: 0x1F2AA90 Offset: 0x1F2AB91 VA: 0x1F2AA90
	internal int <Commit>b__36_0(RangeData.Offset a, RangeData.Offset b) { }
}

