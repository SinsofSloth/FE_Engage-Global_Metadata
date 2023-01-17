// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B700 Offset: 0x3B801 VA: 0x3B700
public interface IBitArray // TypeDefIndex: 4612
{
	// Properties
	public abstract uint capacity { get; }
	public abstract bool allFalse { get; }
	public abstract bool allTrue { get; }
	public abstract bool Item { get; set; }
	public abstract string humanizedData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint get_capacity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_allFalse();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_allTrue();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_Item(uint index);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Item(uint index, bool value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_humanizedData();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IBitArray BitAnd(IBitArray other);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IBitArray BitOr(IBitArray other);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IBitArray BitNot();
}

