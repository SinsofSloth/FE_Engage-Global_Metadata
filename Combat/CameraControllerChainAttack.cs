// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738C0 Offset: 0x2739C1 VA: 0x2738C0
[Serializable]
public class CameraControllerChainAttack : BaseCameraController // TypeDefIndex: 8534
{
	// Fields
	[HeaderAttribute] // RVA: 0x280BA0 Offset: 0x280CA1 VA: 0x280BA0
	public float Distance; // 0xA8
	[HeaderAttribute] // RVA: 0x280BE0 Offset: 0x280CE1 VA: 0x280BE0
	public float EnemyDistance; // 0xAC
	[HeaderAttribute] // RVA: 0x280C20 Offset: 0x280D21 VA: 0x280C20
	public float Height; // 0xB0
	[HeaderAttribute] // RVA: 0x280C60 Offset: 0x280D61 VA: 0x280C60
	public float Back; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x280CA0 Offset: 0x280DA1 VA: 0x280CA0
	private bool <IsEnemyAtk>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x280CB0 Offset: 0x280DB1 VA: 0x280CB0
	private bool <IsInverse>k__BackingField; // 0xB9

	// Properties
	private bool IsEnemyAtk { get; set; }
	private bool IsInverse { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A96E0 Offset: 0x2A97E1 VA: 0x2A96E0
	// RVA: 0x299B680 Offset: 0x299B781 VA: 0x299B680
	private bool get_IsEnemyAtk() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A96F0 Offset: 0x2A97F1 VA: 0x2A96F0
	// RVA: 0x299B690 Offset: 0x299B791 VA: 0x299B690
	private void set_IsEnemyAtk(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9700 Offset: 0x2A9801 VA: 0x2A9700
	// RVA: 0x299B6A0 Offset: 0x299B7A1 VA: 0x299B6A0
	private bool get_IsInverse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9710 Offset: 0x2A9811 VA: 0x2A9710
	// RVA: 0x299B6B0 Offset: 0x299B7B1 VA: 0x299B6B0
	private void set_IsInverse(bool value) { }

	// RVA: 0x299B6C0 Offset: 0x299B7C1 VA: 0x299B6C0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299B9C0 Offset: 0x299BAC1 VA: 0x299B9C0 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x299BA30 Offset: 0x299BB31 VA: 0x299BA30 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x299BA50 Offset: 0x299BB51 VA: 0x299BA50 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299BAF0 Offset: 0x299BBF1 VA: 0x299BAF0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299BB60 Offset: 0x299BC61 VA: 0x299BB60
	public void .ctor() { }
}

