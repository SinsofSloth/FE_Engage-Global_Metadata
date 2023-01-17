// Namespace: 
private enum UnitModel.LoadMode // TypeDefIndex: 8981
{
	// Fields
	public int value__; // 0x0
	public const UnitModel.LoadMode None = 0;
	public const UnitModel.LoadMode Loading = 1;
	public const UnitModel.LoadMode Done = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x274DC0 Offset: 0x274EC1 VA: 0x274DC0
public enum UnitModel.ColorFlags // TypeDefIndex: 8982
{
	// Fields
	public int value__; // 0x0
	public const UnitModel.ColorFlags Fixed = 1;
	public const UnitModel.ColorFlags Danager = 2;
	public const UnitModel.ColorFlags Enemy = 4;
	public const UnitModel.ColorFlags Ally = 8;
	public const UnitModel.ColorFlags Dirty = 16;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x274DD0 Offset: 0x274ED1 VA: 0x274DD0
public enum UnitModel.DirtyFlags // TypeDefIndex: 8983
{
	// Fields
	public int value__; // 0x0
	public const UnitModel.DirtyFlags Speed = 1;
	public const UnitModel.DirtyFlags Animation = 2;
	public const UnitModel.DirtyFlags Renderer = 4;
	public const UnitModel.DirtyFlags Shine = 8;
	public const UnitModel.DirtyFlags Alpha = 16;
	public const UnitModel.DirtyFlags Bright = 32;
}

// Namespace: 
public class UnitModel.ResourceHandle : IDisposable // TypeDefIndex: 8984
{
	// Fields
	public ResourceGameObject BodyPrefab; // 0x10
	public ResourceGameObject HeadPrefab; // 0x18
	public ResourceGameObject RidePrefab; // 0x20
	public ResourceGameObject LeftHandPrefab; // 0x28
	public ResourceGameObject RightHandPrefab; // 0x30
	public ResourceAnimatorController BodyAnim; // 0x38
	public ResourceAnimatorController RideAnim; // 0x40
	public List<ResourceGameObject> AccPrefabs; // 0x48
	public List<string> AccLocators; // 0x50

	// Methods

	// RVA: 0x1ED4540 Offset: 0x1ED4641 VA: 0x1ED4540 Slot: 4
	public void Dispose() { }

	// RVA: 0x1ED4690 Offset: 0x1ED4791 VA: 0x1ED4690
	public void LoadAsync(AssetTable.Result result) { }

	// RVA: 0x1ED4F20 Offset: 0x1ED5021 VA: 0x1ED4F20
	public bool IsLoading() { }

	// RVA: 0x1ED4550 Offset: 0x1ED4651 VA: 0x1ED4550
	public void Release() { }

	// RVA: 0x1ED5090 Offset: 0x1ED5191 VA: 0x1ED5090
	public void .ctor() { }
}

