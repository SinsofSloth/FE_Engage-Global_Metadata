// Namespace: Combat
public class HUDPopupGroup : MonoBehaviour // TypeDefIndex: 8745
{
	// Fields
	private RectTransform m_RectTransform; // 0x18
	private Vector3 m_WorldPos; // 0x20
	private Vector3 spos; // 0x2C

	// Properties
	private bool IsAlive { get; }

	// Methods

	// RVA: 0x2DB85F0 Offset: 0x2DB86F1 VA: 0x2DB85F0
	private bool get_IsAlive() { }

	// RVA: 0x2DB8660 Offset: 0x2DB8761 VA: 0x2DB8660
	public static void DamagePopup(Phase phase) { }

	// RVA: 0x2DB8D90 Offset: 0x2DB8E91 VA: 0x2DB8D90
	private static void SetAsUnscaled(Transform root) { }

	// RVA: 0x2DB8E50 Offset: 0x2DB8F51 VA: 0x2DB8E50
	private void InitialUpdate() { }

	// RVA: 0x2DB9090 Offset: 0x2DB9191 VA: 0x2DB9090
	private void Update() { }

	// RVA: 0x2DB8E70 Offset: 0x2DB8F71 VA: 0x2DB8E70
	public static bool DoesNeedForAttacker(Phase phase) { }

	// RVA: 0x2DB8EB0 Offset: 0x2DB8FB1 VA: 0x2DB8EB0
	public void SetupAsAttacker(Phase phase, Vector3 worldPos) { }

	// RVA: 0x2DB88B0 Offset: 0x2DB89B1 VA: 0x2DB88B0
	public void SetupAsDamager(Phase phase, Vector3 worldPos) { }

	// RVA: 0x2DB97E0 Offset: 0x2DB98E1 VA: 0x2DB97E0
	private static int GetDamage(Phase phase) { }

	// RVA: 0x2DB93F0 Offset: 0x2DB94F1 VA: 0x2DB93F0
	private void init(Vector3 worldPos) { }

	// RVA: 0x2DB95A0 Offset: 0x2DB96A1 VA: 0x2DB95A0
	private static string GetNumberPrefabName(Phase phase, ref int value) { }

	// RVA: 0x2DB9920 Offset: 0x2DB9A21 VA: 0x2DB9920
	private static string GetPopupPrefabName(Phase phase, CombatStyle style) { }

	// RVA: 0x2DB9660 Offset: 0x2DB9761 VA: 0x2DB9660
	private HUDPopup CreateHUD(string name, float y) { }

	// RVA: 0x2DB9A70 Offset: 0x2DB9B71 VA: 0x2DB9A70
	public void .ctor() { }
}

