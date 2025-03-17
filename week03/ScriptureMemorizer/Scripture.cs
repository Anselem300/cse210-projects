public class Scripture {
   private Reference _reference;
   private List<Word> _Words = new List<Word>();

   public Scripture(Reference reference, string text)
   {
    _reference = reference;
    _Words.Add(new Word(text));
   }

   public void HideRandomWords(int numberToHide)
   {

   }

   public string GetDisplayText()
   {
    return "";
   }

   public bool IsCompletelyHidden()
   {
      return true;
   }

}