﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2WPF.Model.Serializable
{
    [Serializable]
    public class ModelViewFAPIAttributeSerializable
    {
        public string AttrName { get; set; }
        public List<ModelViewFAPIAttributePropertySerializable> VaueProperties { get; set; }
    }
}
