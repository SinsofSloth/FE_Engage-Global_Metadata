// Namespace: System.Security
[ComVisibleAttribute] // RVA: 0x473A60 Offset: 0x473B61 VA: 0x473A60
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 877
{
	// Fields
	private string permissionState; // 0x88

	// Methods

	// RVA: 0x3615250 Offset: 0x3615351 VA: 0x3615250
	public void .ctor() { }

	// RVA: 0x36152D0 Offset: 0x36153D1 VA: 0x36152D0
	public void .ctor(string message) { }

	// RVA: 0x3615300 Offset: 0x3615401 VA: 0x3615300
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3615670 Offset: 0x3615771 VA: 0x3615670
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x36156A0 Offset: 0x36157A1 VA: 0x36156A0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3615880 Offset: 0x3615981 VA: 0x3615880 Slot: 3
	public override string ToString() { }
}

