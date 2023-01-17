// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472AC0 Offset: 0x472BC1 VA: 0x472AC0
[Serializable]
public class IOException : SystemException // TypeDefIndex: 632
{
	// Fields
	private string _maybeFullPath; // 0x88

	// Methods

	// RVA: 0x340CD70 Offset: 0x340CE71 VA: 0x340CD70
	public void .ctor() { }

	// RVA: 0x340CDF0 Offset: 0x340CEF1 VA: 0x340CDF0
	public void .ctor(string message) { }

	// RVA: 0x340CE30 Offset: 0x340CF31 VA: 0x340CE30
	public void .ctor(string message, int hresult) { }

	// RVA: 0x340CE70 Offset: 0x340CF71 VA: 0x340CE70
	internal void .ctor(string message, int hresult, string maybeFullPath) { }

	// RVA: 0x340CEC0 Offset: 0x340CFC1 VA: 0x340CEC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x340CF00 Offset: 0x340D001 VA: 0x340CF00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

