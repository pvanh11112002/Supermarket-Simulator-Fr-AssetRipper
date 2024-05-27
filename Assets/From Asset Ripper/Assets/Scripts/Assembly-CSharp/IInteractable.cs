public interface IInteractable
{
	InteractactableType Type { get; }

	bool ContinousInteraction { get; }

	InteractionType InteractionType { get; }

	string InstantInteractionHint { get; }

	string HoldingInteractionHint { get; }

	bool InstantInteract();

	bool HoldingInteract();
}
