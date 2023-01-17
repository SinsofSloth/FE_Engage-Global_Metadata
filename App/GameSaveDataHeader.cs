// Namespace: App
public class GameSaveDataHeader // TypeDefIndex: 13588
{
	// Fields
	public const int Size = 128;
	private const int Version = 9;
	private int m_GameVersion; // 0x10
	private GameUserData.StatusField m_Status; // 0x18
	private ChapterData m_Chapter; // 0x20
	private ChapterData m_NextChapter; // 0x28
	private GameUserData.Sequences m_Sequence; // 0x30
	private GameMode m_GameMode; // 0x34
	private Difficulty m_Difficulty; // 0x38
	private Difficulty m_EvilDifficulty; // 0x3C
	private int m_Turn; // 0x40
	private int m_ContentsIndex; // 0x44
	private ulong m_Identifier; // 0x48
	private float m_PlayTime; // 0x50
	private int m_ChallengeRoute; // 0x54
	private int m_ChallengeStage; // 0x58
	private UnitEdit m_UnitEdit; // 0x60

	// Properties
	public int GameVersion { get; }
	public GameUserData.StatusField Status { get; }
	public ChapterData Chapter { get; }
	public GameUserData.Sequences Sequence { get; }
	public Difficulty Difficulty { get; }
	public GameMode GameMode { get; }
	public int Turn { get; }
	public float PlayTime { get; }
	public int ContentsIndex { get; }
	public ulong Identifier { get; }
	public ChapterData NextChapter { get; }
	public Difficulty EvilDifficulty { get; }

	// Methods

	// RVA: 0x26ABC30 Offset: 0x26ABD31 VA: 0x26ABC30
	public void .ctor() { }

	// RVA: 0x26ABD70 Offset: 0x26ABE71 VA: 0x26ABD70
	public void Update() { }

	// RVA: 0x26AD930 Offset: 0x26ADA31 VA: 0x26AD930
	public void Reset() { }

	// RVA: 0x26AC020 Offset: 0x26AC121 VA: 0x26AC020
	public void Serialize(Stream stream) { }

	// RVA: 0x26AD9D0 Offset: 0x26ADAD1 VA: 0x26AD9D0
	public bool Deserialize(Stream stream) { }

	// RVA: 0x26AE060 Offset: 0x26AE161 VA: 0x26AE060
	public int get_GameVersion() { }

	// RVA: 0x26AE070 Offset: 0x26AE171 VA: 0x26AE070
	public GameUserData.StatusField get_Status() { }

	// RVA: 0x26AE080 Offset: 0x26AE181 VA: 0x26AE080
	public ChapterData get_Chapter() { }

	// RVA: 0x26AE090 Offset: 0x26AE191 VA: 0x26AE090
	public GameUserData.Sequences get_Sequence() { }

	// RVA: 0x26AE140 Offset: 0x26AE241 VA: 0x26AE140
	public Difficulty get_Difficulty() { }

	// RVA: 0x26AE150 Offset: 0x26AE251 VA: 0x26AE150
	public GameMode get_GameMode() { }

	// RVA: 0x26AE160 Offset: 0x26AE261 VA: 0x26AE160
	public int get_Turn() { }

	// RVA: 0x26AE170 Offset: 0x26AE271 VA: 0x26AE170
	public float get_PlayTime() { }

	// RVA: 0x26AE180 Offset: 0x26AE281 VA: 0x26AE180
	public int get_ContentsIndex() { }

	// RVA: 0x26AE190 Offset: 0x26AE291 VA: 0x26AE190
	public ulong get_Identifier() { }

	// RVA: 0x26AE1A0 Offset: 0x26AE2A1 VA: 0x26AE1A0
	public ChapterData get_NextChapter() { }

	// RVA: 0x26AE1B0 Offset: 0x26AE2B1 VA: 0x26AE1B0
	public string GetChapterPrefix() { }

	// RVA: 0x26AE420 Offset: 0x26AE521 VA: 0x26AE420
	public string GetChapterName() { }

	// RVA: 0x26AE500 Offset: 0x26AE601 VA: 0x26AE500
	public string GetPlaceName() { }

	// RVA: 0x26AE2D0 Offset: 0x26AE3D1 VA: 0x26AE2D0
	private ChapterData GetChapterForDisplay() { }

	// RVA: 0x26AE700 Offset: 0x26AE801 VA: 0x26AE700
	public string GetHeroName() { }

	// RVA: 0x26AE710 Offset: 0x26AE811 VA: 0x26AE710
	public Gender GetHeroGender() { }

	// RVA: 0x26AE6A0 Offset: 0x26AE7A1 VA: 0x26AE6A0
	public bool IsEncountMap() { }

	// RVA: 0x26AE3F0 Offset: 0x26AE4F1 VA: 0x26AE3F0
	public bool IsChallengeMap() { }

	// RVA: 0x26AE720 Offset: 0x26AE821 VA: 0x26AE720
	public bool IsTemporary() { }

	// RVA: 0x26AE780 Offset: 0x26AE881 VA: 0x26AE780
	public bool IsCompleted() { }

	// RVA: 0x26AE7E0 Offset: 0x26AE8E1 VA: 0x26AE7E0
	public bool IsEvilCompleted() { }

	// RVA: 0x26AE840 Offset: 0x26AE941 VA: 0x26AE840
	public Difficulty get_EvilDifficulty() { }

	// RVA: 0x26AE850 Offset: 0x26AE951 VA: 0x26AE850
	public bool IsEvilMap() { }
}

