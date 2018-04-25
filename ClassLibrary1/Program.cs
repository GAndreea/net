using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Program
    {
        
        public static BTESTEntities1 context2 = new BTESTEntities1();

        public static void adauga_autor(AUTOR a)
        {
            context2.AUTOR.Add(a);
            context2.SaveChanges();
        }

        public static void adauga_gen(GEN g)
        {
            context2.GEN.Add(g);
            context2.SaveChanges();
        }

        public static void adauga_carte(CARTE c)
        {
            context2.CARTE.Add(c);
            context2.SaveChanges();
        }

        public static void adauga_cititor(CITITOR c)
        {
            context2.CITITOR.Add(c);
            context2.SaveChanges();
        }

        public static void adauga_review(REVIEW new_review)
        {
            context2.REVIEW.Add(new_review);
            context2.SaveChanges();
        }

        public static AUTOR get_autor_by_name(string name)
        {
            using (BTESTEntities1 context = new BTESTEntities1())
            {
                AUTOR obiectAutor = context.AUTOR.FirstOrDefault(a => a.Nume == name);
                return obiectAutor;
            }
          
        }

        public static GEN get_gen_by_name(string name)
        {
            GEN gen = context2.GEN.FirstOrDefault(a => a.Descriere == name);
            return gen;
        }

        public static void achizitie_carte(CARTE carte_noua, int nrExemplare)
        {
            for (var i = 0; i < nrExemplare; i++)
            {
                context2.CARTE.Add(carte_noua);
                context2.SaveChanges();
            }
            context2.SaveChanges();
        }

        public static List<CARTE> listare_carti(int genId)
        {
        
            return context2.CARTE.Where(c => c.GenId == genId).ToList();               
            
        }

        public static int get_genId(string gen)
        {
            var gen1 = context2.GEN.FirstOrDefault(g => g.Descriere == gen);
                if (gen1==null)
                {
                    return -1;
                }
                return gen1.GenId;
            
        }

        public static AUTOR get_autor(int AutorId)
        {
            var autor = context2.AUTOR.FirstOrDefault(a => a.AutorId == AutorId);
            return autor;           
        }

        //verifica daca cititorul exista
        public static int verifica_cititor (string email)
        {
            var cititor = context2.CITITOR.FirstOrDefault(c => c.Email == email);
            if (cititor==null)
            {
               return -1;
            }
            return cititor.CititorId;
                       
        }

        public static int get_stare (int cititorId)
        {
            var cititor = context2.CITITOR.FirstOrDefault(c => c.CititorId == cititorId);
                if (cititor == null)
                {
                    return -1;
                }
                return BitConverter.ToInt32(cititor.Stare,0); 
        }
      
        public static void imprumuta_carte(int carteId, int cititorId)
        {
            var imprumut_nou = new IMPRUMUT()
            {
                    CarteId = carteId,
                    CititorId = cititorId,
                    DataImprumut = DateTime.Now,
                    DataScadenta = DateTime.Now.AddDays(7)
            };
            context2.IMPRUMUT.Add(imprumut_nou);
            context2.SaveChanges();           
        }

        public static void restituie_carte(int imprumutId)
        {
            var original = context2.IMPRUMUT.Find(imprumutId);
                if (original != null) {
                    original.DataRestituire = DateTime.Now;
                }
                context2.SaveChanges();             
            }
        
        //returneaza -1 daca cartea nu e dispoinibila, CarteId altfel
        public static int verifica_carte(string nume_autor="", string prenume_autor="", string titlu_carte="")
        {
             var autor = context2.AUTOR.FirstOrDefault(a => (a.Nume == nume_autor && a.Prenume == prenume_autor));
             var carti = context2.CARTE.Where(c => (c.Titlu == titlu_carte && c.AutorId==autor.AutorId));

                //verifica daca carti e gol
                foreach (var carte in carti)
                {
                    //verific daca e disponibila
                    var carti_imprumutate = context2.IMPRUMUT.Where(c => c.CarteId == carte.CarteId);
                    if (carti_imprumutate.Count()==0)
                    {
                        return carte.CarteId;
                    } 
                    foreach (var i in carti_imprumutate)
                    {
                        if (i.DataRestituire != null)
                        {
                            return (int)i.CarteId;
                        }
                    }

                
                }
            return -1;
        }      

        public static DateTime verifica_data(string nume_autor = "", string prenume_autor = "", string titlu_carte = "")
        {
            DateTime min_date = DateTime.MaxValue;
                var min_id = -1;
                var autor = context2.AUTOR.FirstOrDefault(a => (a.Nume == nume_autor && a.Prenume == prenume_autor));
                var carti = context2.CARTE.Where(c => (c.Titlu == titlu_carte || c.AutorId == autor.AutorId));

                foreach (var carte in carti)
                {
                    var carti_imprumutate = context2.IMPRUMUT.Where(c => c.CarteId == carte.CarteId);
                    foreach (var c in carti_imprumutate)
                    {
                        int res = DateTime.Compare(min_date, (DateTime) c.DataScadenta);
                        if (res>0)
                        {
                            min_date = (DateTime) c.DataScadenta;
                            min_id = (int) c.CititorId;
                        }
                    }
                }
                return min_date;
            
        }

        public static List<IMPRUMUT> get_imprumuturi(int cititorId)
        {
            var imprumuturi = context2.IMPRUMUT.Where(i => i.CititorId == cititorId);
            return imprumuturi.ToList();
            
        }

        public static CARTE get_carte(int CarteId)
        {
            var carte = context2.CARTE.FirstOrDefault(c => c.CarteId == CarteId);
            return carte;          
        }

        //STATISTICI
        public static int get_nrCititori()
        {
            return context2.CITITOR.Count();
            
        }

        public static List<CITITOR> cititori_perioada(DateTime start, DateTime end)
        {
            var imprumuturi = context2.IMPRUMUT.Where(i => (DateTime.Compare(start, (DateTime)i.DataImprumut) < 0
                    && (i.DataRestituire == null || DateTime.Compare((DateTime)i.DataRestituire, end) < 0)));
                List<int> ids = new List<int>();
                foreach (var i in imprumuturi)
                {
                    ids.Add((int)i.CititorId);
                }
                var ids_new = ids.Distinct().ToList();
                List<CITITOR> cititori = new List<CITITOR>();
                foreach (var id in ids_new)
                {
                    var c = context2.CITITOR.FirstOrDefault(c1 => c1.CititorId == id);
                    cititori.Add(c);
                }
                return cititori;
            
        }

        public static int imprumuturi_carte(int Carteid)
        {
            var imprumuturi = context2.IMPRUMUT.Where(i => i.CarteId == Carteid);
            return imprumuturi.Count();         
        }

        public static List<CARTE> clasament_carti()
        {
            var myList = context2.CARTE.ToList();
            myList.Sort(delegate (CARTE c1, CARTE c2) { return imprumuturi_carte(c2.CarteId) - imprumuturi_carte(c1.CarteId); });
            return myList;          
        }

        public static int imprumuturi_autor(int AutorId)
        {
            int nr = 0;
                var carti = context2.CARTE.Where(i => i.AutorId == AutorId);
                foreach (var c in carti)
                {
                    nr = nr + imprumuturi_carte(c.CarteId);
                }
                return nr;
            
        }

        public static List<AUTOR> clasament_autori()
        {
            var myList = context2.AUTOR.ToList();
                myList.Sort(delegate (AUTOR c1, AUTOR c2) { return imprumuturi_autor(c2.AutorId) - imprumuturi_autor(c1.AutorId); });
                return myList;
            
        }

        public static int imprumuturi_gen(int GenId)
        {
            int nr = 0;
                var carti = context2.CARTE.Where(i => i.GenId == GenId);
                foreach (var c in carti)
                {
                    nr = nr + imprumuturi_carte(c.CarteId);
                }
                return nr;
            
        }

        public static List<GEN> clasament_genuri()
        {
            var myList = context2.GEN.ToList();
                myList.Sort(delegate (GEN c1, GEN c2) { return imprumuturi_gen(c2.GenId) - imprumuturi_gen(c1.GenId); });
                return myList;
            
        }
        
        public static List<REVIEW> reviewuri_carte(int CarteId)
        {
            var carte = context2.CARTE.FirstOrDefault(c => c.CarteId == CarteId);
                List<int> myList = new List<int>();
                var imprumuturi = context2.IMPRUMUT.Where(i => i.CarteId == CarteId);
                foreach (var i in imprumuturi)
                {
                    myList.Add(i.ImprumutId);
                }
                var reviewuri = context2.REVIEW.Where(r => myList.Contains((int)r.ImprumutId));
                return reviewuri.ToList();
            
        }

        public static string get_titlu (int id)
        {
           var carte = context2.CARTE.FirstOrDefault(c => c.CarteId == id);
                return carte.Titlu;
            
        }

        //schimbare asocieri
        public static void schimba_autor (CARTE c, AUTOR a)
        {
            c.AUTOR = a;
            c.AutorId = a.AutorId;
            context2.SaveChanges();
        }

        public static void schimba_gen (CARTE c, GEN g)
        {
            c.GEN = g;
            c.GenId = g.GenId;
            context2.SaveChanges();
        }

    }
}
