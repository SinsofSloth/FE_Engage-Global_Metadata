// Namespace: nn.friends
public struct Profile // TypeDefIndex: 14754
{
	// Methods

	// RVA: 0x29E6C10 Offset: 0x29E6D11 VA: 0x29E6C10
	public NetworkServiceAccountId GetAccountId() { }

	// RVA: 0x29E6C90 Offset: 0x29E6D91 VA: 0x29E6C90
	public Nickname GetNickname() { }

	// RVA: 0x29E6D50 Offset: 0x29E6E51 VA: 0x29E6D50
	public Result GetProfileImageUrl(ref string outUrl, ImageSize imageSize) { }

	// RVA: 0x29E6EE0 Offset: 0x29E6FE1 VA: 0x29E6EE0
	public bool IsValid() { }

	// RVA: 0x29E6C50 Offset: 0x29E6D51 VA: 0x29E6C50
	private static extern NetworkServiceAccountId GetAccountId(Profile profile) { }

	// RVA: 0x29E6CF0 Offset: 0x29E6DF1 VA: 0x29E6CF0
	private static extern Nickname GetNickname(Profile profile) { }

	// RVA: 0x29E6E50 Offset: 0x29E6F51 VA: 0x29E6E50
	private static extern Result GetProfileImageUrl(Profile profile, [In] [Out] StringBuilder outUrl, ImageSize imageSize) { }

	// RVA: 0x29E6F20 Offset: 0x29E7021 VA: 0x29E6F20
	private static extern bool IsValid(Profile profile) { }
}

