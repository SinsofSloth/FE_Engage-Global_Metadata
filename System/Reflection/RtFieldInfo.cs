// Namespace: System.Reflection
internal abstract class RtFieldInfo : RuntimeFieldInfo // TypeDefIndex: 576
{
	// Methods

	// RVA: 0x322B170 Offset: 0x322B271 VA: 0x322B170
	internal object UnsafeGetValue(object obj) { }

	// RVA: 0x322B180 Offset: 0x322B281 VA: 0x322B180
	internal void CheckConsistency(object target) { }

	[DebuggerStepThroughAttribute] // RVA: 0x47BE80 Offset: 0x47BF81 VA: 0x47BE80
	[DebuggerHiddenAttribute] // RVA: 0x47BE80 Offset: 0x47BF81 VA: 0x47BE80
	// RVA: 0x322B320 Offset: 0x322B421 VA: 0x322B320
	internal void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHiddenAttribute] // RVA: 0x47BEC0 Offset: 0x47BFC1 VA: 0x47BEC0
	[DebuggerStepThroughAttribute] // RVA: 0x47BEC0 Offset: 0x47BFC1 VA: 0x47BEC0
	// RVA: 0x322B380 Offset: 0x322B481 VA: 0x322B380 Slot: 34
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x322B500 Offset: 0x322B601 VA: 0x322B500
	protected void .ctor() { }
}

