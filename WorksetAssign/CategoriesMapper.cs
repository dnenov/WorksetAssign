using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksetAssign
{
    internal static class CategoriesMapper
    {
        /// <summary>
        /// Retursn a map of caterory names and categoryIds
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        internal static SortedDictionary<string, Category> getMapper(Document doc)
        {
            SortedDictionary<string, Category> mapper = new SortedDictionary<string, Category>();
            Categories categories = doc.Settings.Categories;

            foreach (Category cat in categories)
            {
                try
                {
                    mapper.Add(cat.Name, cat);
                }
                catch
                {

                }
            }

            return mapper;
        }
        /// <summary>
        /// Returns a list of Subcategories from a categoryId
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="catId"></param>
        /// <returns></returns>
        internal static List<Category> getSubCategories(Document doc, Category cat)
        {
            List<Category> listCat = null;
            var categories = cat.SubCategories;
            if(!categories.IsEmpty)
            {
                listCat = new List<Category>();
                foreach (Category subCat in categories)
                {
                    listCat.Add(subCat);
                }
            }
            return listCat;
        }
    }
}
