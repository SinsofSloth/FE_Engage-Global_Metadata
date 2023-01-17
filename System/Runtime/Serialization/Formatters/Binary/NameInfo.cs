// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameInfo // TypeDefIndex: 1086
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x34FD9D0 Offset: 0x34FDAD1 VA: 0x34FD9D0
	internal void .ctor() { }

	// RVA: 0x34FD9E0 Offset: 0x34FDAE1 VA: 0x34FD9E0
	internal void Init() { }

	// RVA: 0x34FDA30 Offset: 0x34FDB31 VA: 0x34FDA30
	public bool get_IsSealed() { }

	// RVA: 0x34FDA80 Offset: 0x34FDB81 VA: 0x34FDA80
	public string get_NIname() { }

	// RVA: 0x34FDAE0 Offset: 0x34FDBE1 VA: 0x34FDAE0
	public void set_NIname(string value) { }
}

