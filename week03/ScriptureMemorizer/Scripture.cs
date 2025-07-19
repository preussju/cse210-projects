
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference; // gets the value for the reference
        _words = new List<Word>(); //creates a new list

        string[] parts = text.Split(' '); //splits the text by the space " "
        foreach (string word in parts)
        {
            _words.Add(new Word(word)); // adds each split word to the list
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();  // choose a random word to hide text
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            while (_words[index].IsHidden()) // does not repeat the same word
            {
                index = random.Next(_words.Count);
            }
            _words[index].Hide(); // hides the chosen word 
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText()+" "; // prints each word in the list with an space
        }

        Console.Write(_reference.GetDisplayText()); // displays the reference
        return " " + text.Trim(); // display the text with the _ words besides the reference 
    }

    public bool IsCompletelyHidden() //if it is completely hidden closes the program
    {
        foreach (Word word in _words) //checks if each word in the text is hidden
        {
            if (!word.IsHidden())
            {
                return false; //returns false if there is a word still
            }
        }
        return true;
    }
}