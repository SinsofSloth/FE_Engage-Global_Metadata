// Namespace: App
public class JobIntroInfoSetter : MonoBehaviour // TypeDefIndex: 12570
{
	// Fields
	public UnitIcon Icon; // 0x18
	public TextMeshProUGUI JobName; // 0x20
	public TextMeshProUGUI Style; // 0x28
	public TextMeshProUGUI Category; // 0x30
	public JobIntroInfoSetter.WeaponSetter[] Weapons; // 0x38
	public TextMeshProUGUI Message; // 0x40
	public TextMeshProUGUI StyleInfo; // 0x48
	public TextMeshProUGUI CategoryInfo; // 0x50
	public TextMeshProUGUI WeaponInfo; // 0x58

	// Methods

	// RVA: 0x24631B0 Offset: 0x24632B1 VA: 0x24631B0
	public void SetData(Unit unit) { }

	// RVA: 0x24636A0 Offset: 0x24637A1 VA: 0x24636A0
	private ValueTuple<ItemData.Kinds[], WeaponLevel.Kind, int>[] GetWeaponKindsList(JobData job) { }

	// RVA: 0x2463AC0 Offset: 0x2463BC1 VA: 0x2463AC0
	public void .ctor() { }
}

