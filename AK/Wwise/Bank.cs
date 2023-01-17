// Namespace: AK.Wwise
[Serializable]
public class Bank : BaseType // TypeDefIndex: 8069
{
	// Fields
	public WwiseBankReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x2617EC0 Offset: 0x2617FC1 VA: 0x2617EC0 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2617ED0 Offset: 0x2617FD1 VA: 0x2617ED0 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x2617F60 Offset: 0x2618061 VA: 0x2617F60 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x2617F70 Offset: 0x2618071 VA: 0x2617F70
	public void Load(bool decodeBank = False, bool saveDecodedBank = False) { }

	// RVA: 0x26180A0 Offset: 0x26181A1 VA: 0x26180A0
	public void LoadAsync(AkCallbackManager.BankCallback callback) { }

	// RVA: 0x26181C0 Offset: 0x26182C1 VA: 0x26181C0
	public void Unload() { }

	// RVA: 0x26182D0 Offset: 0x26183D1 VA: 0x26182D0
	public void .ctor() { }
}

