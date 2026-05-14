# Explanation

This example demonstrates the problem of a client having to orchestrate multiple audio and video subsystems directly to convert a file.
The solution does not use a Facade yet, so the client remains exposed to internal details and the exact flow of subsystem calls.

### Problem

The client must know the exact subsystem calls to perform the conversion:
- check the video file format
- prepare the audio stream
- convert the audio to MP3

Without a Facade, the client code becomes coupled to the process and to each subsystem API.
That makes the conversion logic harder to maintain, reuse, and evolve.

### Solution

With a Facade, we can encapsulate these operations behind a single unified interface.
The client only provides the file name to the Facade and does not need to know how many subsystems are involved or the correct order of calls.

In this example:
- `problem/Program.cs` shows the problem implementation, where the client calls `VideoFile` and `MP3Converter` directly
- `solution/Facade/AudioVisualSystemFacade.cs` shows the solution implementation, which hides the conversion details

### When to use

Use Facade when you need to:

- simplify access to a complex or low-level subsystem
- reduce coupling between client code and multiple subsystems
- provide a cleaner, higher-level interface for operations

### When not to use

Do not use Facade when the functionality is already exposed through a simple interface or when there is no clear set of subsystems to unify.
In that case, a Facade would add an unnecessary layer without real benefit.
