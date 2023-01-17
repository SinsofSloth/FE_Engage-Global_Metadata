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

