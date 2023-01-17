// Namespace: App
public class ExpSequence : ProcInst // TypeDefIndex: 12994
{
	// Fields
	private const string resNameC = "UI/Battle/WdwExp/Prefabs/WdwExpRoot";
	private Unit m_Unit; // 0x70
	private int m_Exp; // 0x78
	private int m_SkillPoint; // 0x7C
	private bool m_isExpSe; // 0x80
	private ExpSetter m_Window; // 0x88

	// Methods

	// RVA: 0x27FFE70 Offset: 0x27FFF71 VA: 0x27FFE70
	private void .ctor(Unit unit, int exp, int skillPoint) { }

	// RVA: 0x27FFF70 Offset: 0x2800071 VA: 0x27FFF70
	private void SoundStart() { }

	// RVA: 0x2800000 Offset: 0x2800101 VA: 0x2800000
	private void SoundStop() { }

	// RVA: 0x2800090 Offset: 0x2800191 VA: 0x2800090
	private void Tick() { }

	// RVA: 0x28004E0 Offset: 0x28005E1 VA: 0x28004E0
	private void WaitLoad() { }

	// RVA: 0x2800590 Offset: 0x2800691 VA: 0x2800590
	private void Open() { }

	// RVA: 0x2800750 Offset: 0x2800851 VA: 0x2800750
	private void WaitAnime() { }

	// RVA: 0x2800860 Offset: 0x2800961 VA: 0x2800860
	private void Release() { }

	// RVA: 0x2800440 Offset: 0x2800541 VA: 0x2800440
	private void UpdateAddExp() { }

	// RVA: 0x2800940 Offset: 0x2800A41 VA: 0x2800940
	public static void CreateBind(ProcInst super, Unit unit, int exp, int skillPoint) { }
}

