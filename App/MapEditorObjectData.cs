// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276310 Offset: 0x276411 VA: 0x276310
public class MapEditorObjectData : StructData<MapEditorObjectData> // TypeDefIndex: 9981
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28C160 Offset: 0x28C261 VA: 0x28C160
	private string <ObjectName>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28C170 Offset: 0x28C271 VA: 0x28C170
	private string <SoundEvent>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28C180 Offset: 0x28C281 VA: 0x28C180
	private string <Category>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28C190 Offset: 0x28C291 VA: 0x28C190
	private int <ObjectKey>k__BackingField; // 0x38

	// Properties
	public string ObjectName { get; set; }
	public string SoundEvent { get; set; }
	public string Category { get; set; }
	public int ObjectKey { get; set; }

	// Methods

	// RVA: 0x21B69A0 Offset: 0x21B6AA1 VA: 0x21B69A0
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA170 Offset: 0x2BA271 VA: 0x2BA170
	// RVA: 0x21B6A50 Offset: 0x21B6B51 VA: 0x21B6A50
	public string get_ObjectName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA180 Offset: 0x2BA281 VA: 0x2BA180
	// RVA: 0x21B6A60 Offset: 0x21B6B61 VA: 0x21B6A60
	private void set_ObjectName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA190 Offset: 0x2BA291 VA: 0x2BA190
	// RVA: 0x21B6A70 Offset: 0x21B6B71 VA: 0x21B6A70
	public string get_SoundEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA1A0 Offset: 0x2BA2A1 VA: 0x2BA1A0
	// RVA: 0x21B6A80 Offset: 0x21B6B81 VA: 0x21B6A80
	private void set_SoundEvent(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA1B0 Offset: 0x2BA2B1 VA: 0x2BA1B0
	// RVA: 0x21B6A90 Offset: 0x21B6B91 VA: 0x21B6A90
	public string get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA1C0 Offset: 0x2BA2C1 VA: 0x2BA1C0
	// RVA: 0x21B6AA0 Offset: 0x21B6BA1 VA: 0x21B6AA0
	private void set_Category(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA1D0 Offset: 0x2BA2D1 VA: 0x2BA1D0
	// RVA: 0x21B6AB0 Offset: 0x21B6BB1 VA: 0x21B6AB0
	public int get_ObjectKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BA1E0 Offset: 0x2BA2E1 VA: 0x2BA1E0
	// RVA: 0x21B6AC0 Offset: 0x21B6BC1 VA: 0x21B6AC0
	private void set_ObjectKey(int value) { }

	// RVA: 0x21B6AD0 Offset: 0x21B6BD1 VA: 0x21B6AD0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x21B6AE0 Offset: 0x21B6BE1 VA: 0x21B6AE0 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x21B2570 Offset: 0x21B2671 VA: 0x21B2570
	public MapEditorCategoryData GetCategory() { }

	// RVA: 0x21B6B60 Offset: 0x21B6C61 VA: 0x21B6B60
	public void .ctor() { }
}

