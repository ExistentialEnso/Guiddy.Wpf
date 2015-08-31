using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiddy.Wpf
{
    public class GuidGenerator
    {
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
