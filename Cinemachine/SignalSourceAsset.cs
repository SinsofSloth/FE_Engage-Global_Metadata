// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BA20 Offset: 0x1BB21 VA: 0x1BA20
public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 5859
{
	// Properties
	public abstract float SignalDuration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_SignalDuration();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);

	// RVA: 0x1A82F30 Offset: 0x1A83031 VA: 0x1A82F30
	protected void .ctor() { }
}

