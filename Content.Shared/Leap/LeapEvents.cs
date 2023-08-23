using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.Leap;

[Serializable, NetSerializable]
public sealed partial class LeapFinishEvent : SimpleDoAfterEvent { }
