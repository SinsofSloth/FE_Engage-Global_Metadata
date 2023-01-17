// Namespace: Cinemachine.Utility
public class HeadingTracker // TypeDefIndex: 5906
{
	// Fields
	private HeadingTracker.Item[] mHistory; // 0x10
	private int mTop; // 0x18
	private int mBottom; // 0x1C
	private int mCount; // 0x20
	private Vector3 mHeadingSum; // 0x24
	private float mWeightSum; // 0x30
	private float mWeightTime; // 0x34
	private Vector3 mLastGoodHeading; // 0x38
	private static float mDecayExponent; // 0x0

	// Properties
	public int FilterSize { get; }

	// Methods

	// RVA: 0x1A81EF0 Offset: 0x1A81FF1 VA: 0x1A81EF0
	public void .ctor(int filterSize) { }

	// RVA: 0x1A82020 Offset: 0x1A82121 VA: 0x1A82020
	public int get_FilterSize() { }

	// RVA: 0x1A81FE0 Offset: 0x1A820E1 VA: 0x1A81FE0
	private void ClearHistory() { }

	// RVA: 0x1A82030 Offset: 0x1A82131 VA: 0x1A82030
	private static float Decay(float time) { }

	// RVA: 0x1A82090 Offset: 0x1A82191 VA: 0x1A82090
	public void Add(Vector3 velocity) { }

	// RVA: 0x1A82270 Offset: 0x1A82371 VA: 0x1A82270
	private void PopBottom() { }

	// RVA: 0x1A82400 Offset: 0x1A82501 VA: 0x1A82400
	public void DecayHistory() { }

	// RVA: 0x1A82520 Offset: 0x1A82621 VA: 0x1A82520
	public Vector3 GetReliableHeading() { }
}

