using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Document_System
{
     public class ImageType
    {
         public string Type { get; private set; }
         
         public static ImageType Png{get {return new ImageType("png");}}
         public static ImageType Gif{get {return new ImageType("gif");}}
         public static ImageType Jpeg{get {return new ImageType("jpeg");}}
          
         public string ContentType
         {
             get 
             {
                  return "image/"+this.Name;
             }
         }
         
          public ImageType(string name)
         {
            this.Name = name;
         }

    }
}
