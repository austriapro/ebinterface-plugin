﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebICommonTestSetup;
using ebIModels.Schema;
using ebIViewModels.ViewModels;
using ebIViewModelsTests.ViewModels;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ebIViewModels.ViewModels.Tests
{
    [TestClass()]
    public class DetailsViewModelsTests : CommonTestSetup
    {
        private readonly Common _common;

        public DetailsViewModelsTests()
        {
            _common = Cmn;
        }


        [TestMethod()]
        public void DetailsViewModelsTest()
        {
            DetailsListConverter det = _common.UContainer.Resolve<DetailsListConverter>();
            var detv = new DetailsViewModel(null, null, false)
            {
                EinzelPreis = 5,
                Menge = 7,
                VatSatz = 20
            };
            // detv.UpdateTotals();
            det.DetailsList.Add(detv);
            var det2 = det.DetailsList[0];
            Assert.AreEqual(det2.NettoBetragZeile, 35);
        }

        [TestMethod()]
        public void GetItemListTest()
        {

        }

        [TestMethod()]
        public void LoadTest()
        {
            _common.Invoice = InvoiceFactory.LoadTemplate(Common.InvTest);
            var det = DetailsListConverter.Load(_common.Invoice.Details.ItemList, _common.UContainer, false);
            Assert.IsNotNull(det);

        }

        [TestMethod]
        public void GetItemLoadRabattTestOk()
        {
            _common.Invoice = InvoiceFactory.LoadTemplate(Common.InvTest);

            var det = DetailsListConverter.Load(_common.Invoice.Details.ItemList, _common.UContainer, false).DetailsList;
            var detList = DetailsListConverter.ConvertToItemList(det, "Z01");
            var det2 = DetailsListConverter.Load(detList, _common.UContainer, false).DetailsList;
            
            Assert.AreEqual(det[0].Rabatt,det2[0].Rabatt);
        }

        [TestMethod]
        public void BestPosNotEmptyTestOk()
        {
            var detail = Cmn.UContainer.Resolve<DetailsViewModel>(new ParameterOverride("bestPosRequired",true));
            detail.ArtikelNr = "100";
            detail.Bezeichnung = "Testartikel";
            detail.Menge = 10;
            detail.Einheit = "STK";
            detail.EinzelPreis = 2000;
            detail.VatSatz = 20;
            detail.BestellBezug = "100";
            detail.SaveCommand.Execute(null);
            Cmn.ListResults(detail.Results);
            Assert.IsTrue(detail.Results.IsValid);
        }
        [TestMethod]
        public void BestPosEmptyTestNotOk()
        {
            var detail = Cmn.UContainer.Resolve<DetailsViewModel>(new ParameterOverride("bestPosRequired", true));
            detail.ArtikelNr = "100";
            detail.Bezeichnung = "Testartikel";
            detail.Menge = 10;
            detail.Einheit = "STK";
            detail.EinzelPreis = 2000;
            detail.VatSatz = 20;
            detail.BestellBezug = "";
            detail.SaveCommand.Execute(null);
            Cmn.ListResults(detail.Results);
            Assert.IsTrue(!detail.Results.IsValid);
        }
        [TestMethod]
        public void BestPosSpacesTestNotOk()
        {
            var detail = Cmn.UContainer.Resolve<DetailsViewModel>(new ParameterOverride("bestPosRequired", true));
            detail.ArtikelNr = "100";
            detail.Bezeichnung = "Testartikel";
            detail.Menge = 10;
            detail.Einheit = "STK";
            detail.EinzelPreis = 2000;
            detail.VatSatz = 20;
            detail.BestellBezug = " ";
            detail.SaveCommand.Execute(null);
            Cmn.ListResults(detail.Results);
            Assert.IsTrue(!detail.Results.IsValid);
        }
        [TestMethod]
        public void BestPosBundAlphaTestNotOk()
        {
            var detail = Cmn.UContainer.Resolve<DetailsViewModel>(new ParameterOverride("bestPosRequired", true));
            detail.ArtikelNr = "100";
            detail.Bezeichnung = "Testartikel";
            detail.Menge = 10;
            detail.Einheit = "STK";
            detail.EinzelPreis = 2000;
            detail.VatSatz = 20;
            detail.BestellBezug = "Abcd";
            detail.SaveCommand.Execute(null);
            Cmn.ListResults(detail.Results);
            Assert.IsTrue(!detail.Results.IsValid);
        }
        [TestMethod]
        public void BestPosWirtschaftAlphaTestOk()
        {
            var detail = Cmn.UContainer.Resolve<DetailsViewModel>(new ParameterOverride("bestPosRequired", false));
            detail.ArtikelNr = "100";
            detail.Bezeichnung = "Testartikel";
            detail.Menge = 10;
            detail.Einheit = "STK";
            detail.EinzelPreis = 2000;
            detail.VatSatz = 20;
            detail.BestellBezug = "Abcd";
            detail.SaveCommand.Execute(null);
            Cmn.ListResults(detail.Results);
            Assert.IsTrue(detail.Results.IsValid);
        }
    }
}
