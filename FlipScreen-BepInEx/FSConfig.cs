using FaveStack.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace FaveStack
{
    public class FSConfig
    {
        public List<FavoriteObject> list = new();

        public static FSConfig Instance;
        public static void Load()
        {
        }

        public class FavoriteObject
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string ThumbnailImageURL { get; set; }
        }
    }
}
