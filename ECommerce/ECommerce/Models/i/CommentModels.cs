﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Models.i
{
    public class CommentModels
    {
        public List<DB.Comments> Comments { get; set; }
        public DB.Products Product { get; set; }
        
    }
}