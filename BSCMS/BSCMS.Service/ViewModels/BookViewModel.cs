﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Service.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string FileName { get; set; }
    }
}
