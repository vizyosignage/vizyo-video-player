using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizyo.Video.Player.Services
{
    public interface IUriResolver
    {
        string? GetRealPath(Uri uri);
    }
}
