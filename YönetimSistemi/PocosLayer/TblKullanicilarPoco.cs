using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YönetimSistemi.PocosLayer
{
    class TblKullanicilarPoco
    {

        private int ID { get; set; }

        private string USERNAME_ { get; set; }

        private string PASSWORD_ { get; set;}

        private string NAMESURNAME { get; set; }

        private string EMAIL { get; set;}

        private string GENDER { get; set; }

       

        private string TELNR1 { get; set; }

        private string TELNR2 { get; set; }


        public TblKullanicilarPoco()
        {

        }


        public int kullaniciID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }



        public string kullaniciAdi
        {
            get
            {
                return USERNAME_;
            }
            set
            {
                USERNAME_ = value;
            }
        }

        public string kullaniciPassword
        {
            get
            {
                return PASSWORD_;
            }
            set
            {
                PASSWORD_ = value;
            }
        }


        public string kullaniciadsoyad
        {
            get
            {
                return NAMESURNAME;
            }
            set
            {
                NAMESURNAME = value;
            }
        }


        public string kullaniciMail
        {
            get
            {
                return EMAIL;
            }
            set
            {
                EMAIL = value;
            }
        }

        public string kullaniciCinsiyet
        {
            get
            {
                return GENDER;
            }
            set
            {
                GENDER = value;
            }
        }





        public string kullaniciTelno1
        {
            get
            {
                return TELNR1;
            }
            set
            {
                TELNR1 = value;
            }
        }

        public string kullaniciTelno2
        {
            get
            {
                return TELNR2;
            }
            set
            {
                TELNR2 = value;
            }
        }

    }







}

