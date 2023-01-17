// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B4D0 Offset: 0x3B5D1 VA: 0x3B4D0
public class DynamicArray<T> // TypeDefIndex: 4521
{
	// Fields
	private T[] m_Array; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CA00 Offset: 0x3CB01 VA: 0x3CA00
	private int <size>k__BackingField; // 0x0

	// Properties
	public int size { get; set; }
	public int capacity { get; }
	public T Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D620 Offset: 0x3D721 VA: 0x3D620
	// RVA: -1 Offset: -1
	public int get_size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0
	|-DynamicArray<object>.get_size
	|-DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>.get_size
	|
	|-RVA: 0x2638D60 Offset: 0x2638E61 VA: 0x2638D60
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_size
	|
	|-RVA: 0x2639140 Offset: 0x2639241 VA: 0x2639140
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_size
	|
	|-RVA: 0x26394F0 Offset: 0x26395F1 VA: 0x26394F0
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.get_size
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D630 Offset: 0x3D731 VA: 0x3D630
	// RVA: -1 Offset: -1
	private void set_size(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26389F0 Offset: 0x2638AF1 VA: 0x26389F0
	|-DynamicArray<object>.set_size
	|
	|-RVA: 0x2638D70 Offset: 0x2638E71 VA: 0x2638D70
	|-DynamicArray<RenderGraph.CompiledPassInfo>.set_size
	|
	|-RVA: 0x2639150 Offset: 0x2639251 VA: 0x2639150
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.set_size
	|
	|-RVA: 0x2639500 Offset: 0x2639601 VA: 0x2639500
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.set_size
	*/

	// RVA: -1 Offset: -1
	public int get_capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638A00 Offset: 0x2638B01 VA: 0x2638A00
	|-DynamicArray<object>.get_capacity
	|
	|-RVA: 0x2638D80 Offset: 0x2638E81 VA: 0x2638D80
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_capacity
	|
	|-RVA: 0x2639160 Offset: 0x2639261 VA: 0x2639160
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_capacity
	|
	|-RVA: 0x2639510 Offset: 0x2639611 VA: 0x2639510
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.get_capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638A10 Offset: 0x2638B11 VA: 0x2638A10
	|-DynamicArray<object>..ctor
	|-DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>..ctor
	|
	|-RVA: 0x2638D90 Offset: 0x2638E91 VA: 0x2638D90
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x2639170 Offset: 0x2639271 VA: 0x2639170
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	|
	|-RVA: 0x2639520 Offset: 0x2639621 VA: 0x2639520
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638A90 Offset: 0x2638B91 VA: 0x2638A90
	|-DynamicArray<object>..ctor
	|
	|-RVA: 0x2638E10 Offset: 0x2638F11 VA: 0x2638E10
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x26391F0 Offset: 0x26392F1 VA: 0x26391F0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	|
	|-RVA: 0x26395A0 Offset: 0x26396A1 VA: 0x26395A0
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638B20 Offset: 0x2638C21 VA: 0x2638B20
	|-DynamicArray<object>.Clear
	|-DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>.Clear
	|
	|-RVA: 0x2638EA0 Offset: 0x2638FA1 VA: 0x2638EA0
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Clear
	|
	|-RVA: 0x2639280 Offset: 0x2639381 VA: 0x2639280
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Clear
	|
	|-RVA: 0x2639630 Offset: 0x2639731 VA: 0x2639630
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.Clear
	*/

	// RVA: -1 Offset: -1
	public int Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638B40 Offset: 0x2638C41 VA: 0x2638B40
	|-DynamicArray<object>.Add
	|
	|-RVA: 0x2638EC0 Offset: 0x2638FC1 VA: 0x2638EC0
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Add
	|
	|-RVA: 0x26392A0 Offset: 0x26393A1 VA: 0x26392A0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Add
	|
	|-RVA: 0x2639650 Offset: 0x2639751 VA: 0x2639650
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.Add
	*/

	// RVA: -1 Offset: -1
	public void Resize(int newSize, bool keepContent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638C60 Offset: 0x2638D61 VA: 0x2638C60
	|-DynamicArray<object>.Resize
	|-DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>.Resize
	|
	|-RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Resize
	|
	|-RVA: 0x26393F0 Offset: 0x26394F1 VA: 0x26393F0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Resize
	|
	|-RVA: 0x26397B0 Offset: 0x26398B1 VA: 0x26397B0
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.Resize
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638D20 Offset: 0x2638E21 VA: 0x2638D20
	|-DynamicArray<object>.get_Item
	|-DynamicArray<RenderGraphResourceRegistry.IRenderGraphResource>.get_Item
	|
	|-RVA: 0x2639100 Offset: 0x2639201 VA: 0x2639100
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_Item
	|
	|-RVA: 0x26394B0 Offset: 0x26395B1 VA: 0x26394B0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_Item
	|
	|-RVA: 0x2639870 Offset: 0x2639971 VA: 0x2639870
	|-DynamicArray<RenderGraphResourceRegistry.RendererListResource>.get_Item
	*/
}

