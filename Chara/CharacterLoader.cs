// Namespace: Chara
public class CharacterLoader // TypeDefIndex: 8375
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FAD0 Offset: 0x27FBD1 VA: 0x27FAD0
	private bool <IsLoaded>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x27FAE0 Offset: 0x27FBE1 VA: 0x27FAE0
	private Character <Chara>k__BackingField; // 0x18
	private readonly Unit m_Unit; // 0x20
	private readonly int m_Side; // 0x28
	private readonly PreloadAnims m_Anim; // 0x30
	private string[] m_Condition; // 0x38
	private readonly bool m_Collision; // 0x40
	private readonly bool m_IsMute; // 0x41

	// Properties
	public bool IsLoaded { get; set; }
	public Character Chara { get; set; }

	// Methods

	// RVA: 0x2B80F30 Offset: 0x2B81031 VA: 0x2B80F30
	public void .ctor(Unit unit, int side, PreloadAnims anim, string[] condition, bool collision = True, bool isMute = False) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B30 Offset: 0x2A7C31 VA: 0x2A7B30
	// RVA: 0x2B81070 Offset: 0x2B81171 VA: 0x2B81070
	public bool get_IsLoaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B40 Offset: 0x2A7C41 VA: 0x2A7B40
	// RVA: 0x2B81080 Offset: 0x2B81181 VA: 0x2B81080
	private void set_IsLoaded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B50 Offset: 0x2A7C51 VA: 0x2A7B50
	// RVA: 0x2B81090 Offset: 0x2B81191 VA: 0x2B81090
	public Character get_Chara() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B60 Offset: 0x2A7C61 VA: 0x2A7B60
	// RVA: 0x2B810A0 Offset: 0x2B811A1 VA: 0x2B810A0
	private void set_Chara(Character value) { }

	[IteratorStateMachineAttribute] // RVA: 0x2A7B70 Offset: 0x2A7C71 VA: 0x2A7B70
	// RVA: 0x2B810B0 Offset: 0x2B811B1 VA: 0x2B810B0
	private IEnumerator Load() { }

	// RVA: 0x2B81130 Offset: 0x2B81231 VA: 0x2B81130
	public void Destroy() { }

	// RVA: 0x2B811B0 Offset: 0x2B812B1 VA: 0x2B811B0
	public void SetActive(int animHash, float startTime = -1) { }
}

