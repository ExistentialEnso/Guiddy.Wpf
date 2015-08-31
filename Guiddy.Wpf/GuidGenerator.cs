using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiddy.Wpf
{
    public class GuidGenerator
    {
        /// <summary>
        /// Generates a new GUID in string form with options pertaining to formatting.
        /// </summary>
        /// <param name="hyphens">Include hyphens?</param>
        /// <param name="uppercase">Uppercase letters?</param>
        /// <returns></returns>
        public static string Generate(bool hyphens, bool uppercase)
        {
            var guid = Guid.NewGuid().ToString();

            if (!hyphens)
            {
                guid = guid.Replace("-", "");
            }

            guid = (uppercase)
                ? guid.ToUpperInvariant()
                : guid.ToLowerInvariant();

            return guid;
        }
    }
}
