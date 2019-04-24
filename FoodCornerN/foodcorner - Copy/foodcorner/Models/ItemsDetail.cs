//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace foodcorner.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;


    public partial class ItemsDetail
    {
        public DB22Entities3 db = new DB22Entities3();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemsDetail()
        {
            this.PassOrders = new HashSet<PassOrder>();
            this.PlaceOrders = new HashSet<PlaceOrder>();
        }
    
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Image { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }

        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassOrder> PassOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceOrder> PlaceOrders { get; set; }

        public IEnumerable<ItemsDetail> doctorsspec(int spec)
        {
            var ide = db.ItemsDetails.Where(p => (p.CategoryId == spec));
            return ide;
        }
    }
}
