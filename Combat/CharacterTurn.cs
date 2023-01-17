// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274080 Offset: 0x274181 VA: 0x274080
public sealed class CharacterTurn : MonoBehaviour // TypeDefIndex: 8651
{
	// Fields
	private Character _cp; // 0x18
	private FXZ m_StartDir; // 0x20
	private FXZ m_TargetDir; // 0x28
	private float m_Ratio; // 0x30

	// Properties
	private Character CP { get; }
	private bool IsActive { get; }

	// Methods

	// RVA: 0x29BF980 Offset: 0x29BFA81 VA: 0x29BF980
	private Character get_CP() { }

	// RVA: 0x29BFA40 Offset: 0x29BFB41 VA: 0x29BFA40
	private bool get_IsActive() { }

	// RVA: 0x29BFA60 Offset: 0x29BFB61 VA: 0x29BFA60
	public void Stop() { }

	// RVA: 0x29BFA70 Offset: 0x29BFB71 VA: 0x29BFA70
	public void SetToEnemy() { }

	// RVA: 0x29BFBB0 Offset: 0x29BFCB1 VA: 0x29BFBB0
	public void SetDir(FXZ targetDir) { }

	// RVA: 0x29BFC60 Offset: 0x29BFD61 VA: 0x29BFC60
	public void TurnToEnemy() { }

	// RVA: 0x29BFDA0 Offset: 0x29BFEA1 VA: 0x29BFDA0
	public void TurnToDir(FXZ targetDir) { }

	// RVA: 0x29BFE70 Offset: 0x29BFF71 VA: 0x29BFE70
	private void Update() { }

	// RVA: 0x29BFFD0 Offset: 0x29C00D1 VA: 0x29BFFD0
	public void .ctor() { }
}

