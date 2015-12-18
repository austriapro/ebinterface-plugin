﻿using System;
using ebICommonTestSetup;
using ebIModels.Models;
using ebIViewModels.ViewModels;
using ebIViewModels.ViewModels.Tests;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ebIViewModelsTests.ViewModels
{
    [TestClass]
    public class RecipientEmailTests : CommonTestSetup
    {
        [TestMethod]
        public void EmailValidBundTest()
        {
            Cmn.Setup(Common.InvTemplate);   // Test mit Template anfangen
            InvoiceViewModel invoiceView = Cmn.UContainer.Resolve<InvoiceViewModel>(new ParameterOverride("invoice", Cmn.Invoice));
            invoiceView.CurrentSelectedValidation = InvoiceSubtypes.ValidationRuleSet.Government;
            invoiceView.VmBillerMail = "meister@holy-wood.com";
            bool result = invoiceView.IsInvoiceValid();
            Assert.AreEqual(true,result);
        }
        [TestMethod]
        public void EmailEmptyBundTest()
        {
            Cmn.Setup(Common.InvTemplate);   // Test mit Template anfangen
            InvoiceViewModel invoiceView = Cmn.UContainer.Resolve<InvoiceViewModel>(new ParameterOverride("invoice", Cmn.Invoice));
            invoiceView.CurrentSelectedValidation = InvoiceSubtypes.ValidationRuleSet.Government;
            invoiceView.VmBillerMail = "";
            bool result = invoiceView.IsInvoiceValid();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void EmailReceipientEmptyBundTest()
        {
            Cmn.Setup(Common.InvTemplate);   // Test mit Template anfangen
            InvoiceViewModel invoiceView = Cmn.UContainer.Resolve<InvoiceViewModel>(new ParameterOverride("invoice", Cmn.Invoice));
            invoiceView.CurrentSelectedValidation = InvoiceSubtypes.ValidationRuleSet.Government;
            invoiceView.VmRecMail = "";
            bool result = invoiceView.IsInvoiceValid();
            Cmn.ListResults(invoiceView.Results,"Leere eMail");
            Assert.IsTrue(result,"Leere eMail");
            invoiceView.VmRecMail = "willi.mailer@gmx.at";
            result = invoiceView.IsInvoiceValid();
            Cmn.ListResults(invoiceView.Results,"eMail OK");
            Assert.IsTrue(result, "eMail OK");
            invoiceView.VmRecMail = "willi-mailer#gmx.at";
            result = invoiceView.IsInvoiceValid();
            Cmn.ListResults(invoiceView.Results,"eMail falsch");
            Assert.IsFalse(result, "eMail falsch");
        }
        [TestMethod]
        public void EmailInvalidBundTest()
        {
            Cmn.Setup(Common.InvTemplate);   // Test mit Template anfangen
            InvoiceViewModel invoiceView = Cmn.UContainer.Resolve<InvoiceViewModel>(new ParameterOverride("invoice", Cmn.Invoice));
            invoiceView.CurrentSelectedValidation = InvoiceSubtypes.ValidationRuleSet.Government;
            invoiceView.VmBillerMail = "aaaa";
            bool result = invoiceView.IsInvoiceValid();
            Cmn.ListResults(invoiceView.Results, "eMail falsch");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void EmailInvalidNotBundTest()
        {
            Cmn.Setup(Common.InvTemplate);   // Test mit Template anfangen
            InvoiceViewModel invoiceView = Cmn.UContainer.Resolve<InvoiceViewModel>(new ParameterOverride("invoice", Cmn.Invoice));
            invoiceView.CurrentSelectedValidation = InvoiceSubtypes.ValidationRuleSet.Industries;
            invoiceView.VmBillerMail = "aaaa";
            bool result = invoiceView.IsInvoiceValid();
            Cmn.ListResults(invoiceView.Results, "eMail falsch");
            Assert.AreEqual(false, result);
        }
    }
}
