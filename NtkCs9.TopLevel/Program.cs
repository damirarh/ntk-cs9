using static System.IO.File;
using static System.Console;

var text = await ReadAllTextAsync(args[0]);
WriteLine(text);

unsafe
{
    WriteLine($"size of nint: {sizeof(nint)}");
}
