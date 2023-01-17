// Namespace: System
[ComVisibleAttribute] // RVA: 0x470790 Offset: 0x470891 VA: 0x470790
[Serializable]
public class OperationCanceledException : SystemException // TypeDefIndex: 285
{
	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x3810DE0 Offset: 0x3810EE1 VA: 0x3810DE0
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x3810DF0 Offset: 0x3810EF1 VA: 0x3810DF0
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x3810E00 Offset: 0x3810F01 VA: 0x3810E00
	public void .ctor() { }

	// RVA: 0x3810E80 Offset: 0x3810F81 VA: 0x3810E80
	public void .ctor(string message) { }

	// RVA: 0x3810EC0 Offset: 0x3810FC1 VA: 0x3810EC0
	public void .ctor(CancellationToken token) { }

	// RVA: 0x3810F50 Offset: 0x3811051 VA: 0x3810F50
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0x3810FA0 Offset: 0x38110A1 VA: 0x3810FA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

