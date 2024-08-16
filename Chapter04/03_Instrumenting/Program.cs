using System.Diagnostics;
using Microsoft.Extensions.Configuration;

// запись в текстовый файл, расположенный в папке проекта
Trace.Listeners.Add(new TextWriterTraceListener(
File.CreateText(Path.Combine(Environment.GetFolderPath(
Environment.SpecialFolder.DesktopDirectory), "log.txt"))));
// модуль записи текста буферизируется, поэтому данная опция
// вызывает функцию Flush() для всех прослушивателей после записи
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");




ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");
configuration.GetSection("PacktSwitch").Bind(ts);
Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");