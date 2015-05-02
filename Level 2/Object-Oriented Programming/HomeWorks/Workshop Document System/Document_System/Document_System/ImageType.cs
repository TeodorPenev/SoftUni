using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Document_System
{
    public class ImageType
    {
        public string Type { get; private set; }
        public string Name { get; set; }

        public static ImageType Png { get { return new ImageType("png"); } }
        public static ImageType Gif { get { return new ImageType("gif"); } }
        public static ImageType Jpeg { get { return new ImageType("jpeg"); } }

        public string ContentType
        {
            get
            {
                return "image/" + this.Name;
            }
        }

        public ImageType(string name)
        {
            this.Name = name;
        }


        internal static ImageType CreateFromFileName(string fileName)
          {
              string fileExtension = new FileInfo(fileName).Extension;
              switch (fileExtension.ToLower())
              {
                  case".png":
                      return ImageType.Png;
                  case".gif":
                      return ImageType.Gif;
                  case".jpg":
                  case".jpeg":
                      return ImageType.Jpeg;
              }
              throw new NotSupportedException("Image type " + fileExtension + " is not supported!");
          }
    }
}
