using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinExercise1.Model
{
    public class ProfilePageModel : INotifyPropertyChanged
    {

        string image = "user1";
        string name = "John Dela Cruz";
        string email = "Cruz@yahoo.com";
        string address = "Cebu City";
        long phone = 9999999999;

        public string Image
        {

            get => image;

            set
            {
                OnPropertyChanged(nameof(Image));
            }

        }

        public string Name
        {

            get => name;



            set
            {

                if (name == value)
                    return;

                name = value;

                OnPropertyChanged(nameof(Name));
            }
        }

        public string Email
        {

            get => email;

            set
            {
                if (email == value)
                    return;

                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Address
        {

            get => address;

            set
            {

                if (address == value)
                    return;

                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public long Phone
        {

            get => phone;

            set
            {

                if (phone == value)
                    return;

                phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));


        }
    }
}
