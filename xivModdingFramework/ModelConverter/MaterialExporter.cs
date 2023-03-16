using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xivModdingFramework.Cache;
using xivModdingFramework.General.Enums;
using xivModdingFramework.Materials.FileTypes;
using xivModdingFramework.Models.DataContainers;
using xivModdingFramework.Models.ModelTextures;
using xivModdingFramework.Textures.FileTypes;

namespace xivModdingFramework.ModelConverter
{
    public class MaterialExporter
    {
       /* /// <summary>
        /// Retrieves and exports the materials for the current model, to be used alongside ExportModel
        /// </summary>
        public static async Task ExportMaterialsForModel(TTModel model, string basePath, string outputFilePath, int mtrlVariant = 1, XivRace targetRace = XivRace.All_Races)
        {
            var modelName = Path.GetFileNameWithoutExtension(model.Source);
            var directory = Path.GetDirectoryName(outputFilePath);

            // Language doesn't actually matter here.
            var _mtrl = new Mtrl(XivCache.GameInfo.GameDirectory);
            var materialIdx = 0;


            foreach (var materialName in model.Materials)
            {
                try
                {
                    var mdlPath = model.Source;

                    // Set source race to match so that it doesn't get replaced
                    if (targetRace != XivRace.All_Races)
                    {
                        var bodyRegex = new Regex("(b[0-9]{4})");
                        var faceRegex = new Regex("(f[0-9]{4})");
                        var tailRegex = new Regex("(t[0-9]{4})");

                        if (bodyRegex.Match(materialName).Success)
                        {
                            var currentRace = model.Source.Substring(model.Source.LastIndexOf('c') + 1, 4);
                            mdlPath = model.Source.Replace(currentRace, targetRace.GetRaceCode());
                        }

                        var faceMatch = faceRegex.Match(materialName);
                        if (faceMatch.Success)
                        {
                            var mdlFace = faceRegex.Match(model.Source).Value;

                            mdlPath = model.Source.Replace(mdlFace, faceMatch.Value);
                        }

                        var tailMatch = tailRegex.Match(materialName);
                        if (tailMatch.Success)
                        {
                            var mdlTail = tailRegex.Match(model.Source).Value;

                            mdlPath = model.Source.Replace(mdlTail, tailMatch.Value);
                        }
                    }

                    // This messy sequence is ultimately to get access to _modelMaps.GetModelMaps().
                    var mtrlPath = Mtrl.GetMtrlPath(mdlPath, materialName, mtrlVariant);
                    var mtrl = await _mtrl.GetMtrlData(Path.Combine(basePath, mtrlPath), mtrlPath, 11);
                    var modelMaps = await ModelTexture.GetModelMaps(gameDirectory, mtrl);

                    // Outgoing file names.
                    var mtrl_prefix = directory + "\\" + Path.GetFileNameWithoutExtension(materialName.Substring(1)) + "_";
                    var mtrl_suffix = ".png";

                    if (modelMaps.Diffuse != null && modelMaps.Diffuse.Length > 0)
                    {
                        using (Image<Rgba32> img = Image.LoadPixelData<Rgba32>(modelMaps.Diffuse, modelMaps.Width, modelMaps.Height))
                        {
                            img.Save(mtrl_prefix + "d" + mtrl_suffix, new PngEncoder());
                        }
                    }

                    if (modelMaps.Normal != null && modelMaps.Diffuse.Length > 0)
                    {
                        using (Image<Rgba32> img = Image.LoadPixelData<Rgba32>(modelMaps.Normal, modelMaps.Width, modelMaps.Height))
                        {
                            img.Save(mtrl_prefix + "n" + mtrl_suffix, new PngEncoder());
                        }
                    }

                    if (modelMaps.Specular != null && modelMaps.Diffuse.Length > 0)
                    {
                        using (Image<Rgba32> img = Image.LoadPixelData<Rgba32>(modelMaps.Specular, modelMaps.Width, modelMaps.Height))
                        {
                            img.Save(mtrl_prefix + "s" + mtrl_suffix, new PngEncoder());
                        }
                    }

                    if (modelMaps.Alpha != null && modelMaps.Diffuse.Length > 0)
                    {
                        using (Image<Rgba32> img = Image.LoadPixelData<Rgba32>(modelMaps.Alpha, modelMaps.Width, modelMaps.Height))
                        {
                            img.Save(mtrl_prefix + "o" + mtrl_suffix, new PngEncoder());
                        }
                    }

                    if (modelMaps.Emissive != null && modelMaps.Diffuse.Length > 0)
                    {
                        using (Image<Rgba32> img = Image.LoadPixelData<Rgba32>(modelMaps.Emissive, modelMaps.Width, modelMaps.Height))
                        {
                            img.Save(mtrl_prefix + "e" + mtrl_suffix, new PngEncoder());
                        }
                    }

                }
                catch (Exception exc)
                {
                    // Failing to resolve a material is considered a non-critical error.
                    // Continue attempting to resolve the rest of the materials in the model.
                    //throw exc;
                }
                materialIdx++;
            }
        }*/
    }
}
