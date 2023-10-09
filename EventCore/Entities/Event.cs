using EventProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class Event : BaseEvent
    {
        [Column(TypeName ="nvarchar(150)")]
        public string EventName { get; set; }

        #region EventDates
        private DateTime _eventStartDate;

        public DateTime EventStartDate
        {
            get { return _eventStartDate; }
            set
            {
                if (DateTime.Now <= value)
                {
                    _eventStartDate = value;
                }
                else
                {
                    throw new Exception("Etkinlik başlangıç tarihi geçmişe yönelik oluşturulamaz.");
                }
            }
        }


        private DateTime _eventEndDate;

        public DateTime EventEndDate
        {
            get { return _eventEndDate; }
            set
            {
                if (_eventStartDate < value)
                {
                    _eventEndDate = value;
                }
                else
                {
                    throw new Exception("Etkinlik bitiş tarihi başlangıç tarihinden önce oluşturulamaz.");
                }
            }
        }
        #endregion

        [Column(TypeName = "nvarchar(50)")]
        public string EventLocation { get; set; }
        public int EventControlAge { get; set; }
        public int EventAttends { get; set; }

        [Column(TypeName="decimal(10,2)")]
        public double EventPrice { get; set; }


        //Ref
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual EventDetail EventDetail { get; set; }
        public virtual IList<Ticket> Tickets { get; set; }
    }
}
