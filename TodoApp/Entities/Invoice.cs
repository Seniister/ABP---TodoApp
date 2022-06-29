using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace BasicAspNetCoreApplication.Entities
{
    public class Invoice : AggregateRoot<Guid>
    {
        public DateTime Date { get; set; }
        public string? ImgUrl { get; set; }
        public string? FileUrl { get; set; }
        public bool Refundable { get; set; }
        public virtual List<InvoiceItem> InvoiceItems { get; set; }
        public InvoiceType Type { get; set; }
        public enum InvoiceType
        {
            Type1,
            Type2,
            Type3,
        }

        protected Invoice()
        {

        }
        public Invoice(Guid id, DateTime dateTime, string? imgUrl, string? fileUrl, bool refundable, InvoiceType type)
        {
            Id = id;
            Date = dateTime;
            ImgUrl = imgUrl;
            FileUrl = fileUrl;
            Refundable = refundable;
            Type = type;

            InvoiceItems = new List<InvoiceItem>();
        }

        public void AddItem(string name, double price)
        {
            InvoiceItems.Add(new InvoiceItem(this.Id, name, price));
        }
    }


    
}

