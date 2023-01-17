// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4726D0 Offset: 0x4727D1 VA: 0x4726D0
[ComDefaultInterfaceAttribute] // RVA: 0x4726D0 Offset: 0x4727D1 VA: 0x4726D0
[ClassInterfaceAttribute] // RVA: 0x4726D0 Offset: 0x4727D1 VA: 0x4726D0
[Serializable]
internal class MonoModule : RuntimeModule // TypeDefIndex: 584
{
	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x34FB170 Offset: 0x34FB271 VA: 0x34FB170 Slot: 9
	public override Assembly get_Assembly() { }

	// RVA: 0x34FB180 Offset: 0x34FB281 VA: 0x34FB180 Slot: 10
	public override string get_ScopeName() { }

	// RVA: 0x34FB190 Offset: 0x34FB291 VA: 0x34FB190 Slot: 11
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x34FB1A0 Offset: 0x34FB2A1 VA: 0x34FB1A0 Slot: 12
	public override bool IsResource() { }

	// RVA: 0x34FB1B0 Offset: 0x34FB2B1 VA: 0x34FB1B0 Slot: 13
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34FB230 Offset: 0x34FB331 VA: 0x34FB230 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34FB2B0 Offset: 0x34FB3B1 VA: 0x34FB2B0 Slot: 7
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34FB3B0 Offset: 0x34FB4B1 VA: 0x34FB3B0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x34FB430 Offset: 0x34FB531 VA: 0x34FB430
	public void .ctor() { }
}

