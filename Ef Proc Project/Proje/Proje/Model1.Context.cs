﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProcProjeDbEntities : DbContext
    {
        public ProcProjeDbEntities()
            : base("name=ProcProjeDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calisans> Calisans { get; set; }
        public virtual DbSet<Hizmetlers> Hizmetlers { get; set; }
        public virtual DbSet<Musterilers> Musterilers { get; set; }
        public virtual DbSet<Taleps> Taleps { get; set; }
    
        public virtual int Calisan_add(string kulAd, string sifre)
        {
            var kulAdParameter = kulAd != null ?
                new ObjectParameter("kulAd", kulAd) :
                new ObjectParameter("kulAd", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("sifre", sifre) :
                new ObjectParameter("sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Calisan_add", kulAdParameter, sifreParameter);
        }
    
        public virtual ObjectResult<Calisanlogin_Result> Calisanlogin(string kulAd, string sifre)
        {
            var kulAdParameter = kulAd != null ?
                new ObjectParameter("kulAd", kulAd) :
                new ObjectParameter("kulAd", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("sifre", sifre) :
                new ObjectParameter("sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Calisanlogin_Result>("Calisanlogin", kulAdParameter, sifreParameter);
        }
    
        public virtual int hizmet_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("hizmet_Select");
        }
    
        public virtual int Hizmetler_add(string hizmetAdi, string hizmetTanimi, Nullable<int> hizmetFiyat)
        {
            var hizmetAdiParameter = hizmetAdi != null ?
                new ObjectParameter("hizmetAdi", hizmetAdi) :
                new ObjectParameter("hizmetAdi", typeof(string));
    
            var hizmetTanimiParameter = hizmetTanimi != null ?
                new ObjectParameter("hizmetTanimi", hizmetTanimi) :
                new ObjectParameter("hizmetTanimi", typeof(string));
    
            var hizmetFiyatParameter = hizmetFiyat.HasValue ?
                new ObjectParameter("hizmetFiyat", hizmetFiyat) :
                new ObjectParameter("hizmetFiyat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Hizmetler_add", hizmetAdiParameter, hizmetTanimiParameter, hizmetFiyatParameter);
        }
    
        public virtual int Hizmetler_Del(Nullable<int> hizmetNo)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Hizmetler_Del", hizmetNoParameter);
        }
    
        public virtual int Hizmetler_up(Nullable<int> hizmetNo, string hizmetAdi, string hizmetTanimi, Nullable<int> hizmetFiyat)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("hizmetNo", hizmetNo) :
                new ObjectParameter("hizmetNo", typeof(int));
    
            var hizmetAdiParameter = hizmetAdi != null ?
                new ObjectParameter("hizmetAdi", hizmetAdi) :
                new ObjectParameter("hizmetAdi", typeof(string));
    
            var hizmetTanimiParameter = hizmetTanimi != null ?
                new ObjectParameter("hizmetTanimi", hizmetTanimi) :
                new ObjectParameter("hizmetTanimi", typeof(string));
    
            var hizmetFiyatParameter = hizmetFiyat.HasValue ?
                new ObjectParameter("hizmetFiyat", hizmetFiyat) :
                new ObjectParameter("hizmetFiyat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Hizmetler_up", hizmetNoParameter, hizmetAdiParameter, hizmetTanimiParameter, hizmetFiyatParameter);
        }
    
        public virtual int Mus_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Mus_Select");
        }
    
        public virtual int Musteri_add(string adSoyad, string telefon, string mail, string adres)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Musteri_add", adSoyadParameter, telefonParameter, mailParameter, adresParameter);
        }
    
        public virtual int Musteriler_del(Nullable<int> musteriNo)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("musteriNo", musteriNo) :
                new ObjectParameter("musteriNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Musteriler_del", musteriNoParameter);
        }
    
        public virtual int Musteriler_up(Nullable<int> musteriNo, string adSoyad, string telefon, string mail, string adres)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Musteriler_up", musteriNoParameter, adSoyadParameter, telefonParameter, mailParameter, adresParameter);
        }
    
        public virtual ObjectResult<CalisanKulAdKONTROL_Result> CalisanKulAdKONTROL(string kulAd)
        {
            var kulAdParameter = kulAd != null ?
                new ObjectParameter("kulAd", kulAd) :
                new ObjectParameter("kulAd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CalisanKulAdKONTROL_Result>("CalisanKulAdKONTROL", kulAdParameter);
        }
    
        public virtual ObjectResult<MusteriList_Result> MusteriList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusteriList_Result>("MusteriList");
        }
    
        public virtual int Siparisler_add(string siparisAdi, Nullable<int> musteriNo, string adres, string aciklama)
        {
            var siparisAdiParameter = siparisAdi != null ?
                new ObjectParameter("siparisAdi", siparisAdi) :
                new ObjectParameter("siparisAdi", typeof(string));
    
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("musteriNo", musteriNo) :
                new ObjectParameter("musteriNo", typeof(int));
    
            var adresParameter = adres != null ?
                new ObjectParameter("adres", adres) :
                new ObjectParameter("adres", typeof(string));
    
            var aciklamaParameter = aciklama != null ?
                new ObjectParameter("aciklama", aciklama) :
                new ObjectParameter("aciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Siparisler_add", siparisAdiParameter, musteriNoParameter, adresParameter, aciklamaParameter);
        }
    
        public virtual int Siparisler_del(Nullable<int> siparisNo)
        {
            var siparisNoParameter = siparisNo.HasValue ?
                new ObjectParameter("siparisNo", siparisNo) :
                new ObjectParameter("siparisNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Siparisler_del", siparisNoParameter);
        }
    
        public virtual int Siparisler_up(Nullable<int> siparisNo, string siparisAdi, Nullable<int> musteriNo, string adres, string aciklama)
        {
            var siparisNoParameter = siparisNo.HasValue ?
                new ObjectParameter("siparisNo", siparisNo) :
                new ObjectParameter("siparisNo", typeof(int));
    
            var siparisAdiParameter = siparisAdi != null ?
                new ObjectParameter("siparisAdi", siparisAdi) :
                new ObjectParameter("siparisAdi", typeof(string));
    
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("musteriNo", musteriNo) :
                new ObjectParameter("musteriNo", typeof(int));
    
            var adresParameter = adres != null ?
                new ObjectParameter("adres", adres) :
                new ObjectParameter("adres", typeof(string));
    
            var aciklamaParameter = aciklama != null ?
                new ObjectParameter("aciklama", aciklama) :
                new ObjectParameter("aciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Siparisler_up", siparisNoParameter, siparisAdiParameter, musteriNoParameter, adresParameter, aciklamaParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<HizmetlerList_Result> HizmetlerList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HizmetlerList_Result>("HizmetlerList");
        }
    
        public virtual int TalepAdd(Nullable<int> hizmetNo, Nullable<int> musteriNo, string musteriNot, Nullable<bool> talepDurumu)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            var musteriNotParameter = musteriNot != null ?
                new ObjectParameter("MusteriNot", musteriNot) :
                new ObjectParameter("MusteriNot", typeof(string));
    
            var talepDurumuParameter = talepDurumu.HasValue ?
                new ObjectParameter("TalepDurumu", talepDurumu) :
                new ObjectParameter("TalepDurumu", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TalepAdd", hizmetNoParameter, musteriNoParameter, musteriNotParameter, talepDurumuParameter);
        }
    
        public virtual ObjectResult<TalepList_Result> TalepList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TalepList_Result>("TalepList");
        }
    
        public virtual int TalepDel(Nullable<int> talepNo)
        {
            var talepNoParameter = talepNo.HasValue ?
                new ObjectParameter("TalepNo", talepNo) :
                new ObjectParameter("TalepNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TalepDel", talepNoParameter);
        }
    
        public virtual int TalepUpdate(Nullable<int> talepNo, Nullable<int> hizmetNo, Nullable<int> musteriNo, string musteriNot, Nullable<bool> talepDurumu)
        {
            var talepNoParameter = talepNo.HasValue ?
                new ObjectParameter("TalepNo", talepNo) :
                new ObjectParameter("TalepNo", typeof(int));
    
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            var musteriNotParameter = musteriNot != null ?
                new ObjectParameter("MusteriNot", musteriNot) :
                new ObjectParameter("MusteriNot", typeof(string));
    
            var talepDurumuParameter = talepDurumu.HasValue ?
                new ObjectParameter("TalepDurumu", talepDurumu) :
                new ObjectParameter("TalepDurumu", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TalepUpdate", talepNoParameter, hizmetNoParameter, musteriNoParameter, musteriNotParameter, talepDurumuParameter);
        }
    }
}