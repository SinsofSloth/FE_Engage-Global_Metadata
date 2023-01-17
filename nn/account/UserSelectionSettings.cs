// Namespace: nn.account
public struct UserSelectionSettings : IEquatable<UserSelectionSettings> // TypeDefIndex: 14784
{
	// Fields
	public UserSelectionSettings.UidArray8 invalidUidList; // 0x0
	public bool isSkipEnabled; // 0x80
	public bool isNetworkServiceAccountRequired; // 0x81
	public bool showSkipButton; // 0x82
	public bool additionalSelect; // 0x83
	public bool isUnqualifiedUserSelectable; // 0x84

	// Methods

	// RVA: 0x20AB600 Offset: 0x20AB701 VA: 0x20AB600
	public void SetDefault() { }

	// RVA: 0x20AB630 Offset: 0x20AB731 VA: 0x20AB630 Slot: 3
	public override string ToString() { }

	// RVA: 0x20ABD70 Offset: 0x20ABE71 VA: 0x20ABD70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20ABE30 Offset: 0x20ABF31 VA: 0x20ABE30 Slot: 4
	public bool Equals(UserSelectionSettings other) { }

	// RVA: 0x20AC000 Offset: 0x20AC101 VA: 0x20AC000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20ABE90 Offset: 0x20ABF91 VA: 0x20ABE90
	public static bool op_Equality(UserSelectionSettings lhs, UserSelectionSettings rhs) { }

	// RVA: 0x20AC080 Offset: 0x20AC181 VA: 0x20AC080
	public static bool op_Inequality(UserSelectionSettings lhs, UserSelectionSettings rhs) { }
}

