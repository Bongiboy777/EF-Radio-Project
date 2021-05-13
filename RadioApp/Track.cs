using System;
using System.Collections.Generic;
using WMPLib;

#nullable disable

namespace RadioDatabase
{
    public partial class Track : IWMPMedia
    {
        public int? PlayListId { get; set; }
        public string Artist { get; set; }
        public int? GenreId { get; set; }
        public string Name { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual PlayList PlayList { get; set; }


        public bool get_isIdentical(IWMPMedia pIWMPMedia)
        {
            return true;
        }

        public double getMarkerTime(int MarkerNum)
        {
            return 1;
        }

        public string getMarkerName(int MarkerNum)

        {
            return "";
        }
        public string getAttributeName(int lIndex)
        {
            return "";
        }
        public string getItemInfo(string bstrItemName)
        {
            return "";
        }
        public void setItemInfo(string bstrItemName, string bstrVal)
        {

        }

        public string getItemInfoByAtom(int lAtom)
        {
            return "";
        }
        public bool isMemberOf(IWMPPlaylist pPlaylist)
        {
            return true;
        }
        public bool isReadOnlyItem(string bstrItemName)
        {
        return true;
        }

        public string sourceURL { get; }

        public string name { get; set; }

        public int imageSourceWidth { get; }

        public int imageSourceHeight { get; }

        public int markerCount { get; }

        public double duration { get; }

        public string durationString { get; }

        public int attributeCount { get; }
    }
}
