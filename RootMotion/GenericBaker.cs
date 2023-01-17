// Namespace: RootMotion
public class GenericBaker : Baker // TypeDefIndex: 14282
{
	// Fields
	[TooltipAttribute] // RVA: 0x29E7D0 Offset: 0x29E8D1 VA: 0x29E7D0
	public bool markAsLegacy; // 0x74
	[TooltipAttribute] // RVA: 0x29E810 Offset: 0x29E911 VA: 0x29E810
	public Transform root; // 0x78
	[TooltipAttribute] // RVA: 0x29E850 Offset: 0x29E951 VA: 0x29E850
	public Transform rootNode; // 0x80
	[TooltipAttribute] // RVA: 0x29E890 Offset: 0x29E991 VA: 0x29E890
	public Transform[] ignoreList; // 0x88
	[TooltipAttribute] // RVA: 0x29E8D0 Offset: 0x29E9D1 VA: 0x29E8D0
	public Transform[] bakePositionList; // 0x90
	private BakerTransform[] children; // 0x98
	private BakerTransform rootChild; // 0xA0
	private int rootChildIndex; // 0xA8

	// Methods

	// RVA: 0x28E00F0 Offset: 0x28E01F1 VA: 0x28E00F0
	private void Awake() { }

	// RVA: 0x28E0500 Offset: 0x28E0601 VA: 0x28E0500 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x28E0510 Offset: 0x28E0611 VA: 0x28E0510 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x28E0620 Offset: 0x28E0721 VA: 0x28E0620 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x28E06A0 Offset: 0x28E07A1 VA: 0x28E06A0 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x28E0720 Offset: 0x28E0821 VA: 0x28E0720 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x28E0340 Offset: 0x28E0441 VA: 0x28E0340
	private bool IsIgnored(Transform t) { }

	// RVA: 0x28E0420 Offset: 0x28E0521 VA: 0x28E0420
	private bool BakePosition(Transform t) { }

	// RVA: 0x28E07A0 Offset: 0x28E08A1 VA: 0x28E07A0
	public void .ctor() { }
}

