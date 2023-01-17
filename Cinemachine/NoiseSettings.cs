// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B970 Offset: 0x1BA71 VA: 0x1B970
[HelpURLAttribute] // RVA: 0x1B970 Offset: 0x1BA71 VA: 0x1B970
public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 5856
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x21FC0 Offset: 0x220C1 VA: 0x21FC0
	[TooltipAttribute] // RVA: 0x21FC0 Offset: 0x220C1 VA: 0x21FC0
	public NoiseSettings.TransformNoiseParams[] PositionNoise; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x22020 Offset: 0x22121 VA: 0x22020
	[TooltipAttribute] // RVA: 0x22020 Offset: 0x22121 VA: 0x22020
	public NoiseSettings.TransformNoiseParams[] OrientationNoise; // 0x20

	// Properties
	public override float SignalDuration { get; }

	// Methods

	// RVA: 0x1A82AB0 Offset: 0x1A82BB1 VA: 0x1A82AB0
	public static Vector3 GetCombinedFilterResults(NoiseSettings.TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) { }

	// RVA: 0x1A82CF0 Offset: 0x1A82DF1 VA: 0x1A82CF0 Slot: 6
	public override float get_SignalDuration() { }

	// RVA: 0x1A82D00 Offset: 0x1A82E01 VA: 0x1A82D00 Slot: 7
	public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1A82EA0 Offset: 0x1A82FA1 VA: 0x1A82EA0
	public void .ctor() { }
}

