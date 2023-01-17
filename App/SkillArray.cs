// Namespace: App
[DefaultMemberAttribute] // RVA: 0x278DA0 Offset: 0x278EA1 VA: 0x278DA0
public class SkillArray // TypeDefIndex: 13479
{
	// Fields
	public const int MaxCount = 1280;
	public const int Capacity = 32;
	private const int Version = 1;
	private BitStruct m_Mask; // 0x10
	private List<SkillArray.Entity> m_List; // 0x18
	private SkillData.Flags m_Flags; // 0x20
	private SkillData.CycleMasks m_Cycles; // 0x28
	private SkillData.TimingMasks m_Timings; // 0x2C
	private SkillData.Attrs m_Efficacys; // 0x30
	private SkillData.Attrs m_EfficacyIgnores; // 0x34
	private SkillData.States m_BadStates; // 0x38
	private SkillData.States m_BadIgnore; // 0x3C
	private WeaponLevels m_WeaponLevels; // 0x40
	private bool m_IsEquipSkillFirstNull; // 0x48

	// Properties
	public SkillData.Flags Flags { get; }
	public int Count { get; }
	public SkillData Item { get; }
	public WeaponLevels WeaponLevels { get; }
	public bool IsEquipSkillFirstNull { get; set; }

	// Methods

	// RVA: 0x2343B10 Offset: 0x2343C11 VA: 0x2343B10
	public void .ctor() { }

	// RVA: 0x2343C10 Offset: 0x2343D11 VA: 0x2343C10
	public void .ctor(SkillArray src) { }

	// RVA: 0x2343F50 Offset: 0x2344051 VA: 0x2343F50
	public SkillArray.Enumerator GetEnumerator() { }

	// RVA: 0x2343F70 Offset: 0x2344071 VA: 0x2343F70
	public SkillData.Flags get_Flags() { }

	// RVA: 0x2343F80 Offset: 0x2344081 VA: 0x2343F80
	public bool Test(string sid) { }

	// RVA: 0x2344040 Offset: 0x2344141 VA: 0x2344040
	public bool Test(SkillData skill) { }

	// RVA: 0x2344060 Offset: 0x2344161 VA: 0x2344060
	public bool Test(SkillData.Flags flags) { }

	// RVA: 0x2344070 Offset: 0x2344171 VA: 0x2344070
	public bool Test(SkillData.States states) { }

	// RVA: 0x2344080 Offset: 0x2344181 VA: 0x2344080
	public bool Test(SkillData.Timings timing) { }

	// RVA: 0x2344090 Offset: 0x2344191 VA: 0x2344090
	public bool Test(SkillData.Timings timing1, SkillData.Timings timing2) { }

	// RVA: 0x23440B0 Offset: 0x23441B1 VA: 0x23440B0
	public bool Test(SkillData.TimingMasks mask) { }

	// RVA: 0x23440C0 Offset: 0x23441C1 VA: 0x23440C0
	public bool Test(SkillData.Cycles cycle) { }

	// RVA: 0x23440D0 Offset: 0x23441D1 VA: 0x23440D0
	public bool Test(SkillData.Cycles cycle1, SkillData.Cycles cycle2) { }

	// RVA: 0x23440F0 Offset: 0x23441F1 VA: 0x23440F0
	public bool Test(SkillData.CycleMasks mask) { }

	// RVA: 0x2344100 Offset: 0x2344201 VA: 0x2344100
	public bool Test(SkillData.Targets target) { }

	// RVA: 0x2344250 Offset: 0x2344351 VA: 0x2344250
	public SkillData.States GetBadStates() { }

	// RVA: 0x2344260 Offset: 0x2344361 VA: 0x2344260
	public bool Set(string sid, SkillData.Categorys category) { }

	// RVA: 0x2344950 Offset: 0x2344A51 VA: 0x2344950
	public bool Set(SkillData skill, SkillData.Categorys category) { }

	// RVA: 0x2344FA0 Offset: 0x23450A1 VA: 0x2344FA0
	public void Set(string[] sids, SkillData.Categorys category) { }

	// RVA: 0x2345740 Offset: 0x2345841 VA: 0x2345740
	public void Set(SkillArray src) { }

	// RVA: 0x2345F70 Offset: 0x2346071 VA: 0x2345F70
	public bool Add(string sid, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x23465C0 Offset: 0x23466C1 VA: 0x23465C0
	public bool Add(SkillData skill, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x2346B80 Offset: 0x2346C81 VA: 0x2346B80
	public bool AddWithoutUpdate(SkillData skill, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x2346FA0 Offset: 0x23470A1 VA: 0x2346FA0
	public void Update() { }

	// RVA: 0x2347180 Offset: 0x2347281 VA: 0x2347180
	public bool Add(string[] sids, SkillData.Categorys category) { }

	// RVA: 0x2347870 Offset: 0x2347971 VA: 0x2347870
	public bool Add(List<SkillData> skills, SkillData.Categorys category) { }

	// RVA: 0x2347F30 Offset: 0x2348031 VA: 0x2347F30
	public bool Add(SkillArray src) { }

	// RVA: 0x23486C0 Offset: 0x23487C1 VA: 0x23486C0
	public bool Remove(string sid) { }

	// RVA: 0x2348A60 Offset: 0x2348B61 VA: 0x2348A60
	public bool Remove(SkillArray src) { }

	// RVA: 0x2348EF0 Offset: 0x2348FF1 VA: 0x2348EF0
	public bool Remove(SkillData skill) { }

	// RVA: 0x2349210 Offset: 0x2349311 VA: 0x2349210
	public bool Remove(SkillData.Flags flags) { }

	// RVA: 0x23495D0 Offset: 0x23496D1 VA: 0x23495D0
	public bool Replace(int index, SkillData skill, SkillData.Categorys category) { }

	// RVA: 0x2349910 Offset: 0x2349A11 VA: 0x2349910
	public bool Replace(SkillData skill) { }

	// RVA: 0x2349CF0 Offset: 0x2349DF1 VA: 0x2349CF0
	public bool Move(int oldIndex, int newIndex) { }

	// RVA: 0x2349FA0 Offset: 0x234A0A1 VA: 0x2349FA0
	public void Sort() { }

	// RVA: 0x234A0D0 Offset: 0x234A1D1 VA: 0x234A0D0
	public SkillData GetGiveSkill(SkillData give) { }

	// RVA: 0x234A150 Offset: 0x234A251 VA: 0x234A150
	private bool AddImpl(string sid, SkillData.Categorys category, int age) { }

	// RVA: 0x234A5F0 Offset: 0x234A6F1 VA: 0x234A5F0
	private bool AddImpl(SkillData skill, SkillData.Categorys category, int age) { }

	// RVA: 0x234AA00 Offset: 0x234AB01 VA: 0x234AA00
	private bool RemoveImpl(SkillData skill) { }

	// RVA: 0x234AB80 Offset: 0x234AC81 VA: 0x234AB80
	private bool RemoveImpl(int index) { }

	// RVA: 0x234AC60 Offset: 0x234AD61 VA: 0x234AC60
	private bool ReplaceImpl(int index, SkillData skill, SkillData.Categorys category, int age) { }

	// RVA: 0x234AE00 Offset: 0x234AF01 VA: 0x234AE00
	private bool MoveImpl(int oldIndex, int newIndex) { }

	// RVA: 0x234AEF0 Offset: 0x234AFF1 VA: 0x234AEF0
	private bool AddSyncImpl(Unit unit, SkillData skill, SkillData.Categorys category) { }

	// RVA: 0x234B560 Offset: 0x234B661 VA: 0x234B560
	public bool CanGive(SkillData give) { }

	// RVA: 0x234B880 Offset: 0x234B981 VA: 0x234B880
	public void Commit(Unit unit) { }

	// RVA: 0x234BBF0 Offset: 0x234BCF1 VA: 0x234BBF0
	public int GetItemRangeI(Unit unit, ItemData item) { }

	// RVA: 0x234BE60 Offset: 0x234BF61 VA: 0x234BE60
	public int GetItemRangeO(Unit unit, ItemData item) { }

	// RVA: 0x234C090 Offset: 0x234C191 VA: 0x234C090
	public int GetItemDistance(Unit unit, ItemData item) { }

	// RVA: 0x234C260 Offset: 0x234C361 VA: 0x234C260
	public int GetRodRangeExtend(ItemData item) { }

	// RVA: 0x234C430 Offset: 0x234C531 VA: 0x234C430
	private void UpdateImpl() { }

	// RVA: 0x234C600 Offset: 0x234C701 VA: 0x234C600
	public void Clear() { }

	// RVA: 0x234C6D0 Offset: 0x234C7D1 VA: 0x234C6D0
	public void Copy(SkillArray src) { }

	// RVA: 0x234C930 Offset: 0x234CA31 VA: 0x234C930
	public void Change(int index) { }

	// RVA: 0x234CE30 Offset: 0x234CF31 VA: 0x234CE30
	public bool IsExist() { }

	// RVA: 0x234CE80 Offset: 0x234CF81 VA: 0x234CE80
	public bool IsIgnore(SkillData.States state) { }

	// RVA: 0x234CE90 Offset: 0x234CF91 VA: 0x234CE90
	public int IndexOf(string sid) { }

	// RVA: 0x234CFE0 Offset: 0x234D0E1 VA: 0x234CFE0
	public int IndexOf(SkillData skill) { }

	// RVA: 0x234D0C0 Offset: 0x234D1C1 VA: 0x234D0C0
	public int get_Count() { }

	// RVA: 0x234D110 Offset: 0x234D211 VA: 0x234D110
	public SkillData get_Item(int index) { }

	// RVA: 0x234D1E0 Offset: 0x234D2E1 VA: 0x234D1E0
	public SkillData GetSkill(int index) { }

	// RVA: 0x234D2B0 Offset: 0x234D3B1 VA: 0x234D2B0
	public SkillData TryGetSkill(int index) { }

	// RVA: 0x234D3B0 Offset: 0x234D4B1 VA: 0x234D3B0
	public SkillArray.Entity GetEntity(int index) { }

	// RVA: 0x234D420 Offset: 0x234D521 VA: 0x234D420
	public int GetAge(int index) { }

	// RVA: 0x234D490 Offset: 0x234D591 VA: 0x234D490
	public int GetAge(SkillData skill) { }

	// RVA: 0x234D5D0 Offset: 0x234D6D1 VA: 0x234D5D0
	public int GetDecay(int index) { }

	// RVA: 0x234D650 Offset: 0x234D751 VA: 0x234D650
	public SkillData.Categorys GetCategory(int index) { }

	// RVA: 0x234D6C0 Offset: 0x234D7C1 VA: 0x234D6C0
	public SkillData.Categorys GetCategory(SkillData skill) { }

	// RVA: 0x234D800 Offset: 0x234D901 VA: 0x234D800
	public SkillData Find(string sid) { }

	// RVA: 0x234DA00 Offset: 0x234DB01 VA: 0x234DA00
	public SkillData Find(SkillData.Flags flags) { }

	// RVA: 0x234DB40 Offset: 0x234DC41 VA: 0x234DB40
	public SkillData Find(SkillData.States states) { }

	// RVA: 0x234DC80 Offset: 0x234DD81 VA: 0x234DC80
	public SkillData Find(SkillData.Works work) { }

	// RVA: 0x234DDC0 Offset: 0x234DEC1 VA: 0x234DDC0
	public bool UpdateAging(SkillData.Cycles cycle, Func<SkillData, bool> ignore) { }

	// RVA: 0x234E400 Offset: 0x234E501 VA: 0x234E400
	public bool UpdateAging(SkillData.Cycles cycle1, SkillData.Cycles cycle2, Func<SkillData, bool> ignore) { }

	// RVA: 0x234DDD0 Offset: 0x234DED1 VA: 0x234DDD0
	private bool UpdateAgingImpl(SkillData.CycleMasks mask, Func<SkillData, bool> ignore) { }

	// RVA: 0x234E420 Offset: 0x234E521 VA: 0x234E420
	public void ClearCycles() { }

	// RVA: 0x234E7C0 Offset: 0x234E8C1 VA: 0x234E7C0
	public void Serialize(Stream stream) { }

	// RVA: 0x234E970 Offset: 0x234EA71 VA: 0x234E970
	public void Deserialize(Stream stream) { }

	// RVA: 0x234EEE0 Offset: 0x234EFE1 VA: 0x234EEE0
	public int CalcWork(int value, SkillData.Works work) { }

	// RVA: 0x234F060 Offset: 0x234F161 VA: 0x234F060
	public int GetPower() { }

	// RVA: 0x234F1B0 Offset: 0x234F2B1 VA: 0x234F1B0
	public int GetEfficacyValue(Unit target) { }

	// RVA: 0x234F360 Offset: 0x234F461 VA: 0x234F360
	public SkillData.Attrs GetEfficacyMask(Unit target) { }

	// RVA: 0x234F3A0 Offset: 0x234F4A1 VA: 0x234F3A0
	public bool IsEfficacy(Unit target) { }

	// RVA: 0x234F3E0 Offset: 0x234F4E1 VA: 0x234F3E0
	public WeaponLevels get_WeaponLevels() { }

	// RVA: 0x234F3F0 Offset: 0x234F4F1 VA: 0x234F3F0
	public bool get_IsEquipSkillFirstNull() { }

	// RVA: 0x234F400 Offset: 0x234F501 VA: 0x234F400
	public void set_IsEquipSkillFirstNull(bool value) { }
}

