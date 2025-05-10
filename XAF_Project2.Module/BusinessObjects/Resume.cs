using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using XAF_Project2.Module;
using XAF_Project2.Module.BusinessObjects;

namespace XAF_Project2.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    public class Resume : BaseObject
    {
        public Resume(Session session) : base(session) { }
        private Contact contact;
        public Contact Contact
        {
            get
            {
                return contact;
            }
            set
            {
                SetPropertyValue("Contact", ref contact, value);
            }
        }

        [DevExpress.Xpo.Aggregated, Association("Resume-PortfolioFileData")]
        public XPCollection<PortfolioFileData> Portfolio
        {
            get { return GetCollection<PortfolioFileData>("Portfolio"); }
        }
    }
}