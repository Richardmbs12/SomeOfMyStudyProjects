using BusinessLayer.io.customerManagement.enquiries;
using BusinessLayer.io.technicalSupport.schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.technicalSupport.technicalTask
{
    public class TechnicalTask
    {
        public TechnicalTask()
        {

        }
        public TechnicalTask(bool completed, string taskDescription, DateTime taskTime , int trackingNumber)
        {
            Completed = completed;
            TaskDescription = taskDescription;
            TaskTime = taskTime;
            TrackingNumber = trackingNumber;
        }

        public TechnicalTask(bool completed, string taskDescription, DateTime taskTime)
        {
            Completed = completed;
            TaskDescription = taskDescription;
            TaskTime = taskTime;
        }

        public bool Completed { get; set; }
        public string TaskDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime TaskTime { get; set; }

        [ForeignKey("CustomerEnquiry")]
        [Key]
        public int TrackingNumber { get; set; }
        public virtual CustomerEnquiry CustomerEnquiry { get; set; }

        //EF

        
        public int? ScheduleID { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
