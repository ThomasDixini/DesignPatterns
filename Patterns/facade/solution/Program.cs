using solution.Facade;
using solution.ThirdParty.Classes;

var facade = new AudioVisualSystemFacade(new VideoFile(), new MP3Converter());
var output = facade.Convert("movie.mp4");
Console.WriteLine(output);
