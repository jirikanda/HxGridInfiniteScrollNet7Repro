using ProtoBuf;

namespace Havit.NewProjectTemplate.Contracts;

[ProtoContract]
public class DataFragmentResult<TItem>
{
	[ProtoMember(1)]
	public List<TItem> Data { get; init; } = new(); // ProtoBuf returns empty collections as null

	[ProtoMember(2)]
	public int TotalCount { get; init; }
}
