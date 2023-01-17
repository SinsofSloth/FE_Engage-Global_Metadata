// Namespace: UnityEngine.UI
[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4248
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x43CA0 Offset: 0x43DA1 VA: 0x43CA0
	[SerializeField] // RVA: 0x43CA0 Offset: 0x43DA1 VA: 0x43CA0
	private Color m_NormalColor; // 0x0
	[SerializeField] // RVA: 0x43CF0 Offset: 0x43DF1 VA: 0x43CF0
	[FormerlySerializedAsAttribute] // RVA: 0x43CF0 Offset: 0x43DF1 VA: 0x43CF0
	private Color m_HighlightedColor; // 0x10
	[SerializeField] // RVA: 0x43D40 Offset: 0x43E41 VA: 0x43D40
	[FormerlySerializedAsAttribute] // RVA: 0x43D40 Offset: 0x43E41 VA: 0x43D40
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x43D90 Offset: 0x43E91 VA: 0x43D90
	[SerializeField] // RVA: 0x43D90 Offset: 0x43E91 VA: 0x43D90
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x43DE0 Offset: 0x43EE1 VA: 0x43DE0
	[SerializeField] // RVA: 0x43DE0 Offset: 0x43EE1 VA: 0x43DE0
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0x43E30 Offset: 0x43F31 VA: 0x43E30
	[SerializeField] // RVA: 0x43E30 Offset: 0x43F31 VA: 0x43E30
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0x43E70 Offset: 0x43F71 VA: 0x43E70
	[SerializeField] // RVA: 0x43E70 Offset: 0x43F71 VA: 0x43E70
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x1A42EA0 Offset: 0x1A42FA1 VA: 0x1A42EA0
	public Color get_normalColor() { }

	// RVA: 0x1A42EB0 Offset: 0x1A42FB1 VA: 0x1A42EB0
	public void set_normalColor(Color value) { }

	// RVA: 0x1A42ED0 Offset: 0x1A42FD1 VA: 0x1A42ED0
	public Color get_highlightedColor() { }

	// RVA: 0x1A42EE0 Offset: 0x1A42FE1 VA: 0x1A42EE0
	public void set_highlightedColor(Color value) { }

	// RVA: 0x1A42F00 Offset: 0x1A43001 VA: 0x1A42F00
	public Color get_pressedColor() { }

	// RVA: 0x1A42F10 Offset: 0x1A43011 VA: 0x1A42F10
	public void set_pressedColor(Color value) { }

	// RVA: 0x1A42F30 Offset: 0x1A43031 VA: 0x1A42F30
	public Color get_selectedColor() { }

	// RVA: 0x1A42F40 Offset: 0x1A43041 VA: 0x1A42F40
	public void set_selectedColor(Color value) { }

	// RVA: 0x1A42F60 Offset: 0x1A43061 VA: 0x1A42F60
	public Color get_disabledColor() { }

	// RVA: 0x1A42F70 Offset: 0x1A43071 VA: 0x1A42F70
	public void set_disabledColor(Color value) { }

	// RVA: 0x1A42F90 Offset: 0x1A43091 VA: 0x1A42F90
	public float get_colorMultiplier() { }

	// RVA: 0x1A42FA0 Offset: 0x1A430A1 VA: 0x1A42FA0
	public void set_colorMultiplier(float value) { }

	// RVA: 0x1A42FB0 Offset: 0x1A430B1 VA: 0x1A42FB0
	public float get_fadeDuration() { }

	// RVA: 0x1A42FC0 Offset: 0x1A430C1 VA: 0x1A42FC0
	public void set_fadeDuration(float value) { }

	// RVA: 0x1A42FD0 Offset: 0x1A430D1 VA: 0x1A42FD0
	private static void .cctor() { }

	// RVA: 0x1A431E0 Offset: 0x1A432E1 VA: 0x1A431E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A432A0 Offset: 0x1A433A1 VA: 0x1A432A0 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x1A43380 Offset: 0x1A43481 VA: 0x1A43380
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x1A433E0 Offset: 0x1A434E1 VA: 0x1A433E0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x1A43440 Offset: 0x1A43541 VA: 0x1A43440 Slot: 2
	public override int GetHashCode() { }
}

