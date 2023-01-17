// Namespace: App
internal abstract class EnumItem<T, Type> : InstanceItem<T> // TypeDefIndex: 8955
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T instance) { }

	// RVA: -1 Offset: -1 Slot: 72
	protected virtual Type GetValue() { }

	// RVA: -1 Offset: -1 Slot: 73
	protected virtual void SetValue(Type value) { }

	// RVA: -1 Offset: -1 Slot: 42
	public override string GetColumnName0() { }

	// RVA: -1 Offset: -1 Slot: 43
	public override string GetColumnName1() { }

	// RVA: -1 Offset: -1 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }
}

