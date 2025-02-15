using System;

class Scripture
{
    private string _scriptureText;
    private Reference _scriptureReference;

    public Scripture (Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _scriptureText = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _scriptureText);
    }
}