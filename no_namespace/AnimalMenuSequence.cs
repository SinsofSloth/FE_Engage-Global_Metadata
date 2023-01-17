// Namespace: 
public enum AnimalMenuSequence.Label // TypeDefIndex: 10441
{
	// Fields
	public int value__; // 0x0
	public const AnimalMenuSequence.Label Init = 0;
	public const AnimalMenuSequence.Label OutsideSelect = 1;
	public const AnimalMenuSequence.Label InsideSelect = 2;
	public const AnimalMenuSequence.Label Confirm = 3;
	public const AnimalMenuSequence.Label Apply = 4;
	public const AnimalMenuSequence.Label End = 5;
}

// Namespace: 
public enum AnimalMenuSequence.From // TypeDefIndex: 10442
{
	// Fields
	public int value__; // 0x0
	public const AnimalMenuSequence.From Outside = 0;
	public const AnimalMenuSequence.From Inside = 1;
}

// Namespace: 
private class AnimalMenuSequence.ConfirmYes : BasicDialogItemYes // TypeDefIndex: 10443
{
	// Methods

	// RVA: 0x1F5F060 Offset: 0x1F5F161 VA: 0x1F5F060
	public void .ctor() { }

	// RVA: 0x1F5F0F0 Offset: 0x1F5F1F1 VA: 0x1F5F0F0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class AnimalMenuSequence.ConfirmNo : BasicDialogItemNo // TypeDefIndex: 10444
{
	// Methods

	// RVA: 0x1F5EF50 Offset: 0x1F5F051 VA: 0x1F5EF50
	public void .ctor() { }

	// RVA: 0x1F5EFE0 Offset: 0x1F5F0E1 VA: 0x1F5EFE0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

