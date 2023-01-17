// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472C20 Offset: 0x472D21 VA: 0x472C20
[Serializable]
public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 657
{
	// Fields
	private string current; // 0x60
	private string parent; // 0x68

	// Properties
	public override bool Exists { get; }
	public override string Name { get; }
	public DirectoryInfo Parent { get; }

	// Methods

	// RVA: 0x37296F0 Offset: 0x37297F1 VA: 0x37296F0
	public void .ctor(string path) { }

	// RVA: 0x3728C30 Offset: 0x3728D31 VA: 0x3728C30
	internal void .ctor(string path, bool simpleOriginalPath) { }

	// RVA: 0x3729B00 Offset: 0x3729C01 VA: 0x3729B00
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3729870 Offset: 0x3729971 VA: 0x3729870
	private void Initialize() { }

	// RVA: 0x3729B30 Offset: 0x3729C31 VA: 0x3729B30 Slot: 9
	public override bool get_Exists() { }

	// RVA: 0x3729B90 Offset: 0x3729C91 VA: 0x3729B90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x3728D30 Offset: 0x3728E31 VA: 0x3728D30
	public DirectoryInfo get_Parent() { }

	// RVA: 0x3728DB0 Offset: 0x3728EB1 VA: 0x3728DB0
	public void Create() { }

	// RVA: 0x3729BA0 Offset: 0x3729CA1 VA: 0x3729BA0
	public FileInfo[] GetFiles() { }

	// RVA: 0x3729C00 Offset: 0x3729D01 VA: 0x3729C00
	public FileInfo[] GetFiles(string searchPattern) { }

	// RVA: 0x3729DA0 Offset: 0x3729EA1 VA: 0x3729DA0
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x3729E00 Offset: 0x3729F01 VA: 0x3729E00
	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	// RVA: 0x3729FA0 Offset: 0x372A0A1 VA: 0x3729FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3729700 Offset: 0x3729801 VA: 0x3729700
	internal void CheckPath(string path) { }
}

