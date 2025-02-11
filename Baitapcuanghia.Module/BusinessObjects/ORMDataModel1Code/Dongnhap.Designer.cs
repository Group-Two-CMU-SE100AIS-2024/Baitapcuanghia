﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Baitapcuanghia.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("Soluong")]
    public partial class Dongnhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Phieunhap fNhapID;
        [Association(@"DongnhapReferencesPhieunhap")]
        public Phieunhap NhapID
        {
            get { return fNhapID; }
            set { SetPropertyValue<Phieunhap>(nameof(NhapID), ref fNhapID, value); }
        }
        Sanpham fSanphamID;
        [Association(@"DongnhapReferencesSanpham")]
        public Sanpham SanphamID
        {
            get { return fSanphamID; }
            set { SetPropertyValue<Sanpham>(nameof(SanphamID), ref fSanphamID, value); }
        }
        double fSoluong;
        [DevExpress.Xpo.DisplayName(@"Số lượng")]
        public double Soluong
        {
            get { return fSoluong; }
            set { SetPropertyValue<double>(nameof(Soluong), ref fSoluong, value); }
        }
        decimal fDongia;
        [DevExpress.Xpo.DisplayName(@"Đơn giá")]
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")]
        public decimal Dongia
        {
            get { return fDongia; }
            set { SetPropertyValue<decimal>(nameof(Dongia), ref fDongia, value); }
        }
    }

}
