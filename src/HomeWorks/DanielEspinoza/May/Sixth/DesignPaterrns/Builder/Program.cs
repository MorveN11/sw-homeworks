using System;
using System.Collections.Generic;


namespace BuilderDesignPattern{

class Presentation
{
    public List<string> slides { get; set; }
    public string theme { get; set; }
    public string transition { get; set; }
    public string multimedia { get; set; }

 public void Show()
{
    Console.WriteLine("Presentation:");
    Console.WriteLine($"Theme: {theme ?? "Not specified"}");
    Console.WriteLine($"Transition: {transition ?? "Not specified"}");
    Console.WriteLine($"Multimedia: {multimedia ?? "Not specified"}");
    Console.WriteLine("Slides:");

    if (slides != null)
    {
        foreach (var slide in slides)
        {
            Console.WriteLine(slide);
        }
    }
    else
    {
        Console.WriteLine("No slides available");
    }
}
}

class PresentationBuilder
{
    private Presentation _presentation = new Presentation();

    public PresentationBuilder SelectSlides(List<string> slides)
    {
        _presentation.slides = slides;
        return this;
    }

    public PresentationBuilder SelectTheme(string theme)
    {
        _presentation.theme = theme;
        return this;
    }

    public PresentationBuilder SelectTransition(string transition)
    {
        _presentation.transition = transition;
        return this;
    }

    public PresentationBuilder SelectMultimedia(string multimedia)
    {
        _presentation.multimedia = multimedia;
        return this;
    }

    public Presentation Build()
    {
        return _presentation;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var customPresentation = new PresentationBuilder()
            .SelectSlides(new List<string> { "Introduction", "Development", "Conclusion" })
            .SelectTheme("Blue Theme")
            .SelectTransition("Slide")
            .SelectMultimedia("Video")
            .Build();

        customPresentation.Show();
    }
}

}
