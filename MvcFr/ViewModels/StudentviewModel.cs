using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFr.ViewModels
{
    public class StudentviewModel
    {
        private int id;
        private string Name;
        private int Age;
        private string Mobile;
        private string Email;
        private int ClassId;
        private string ClassName;
        private DateTime AddTime;
        private string loge;
        private string pwd;

        public int Id { get => id; set => id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Mobile1 { get => Mobile; set => Mobile = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int ClassId1 { get => ClassId; set => ClassId = value; }
        public DateTime AddTime1 { get => AddTime; set => AddTime = value; }
        public string ClassName1 { get => ClassName; set => ClassName = value; }
        public string Loge { get => loge; set => loge = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}