// Namespace: App
public class SaveDataMenuSequence : SingletonProcInst<SaveDataMenuSequence> // TypeDefIndex: 13136
{
	// Fields
	private SaveDataMenuSequence.Mode m_Mode; // 0x74
	private GameSaveDataHeaderReader m_saveDataHeaderReader; // 0x78

	// Methods

	// RVA: 0x20620B0 Offset: 0x20621B1 VA: 0x20620B0
	private void .ctor(SaveDataMenuSequence.Mode mode) { }

	// RVA: 0x2062140 Offset: 0x2062241 VA: 0x2062140
	public SaveDataMenuSequence.Mode GetMode() { }

	// RVA: 0x2062150 Offset: 0x2062251 VA: 0x2062150
	private void LoadHeader() { }

	// RVA: 0x20621D0 Offset: 0x20622D1 VA: 0x20621D0
	private bool IsLoadingHeader() { }

	// RVA: 0x2062330 Offset: 0x2062431 VA: 0x2062330
	private void Branch() { }

	// RVA: 0x2062400 Offset: 0x2062501 VA: 0x2062400
	private void CreateLoadMenu() { }

	// RVA: 0x2062480 Offset: 0x2062581 VA: 0x2062480
	private void CreateSaveMenu() { }

	// RVA: 0x2062520 Offset: 0x2062621 VA: 0x2062520
	private void CreateSuspendMenu() { }

	// RVA: 0x20625A0 Offset: 0x20626A1 VA: 0x20625A0
	private void CreateCopyMenu() { }

	// RVA: 0x2062620 Offset: 0x2062721 VA: 0x2062620
	private void CreateDeleteMenu() { }

	// RVA: 0x20626A0 Offset: 0x20627A1 VA: 0x20626A0
	private ProcDesc[] GetProcDesc() { }

	// RVA: 0x2063790 Offset: 0x2063891 VA: 0x2063790
	public static void CreateBind(ProcInst super, SaveDataMenuSequence.Mode mode) { }
}

