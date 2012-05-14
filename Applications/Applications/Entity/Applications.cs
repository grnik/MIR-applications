using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Web;

namespace ApplicationsMir.DAL
{
    public partial class Applications : EntityObject
    {
        #region Конструктор

        private Applications()
        {
            this.Creating = DateTime.Now;
            this.Login = "Default";
        }

        public Applications(string who, int? room, string phone, string description, int? employeeID, string problem, int statusID, string comment)
            : this()
        {
            this.Who = who;
            this.Room = room;
            if (!String.IsNullOrEmpty(phone))
                this.Phone = phone;
            this.Description = description;
            this.EmployeeID = employeeID;
            this.Problem = problem;
            this.StatusID = statusID;
            if(!String.IsNullOrEmpty(comment))
            this.Comment = comment;
        }

        #endregion
    }
}