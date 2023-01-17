// Namespace: App
[DefaultMemberAttribute] // RVA: 0x275F20 Offset: 0x276021 VA: 0x275F20
public abstract class CapabilityBase<T> : CapabilityDefinition, IDisposable // TypeDefIndex: 9828
{
	// Fields
	private const int Version = 0;
	private T[] m_Data; // 0x0

	// Properties
	public T Item { get; set; }
	public T Hp { get; set; }
	public T Str { get; set; }
	public T Tech { get; set; }
	public T Quick { get; set; }
	public T Luck { get; set; }
	public T Def { get; set; }
	public T Magic { get; set; }
	public T Mdef { get; set; }
	public T Phys { get; set; }
	public T Sight { get; set; }
	public T Move { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C88D0 Offset: 0x30C89D1 VA: 0x30C88D0
	|-CapabilityBase<byte>..ctor
	|
	|-RVA: 0x30C9E70 Offset: 0x30C9F71 VA: 0x30C9E70
	|-CapabilityBase<short>..ctor
	|
	|-RVA: 0x30CB410 Offset: 0x30CB511 VA: 0x30CB410
	|-CapabilityBase<int>..ctor
	|
	|-RVA: 0x30CC9B0 Offset: 0x30CCAB1 VA: 0x30CC9B0
	|-CapabilityBase<object>..ctor
	|
	|-RVA: 0x30CE0C0 Offset: 0x30CE1C1 VA: 0x30CE0C0
	|-CapabilityBase<sbyte>..ctor
	|
	|-RVA: 0x30CF660 Offset: 0x30CF761 VA: 0x30CF660
	|-CapabilityBase<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8A80 Offset: 0x30C8B81 VA: 0x30C8A80
	|-CapabilityBase<byte>.get_Item
	|
	|-RVA: 0x30CA020 Offset: 0x30CA121 VA: 0x30CA020
	|-CapabilityBase<short>.get_Item
	|
	|-RVA: 0x30CB5C0 Offset: 0x30CB6C1 VA: 0x30CB5C0
	|-CapabilityBase<int>.get_Item
	|
	|-RVA: 0x30CCBB0 Offset: 0x30CCCB1 VA: 0x30CCBB0
	|-CapabilityBase<object>.get_Item
	|
	|-RVA: 0x30CE270 Offset: 0x30CE371 VA: 0x30CE270
	|-CapabilityBase<sbyte>.get_Item
	|
	|-RVA: 0x30CF810 Offset: 0x30CF911 VA: 0x30CF810
	|-CapabilityBase<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8AC0 Offset: 0x30C8BC1 VA: 0x30C8AC0
	|-CapabilityBase<byte>.set_Item
	|
	|-RVA: 0x30CA060 Offset: 0x30CA161 VA: 0x30CA060
	|-CapabilityBase<short>.set_Item
	|
	|-RVA: 0x30CB600 Offset: 0x30CB701 VA: 0x30CB600
	|-CapabilityBase<int>.set_Item
	|
	|-RVA: 0x30CCBF0 Offset: 0x30CCCF1 VA: 0x30CCBF0
	|-CapabilityBase<object>.set_Item
	|
	|-RVA: 0x30CE2B0 Offset: 0x30CE3B1 VA: 0x30CE2B0
	|-CapabilityBase<sbyte>.set_Item
	|
	|-RVA: 0x30CF850 Offset: 0x30CF951 VA: 0x30CF850
	|-CapabilityBase<float>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8B00 Offset: 0x30C8C01 VA: 0x30C8B00
	|-CapabilityBase<byte>.Finalize
	|
	|-RVA: 0x30CA0A0 Offset: 0x30CA1A1 VA: 0x30CA0A0
	|-CapabilityBase<short>.Finalize
	|
	|-RVA: 0x30CB640 Offset: 0x30CB741 VA: 0x30CB640
	|-CapabilityBase<int>.Finalize
	|
	|-RVA: 0x30CCC30 Offset: 0x30CCD31 VA: 0x30CCC30
	|-CapabilityBase<object>.Finalize
	|
	|-RVA: 0x30CE2F0 Offset: 0x30CE3F1 VA: 0x30CE2F0
	|-CapabilityBase<sbyte>.Finalize
	|
	|-RVA: 0x30CF890 Offset: 0x30CF991 VA: 0x30CF890
	|-CapabilityBase<float>.Finalize
	*/

	// RVA: -1 Offset: -1
	public void Set(int i, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8B80 Offset: 0x30C8C81 VA: 0x30C8B80
	|-CapabilityBase<byte>.Set
	|
	|-RVA: 0x30CA120 Offset: 0x30CA221 VA: 0x30CA120
	|-CapabilityBase<short>.Set
	|
	|-RVA: 0x30CB6C0 Offset: 0x30CB7C1 VA: 0x30CB6C0
	|-CapabilityBase<int>.Set
	|
	|-RVA: 0x30CCCB0 Offset: 0x30CCDB1 VA: 0x30CCCB0
	|-CapabilityBase<object>.Set
	|
	|-RVA: 0x30CE370 Offset: 0x30CE471 VA: 0x30CE370
	|-CapabilityBase<sbyte>.Set
	|
	|-RVA: 0x30CF910 Offset: 0x30CFA11 VA: 0x30CF910
	|-CapabilityBase<float>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8BC0 Offset: 0x30C8CC1 VA: 0x30C8BC0
	|-CapabilityBase<byte>.Get
	|
	|-RVA: 0x30CA160 Offset: 0x30CA261 VA: 0x30CA160
	|-CapabilityBase<short>.Get
	|
	|-RVA: 0x30CB700 Offset: 0x30CB801 VA: 0x30CB700
	|-CapabilityBase<int>.Get
	|
	|-RVA: 0x30CCCF0 Offset: 0x30CCDF1 VA: 0x30CCCF0
	|-CapabilityBase<object>.Get
	|
	|-RVA: 0x30CE3B0 Offset: 0x30CE4B1 VA: 0x30CE3B0
	|-CapabilityBase<sbyte>.Get
	|
	|-RVA: 0x30CF950 Offset: 0x30CFA51 VA: 0x30CF950
	|-CapabilityBase<float>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(int i, T v);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CapabilityBase<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Set(CapabilityDefinition.Type t, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C00 Offset: 0x30C8D01 VA: 0x30C8C00
	|-CapabilityBase<byte>.Set
	|
	|-RVA: 0x30CA1A0 Offset: 0x30CA2A1 VA: 0x30CA1A0
	|-CapabilityBase<short>.Set
	|
	|-RVA: 0x30CB740 Offset: 0x30CB841 VA: 0x30CB740
	|-CapabilityBase<int>.Set
	|
	|-RVA: 0x30CCD30 Offset: 0x30CCE31 VA: 0x30CCD30
	|-CapabilityBase<object>.Set
	|
	|-RVA: 0x30CE3F0 Offset: 0x30CE4F1 VA: 0x30CE3F0
	|-CapabilityBase<sbyte>.Set
	|
	|-RVA: 0x30CF990 Offset: 0x30CFA91 VA: 0x30CF990
	|-CapabilityBase<float>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(CapabilityDefinition.Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C20 Offset: 0x30C8D21 VA: 0x30C8C20
	|-CapabilityBase<byte>.Get
	|
	|-RVA: 0x30CA1C0 Offset: 0x30CA2C1 VA: 0x30CA1C0
	|-CapabilityBase<short>.Get
	|
	|-RVA: 0x30CB760 Offset: 0x30CB861 VA: 0x30CB760
	|-CapabilityBase<int>.Get
	|
	|-RVA: 0x30CCD50 Offset: 0x30CCE51 VA: 0x30CCD50
	|-CapabilityBase<object>.Get
	|
	|-RVA: 0x30CE410 Offset: 0x30CE511 VA: 0x30CE410
	|-CapabilityBase<sbyte>.Get
	|
	|-RVA: 0x30CF9B0 Offset: 0x30CFAB1 VA: 0x30CF9B0
	|-CapabilityBase<float>.Get
	*/

	// RVA: -1 Offset: -1
	public void Add(CapabilityDefinition.Type t, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C40 Offset: 0x30C8D41 VA: 0x30C8C40
	|-CapabilityBase<byte>.Add
	|
	|-RVA: 0x30CA1E0 Offset: 0x30CA2E1 VA: 0x30CA1E0
	|-CapabilityBase<short>.Add
	|
	|-RVA: 0x30CB780 Offset: 0x30CB881 VA: 0x30CB780
	|-CapabilityBase<int>.Add
	|
	|-RVA: 0x30CCD70 Offset: 0x30CCE71 VA: 0x30CCD70
	|-CapabilityBase<object>.Add
	|
	|-RVA: 0x30CE430 Offset: 0x30CE531 VA: 0x30CE430
	|-CapabilityBase<sbyte>.Add
	|
	|-RVA: 0x30CF9D0 Offset: 0x30CFAD1 VA: 0x30CF9D0
	|-CapabilityBase<float>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddHp(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C50 Offset: 0x30C8D51 VA: 0x30C8C50
	|-CapabilityBase<byte>.AddHp
	|
	|-RVA: 0x30CA1F0 Offset: 0x30CA2F1 VA: 0x30CA1F0
	|-CapabilityBase<short>.AddHp
	|
	|-RVA: 0x30CB790 Offset: 0x30CB891 VA: 0x30CB790
	|-CapabilityBase<int>.AddHp
	|
	|-RVA: 0x30CCD80 Offset: 0x30CCE81 VA: 0x30CCD80
	|-CapabilityBase<object>.AddHp
	|
	|-RVA: 0x30CE440 Offset: 0x30CE541 VA: 0x30CE440
	|-CapabilityBase<sbyte>.AddHp
	|
	|-RVA: 0x30CF9E0 Offset: 0x30CFAE1 VA: 0x30CF9E0
	|-CapabilityBase<float>.AddHp
	*/

	// RVA: -1 Offset: -1
	public void AddStr(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C70 Offset: 0x30C8D71 VA: 0x30C8C70
	|-CapabilityBase<byte>.AddStr
	|
	|-RVA: 0x30CA210 Offset: 0x30CA311 VA: 0x30CA210
	|-CapabilityBase<short>.AddStr
	|
	|-RVA: 0x30CB7B0 Offset: 0x30CB8B1 VA: 0x30CB7B0
	|-CapabilityBase<int>.AddStr
	|
	|-RVA: 0x30CCDA0 Offset: 0x30CCEA1 VA: 0x30CCDA0
	|-CapabilityBase<object>.AddStr
	|
	|-RVA: 0x30CE460 Offset: 0x30CE561 VA: 0x30CE460
	|-CapabilityBase<sbyte>.AddStr
	|
	|-RVA: 0x30CFA00 Offset: 0x30CFB01 VA: 0x30CFA00
	|-CapabilityBase<float>.AddStr
	*/

	// RVA: -1 Offset: -1
	public void AddTech(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8C90 Offset: 0x30C8D91 VA: 0x30C8C90
	|-CapabilityBase<byte>.AddTech
	|
	|-RVA: 0x30CA230 Offset: 0x30CA331 VA: 0x30CA230
	|-CapabilityBase<short>.AddTech
	|
	|-RVA: 0x30CB7D0 Offset: 0x30CB8D1 VA: 0x30CB7D0
	|-CapabilityBase<int>.AddTech
	|
	|-RVA: 0x30CCDC0 Offset: 0x30CCEC1 VA: 0x30CCDC0
	|-CapabilityBase<object>.AddTech
	|
	|-RVA: 0x30CE480 Offset: 0x30CE581 VA: 0x30CE480
	|-CapabilityBase<sbyte>.AddTech
	|
	|-RVA: 0x30CFA20 Offset: 0x30CFB21 VA: 0x30CFA20
	|-CapabilityBase<float>.AddTech
	*/

	// RVA: -1 Offset: -1
	public void AddQuick(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8CB0 Offset: 0x30C8DB1 VA: 0x30C8CB0
	|-CapabilityBase<byte>.AddQuick
	|
	|-RVA: 0x30CA250 Offset: 0x30CA351 VA: 0x30CA250
	|-CapabilityBase<short>.AddQuick
	|
	|-RVA: 0x30CB7F0 Offset: 0x30CB8F1 VA: 0x30CB7F0
	|-CapabilityBase<int>.AddQuick
	|
	|-RVA: 0x30CCDE0 Offset: 0x30CCEE1 VA: 0x30CCDE0
	|-CapabilityBase<object>.AddQuick
	|
	|-RVA: 0x30CE4A0 Offset: 0x30CE5A1 VA: 0x30CE4A0
	|-CapabilityBase<sbyte>.AddQuick
	|
	|-RVA: 0x30CFA40 Offset: 0x30CFB41 VA: 0x30CFA40
	|-CapabilityBase<float>.AddQuick
	*/

	// RVA: -1 Offset: -1
	public void AddLuck(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8CD0 Offset: 0x30C8DD1 VA: 0x30C8CD0
	|-CapabilityBase<byte>.AddLuck
	|
	|-RVA: 0x30CA270 Offset: 0x30CA371 VA: 0x30CA270
	|-CapabilityBase<short>.AddLuck
	|
	|-RVA: 0x30CB810 Offset: 0x30CB911 VA: 0x30CB810
	|-CapabilityBase<int>.AddLuck
	|
	|-RVA: 0x30CCE00 Offset: 0x30CCF01 VA: 0x30CCE00
	|-CapabilityBase<object>.AddLuck
	|
	|-RVA: 0x30CE4C0 Offset: 0x30CE5C1 VA: 0x30CE4C0
	|-CapabilityBase<sbyte>.AddLuck
	|
	|-RVA: 0x30CFA60 Offset: 0x30CFB61 VA: 0x30CFA60
	|-CapabilityBase<float>.AddLuck
	*/

	// RVA: -1 Offset: -1
	public void AddDef(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8CF0 Offset: 0x30C8DF1 VA: 0x30C8CF0
	|-CapabilityBase<byte>.AddDef
	|
	|-RVA: 0x30CA290 Offset: 0x30CA391 VA: 0x30CA290
	|-CapabilityBase<short>.AddDef
	|
	|-RVA: 0x30CB830 Offset: 0x30CB931 VA: 0x30CB830
	|-CapabilityBase<int>.AddDef
	|
	|-RVA: 0x30CCE20 Offset: 0x30CCF21 VA: 0x30CCE20
	|-CapabilityBase<object>.AddDef
	|
	|-RVA: 0x30CE4E0 Offset: 0x30CE5E1 VA: 0x30CE4E0
	|-CapabilityBase<sbyte>.AddDef
	|
	|-RVA: 0x30CFA80 Offset: 0x30CFB81 VA: 0x30CFA80
	|-CapabilityBase<float>.AddDef
	*/

	// RVA: -1 Offset: -1
	public void AddMagic(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8D10 Offset: 0x30C8E11 VA: 0x30C8D10
	|-CapabilityBase<byte>.AddMagic
	|
	|-RVA: 0x30CA2B0 Offset: 0x30CA3B1 VA: 0x30CA2B0
	|-CapabilityBase<short>.AddMagic
	|
	|-RVA: 0x30CB850 Offset: 0x30CB951 VA: 0x30CB850
	|-CapabilityBase<int>.AddMagic
	|
	|-RVA: 0x30CCE40 Offset: 0x30CCF41 VA: 0x30CCE40
	|-CapabilityBase<object>.AddMagic
	|
	|-RVA: 0x30CE500 Offset: 0x30CE601 VA: 0x30CE500
	|-CapabilityBase<sbyte>.AddMagic
	|
	|-RVA: 0x30CFAA0 Offset: 0x30CFBA1 VA: 0x30CFAA0
	|-CapabilityBase<float>.AddMagic
	*/

	// RVA: -1 Offset: -1
	public void AddMdef(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8D30 Offset: 0x30C8E31 VA: 0x30C8D30
	|-CapabilityBase<byte>.AddMdef
	|
	|-RVA: 0x30CA2D0 Offset: 0x30CA3D1 VA: 0x30CA2D0
	|-CapabilityBase<short>.AddMdef
	|
	|-RVA: 0x30CB870 Offset: 0x30CB971 VA: 0x30CB870
	|-CapabilityBase<int>.AddMdef
	|
	|-RVA: 0x30CCE60 Offset: 0x30CCF61 VA: 0x30CCE60
	|-CapabilityBase<object>.AddMdef
	|
	|-RVA: 0x30CE520 Offset: 0x30CE621 VA: 0x30CE520
	|-CapabilityBase<sbyte>.AddMdef
	|
	|-RVA: 0x30CFAC0 Offset: 0x30CFBC1 VA: 0x30CFAC0
	|-CapabilityBase<float>.AddMdef
	*/

	// RVA: -1 Offset: -1
	public void AddPhys(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8D50 Offset: 0x30C8E51 VA: 0x30C8D50
	|-CapabilityBase<byte>.AddPhys
	|
	|-RVA: 0x30CA2F0 Offset: 0x30CA3F1 VA: 0x30CA2F0
	|-CapabilityBase<short>.AddPhys
	|
	|-RVA: 0x30CB890 Offset: 0x30CB991 VA: 0x30CB890
	|-CapabilityBase<int>.AddPhys
	|
	|-RVA: 0x30CCE80 Offset: 0x30CCF81 VA: 0x30CCE80
	|-CapabilityBase<object>.AddPhys
	|
	|-RVA: 0x30CE540 Offset: 0x30CE641 VA: 0x30CE540
	|-CapabilityBase<sbyte>.AddPhys
	|
	|-RVA: 0x30CFAE0 Offset: 0x30CFBE1 VA: 0x30CFAE0
	|-CapabilityBase<float>.AddPhys
	*/

	// RVA: -1 Offset: -1
	public void AddSight(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8D70 Offset: 0x30C8E71 VA: 0x30C8D70
	|-CapabilityBase<byte>.AddSight
	|
	|-RVA: 0x30CA310 Offset: 0x30CA411 VA: 0x30CA310
	|-CapabilityBase<short>.AddSight
	|
	|-RVA: 0x30CB8B0 Offset: 0x30CB9B1 VA: 0x30CB8B0
	|-CapabilityBase<int>.AddSight
	|
	|-RVA: 0x30CCEA0 Offset: 0x30CCFA1 VA: 0x30CCEA0
	|-CapabilityBase<object>.AddSight
	|
	|-RVA: 0x30CE560 Offset: 0x30CE661 VA: 0x30CE560
	|-CapabilityBase<sbyte>.AddSight
	|
	|-RVA: 0x30CFB00 Offset: 0x30CFC01 VA: 0x30CFB00
	|-CapabilityBase<float>.AddSight
	*/

	// RVA: -1 Offset: -1
	public void AddMove(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8D90 Offset: 0x30C8E91 VA: 0x30C8D90
	|-CapabilityBase<byte>.AddMove
	|
	|-RVA: 0x30CA330 Offset: 0x30CA431 VA: 0x30CA330
	|-CapabilityBase<short>.AddMove
	|
	|-RVA: 0x30CB8D0 Offset: 0x30CB9D1 VA: 0x30CB8D0
	|-CapabilityBase<int>.AddMove
	|
	|-RVA: 0x30CCEC0 Offset: 0x30CCFC1 VA: 0x30CCEC0
	|-CapabilityBase<object>.AddMove
	|
	|-RVA: 0x30CE580 Offset: 0x30CE681 VA: 0x30CE580
	|-CapabilityBase<sbyte>.AddMove
	|
	|-RVA: 0x30CFB20 Offset: 0x30CFC21 VA: 0x30CFB20
	|-CapabilityBase<float>.AddMove
	*/

	// RVA: -1 Offset: -1
	public void Set(CapabilityBase<T> v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8DB0 Offset: 0x30C8EB1 VA: 0x30C8DB0
	|-CapabilityBase<byte>.Set
	|
	|-RVA: 0x30CA350 Offset: 0x30CA451 VA: 0x30CA350
	|-CapabilityBase<short>.Set
	|
	|-RVA: 0x30CB8F0 Offset: 0x30CB9F1 VA: 0x30CB8F0
	|-CapabilityBase<int>.Set
	|
	|-RVA: 0x30CCEE0 Offset: 0x30CCFE1 VA: 0x30CCEE0
	|-CapabilityBase<object>.Set
	|
	|-RVA: 0x30CE5A0 Offset: 0x30CE6A1 VA: 0x30CE5A0
	|-CapabilityBase<sbyte>.Set
	|
	|-RVA: 0x30CFB40 Offset: 0x30CFC41 VA: 0x30CFB40
	|-CapabilityBase<float>.Set
	*/

	// RVA: -1 Offset: -1
	public void Add(CapabilityBase<T> v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9080 Offset: 0x30C9181 VA: 0x30C9080
	|-CapabilityBase<byte>.Add
	|
	|-RVA: 0x30CA620 Offset: 0x30CA721 VA: 0x30CA620
	|-CapabilityBase<short>.Add
	|
	|-RVA: 0x30CBBC0 Offset: 0x30CBCC1 VA: 0x30CBBC0
	|-CapabilityBase<int>.Add
	|
	|-RVA: 0x30CD1B0 Offset: 0x30CD2B1 VA: 0x30CD1B0
	|-CapabilityBase<object>.Add
	|
	|-RVA: 0x30CE870 Offset: 0x30CE971 VA: 0x30CE870
	|-CapabilityBase<sbyte>.Add
	|
	|-RVA: 0x30CFDE0 Offset: 0x30CFEE1 VA: 0x30CFDE0
	|-CapabilityBase<float>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C92F0 Offset: 0x30C93F1 VA: 0x30C92F0
	|-CapabilityBase<byte>.Clear
	|
	|-RVA: 0x30CA890 Offset: 0x30CA991 VA: 0x30CA890
	|-CapabilityBase<short>.Clear
	|
	|-RVA: 0x30CBE30 Offset: 0x30CBF31 VA: 0x30CBE30
	|-CapabilityBase<int>.Clear
	|
	|-RVA: 0x30CD420 Offset: 0x30CD521 VA: 0x30CD420
	|-CapabilityBase<object>.Clear
	|
	|-RVA: 0x30CEAE0 Offset: 0x30CEBE1 VA: 0x30CEAE0
	|-CapabilityBase<sbyte>.Clear
	|
	|-RVA: 0x30D0030 Offset: 0x30D0131 VA: 0x30D0030
	|-CapabilityBase<float>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Copy(CapabilityBase<T> src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C93F0 Offset: 0x30C94F1 VA: 0x30C93F0
	|-CapabilityBase<byte>.Copy
	|
	|-RVA: 0x30CA990 Offset: 0x30CAA91 VA: 0x30CA990
	|-CapabilityBase<short>.Copy
	|
	|-RVA: 0x30CBF30 Offset: 0x30CC031 VA: 0x30CBF30
	|-CapabilityBase<int>.Copy
	|
	|-RVA: 0x30CD580 Offset: 0x30CD681 VA: 0x30CD580
	|-CapabilityBase<object>.Copy
	|
	|-RVA: 0x30CEBE0 Offset: 0x30CECE1 VA: 0x30CEBE0
	|-CapabilityBase<sbyte>.Copy
	|
	|-RVA: 0x30D0130 Offset: 0x30D0231 VA: 0x30D0130
	|-CapabilityBase<float>.Copy
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsZero();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CapabilityBase<object>.IsZero
	*/

	// RVA: -1 Offset: -1
	public void Serialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C95D0 Offset: 0x30C96D1 VA: 0x30C95D0
	|-CapabilityBase<byte>.Serialize
	|
	|-RVA: 0x30CAB70 Offset: 0x30CAC71 VA: 0x30CAB70
	|-CapabilityBase<short>.Serialize
	|
	|-RVA: 0x30CC110 Offset: 0x30CC211 VA: 0x30CC110
	|-CapabilityBase<int>.Serialize
	|
	|-RVA: 0x30CD7A0 Offset: 0x30CD8A1 VA: 0x30CD7A0
	|-CapabilityBase<object>.Serialize
	|
	|-RVA: 0x30CEDC0 Offset: 0x30CEEC1 VA: 0x30CEDC0
	|-CapabilityBase<sbyte>.Serialize
	|
	|-RVA: 0x30D0310 Offset: 0x30D0411 VA: 0x30D0310
	|-CapabilityBase<float>.Serialize
	*/

	// RVA: -1 Offset: -1
	public void Deserialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C97D0 Offset: 0x30C98D1 VA: 0x30C97D0
	|-CapabilityBase<byte>.Deserialize
	|
	|-RVA: 0x30CAD70 Offset: 0x30CAE71 VA: 0x30CAD70
	|-CapabilityBase<short>.Deserialize
	|
	|-RVA: 0x30CC310 Offset: 0x30CC411 VA: 0x30CC310
	|-CapabilityBase<int>.Deserialize
	|
	|-RVA: 0x30CD9A0 Offset: 0x30CDAA1 VA: 0x30CD9A0
	|-CapabilityBase<object>.Deserialize
	|
	|-RVA: 0x30CEFC0 Offset: 0x30CF0C1 VA: 0x30CEFC0
	|-CapabilityBase<sbyte>.Deserialize
	|
	|-RVA: 0x30D0510 Offset: 0x30D0611 VA: 0x30D0510
	|-CapabilityBase<float>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void WriteToStream(Stream stream, T v);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CapabilityBase<object>.WriteToStream
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract T ReadFromStream(Stream stream);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CapabilityBase<object>.ReadFromStream
	*/

	// RVA: -1 Offset: -1
	public T get_Hp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9A40 Offset: 0x30C9B41 VA: 0x30C9A40
	|-CapabilityBase<byte>.get_Hp
	|
	|-RVA: 0x30CAFE0 Offset: 0x30CB0E1 VA: 0x30CAFE0
	|-CapabilityBase<short>.get_Hp
	|
	|-RVA: 0x30CC580 Offset: 0x30CC681 VA: 0x30CC580
	|-CapabilityBase<int>.get_Hp
	|
	|-RVA: 0x30CDC90 Offset: 0x30CDD91 VA: 0x30CDC90
	|-CapabilityBase<object>.get_Hp
	|
	|-RVA: 0x30CF230 Offset: 0x30CF331 VA: 0x30CF230
	|-CapabilityBase<sbyte>.get_Hp
	|
	|-RVA: 0x30D0780 Offset: 0x30D0881 VA: 0x30D0780
	|-CapabilityBase<float>.get_Hp
	*/

	// RVA: -1 Offset: -1
	public void set_Hp(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9A70 Offset: 0x30C9B71 VA: 0x30C9A70
	|-CapabilityBase<byte>.set_Hp
	|
	|-RVA: 0x30CB010 Offset: 0x30CB111 VA: 0x30CB010
	|-CapabilityBase<short>.set_Hp
	|
	|-RVA: 0x30CC5B0 Offset: 0x30CC6B1 VA: 0x30CC5B0
	|-CapabilityBase<int>.set_Hp
	|
	|-RVA: 0x30CDCC0 Offset: 0x30CDDC1 VA: 0x30CDCC0
	|-CapabilityBase<object>.set_Hp
	|
	|-RVA: 0x30CF260 Offset: 0x30CF361 VA: 0x30CF260
	|-CapabilityBase<sbyte>.set_Hp
	|
	|-RVA: 0x30D07B0 Offset: 0x30D08B1 VA: 0x30D07B0
	|-CapabilityBase<float>.set_Hp
	*/

	// RVA: -1 Offset: -1
	public T get_Str() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9AA0 Offset: 0x30C9BA1 VA: 0x30C9AA0
	|-CapabilityBase<byte>.get_Str
	|
	|-RVA: 0x30CB040 Offset: 0x30CB141 VA: 0x30CB040
	|-CapabilityBase<short>.get_Str
	|
	|-RVA: 0x30CC5E0 Offset: 0x30CC6E1 VA: 0x30CC5E0
	|-CapabilityBase<int>.get_Str
	|
	|-RVA: 0x30CDCF0 Offset: 0x30CDDF1 VA: 0x30CDCF0
	|-CapabilityBase<object>.get_Str
	|
	|-RVA: 0x30CF290 Offset: 0x30CF391 VA: 0x30CF290
	|-CapabilityBase<sbyte>.get_Str
	|
	|-RVA: 0x30D07E0 Offset: 0x30D08E1 VA: 0x30D07E0
	|-CapabilityBase<float>.get_Str
	*/

	// RVA: -1 Offset: -1
	public void set_Str(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9AD0 Offset: 0x30C9BD1 VA: 0x30C9AD0
	|-CapabilityBase<byte>.set_Str
	|
	|-RVA: 0x30CB070 Offset: 0x30CB171 VA: 0x30CB070
	|-CapabilityBase<short>.set_Str
	|
	|-RVA: 0x30CC610 Offset: 0x30CC711 VA: 0x30CC610
	|-CapabilityBase<int>.set_Str
	|
	|-RVA: 0x30CDD20 Offset: 0x30CDE21 VA: 0x30CDD20
	|-CapabilityBase<object>.set_Str
	|
	|-RVA: 0x30CF2C0 Offset: 0x30CF3C1 VA: 0x30CF2C0
	|-CapabilityBase<sbyte>.set_Str
	|
	|-RVA: 0x30D0810 Offset: 0x30D0911 VA: 0x30D0810
	|-CapabilityBase<float>.set_Str
	*/

	// RVA: -1 Offset: -1
	public T get_Tech() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9B00 Offset: 0x30C9C01 VA: 0x30C9B00
	|-CapabilityBase<byte>.get_Tech
	|
	|-RVA: 0x30CB0A0 Offset: 0x30CB1A1 VA: 0x30CB0A0
	|-CapabilityBase<short>.get_Tech
	|
	|-RVA: 0x30CC640 Offset: 0x30CC741 VA: 0x30CC640
	|-CapabilityBase<int>.get_Tech
	|
	|-RVA: 0x30CDD50 Offset: 0x30CDE51 VA: 0x30CDD50
	|-CapabilityBase<object>.get_Tech
	|
	|-RVA: 0x30CF2F0 Offset: 0x30CF3F1 VA: 0x30CF2F0
	|-CapabilityBase<sbyte>.get_Tech
	|
	|-RVA: 0x30D0840 Offset: 0x30D0941 VA: 0x30D0840
	|-CapabilityBase<float>.get_Tech
	*/

	// RVA: -1 Offset: -1
	public void set_Tech(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9B30 Offset: 0x30C9C31 VA: 0x30C9B30
	|-CapabilityBase<byte>.set_Tech
	|
	|-RVA: 0x30CB0D0 Offset: 0x30CB1D1 VA: 0x30CB0D0
	|-CapabilityBase<short>.set_Tech
	|
	|-RVA: 0x30CC670 Offset: 0x30CC771 VA: 0x30CC670
	|-CapabilityBase<int>.set_Tech
	|
	|-RVA: 0x30CDD80 Offset: 0x30CDE81 VA: 0x30CDD80
	|-CapabilityBase<object>.set_Tech
	|
	|-RVA: 0x30CF320 Offset: 0x30CF421 VA: 0x30CF320
	|-CapabilityBase<sbyte>.set_Tech
	|
	|-RVA: 0x30D0870 Offset: 0x30D0971 VA: 0x30D0870
	|-CapabilityBase<float>.set_Tech
	*/

	// RVA: -1 Offset: -1
	public T get_Quick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9B60 Offset: 0x30C9C61 VA: 0x30C9B60
	|-CapabilityBase<byte>.get_Quick
	|
	|-RVA: 0x30CB100 Offset: 0x30CB201 VA: 0x30CB100
	|-CapabilityBase<short>.get_Quick
	|
	|-RVA: 0x30CC6A0 Offset: 0x30CC7A1 VA: 0x30CC6A0
	|-CapabilityBase<int>.get_Quick
	|
	|-RVA: 0x30CDDB0 Offset: 0x30CDEB1 VA: 0x30CDDB0
	|-CapabilityBase<object>.get_Quick
	|
	|-RVA: 0x30CF350 Offset: 0x30CF451 VA: 0x30CF350
	|-CapabilityBase<sbyte>.get_Quick
	|
	|-RVA: 0x30D08A0 Offset: 0x30D09A1 VA: 0x30D08A0
	|-CapabilityBase<float>.get_Quick
	*/

	// RVA: -1 Offset: -1
	public void set_Quick(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9B90 Offset: 0x30C9C91 VA: 0x30C9B90
	|-CapabilityBase<byte>.set_Quick
	|
	|-RVA: 0x30CB130 Offset: 0x30CB231 VA: 0x30CB130
	|-CapabilityBase<short>.set_Quick
	|
	|-RVA: 0x30CC6D0 Offset: 0x30CC7D1 VA: 0x30CC6D0
	|-CapabilityBase<int>.set_Quick
	|
	|-RVA: 0x30CDDE0 Offset: 0x30CDEE1 VA: 0x30CDDE0
	|-CapabilityBase<object>.set_Quick
	|
	|-RVA: 0x30CF380 Offset: 0x30CF481 VA: 0x30CF380
	|-CapabilityBase<sbyte>.set_Quick
	|
	|-RVA: 0x30D08D0 Offset: 0x30D09D1 VA: 0x30D08D0
	|-CapabilityBase<float>.set_Quick
	*/

	// RVA: -1 Offset: -1
	public T get_Luck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9BC0 Offset: 0x30C9CC1 VA: 0x30C9BC0
	|-CapabilityBase<byte>.get_Luck
	|
	|-RVA: 0x30CB160 Offset: 0x30CB261 VA: 0x30CB160
	|-CapabilityBase<short>.get_Luck
	|
	|-RVA: 0x30CC700 Offset: 0x30CC801 VA: 0x30CC700
	|-CapabilityBase<int>.get_Luck
	|
	|-RVA: 0x30CDE10 Offset: 0x30CDF11 VA: 0x30CDE10
	|-CapabilityBase<object>.get_Luck
	|
	|-RVA: 0x30CF3B0 Offset: 0x30CF4B1 VA: 0x30CF3B0
	|-CapabilityBase<sbyte>.get_Luck
	|
	|-RVA: 0x30D0900 Offset: 0x30D0A01 VA: 0x30D0900
	|-CapabilityBase<float>.get_Luck
	*/

	// RVA: -1 Offset: -1
	public void set_Luck(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9BF0 Offset: 0x30C9CF1 VA: 0x30C9BF0
	|-CapabilityBase<byte>.set_Luck
	|
	|-RVA: 0x30CB190 Offset: 0x30CB291 VA: 0x30CB190
	|-CapabilityBase<short>.set_Luck
	|
	|-RVA: 0x30CC730 Offset: 0x30CC831 VA: 0x30CC730
	|-CapabilityBase<int>.set_Luck
	|
	|-RVA: 0x30CDE40 Offset: 0x30CDF41 VA: 0x30CDE40
	|-CapabilityBase<object>.set_Luck
	|
	|-RVA: 0x30CF3E0 Offset: 0x30CF4E1 VA: 0x30CF3E0
	|-CapabilityBase<sbyte>.set_Luck
	|
	|-RVA: 0x30D0930 Offset: 0x30D0A31 VA: 0x30D0930
	|-CapabilityBase<float>.set_Luck
	*/

	// RVA: -1 Offset: -1
	public T get_Def() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9C20 Offset: 0x30C9D21 VA: 0x30C9C20
	|-CapabilityBase<byte>.get_Def
	|
	|-RVA: 0x30CB1C0 Offset: 0x30CB2C1 VA: 0x30CB1C0
	|-CapabilityBase<short>.get_Def
	|
	|-RVA: 0x30CC760 Offset: 0x30CC861 VA: 0x30CC760
	|-CapabilityBase<int>.get_Def
	|
	|-RVA: 0x30CDE70 Offset: 0x30CDF71 VA: 0x30CDE70
	|-CapabilityBase<object>.get_Def
	|
	|-RVA: 0x30CF410 Offset: 0x30CF511 VA: 0x30CF410
	|-CapabilityBase<sbyte>.get_Def
	|
	|-RVA: 0x30D0960 Offset: 0x30D0A61 VA: 0x30D0960
	|-CapabilityBase<float>.get_Def
	*/

	// RVA: -1 Offset: -1
	public void set_Def(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9C50 Offset: 0x30C9D51 VA: 0x30C9C50
	|-CapabilityBase<byte>.set_Def
	|
	|-RVA: 0x30CB1F0 Offset: 0x30CB2F1 VA: 0x30CB1F0
	|-CapabilityBase<short>.set_Def
	|
	|-RVA: 0x30CC790 Offset: 0x30CC891 VA: 0x30CC790
	|-CapabilityBase<int>.set_Def
	|
	|-RVA: 0x30CDEA0 Offset: 0x30CDFA1 VA: 0x30CDEA0
	|-CapabilityBase<object>.set_Def
	|
	|-RVA: 0x30CF440 Offset: 0x30CF541 VA: 0x30CF440
	|-CapabilityBase<sbyte>.set_Def
	|
	|-RVA: 0x30D0990 Offset: 0x30D0A91 VA: 0x30D0990
	|-CapabilityBase<float>.set_Def
	*/

	// RVA: -1 Offset: -1
	public T get_Magic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9C80 Offset: 0x30C9D81 VA: 0x30C9C80
	|-CapabilityBase<byte>.get_Magic
	|
	|-RVA: 0x30CB220 Offset: 0x30CB321 VA: 0x30CB220
	|-CapabilityBase<short>.get_Magic
	|
	|-RVA: 0x30CC7C0 Offset: 0x30CC8C1 VA: 0x30CC7C0
	|-CapabilityBase<int>.get_Magic
	|
	|-RVA: 0x30CDED0 Offset: 0x30CDFD1 VA: 0x30CDED0
	|-CapabilityBase<object>.get_Magic
	|
	|-RVA: 0x30CF470 Offset: 0x30CF571 VA: 0x30CF470
	|-CapabilityBase<sbyte>.get_Magic
	|
	|-RVA: 0x30D09C0 Offset: 0x30D0AC1 VA: 0x30D09C0
	|-CapabilityBase<float>.get_Magic
	*/

	// RVA: -1 Offset: -1
	public void set_Magic(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9CB0 Offset: 0x30C9DB1 VA: 0x30C9CB0
	|-CapabilityBase<byte>.set_Magic
	|
	|-RVA: 0x30CB250 Offset: 0x30CB351 VA: 0x30CB250
	|-CapabilityBase<short>.set_Magic
	|
	|-RVA: 0x30CC7F0 Offset: 0x30CC8F1 VA: 0x30CC7F0
	|-CapabilityBase<int>.set_Magic
	|
	|-RVA: 0x30CDF00 Offset: 0x30CE001 VA: 0x30CDF00
	|-CapabilityBase<object>.set_Magic
	|
	|-RVA: 0x30CF4A0 Offset: 0x30CF5A1 VA: 0x30CF4A0
	|-CapabilityBase<sbyte>.set_Magic
	|
	|-RVA: 0x30D09F0 Offset: 0x30D0AF1 VA: 0x30D09F0
	|-CapabilityBase<float>.set_Magic
	*/

	// RVA: -1 Offset: -1
	public T get_Mdef() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9CE0 Offset: 0x30C9DE1 VA: 0x30C9CE0
	|-CapabilityBase<byte>.get_Mdef
	|
	|-RVA: 0x30CB280 Offset: 0x30CB381 VA: 0x30CB280
	|-CapabilityBase<short>.get_Mdef
	|
	|-RVA: 0x30CC820 Offset: 0x30CC921 VA: 0x30CC820
	|-CapabilityBase<int>.get_Mdef
	|
	|-RVA: 0x30CDF30 Offset: 0x30CE031 VA: 0x30CDF30
	|-CapabilityBase<object>.get_Mdef
	|
	|-RVA: 0x30CF4D0 Offset: 0x30CF5D1 VA: 0x30CF4D0
	|-CapabilityBase<sbyte>.get_Mdef
	|
	|-RVA: 0x30D0A20 Offset: 0x30D0B21 VA: 0x30D0A20
	|-CapabilityBase<float>.get_Mdef
	*/

	// RVA: -1 Offset: -1
	public void set_Mdef(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9D10 Offset: 0x30C9E11 VA: 0x30C9D10
	|-CapabilityBase<byte>.set_Mdef
	|
	|-RVA: 0x30CB2B0 Offset: 0x30CB3B1 VA: 0x30CB2B0
	|-CapabilityBase<short>.set_Mdef
	|
	|-RVA: 0x30CC850 Offset: 0x30CC951 VA: 0x30CC850
	|-CapabilityBase<int>.set_Mdef
	|
	|-RVA: 0x30CDF60 Offset: 0x30CE061 VA: 0x30CDF60
	|-CapabilityBase<object>.set_Mdef
	|
	|-RVA: 0x30CF500 Offset: 0x30CF601 VA: 0x30CF500
	|-CapabilityBase<sbyte>.set_Mdef
	|
	|-RVA: 0x30D0A50 Offset: 0x30D0B51 VA: 0x30D0A50
	|-CapabilityBase<float>.set_Mdef
	*/

	// RVA: -1 Offset: -1
	public T get_Phys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9D40 Offset: 0x30C9E41 VA: 0x30C9D40
	|-CapabilityBase<byte>.get_Phys
	|
	|-RVA: 0x30CB2E0 Offset: 0x30CB3E1 VA: 0x30CB2E0
	|-CapabilityBase<short>.get_Phys
	|
	|-RVA: 0x30CC880 Offset: 0x30CC981 VA: 0x30CC880
	|-CapabilityBase<int>.get_Phys
	|
	|-RVA: 0x30CDF90 Offset: 0x30CE091 VA: 0x30CDF90
	|-CapabilityBase<object>.get_Phys
	|
	|-RVA: 0x30CF530 Offset: 0x30CF631 VA: 0x30CF530
	|-CapabilityBase<sbyte>.get_Phys
	|
	|-RVA: 0x30D0A80 Offset: 0x30D0B81 VA: 0x30D0A80
	|-CapabilityBase<float>.get_Phys
	*/

	// RVA: -1 Offset: -1
	public void set_Phys(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9D70 Offset: 0x30C9E71 VA: 0x30C9D70
	|-CapabilityBase<byte>.set_Phys
	|
	|-RVA: 0x30CB310 Offset: 0x30CB411 VA: 0x30CB310
	|-CapabilityBase<short>.set_Phys
	|
	|-RVA: 0x30CC8B0 Offset: 0x30CC9B1 VA: 0x30CC8B0
	|-CapabilityBase<int>.set_Phys
	|
	|-RVA: 0x30CDFC0 Offset: 0x30CE0C1 VA: 0x30CDFC0
	|-CapabilityBase<object>.set_Phys
	|
	|-RVA: 0x30CF560 Offset: 0x30CF661 VA: 0x30CF560
	|-CapabilityBase<sbyte>.set_Phys
	|
	|-RVA: 0x30D0AB0 Offset: 0x30D0BB1 VA: 0x30D0AB0
	|-CapabilityBase<float>.set_Phys
	*/

	// RVA: -1 Offset: -1
	public T get_Sight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9DA0 Offset: 0x30C9EA1 VA: 0x30C9DA0
	|-CapabilityBase<byte>.get_Sight
	|
	|-RVA: 0x30CB340 Offset: 0x30CB441 VA: 0x30CB340
	|-CapabilityBase<short>.get_Sight
	|
	|-RVA: 0x30CC8E0 Offset: 0x30CC9E1 VA: 0x30CC8E0
	|-CapabilityBase<int>.get_Sight
	|
	|-RVA: 0x30CDFF0 Offset: 0x30CE0F1 VA: 0x30CDFF0
	|-CapabilityBase<object>.get_Sight
	|
	|-RVA: 0x30CF590 Offset: 0x30CF691 VA: 0x30CF590
	|-CapabilityBase<sbyte>.get_Sight
	|
	|-RVA: 0x30D0AE0 Offset: 0x30D0BE1 VA: 0x30D0AE0
	|-CapabilityBase<float>.get_Sight
	*/

	// RVA: -1 Offset: -1
	public void set_Sight(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9DD0 Offset: 0x30C9ED1 VA: 0x30C9DD0
	|-CapabilityBase<byte>.set_Sight
	|
	|-RVA: 0x30CB370 Offset: 0x30CB471 VA: 0x30CB370
	|-CapabilityBase<short>.set_Sight
	|
	|-RVA: 0x30CC910 Offset: 0x30CCA11 VA: 0x30CC910
	|-CapabilityBase<int>.set_Sight
	|
	|-RVA: 0x30CE020 Offset: 0x30CE121 VA: 0x30CE020
	|-CapabilityBase<object>.set_Sight
	|
	|-RVA: 0x30CF5C0 Offset: 0x30CF6C1 VA: 0x30CF5C0
	|-CapabilityBase<sbyte>.set_Sight
	|
	|-RVA: 0x30D0B10 Offset: 0x30D0C11 VA: 0x30D0B10
	|-CapabilityBase<float>.set_Sight
	*/

	// RVA: -1 Offset: -1
	public T get_Move() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9E00 Offset: 0x30C9F01 VA: 0x30C9E00
	|-CapabilityBase<byte>.get_Move
	|
	|-RVA: 0x30CB3A0 Offset: 0x30CB4A1 VA: 0x30CB3A0
	|-CapabilityBase<short>.get_Move
	|
	|-RVA: 0x30CC940 Offset: 0x30CCA41 VA: 0x30CC940
	|-CapabilityBase<int>.get_Move
	|
	|-RVA: 0x30CE050 Offset: 0x30CE151 VA: 0x30CE050
	|-CapabilityBase<object>.get_Move
	|
	|-RVA: 0x30CF5F0 Offset: 0x30CF6F1 VA: 0x30CF5F0
	|-CapabilityBase<sbyte>.get_Move
	|
	|-RVA: 0x30D0B40 Offset: 0x30D0C41 VA: 0x30D0B40
	|-CapabilityBase<float>.get_Move
	*/

	// RVA: -1 Offset: -1
	public void set_Move(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9E30 Offset: 0x30C9F31 VA: 0x30C9E30
	|-CapabilityBase<byte>.set_Move
	|
	|-RVA: 0x30CB3D0 Offset: 0x30CB4D1 VA: 0x30CB3D0
	|-CapabilityBase<short>.set_Move
	|
	|-RVA: 0x30CC970 Offset: 0x30CCA71 VA: 0x30CC970
	|-CapabilityBase<int>.set_Move
	|
	|-RVA: 0x30CE080 Offset: 0x30CE181 VA: 0x30CE080
	|-CapabilityBase<object>.set_Move
	|
	|-RVA: 0x30CF620 Offset: 0x30CF721 VA: 0x30CF620
	|-CapabilityBase<sbyte>.set_Move
	|
	|-RVA: 0x30D0B70 Offset: 0x30D0C71 VA: 0x30D0B70
	|-CapabilityBase<float>.set_Move
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C9E60 Offset: 0x30C9F61 VA: 0x30C9E60
	|-CapabilityBase<byte>.Dispose
	|
	|-RVA: 0x30CB400 Offset: 0x30CB501 VA: 0x30CB400
	|-CapabilityBase<short>.Dispose
	|
	|-RVA: 0x30CC9A0 Offset: 0x30CCAA1 VA: 0x30CC9A0
	|-CapabilityBase<int>.Dispose
	|
	|-RVA: 0x30CE0B0 Offset: 0x30CE1B1 VA: 0x30CE0B0
	|-CapabilityBase<object>.Dispose
	|
	|-RVA: 0x30CF650 Offset: 0x30CF751 VA: 0x30CF650
	|-CapabilityBase<sbyte>.Dispose
	|
	|-RVA: 0x30D0BA0 Offset: 0x30D0CA1 VA: 0x30D0BA0
	|-CapabilityBase<float>.Dispose
	*/
}

