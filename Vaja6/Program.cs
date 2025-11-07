using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;
// lastnosti igralec
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }
// metoda za vraacanje idja
        public int Id {
            get
            {
                return id;
            }
        }
// metoda za vracanje in pokrasanje imena
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
metoda za vreacanje in pokrajsanje gesla
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
