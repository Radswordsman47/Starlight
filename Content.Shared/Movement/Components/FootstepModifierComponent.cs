using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Content.Shared.Inventory; // Starlight

namespace Content.Shared.Movement.Components;

/// <summary>
/// Changes footstep sound
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FootstepModifierComponent : Component
{
    [DataField, AutoNetworkedField]
    public SoundSpecifier? FootstepSoundCollection;

    [DataField, AutoNetworkedField] public SlotFlags DisableSlots; // Starlight - If something is in one of these slots, disable this modifier.
}
