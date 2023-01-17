// Namespace: System
[ComVisibleAttribute] // RVA: 0x470DA0 Offset: 0x470EA1 VA: 0x470DA0
[Serializable]
public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 328
{
	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x3643320 Offset: 0x3643421 VA: 0x3643320
	public void .ctor() { }

	// RVA: 0x3641480 Offset: 0x3641581 VA: 0x3641480
	public void .ctor(string message) { }

	// RVA: 0x36433A0 Offset: 0x36434A1 VA: 0x36433A0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x36433D0 Offset: 0x36434D1 VA: 0x36433D0
	private void SetMessageField() { }

	// RVA: 0x3643540 Offset: 0x3643641 VA: 0x3643540
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x36435D0 Offset: 0x36436D1 VA: 0x36435D0
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x3643670 Offset: 0x3643771 VA: 0x3643670
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x36437F0 Offset: 0x36438F1 VA: 0x36437F0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

