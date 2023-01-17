// Namespace: AK.Wwise
[Serializable]
public class RTPC : BaseType // TypeDefIndex: 8074
{
	// Fields
	public WwiseRtpcReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x2766330 Offset: 0x2766431 VA: 0x2766330 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2766340 Offset: 0x2766441 VA: 0x2766340 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x27663D0 Offset: 0x27664D1 VA: 0x27663D0 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x27663E0 Offset: 0x27664E1 VA: 0x27663E0
	public void SetValue(GameObject gameObject, float value) { }

	// RVA: 0x27664B0 Offset: 0x27665B1 VA: 0x27664B0
	public float GetValue(GameObject gameObject) { }

	// RVA: 0x27665D0 Offset: 0x27666D1 VA: 0x27665D0
	public void SetGlobalValue(float value) { }

	// RVA: 0x2766690 Offset: 0x2766791 VA: 0x2766690
	public float GetGlobalValue() { }

	// RVA: 0x27666A0 Offset: 0x27667A1 VA: 0x27666A0
	public void .ctor() { }
}

