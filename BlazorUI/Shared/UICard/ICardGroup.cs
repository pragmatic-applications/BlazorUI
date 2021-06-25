namespace BlazorUI.Shared.UICard
{
  public interface ICardGroup
  {
    void AddCard(Card card);
    void ChildStateChanged();
  }
}
