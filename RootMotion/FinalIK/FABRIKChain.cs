// Namespace: RootMotion.FinalIK
[Serializable]
public class FABRIKChain // TypeDefIndex: 14353
{
	// Fields
	public FABRIK ik; // 0x10
	[RangeAttribute] // RVA: 0x29FFF0 Offset: 0x2A00F1 VA: 0x29FFF0
	public float pull; // 0x18
	[RangeAttribute] // RVA: 0x2A0010 Offset: 0x2A0111 VA: 0x2A0010
	public float pin; // 0x1C
	public int[] children; // 0x20

	// Methods

	// RVA: 0x2802570 Offset: 0x2802671 VA: 0x2802570
	public bool IsValid(ref string message) { }

	// RVA: 0x2802640 Offset: 0x2802741 VA: 0x2802640
	public void Initiate() { }

	// RVA: 0x2802650 Offset: 0x2802751 VA: 0x2802650
	public void Stage1(FABRIKChain[] chain) { }

	// RVA: 0x28028A0 Offset: 0x28029A1 VA: 0x28028A0
	public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) { }

	// RVA: 0x2802710 Offset: 0x2802811 VA: 0x2802710
	private Vector3 GetCentroid(FABRIKChain[] chain) { }

	// RVA: 0x2802980 Offset: 0x2802A81 VA: 0x2802980
	public void .ctor() { }
}

