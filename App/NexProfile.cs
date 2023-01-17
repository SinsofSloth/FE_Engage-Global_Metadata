// Namespace: App
public class NexProfile : SingletonClass<NexProfile> // TypeDefIndex: 12741
{
	// Fields
	private NexProfile.Results m_LastResult; // 0x1C
	private ProfileCard m_LastResultData; // 0x20

	// Properties
	public NexProfile.Results Result { get; }
	public ProfileCard ResultData { get; }

	// Methods

	// RVA: 0x2357150 Offset: 0x2357251 VA: 0x2357150 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2357200 Offset: 0x2357301 VA: 0x2357200 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x2357210 Offset: 0x2357311 VA: 0x2357210
	public bool Upload(ProcInst super, ProfileCard profile) { }

	// RVA: 0x2357260 Offset: 0x2357361 VA: 0x2357260
	public bool Download(ProcInst super, ulong principalID) { }

	// RVA: 0x23572B0 Offset: 0x23573B1 VA: 0x23572B0
	public NexProfile.Results get_Result() { }

	// RVA: 0x23572C0 Offset: 0x23573C1 VA: 0x23572C0
	public ProfileCard get_ResultData() { }

	// RVA: 0x23571F0 Offset: 0x23572F1 VA: 0x23571F0
	private void ClearResult() { }

	// RVA: 0x23572D0 Offset: 0x23573D1 VA: 0x23572D0
	public void .ctor() { }
}

