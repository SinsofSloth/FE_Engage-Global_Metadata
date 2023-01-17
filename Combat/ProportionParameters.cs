// Namespace: Combat
[Serializable]
public sealed class ProportionParameters // TypeDefIndex: 8669
{
	// Fields
	[RangeAttribute] // RVA: 0x2832B0 Offset: 0x2833B1 VA: 0x2832B0
	[TooltipAttribute] // RVA: 0x2832B0 Offset: 0x2833B1 VA: 0x2832B0
	public float ScaleAll; // 0x10
	[RangeAttribute] // RVA: 0x283310 Offset: 0x283411 VA: 0x283310
	[TooltipAttribute] // RVA: 0x283310 Offset: 0x283411 VA: 0x283310
	public float ScaleHead; // 0x14
	[RangeAttribute] // RVA: 0x283370 Offset: 0x283471 VA: 0x283370
	[TooltipAttribute] // RVA: 0x283370 Offset: 0x283471 VA: 0x283370
	public float ScaleNeck; // 0x18
	[TooltipAttribute] // RVA: 0x2833D0 Offset: 0x2834D1 VA: 0x2833D0
	[RangeAttribute] // RVA: 0x2833D0 Offset: 0x2834D1 VA: 0x2833D0
	public float ScaleTorso; // 0x1C
	[RangeAttribute] // RVA: 0x283430 Offset: 0x283531 VA: 0x283430
	[TooltipAttribute] // RVA: 0x283430 Offset: 0x283531 VA: 0x283430
	public float ScaleShoulders; // 0x20
	[TooltipAttribute] // RVA: 0x283490 Offset: 0x283591 VA: 0x283490
	[RangeAttribute] // RVA: 0x283490 Offset: 0x283591 VA: 0x283490
	public float ScaleArms; // 0x24
	[RangeAttribute] // RVA: 0x2834F0 Offset: 0x2835F1 VA: 0x2834F0
	[TooltipAttribute] // RVA: 0x2834F0 Offset: 0x2835F1 VA: 0x2834F0
	public float ScaleHands; // 0x28
	[RangeAttribute] // RVA: 0x283550 Offset: 0x283651 VA: 0x283550
	[TooltipAttribute] // RVA: 0x283550 Offset: 0x283651 VA: 0x283550
	public float ScaleLegs; // 0x2C
	[RangeAttribute] // RVA: 0x2835B0 Offset: 0x2836B1 VA: 0x2835B0
	[TooltipAttribute] // RVA: 0x2835B0 Offset: 0x2836B1 VA: 0x2835B0
	public float ScaleFeet; // 0x30
	[RangeAttribute] // RVA: 0x283610 Offset: 0x283711 VA: 0x283610
	[TooltipAttribute] // RVA: 0x283610 Offset: 0x283711 VA: 0x283610
	public float VolumeArms; // 0x34
	[TooltipAttribute] // RVA: 0x283670 Offset: 0x283771 VA: 0x283670
	[RangeAttribute] // RVA: 0x283670 Offset: 0x283771 VA: 0x283670
	public float VolumeLegs; // 0x38
	[RangeAttribute] // RVA: 0x2836D0 Offset: 0x2837D1 VA: 0x2836D0
	[TooltipAttribute] // RVA: 0x2836D0 Offset: 0x2837D1 VA: 0x2836D0
	public float VolumeBust; // 0x3C
	[TooltipAttribute] // RVA: 0x283730 Offset: 0x283831 VA: 0x283730
	[RangeAttribute] // RVA: 0x283730 Offset: 0x283831 VA: 0x283730
	public float VolumeAbdomen; // 0x40
	[TooltipAttribute] // RVA: 0x283790 Offset: 0x283891 VA: 0x283790
	[RangeAttribute] // RVA: 0x283790 Offset: 0x283891 VA: 0x283790
	public float VolumeTorso; // 0x44
	[TooltipAttribute] // RVA: 0x2837F0 Offset: 0x2838F1 VA: 0x2837F0
	public float HipJointHeight; // 0x48
	[TooltipAttribute] // RVA: 0x283830 Offset: 0x283931 VA: 0x283830
	public float AnkleHeight; // 0x4C
	private Transform[] targetNodes; // 0x50
	private Vector3[] proportionScales; // 0x58
	private int writeCount; // 0x60

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x2EED610 Offset: 0x2EED711 VA: 0x2EED610
	public void ImportLegScaleParamsFromModel(Transform root) { }

	// RVA: 0x2EED730 Offset: 0x2EED831 VA: 0x2EED730
	public void .ctor() { }

	// RVA: 0x2EED760 Offset: 0x2EED861 VA: 0x2EED760
	public void .ctor(ProportionParameters rhs) { }

	// RVA: 0x2EED820 Offset: 0x2EED921 VA: 0x2EED820
	public void ResetToOne() { }

	// RVA: 0x2EED840 Offset: 0x2EED941 VA: 0x2EED840
	public string GetClipboardFormedString() { }

	// RVA: 0x2EEDB30 Offset: 0x2EEDC31 VA: 0x2EEDB30
	public void Random() { }

	// RVA: 0x2EEDC80 Offset: 0x2EEDD81 VA: 0x2EEDC80
	public bool get_IsValid() { }

	// RVA: 0x2EEDDA0 Offset: 0x2EEDEA1 VA: 0x2EEDDA0
	public void CopyFrom(ProportionParameters rhs) { }

	// RVA: 0x2EEDE30 Offset: 0x2EEDF31 VA: 0x2EEDE30
	public void ImportFromAssetResult(AssetTable.Result r) { }

	// RVA: 0x2EEDED0 Offset: 0x2EEDFD1 VA: 0x2EEDED0
	public string DumpToString() { }

	// RVA: 0x2EEE320 Offset: 0x2EEE421 VA: 0x2EEE320
	public string DumpToShortString() { }

	// RVA: 0x2EEE570 Offset: 0x2EEE671 VA: 0x2EEE570
	public void Calculate(CharacterJoint j) { }

	// RVA: 0x2EEF0A0 Offset: 0x2EEF1A1 VA: 0x2EEF0A0
	public void Flush() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA10 Offset: 0x2ABB11 VA: 0x2ABA10
	// RVA: 0x2EEEBB0 Offset: 0x2EEECB1 VA: 0x2EEEBB0
	private void <Calculate>g__sxyz|28_0(Transform t, float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA20 Offset: 0x2ABB21 VA: 0x2ABA20
	// RVA: 0x2EEECE0 Offset: 0x2EEEDE1 VA: 0x2EEECE0
	private void <Calculate>g__s_yz|28_1(Transform t, float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA30 Offset: 0x2ABB31 VA: 0x2ABA30
	// RVA: 0x2EEEE20 Offset: 0x2EEEF21 VA: 0x2EEEE20
	private void <Calculate>g__s_y_|28_2(Transform t, float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA40 Offset: 0x2ABB41 VA: 0x2ABA40
	// RVA: 0x2EEEF60 Offset: 0x2EEF061 VA: 0x2EEEF60
	private void <Calculate>g__s__z|28_3(Transform t, float value) { }
}

