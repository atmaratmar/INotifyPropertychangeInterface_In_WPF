using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InotifyPropertychangeInterface_In_WPF
{
    /*If an object implements INotifyPropertyChanged Interface,It'll raise a property changed event when its property changes.
     supose you have a class and you have a peroperty in side it now whenever change that property it will raise an event to up
     date the UI. this interface present in componenetModel Name Space this interface use to notify the interface that property
     has change you need to update and this practice is widely use whene we use wpf MVVM pattern  lets jamp to implement this 
     in a demo*/
    // fist we implement INotify to the person clasee 

    public class Person : INotifyPropertyChanged //then we need to implment this interface
    {
        // lets create three peroperties her
        private string firstName;

        public string _FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnpropertyChange("_FirstName");
                    OnpropertyChange("_FullName"); // this is don lets bound this to our property
                }
            }
        }
        private string lastName;

        public string _LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnpropertyChange("_LastName");
                    OnpropertyChange("_FullName");

                }
            }
        }
        private string fullName;
        public string _FullName
        {
            get { return fullName = firstName + " " + lastName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnpropertyChange("_FullName");  // to notify full Name we add this each property
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;// her is the event which create it by inotifyproperty changed
        // we need to raise the event how to do that we need write a method which carrespondce to this events
        //we write a method which take a parameter
        private void OnpropertyChange(string propertyName)
        {
            //the lets write the logic
            if (PropertyChanged != null)
            {
                //then raise this events //this means current object then we ask this a spicial class  PropertyChangedEventArgs
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                // on the setter my propeties i pass this method and pass property name 
            }
        }

    }
}
