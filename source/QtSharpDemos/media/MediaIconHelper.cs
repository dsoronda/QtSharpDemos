using QtGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.media
{
    /// <summary>
    /// Helper class that loads icons from disk
    /// </summary>
    public static class MediaIconHelper
    {
        // load icons
        // all icons in project should have "Copy to Output Directory" set to Copy...;

        public const string MediaPath = @"media\icons";
        public static readonly QIcon NewDocumentIcon = new QIcon($@"{MediaPath}\document-new.png");
        public static readonly QIcon OpenDocumentIcon = new QIcon($@"{MediaPath}\document-open.png");
        public static readonly QIcon SystemLogOugIcon = new QIcon($@"{MediaPath}\system-log-out.png");
        public static readonly QIcon PreferencesSystemIcon = new QIcon($@"{MediaPath}\preferences-system.png");
        public static readonly QIcon PackageGenericIcon = new QIcon($@"{MediaPath}\package-x-generic.png");
    }
}
