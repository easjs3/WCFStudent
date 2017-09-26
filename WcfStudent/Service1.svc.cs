using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudent
{



    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }







        public void AddStudent(string name, int alder)
        {
           Student.StudentListe.Add(new Student(){alder = alder, name = name});
        }

        public void EditStudent(string name)
        {
            
        }

        public Student FindStudent(string name)
        {
            return Student.StudentListe.Find(x => x.name == name);
        }

        //ikke sikker på dette er den rigtige metode 
        //kontroll
        //TODO:
        public List<Student> GetAlleStudents()
        {
            return Student.StudentListe;
        }

        public void RemoveStudent(string name)
        {
            Student.StudentListe.Remove(new Student() { name = name });

        }







        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
