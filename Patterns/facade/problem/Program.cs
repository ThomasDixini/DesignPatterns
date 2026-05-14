// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Facade Pattern - Problem Example");
Console.WriteLine();

var videoFile = new VideoFile("movie.mp4");

// The client must orchestrate the subsystem calls directly.
var format = videoFile.GetVideoFormat();
Console.WriteLine($"Video format detected: {format}");

var converter = new MP3Converter();
var result = converter.Convert(videoFile);
Console.WriteLine(result);

public class VideoFile
{
    public string FileName { get; }

    public VideoFile(string fileName)
    {
        FileName = fileName;
    }

    public string GetVideoFormat()
    {
        Console.WriteLine($"[VideoSubsystem] Inspecting file {FileName}...");
        return ".mp4";
    }
}

public class MP3Converter
{
    public string Convert(VideoFile videoFile)
    {
        Console.WriteLine($"[AudioSubsystem] Converting audio track from {videoFile.FileName}...");
        return $"Conversion finished: '{videoFile.FileName}' -> .mp3";
    }
}
