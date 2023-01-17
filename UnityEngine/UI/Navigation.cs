// Namespace: UnityEngine.UI
[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4329
{
	// Fields
	[SerializeField] // RVA: 0x44FF0 Offset: 0x450F1 VA: 0x44FF0
	private Navigation.Mode m_Mode; // 0x0
	[TooltipAttribute] // RVA: 0x45000 Offset: 0x45101 VA: 0x45000
	[SerializeField] // RVA: 0x45000 Offset: 0x45101 VA: 0x45000
	private bool m_WrapAround; // 0x4
	[SerializeField] // RVA: 0x45050 Offset: 0x45151 VA: 0x45050
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x45060 Offset: 0x45161 VA: 0x45060
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x45070 Offset: 0x45171 VA: 0x45070
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x45080 Offset: 0x45181 VA: 0x45080
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x1B6DF10 Offset: 0x1B6E011 VA: 0x1B6DF10
	public Navigation.Mode get_mode() { }

	// RVA: 0x1B6DF20 Offset: 0x1B6E021 VA: 0x1B6DF20
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x1B6DF30 Offset: 0x1B6E031 VA: 0x1B6DF30
	public bool get_wrapAround() { }

	// RVA: 0x1B6DF40 Offset: 0x1B6E041 VA: 0x1B6DF40
	public void set_wrapAround(bool value) { }

	// RVA: 0x1B6DF50 Offset: 0x1B6E051 VA: 0x1B6DF50
	public Selectable get_selectOnUp() { }

	// RVA: 0x1B6DF60 Offset: 0x1B6E061 VA: 0x1B6DF60
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x1B6DF70 Offset: 0x1B6E071 VA: 0x1B6DF70
	public Selectable get_selectOnDown() { }

	// RVA: 0x1B6DF80 Offset: 0x1B6E081 VA: 0x1B6DF80
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x1B6DF90 Offset: 0x1B6E091 VA: 0x1B6DF90
	public Selectable get_selectOnLeft() { }

	// RVA: 0x1B6DFA0 Offset: 0x1B6E0A1 VA: 0x1B6DFA0
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x1B6DFB0 Offset: 0x1B6E0B1 VA: 0x1B6DFB0
	public Selectable get_selectOnRight() { }

	// RVA: 0x1B6DFC0 Offset: 0x1B6E0C1 VA: 0x1B6DFC0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x1B6DFD0 Offset: 0x1B6E0D1 VA: 0x1B6DFD0
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x1B6E000 Offset: 0x1B6E101 VA: 0x1B6E000 Slot: 4
	public bool Equals(Navigation other) { }
}

