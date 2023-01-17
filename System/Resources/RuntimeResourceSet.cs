// Namespace: System.Resources
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 498
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x322E6F0 Offset: 0x322E7F1 VA: 0x322E6F0
	internal void .ctor(string fileName) { }

	// RVA: 0x322E860 Offset: 0x322E961 VA: 0x322E860
	internal void .ctor(Stream stream) { }

	// RVA: 0x322E990 Offset: 0x322EA91 VA: 0x322E990 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x322EB10 Offset: 0x322EC11 VA: 0x322EB10 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x322EC30 Offset: 0x322ED31 VA: 0x322EC30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x322EB20 Offset: 0x322EC21 VA: 0x322EB20
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x322EC40 Offset: 0x322ED41 VA: 0x322EC40 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x322F7D0 Offset: 0x322F8D1 VA: 0x322F7D0 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x322F850 Offset: 0x322F951 VA: 0x322F850 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x322F860 Offset: 0x322F961 VA: 0x322F860 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x322ECC0 Offset: 0x322EDC1 VA: 0x322ECC0
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x322F870 Offset: 0x322F971 VA: 0x322F870
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}

