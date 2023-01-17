// Namespace: App
public class ProfileList : List<ProfileCard> // TypeDefIndex: 13636
{
	// Fields
	private const int Version = 0;
	public const int ProfileCountMax = 30;

	// Methods

	// RVA: 0x2EECCD0 Offset: 0x2EECDD1 VA: 0x2EECCD0
	public ProfileCard TryGet(int index) { }

	// RVA: 0x2EECD60 Offset: 0x2EECE61 VA: 0x2EECD60
	public void Serialize(Stream stream) { }

	// RVA: 0x2EECE30 Offset: 0x2EECF31 VA: 0x2EECE30
	public void Deserialize(Stream stream) { }

	// RVA: 0x2EECFE0 Offset: 0x2EED0E1 VA: 0x2EECFE0
	public bool TryGet(ulong ownerID, out ProfileCard card) { }

	// RVA: 0x2EED160 Offset: 0x2EED261 VA: 0x2EED160
	public bool TryAdd(ProfileCard card) { }

	// RVA: 0x2EED250 Offset: 0x2EED351 VA: 0x2EED250
	public bool ForceAdd(ProfileCard card) { }

	// RVA: 0x2EED330 Offset: 0x2EED431 VA: 0x2EED330
	public bool IsFull() { }

	// RVA: 0x2EED380 Offset: 0x2EED481 VA: 0x2EED380
	public bool IsOver() { }

	// RVA: 0x2EED3D0 Offset: 0x2EED4D1 VA: 0x2EED3D0
	public void .ctor() { }
}

