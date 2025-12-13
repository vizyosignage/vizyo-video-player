using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizyo.Video.Player.Services;

namespace Vizyo.Video.Player.Desktop
{
    internal class UriResolver : IUriResolver
    {
        public string? GetRealPath(Uri uri)
        {
            return uri.LocalPath;
        }
    }
}
