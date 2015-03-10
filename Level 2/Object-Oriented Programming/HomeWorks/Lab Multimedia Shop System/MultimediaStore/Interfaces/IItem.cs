﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Interfaces
{
    interface IItem
    {
        string Id { get; set ; }
        string Title { get; set; }
        decimal Price { get; set; }
        List<string> Genres { get; set; }
    }
}
