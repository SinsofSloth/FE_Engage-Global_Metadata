// Namespace: UnityEngine.ResourceManagement.Exceptions
public class UnknownResourceProviderException : ResourceManagerException // TypeDefIndex: 5550
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x725E0 Offset: 0x726E1 VA: 0x725E0
	private IResourceLocation <Location>k__BackingField; // 0x88

	// Properties
	public IResourceLocation Location { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x72DB0 Offset: 0x72EB1 VA: 0x72DB0
	// RVA: 0x3637810 Offset: 0x3637911 VA: 0x3637810
	public IResourceLocation get_Location() { }

	[CompilerGeneratedAttribute] // RVA: 0x72DC0 Offset: 0x72EC1 VA: 0x72DC0
	// RVA: 0x3637820 Offset: 0x3637921 VA: 0x3637820
	private void set_Location(IResourceLocation value) { }

	// RVA: 0x3633690 Offset: 0x3633791 VA: 0x3633690
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x3637830 Offset: 0x3637931 VA: 0x3637830
	public void .ctor() { }

	// RVA: 0x36378A0 Offset: 0x36379A1 VA: 0x36378A0
	public void .ctor(string message) { }

	// RVA: 0x3637920 Offset: 0x3637A21 VA: 0x3637920
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x36379B0 Offset: 0x3637AB1 VA: 0x36379B0
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x3637A40 Offset: 0x3637B41 VA: 0x3637A40 Slot: 5
	public override string get_Message() { }

	// RVA: 0x3637CD0 Offset: 0x3637DD1 VA: 0x3637CD0 Slot: 3
	public override string ToString() { }
}

