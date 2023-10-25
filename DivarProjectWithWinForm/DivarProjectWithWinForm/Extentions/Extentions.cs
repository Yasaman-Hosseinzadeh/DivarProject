using DivarProjectWithWinForm.Enums;
using DivarProjectWithWinForm.Models.Entites;
using DivarProjectWithWinForm.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DivarProjectWithWinForm.Extentions
{
    public static class Extentions
    {
        const string FilewareHouseDicretoty = @"C:\Users\yhosseinzade\source\repos\DivarProject\DivarProjectWithWinForm\DivarProjectWithWinForm\Pictures";
        public static ComboBoxModel ConvertToCategoryModel(this Category category)
        {
            return new ComboBoxModel() { 
                Value = category.Id,
                Name = category.Title
            };
        }

        public static List<ComboBoxModel> ConvertToCategoryModel(this List<Category> categoryList)
        {
            var result = new List<ComboBoxModel>();
            foreach (var category in categoryList)
                result.Add(ConvertToCategoryModel(category));
            return result;
        }

        public static string GetDescription(this Enum value)
        {
            return value.GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description;
        }

        public static List<ComboBoxModel> GetIntactStatusComboBoxData()
        {
            var result = new List<ComboBoxModel>();
            var values = Enum.GetValues(typeof(IntactStatus));
            foreach (IntactStatus item in values)
            {
                result.Add(new ComboBoxModel()
                {
                    Value = (int)item,
                    Name = item.GetDescription()
                });
            }
            return result;
        }

        public static int ConvertToInt(this bool value)
        {
            return value ? 1 : 0;
        }

        public static void SaveImage(string imagePath, int id)
        {
            var detinationFolder = $"{FilewareHouseDicretoty}\\{id}";
            if (!Directory.Exists(detinationFolder)) 
                Directory.CreateDirectory(detinationFolder);
            var detinationFile = $"{detinationFolder}\\{id}.jpg";
            File.Copy(imagePath, detinationFile);
        }

        public static string GetImagePath(int id)
        {
            var imagePath = $"{FilewareHouseDicretoty}\\{id}\\{id}.jpg";
            if (File.Exists(imagePath))
                return imagePath;
            return string.Empty;
        }
    }
}
