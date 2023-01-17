// Namespace: App
public class BasicMenuItemContent : MonoBehaviour // TypeDefIndex: 12522
{
	// Fields
	protected BasicMenuItem m_menuItem; // 0x18
	protected Color m_textBaseColor; // 0x20
	protected Color m_textBlendColor; // 0x30
	private GameObject m_frmContent; // 0x40

	// Properties
	private GameObject childObject { get; }

	// Methods

	// RVA: 0x2903AC0 Offset: 0x2903BC1 VA: 0x2903AC0
	public BasicMenuItem GetMenuItem() { }

	// RVA: 0x2903AD0 Offset: 0x2903BD1 VA: 0x2903AD0
	public string GetName() { }

	// RVA: 0x2903AE0 Offset: 0x2903BE1 VA: 0x2903AE0
	public string GetText() { }

	// RVA: 0x2903C10 Offset: 0x2903D11 VA: 0x2903C10
	public void SetText(string name) { }

	// RVA: 0x2903E80 Offset: 0x2903F81 VA: 0x2903E80
	public void SetTextSize(int fontSize) { }

	// RVA: 0x28F46C0 Offset: 0x28F47C1 VA: 0x28F46C0
	public void SetTextBaseColor(Color color) { }

	// RVA: 0x28F3BA0 Offset: 0x28F3CA1 VA: 0x28F3BA0
	public void SetTextBlendColor(Color color) { }

	// RVA: 0x2904050 Offset: 0x2904151 VA: 0x2904050
	public void SetFrmContent(GameObject frmContent) { }

	// RVA: 0x2903E10 Offset: 0x2903F11 VA: 0x2903E10
	private GameObject get_childObject() { }

	// RVA: 0x2904060 Offset: 0x2904161 VA: 0x2904060 Slot: 4
	public virtual Text GetTextComponent() { }

	// RVA: 0x2904170 Offset: 0x2904271 VA: 0x2904170 Slot: 5
	public virtual TextMeshProUGUI GetTextMeshProComponent() { }

	// RVA: 0x2904280 Offset: 0x2904381 VA: 0x2904280 Slot: 6
	public virtual RectTransform GetRectTransform() { }

	// RVA: 0x2904390 Offset: 0x2904491 VA: 0x2904390 Slot: 7
	protected virtual void UpdateTextColor() { }

	// RVA: 0x2902170 Offset: 0x2902271 VA: 0x2902170
	public void SetMenuItem(BasicMenuItem menuItem) { }

	// RVA: 0x28F60D0 Offset: 0x28F61D1 VA: 0x28F60D0 Slot: 8
	public virtual void Build(BasicMenuItem menuItem) { }

	// RVA: 0x29045F0 Offset: 0x29046F1 VA: 0x29045F0 Slot: 9
	public virtual void BuildFont() { }

	// RVA: 0x2904600 Offset: 0x2904701 VA: 0x2904600 Slot: 10
	public virtual void BuildText() { }

	// RVA: 0x2904680 Offset: 0x2904781 VA: 0x2904680 Slot: 11
	public virtual void BuildTextColor() { }

	// RVA: 0x2904860 Offset: 0x2904961 VA: 0x2904860 Slot: 12
	public virtual void Unbind() { }

	// RVA: 0x29048B0 Offset: 0x29049B1 VA: 0x29048B0 Slot: 13
	public virtual void Disable() { }

	// RVA: 0x2904910 Offset: 0x2904A11 VA: 0x2904910 Slot: 14
	protected virtual void Start() { }

	// RVA: 0x2904920 Offset: 0x2904A21 VA: 0x2904920 Slot: 15
	protected virtual void Update() { }

	// RVA: 0x2904930 Offset: 0x2904A31 VA: 0x2904930
	public void ForceRebuildLayout() { }

	// RVA: 0x28F8070 Offset: 0x28F8171 VA: 0x28F8070
	public void .ctor() { }
}

