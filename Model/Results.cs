using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace Linear_equation.Model
{
    public class Results: INotifyPropertyChanged
    {
        private float result;
        private float degree;
        private float a;
        private float b;
        private float c;
        private float x;
        private float y;
        
        public float Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        
        public float A
        {
            get { return a; }
            set { a = value; }
        }

        public float B
        {
            get { return b; } 
            set { b = value; }
        }
        public float C
        {
            get { return C; }
            set { C = value; }
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y;}
            set { y = value;}
        }
      
        public float Result
        {
            get
            {
                switch (degree)
                {
                    case 1:
                        result = a * x + b + c;
                        break;
                    case 2:
                        result = a * (x * x) + b * y - c;
                        break;
                    case 3:
                        result = a * (x * x * x) + b * (y * y) + c;
                        break;
                    case 4:
                        result = a * (x * x * x * x) + b * (y * y * y) + c;
                        break;
                    case 5:
                        result = a * (x * x * x * x * x) + b * (y * y * y * y) + c;
                        break;

                }
                return result;

            }
           private set { x = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
    
}
