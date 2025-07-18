using System.Data.Common;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // set to show word 
    }

    public void Hide()
    {
        _isHidden = true; //hide 
    }

    public void Show()
    {
        _isHidden = false; //show 
    }

    public bool IsHidden()
    {
        return _isHidden; 
    }

    public string GetDisplayText()
    {
        if (_isHidden) // if is true
        {
            string word = "";
            for (int i = 0; i < _text.Length; i++) // _ per character in word 
            {
                word += "_";
            }
            return word;
        }
        else
        {
            return _text;
        }
    }
}