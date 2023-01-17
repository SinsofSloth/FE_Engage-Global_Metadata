// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 4349
{
	// Fields
	[SerializeField] // RVA: 0x45690 Offset: 0x45791 VA: 0x45690
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x456A0 Offset: 0x457A1 VA: 0x456A0
	private Sprite m_PressedSprite; // 0x8
	[SerializeField] // RVA: 0x456B0 Offset: 0x457B1 VA: 0x456B0
	[FormerlySerializedAsAttribute] // RVA: 0x456B0 Offset: 0x457B1 VA: 0x456B0
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x45700 Offset: 0x45801 VA: 0x45700
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x1BF3190 Offset: 0x1BF3291 VA: 0x1BF3190
	public Sprite get_highlightedSprite() { }

	// RVA: 0x1BF31A0 Offset: 0x1BF32A1 VA: 0x1BF31A0
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x1BF31B0 Offset: 0x1BF32B1 VA: 0x1BF31B0
	public Sprite get_pressedSprite() { }

	// RVA: 0x1BF31C0 Offset: 0x1BF32C1 VA: 0x1BF31C0
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x1BF31D0 Offset: 0x1BF32D1 VA: 0x1BF31D0
	public Sprite get_selectedSprite() { }

	// RVA: 0x1BF31E0 Offset: 0x1BF32E1 VA: 0x1BF31E0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x1BF31F0 Offset: 0x1BF32F1 VA: 0x1BF31F0
	public Sprite get_disabledSprite() { }

	// RVA: 0x1BF3200 Offset: 0x1BF3301 VA: 0x1BF3200
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x1BF3210 Offset: 0x1BF3311 VA: 0x1BF3210 Slot: 4
	public bool Equals(SpriteState other) { }
}

