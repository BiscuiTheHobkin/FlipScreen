using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(Flip.BuildInfo.Description)]
[assembly: AssemblyDescription(Flip.BuildInfo.Description)]
[assembly: AssemblyCompany(Flip.BuildInfo.Company)]
[assembly: AssemblyProduct(Flip.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Flip.BuildInfo.Author)]
[assembly: AssemblyTrademark(Flip.BuildInfo.Company)]
[assembly: AssemblyVersion(Flip.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Flip.BuildInfo.Version)]
[assembly: MelonInfo(typeof(Flip.FlipScreen), Flip.BuildInfo.Name, Flip.BuildInfo.Version, Flip.BuildInfo.Author, Flip.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]