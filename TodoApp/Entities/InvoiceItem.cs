using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace BasicAspNetCoreApplication.Entities
{
    public class InvoiceItem : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual Guid InoviceId { get; set; }

        internal InvoiceItem(Guid id, Guid InoviceId, string name, double price)
        {
           
            this.InoviceId = InoviceId;
            Name = name;
            Price = price;
        }

        public override object[] GetKeys()
        {
            return new Object[] { Id , InoviceId };
        }
        
    }
}
