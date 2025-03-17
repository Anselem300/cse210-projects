public class Scripture {
   private Reference _reference;
   private List<Word> _Words = new List<Word>();
   private Random _random;

   public Scripture(Reference reference, string text)
   {
     _reference = reference;
     _Words = text.Split(' ').Select(w => new Word(w)).ToList();
     _random  = new Random();
   }

   public void HideRandomWords(int numberToHide)
   {
    var _visiblewords = _Words.Where(w => ! w.IsHidden()).ToList();
    int _wordsToHide = Math.Min(numberToHide, _visiblewords.Count);

    for (int i = 0; i< _wordsToHide; i++)
    {
        Word _wordToHide = _visiblewords[_random.Next(_visiblewords.Count)];
        _wordToHide.Hide();
    }
   }

   public string GetDisplayText()
   {
    string _scriptureText = string.Join(" ", _Words.Select(w => w.GetDisplayText()));
    return $"{_reference.DisplayReference()}\n{_scriptureText}";
   }

   public bool IsCompletelyHidden()
   {
      return _Words.All(w => w.IsHidden());
   }

}