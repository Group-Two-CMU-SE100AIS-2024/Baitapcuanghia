﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Baitapcuanghia.Module.BusinessObjects.ORMDataModel1
{

    public partial class Nhacungcap
    {
        public Nhacungcap(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
