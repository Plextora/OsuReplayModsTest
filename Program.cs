using OsuParsers.Decoders;
using OsuParsers.Enums;

var osuReplay = ReplayDecoder.Decode(@"C:\Users\Plextora\Desktop\test.osr"); // osr to edit
var mods = new List<Mods> { Mods.DoubleTime, Mods.Flashlight }; // list of mods to add for replay

osuReplay.Mods = Mods.None; // remove all mods from replay
foreach (var i in mods)
    osuReplay.Mods |= i; // add mods to replay
osuReplay.Save(@"C:\Users\Plextora\Desktop\output.osr"); // edited osr output

Console.ReadLine();