using BusinessLayer.io.employeeManagement.technicalSupportManagementEmployee;
using BusinessLayer.io.technicalSupport.technicalTask;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.technicalSupport.schedule
{
    public class Schedule
    {
        public Schedule()
        {

        }
        public Schedule(DateTime scheduleDate, int scheduleID, List<TechnicalTask> tasks
            , TechnicalSupportManagementEmployee technicalSupportEmployee)
        {
            ScheduleDate = scheduleDate;
            ScheduleID = scheduleID;
            Tasks = tasks;
            TechnicalSupportEmployee = technicalSupportEmployee;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime ScheduleDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ScheduleID { get; set; }
        //EF
        public virtual List<TechnicalTask> Tasks { get; set; }
        public string ID { get; set; }
        public TechnicalSupportManagementEmployee TechnicalSupportEmployee { get; set; }
    }
}
