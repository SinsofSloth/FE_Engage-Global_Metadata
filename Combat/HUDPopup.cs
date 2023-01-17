// Namespace: Combat
[RequireComponent] // RVA: 0x2745A0 Offset: 0x2746A1 VA: 0x2745A0
public class HUDPopup : MonoBehaviour // TypeDefIndex: 8744
{
	// Fields
	private RectTransform m_RectTransform; // 0x18
	private Vector3 m_WorldPos; // 0x20
	private Vector2 m_Offset2D; // 0x2C

	// Methods

	// RVA: 0x2DB7E20 Offset: 0x2DB7F21 VA: 0x2DB7E20
	private void Update() { }

	// RVA: 0x2DB8010 Offset: 0x2DB8111 VA: 0x2DB8010
	public HUDPopup SetWorldPosition(in Vector3 worldPos) { }

	// RVA: 0x2DB80A0 Offset: 0x2DB81A1 VA: 0x2DB80A0
	public HUDPopup SetWorldPositionAndDisplayNumber(in Vector3 worldPos, int value) { }

	// RVA: 0x2DB8210 Offset: 0x2DB8311 VA: 0x2DB8210
	public HUDPopup Set2DOffset(float offsetX, float offsetY) { }

	// RVA: 0x2DB8220 Offset: 0x2DB8321 VA: 0x2DB8220
	public HUDPopup SetText(string text) { }

	// RVA: 0x2DB8140 Offset: 0x2DB8241 VA: 0x2DB8140
	public HUDPopup SetText(int value) { }

	// RVA: 0x2DB82E0 Offset: 0x2DB83E1 VA: 0x2DB82E0
	public string GetText() { }

	// RVA: 0x2DB83C0 Offset: 0x2DB84C1 VA: 0x2DB83C0
	public HUDPopup SetTextColor(Color color) { }

	// RVA: 0x2DB84A0 Offset: 0x2DB85A1 VA: 0x2DB84A0
	public HUDPopup SetImage(string name, Sprite sprite) { }

	// RVA: 0x2DB85E0 Offset: 0x2DB86E1 VA: 0x2DB85E0
	public void .ctor() { }
}

